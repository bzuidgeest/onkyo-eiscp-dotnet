using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using kvp = System.Collections.Generic.KeyValuePair<string, string>;
namespace Eiscp.Core
{
    public static class Utils
    {
        /// <summary>
        /// Convert an ascii command like (PVR00) to the binary data we
        /// need to send to the receiver.
        /// </summary>        
        public static EiscpPacket CommandToPacket(string command)
        {
            return new EiscpPacket(new IscpMessage(command));
        }

        /// <summary>
        /// Ensures that various ways to refer to a command can be used.
        /// </summary>
        public static string NormalizeCommand(string command)
        {
            return command.ToLower().Replace('_', ' ').Replace('-', ' ');
        }


        /// <summary>
        /// Navigate a dictionary tree.
        /// </summary>
        /// This function saves the tedium of repeated casts when someone wants to
        /// retrieve an object located in a deeply nested dictionary.
        /// <param name="dict">Root of a dictionary tree.</param>
        /// <param name="keys">Path to the object in the tree.</param>
        /// <returns>Node pointed by the path. It may be itself a dictionary.</returns>
		public static T Nav<T>(IDictionary dict, params string[] keys) {
			if (!_TryNav<T>(dict, out var res, true, keys))
				throw new Exception("Probably should ahave already thrown");
			return res;
		}
		public static bool TryNav<T>(IDictionary dict, out T res, params string[] keys) => _TryNav(dict, out res, false, keys);
		private static bool _TryNav<T>(IDictionary dict, out T res, bool throwOnError, params string[] keys) {
			object lastItm = null;
			res = default;
			foreach (object key in keys) {
				if (dict == null || dict.Contains(key) == false) {
					if (throwOnError)
						throw new Exception($"dict is null or key: {key} does not exist");
					return false;
				}
				lastItm = dict[key];
				dict = lastItm as IDictionary;


			}
			if (lastItm is T ret)
				res = ret;
			else {
				if (throwOnError)
					throw new Exception($"item is type: {lastItm?.GetType()} not expected of: {typeof(T)}");
				return false;
            }

			return true;
        }

