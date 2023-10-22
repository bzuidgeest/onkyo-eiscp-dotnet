using Eiscp.Core;
using Eiscp.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Eiscp.Core
{
    public static partial class EiscpCommands
    {
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
        ///     Command("power=on");
        ///     Command("zone2.volume=66");
        /// </code>
        /// </example>.
        /// This regex validate the supported command styles.
        /// ^(?<Zone>\w*(?=\.))?\.*(?<Command>\w+)[=:](?<Values>\w+)$
        private const string commandPattern = "^(?<Zone>\\w*(?=\\.))?\\.*(?<Command>\\w+)[=:](?<Values>\\w+)$";
        public static ISCPMessage CommandToISCPMessage(string command)
        {
            command = command.Trim();
            if (Regex.IsMatch(command, commandPattern))
            {
                GroupCollection groups = Regex.Match(command, commandPattern).Groups;
                return CommandToISCPMessage(groups["Command"].Value, groups["Values"].Value, groups["Zone"].Value);
            }
            else
            {
                throw new Exception($"Invalid command, {command} does not match <zone>.<command>:|=<values> or <command>:|=<values>");
            }
        }

        public static ISCPMessage CommandToISCPMessage(string command, string values = "", string zone = "")
        {
            string iZone, iCommand, iValues = "";

            if (string.IsNullOrEmpty(zone))
            {
                iZone = "main";
            }
            else
            {
                iZone = zone;
            }

            if (EiscpCommands.Commands.ContainsKey(zone) == true)
            {
                if ((EiscpCommands.CommandMappings[zone]).Contains(command))
                {
                    iCommand = (string)(EiscpCommands.CommandMappings[zone])[command];

                    // next check and set value
                }
                else
                {
                    throw new Exception($"Incorrect command {command} value for {zone}");
                }
            }
            else
            {
                throw new Exception($"Incorrect zone value {zone}");
            }

            return new ISCPMessage($"{iCommand}{iValues}");

            //List<string> argumentsList = null;
            //string defaultZone = "main";
            //char[] commandSep = new char[] { '.', ' ' };
            //Func<string, string> norm = s => s.Trim().ToLower();

            //// If parts are not explicitly given, parse the command
            //if (String.IsNullOrWhiteSpace(arguments))
            //{
            //    // Separating command and args with colon allows multiple args
            //    if (command.Contains(":") || command.Contains("="))
            //    {
            //        char[] separators = new char[] { ':', '=' };
            //        string[] baseAndArguments = command.Split(separators, 2); // in Python counterpart it's "max 1 split", here - it's "max 2 parts"
            //        string commandBase = baseAndArguments[0];
            //        string commandArguments = baseAndArguments[1];

            //        var parts = new List<string>(
            //            from c in commandBase.Split(commandSep)
            //            select norm(c)
            //        );

            //        if (parts.Count == 2)
            //        {
            //            zone = parts[0];
            //            command = parts[1];
            //        }
            //        else
            //        {
            //            zone = defaultZone;
            //            command = parts[0];
            //        }

            //        // Split arguments by comma or space
            //        argumentsList = new List<string>(
            //            from a in commandArguments.Split(',', ' ')
            //            select norm(a)
            //        );
            //    }
            //    else
            //    {
            //        // Split command part by space or dot
            //        var parts = new List<string>(
            //            from c in command.Split(commandSep)
            //            select norm(c)
            //        );

            //        if (parts.Count >= 3)
            //        {
            //            zone = parts[0];
            //            command = parts[1];
            //            argumentsList = parts.GetRange(2, parts.Count - 2);
            //        }
            //        else if (parts.Count == 2)
            //        {
            //            zone = defaultZone;
            //            command = parts[0];
            //            argumentsList = parts.GetRange(1, 1);
            //        }
            //        else
            //        {
            //            throw new ArgumentException("Need at least command and argument");
            //        }
            //    }
            //}
            //else
            //    argumentsList = arguments.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //if (command.Length == 3)//if they gave a direct cmd we tolowered it already
            //    command = command.ToUpper();
            //// Find the command in our database, resolve to internal eISCP command
            //if (!EiscpCommands.Commands.ContainsKey(zone))
            //{
            //    throw new ArgumentException(String.Format("\"{0}\" is not a valid zone", zone));
            //}

            //if (!TryNav<string>(EiscpCommands.CommandMappings, out var cmdPrefix, zone, command))
            //    cmdPrefix = command;
            //var cmdInfo = Nav<IDictionary>(EiscpCommands.Commands, zone, cmdPrefix);
            //if (cmdInfo == null)
            //{
            //    throw new ArgumentException(String.Format("\"{0}\" is not a valid command in zone \"{1}\"", command, zone));
            //}

            //// TODO: For now, only support one; though some rare commands would
            //// need multiple.
            //string argument = argumentsList[0];

            //if (!TryNav<string>(EiscpCommands.ValueMappings, out var sendValue, zone, cmdPrefix, argument))
            //{
            //    var dict = Nav<IDictionary>(EiscpCommands.ValueMappings, zone, cmdPrefix);//right now we are not validating against the dict we prolly should
            //    if (Int32.TryParse(argument, out var intVal))
            //        sendValue = Convert.ToString(intVal, 16);
            //    else
            //        sendValue = null;
            //}
            ////var value = Nav<string>(cmdInfo, "values", actualValueName, "name");

            //if (sendValue == null)
            //{
            //    throw new ArgumentException(String.Format("\"{0}\" is not a valid argument " +
            //        "for command \"{1}\" in zone \"{2}\"", argument, command, zone));
            //}

            //return new ISCPMessage((string)cmdPrefix + sendValue);
        }

        /// <summary>
        /// Navigate a dictionary tree.
        /// </summary>
        /// This function saves the tedium of repeated casts when someone wants to
        /// retrieve an object located in a deeply nested dictionary.
        /// <param name="dict">Root of a dictionary tree.</param>
        /// <param name="keys">Path to the object in the tree.</param>
        /// <returns>Node pointed by the path. It may be itself a dictionary.</returns>
		private static T Nav<T>(IDictionary dict, params string[] keys)
        {
            if (!_TryNav<T>(dict, out var res, true, keys))
                throw new Exception("Probably should ahave already thrown");
            return res;
        }
        private static bool TryNav<T>(IDictionary dict, out T res, params string[] keys) => _TryNav(dict, out res, false, keys);
        private static bool _TryNav<T>(IDictionary dict, out T res, bool throwOnError, params string[] keys)
        {
            object lastItm = null;
            res = default;
            foreach (object key in keys)
            {
                if (dict == null || dict.Contains(key) == false)
                {
                    if (throwOnError)
                        throw new Exception($"dict is null or key: {key} does not exist");
                    return false;
                }
                lastItm = dict[key];
                dict = lastItm as IDictionary;


            }
            if (lastItm is T ret)
                res = ret;
            else
            {
                if (throwOnError)
                    throw new Exception($"item is type: {lastItm?.GetType()} not expected of: {typeof(T)}");
                return false;
            }

            return true;
        }
    }
}