        /// <summary>
        /// Transform the given given high-level command to a
        /// low-level ISCP message.
        /// </summary>
        ///
        /// <exception cref="ArgumentException">
        /// Raises <c>ArgumentException</c> if <paramref name="command"/> is not valid.
        /// </exception>
        /// 
        /// This exposes a system of human-readable, "pretty"
        /// commands, which is organized into three parts: the zone, the
        /// command, and arguments. For example:    
        /// 
        /// <example>
        /// <code>
        ///     Command("power", "on");
        ///     Command("power", "on", zone: "main");
        ///     Command("volume", "66", zone: "zone2");
        /// </code>
        /// </example>
        /// 
        /// As you can see, if no zone is given, the main zone is assumed.
        ///
        /// Instead of passing three different parameters, you may put the
        /// whole thing in a single string, which is helpful when taking
        /// input from users:
        ///
        /// <example>
        /// <code>
        ///    Command("power on:);
        ///    Command("zone2 volume 66");
        /// </code>
        /// </example>
        /// To further simplify things, for example when taking user input
        /// from a command line, where whitespace needs escaping, the
        /// following is also supported:
        ///
        /// <example>
        /// <code>
        ///     Command("power=on");
        ///     Command("zone2.volume=66");
        /// </code>
        /// </example>
        public static string CommandToIscp(string command, string arguments = null, string zone = null)
        {
			if (String.IsNullOrWhiteSpace(zone))
				zone = "main";
            List<string> argumentsList = null;
            string defaultZone = "main";
            char[] commandSep = new char[] { '.', ' ' };
            Func<string, string> norm = s => s.Trim().ToLower();

            // If parts are not explicitly given, parse the command
			if (String.IsNullOrWhiteSpace(arguments)) {
                // Separating command and args with colon allows multiple args
				if (command.Contains(":") || command.Contains("=")) {
                    char[] separators = new char[] { ':', '=' };
                    string[] baseAndArguments = command.Split(separators, 2); // in Python counterpart it's "max 1 split", here - it's "max 2 parts"
                    string commandBase = baseAndArguments[0];
                    string commandArguments = baseAndArguments[1];
                     
                    var parts = new List<string>(
                        from c in commandBase.Split(commandSep)
                        select norm(c)
                    );

                    if (parts.Count == 2)
                    {
                        zone = parts[0];
                        command = parts[1];
                    }
                    else
                    {
                        zone = defaultZone;
                        command = parts[0];
                    }

                    // Split arguments by comma or space
                    argumentsList = new List<string>(
                        from a in commandArguments.Split(',', ' ')
                        select norm(a)
                    );
                }
                else
                {
                    // Split command part by space or dot
                    var parts = new List<string>(
                        from c in command.Split(commandSep)
                        select norm(c)
                    );

                    if (parts.Count >= 3)
                    {
                        zone = parts[0];
                        command = parts[1];
                        argumentsList = parts.GetRange(2, parts.Count - 2);
                    }
                    else if (parts.Count == 2)
                    {
                        zone = defaultZone;
                        command = parts[0];
                        argumentsList = parts.GetRange(1, 1);
                    }
                    else
                    {
                        throw new ArgumentException("Need at least command and argument");
                    }
                }
			} else
				argumentsList = arguments.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
			if (command.Length == 3)//if they gave a direct cmd we tolowered it already
				command = command.ToUpper();
            // Find the command in our database, resolve to internal eISCP command
			if (!EiscpCommands.Commands.ContainsKey(zone)) {
				throw new ArgumentException(String.Format("\"{0}\" is not a valid zone", zone));
            }

			if (!TryNav<string>(EiscpCommands.CommandMappings, out var cmdPrefix, zone, command))
				cmdPrefix = command;
			var cmdInfo = Nav<IDictionary>(EiscpCommands.Commands, zone, cmdPrefix);
			if (cmdInfo == null) {
                throw new ArgumentException(String.Format("\"{0}\" is not a valid command in zone \"{1}\"", command, zone));
            }

            // TODO: For now, only support one; though some rare commands would
            // need multiple.
            string argument = argumentsList[0];

			if (!TryNav<string>(EiscpCommands.ValueMappings, out var sendValue, zone, cmdPrefix, argument)) {
				var dict = Nav<IDictionary>(EiscpCommands.ValueMappings, zone, cmdPrefix);//right now we are not validating against the dict we prolly should
				if (Int32.TryParse(argument, out var intVal))
					sendValue = Convert.ToString(intVal, 16);
				else
					sendValue = null;
			}
			//var value = Nav<string>(cmdInfo, "values", actualValueName, "name");

			if (sendValue == null) {
                throw new ArgumentException(String.Format("\"{0}\" is not a valid argument " +
                    "for command \"{1}\" in zone \"{2}\"", argument, command, zone));
            }

			return (string)cmdPrefix + sendValue;
        }

		public static Tuple<string, string> IscpToCommand(string iscpMessage) {
			var res = IscpToCommandDetailed(iscpMessage);
			return new(res.CommandName, res.ValueName);
		}
		public static CmdDetailedResult IscpToCommandDetailed(string iscpMessage) {


                // For now, ISCP commands are always three characters, which
                // makes this easy.
                string command = iscpMessage.Substring(0, 3);
                string args = iscpMessage.Substring(3);
			var arr = new[] { 1, 2, 3 };

			var zone = EiscpCommands.Commands.Cast<DictionaryEntry>().FirstOrDefault(kvp => (kvp.Value as IDictionary).Contains(command)).Key.ToString();

			var cmdInfo = Nav<IDictionary>(EiscpCommands.Commands, zone, command);

			var ret = new CmdDetailedResult();
			ret.CommandName = Nav<string>(cmdInfo, "name");
			ret.CommandDescription = Nav<string>(cmdInfo, "description");
			if (TryNav<IDictionary>(cmdInfo, out var valueInfo, "values", args)) {
				if (TryNav<string[]>(valueInfo, out var valNameArr, "name")) {
					ret.ValueName = valNameArr.First();
				} else
					ret.ValueName = Nav<string>(valueInfo, "name");

				ret.ValueDescription = Nav<string>(valueInfo, "description");
			} else {
				var match = Regex.Match(args, @"^(?<plusMinus>[+-])?(?<num>[0-9a-f]+)$", RegexOptions.IgnoreCase);
				if (match.Success) {
					try {
						
						if (false && match.Groups["plusMinus"].Success) //acutally seems stil lare in hex: if we have plus minus assume its always base 10 (ie dbs)
							ret.ValueName = Int32.Parse(match.Groups["num"].Value).ToString();
						else
							ret.ValueName = Convert.ToInt16(match.Groups["num"].Value, 16).ToString();
						if (match.Groups["plusMinus"].Success)
							ret.ValueName = $"{match.Groups["plusMinus"].Value}{ret.ValueName}";
					} catch { ret.ValueName = args; }
				} else {
					ret.ValueName = args;
					if (ret.CommandName == "video-information" || ret.CommandName == "audio-information") {
						var valArr = args.Split(new[] { "," }, StringSplitOptions.None);
						var valueDict = Nav<IDictionary>(cmdInfo, "values");
						if (valArr.Length > 4) {
							var allKeys = valueDict.Keys.Cast<string>().Select(name => new { name, count = name.Count(c => c == ',') }).ToArray();
							var keyName = allKeys.OrderByDescending(a => a.count).FirstOrDefault(a => a.count <= valArr.Length).name;//it seems length is normally -2 from the actual commas sent but maybe it varies so lets choose the longest one that is not longer than data received
							var valueData = Nav<IDictionary>(valueDict, keyName);
							ret.ValueDescription = Nav<string>(valueData, "description");
							if (ret.CommandName == "audio-information")
								ret.ValueDescription += "\nk...k: Audio Style";
							var descArr = ret.ValueDescription.Split(new[] { "\n" }, StringSplitOptions.None).Skip(1).ToArray();
							var kvpList = new List<kvp>();
							var maxIndex = Math.Min(valArr.Length, descArr.Length);
							for (var x = 0; x < maxIndex; x++) {
								var valKeyName = descArr[x];
								var colPos = valKeyName.IndexOf(':');
								if (colPos != -1)
									valKeyName = valKeyName.Substring(colPos + 1).Trim();

								kvpList.Add(new(valKeyName, valArr[x]));
							}
							ret.ParsedValueNameToValue = kvpList;

						}
					} else if (ret.CommandName == "temperature-data") {

						var tempMatch = Regex.Match(args, @"^F\s*(?<fdeg>[0-9]+)C\s*(?<cdeg>[0-9]+)$");
						if (tempMatch.Success) {
							ret.ParsedValueNameToValue = new[] {
								new kvp("F", tempMatch.Groups["fdeg"].Value),
								new kvp("C", tempMatch.Groups["cdeg"].Value),
							};
						}
                    }
                }
            }

			return ret;

        }

        /// <summary>
        /// Helper that calls <paramref name="getterFunc"/> until a matching message
        /// is found, or the timeout occurs. 
        /// </summary>
        /// Matching means the same commands
        /// group, i.e. for sent message MVLUP we would accept MVL13
        /// in response.
        public static byte[] FilterForMessage(Func<double, byte[]> getterFunc, string msg)
        {
            long start = DateTime.Now.Ticks; // 10 000 ticks makes a millisecond

            while (true)
            {
                byte[] candidate = getterFunc(0.05);
                if (candidate != null)
                {
                    string str = Encoding.ASCII.GetString(candidate);
                    // It seems ISCP commands are always three characters.
                    if (str.Substring(0, 3) == msg.Substring(0, 3))
                    {
                        return candidate;
                    }
                }

                // The protocol docs claim that a response  should arrive
                // within *50ms or the communication as failed*. In my tests,
                // however, the interval needed to be at least 200ms before
                // I managed to see any response, aand only after 300ms
                // reproducably, so use a generous timeout.
                // I needed an even bigger timeout. Should be replaced with some async receiver 
                if (DateTime.Now.Ticks - start > 14000000) // 700ms
                {
					throw new TimeoutException("Not received a response");
                }
            }
        }
    }
}