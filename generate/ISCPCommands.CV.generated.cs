// Generated
// by 
// from 
// at 25-10-2023 21:01:17

using System.Collections;
using System.Collections.Specialized;

namespace Eiscp.Core
{
	public static partial class EiscpCommands
	{
		public static readonly Dictionary<string, Dictionary<string, Dictionary<string, IValue>>> ValueMappings = new Dictionary<string, Dictionary<string, Dictionary<string, IValue>>>() {
			{ "main", new Dictionary<string, Dictionary<string, IValue>>() {
				{ "PWR", new Dictionary<string, IValue>() {
					{ "standby", new SingleValue<string>("00") },
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "standby-all", new SingleValue<string>("ALL") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "AMT", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CMT", new Dictionary<string, IValue>() {
					{ "aabbccddeeffgghhiijjkkllmm", new SingleValue<string>("aabbccddeeffgghhiijjkkllmm") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SPA", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SPB", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SPL", new Dictionary<string, IValue>() {
					{ "surrback", new SingleValue<string>("SB") },
					{ "front-high", new SingleValue<string>("FH") },
					{ "surrback-front-high-speakers", new SingleValue<string>("FH") },
					{ "front-wide", new SingleValue<string>("FW") },
					{ "surrback-front-wide-speakers", new SingleValue<string>("FW") },
					{ "front-high-front-wide-speakers", new SingleValue<string>("HW") },
					{ "height1-speakers", new SingleValue<string>("H1") },
					{ "height2-speakers", new SingleValue<string>("H2") },
					{ "back-height1-speakers", new SingleValue<string>("BH") },
					{ "back-wide-speakers", new SingleValue<string>("BW") },
					{ "height1-height2-speakers", new SingleValue<string>("HH") },
					{ "speakers-a", new SingleValue<string>("A") },
					{ "speakers-b", new SingleValue<string>("B") },
					{ "speakers-a-b", new SingleValue<string>("AB") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "MVL", new Dictionary<string, IValue>()
				{
					{ "vol-0-100,", new MultiValue<string>(new string[] {"0","100"}) },
					{ "vol-0-50,", new MultiValue<string>(new string[] {"0","50"}) },
					{ "level-up", new SingleValue<string>("UP") },
					{ "level-down", new SingleValue<string>("DOWN") },
					{ "level-up-1db-step", new SingleValue<string>("UP1") },
					{ "level-down-1db-step", new SingleValue<string>("DOWN1") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TFR", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "t-xx", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TFW", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "t-xx", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TFH", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "t-xx", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TCT", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "t-xx", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TSR", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "t-xx", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TSB", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "t-xx", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TSW", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PMB", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SLP", new Dictionary<string, IValue>()
				{
					{ "time-1-90min", new MultiValue<string>(new string[] {"1","90"}) },
					{ "time-off", new SingleValue<string>("OFF") },
					{ "up", new SingleValue<string>("UP") },
					{ "qstn", new SingleValue<string>("QSTN") }
				}
				},
				{ "SLC", new Dictionary<string, IValue>() {
					{ "test", new SingleValue<string>("TEST") },
					{ "test-tone-off", new SingleValue<string>("OFF") },
					{ "chsel", new SingleValue<string>("CHSEL") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") }
				}
				},
				{ "SWL", new Dictionary<string, IValue>()
				{
					{ "15-0db-0-0db-12-0db", new MultiValue<string>(new string[] {"-30","24"}) },
					{ "15db-0db-12db", new MultiValue<string>(new string[] {"-15","12"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SW2", new Dictionary<string, IValue>()
				{
					{ "15-0db-0-0db-12-0db", new MultiValue<string>(new string[] {"-30","24"}) },
					{ "15db-0db-12db", new MultiValue<string>(new string[] {"-15","12"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CTL", new Dictionary<string, IValue>()
				{
					{ "12-0db-0-0db-12-0db", new MultiValue<string>(new string[] {"-24","24"}) },
					{ "12db-0db-12db", new MultiValue<string>(new string[] {"-12","12"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TCL", new Dictionary<string, IValue>() {
					{ "levels", new SingleValue<string>("aaabbbcccdddeeefffggghhhiiijjjkkklllmmm") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DIF", new Dictionary<string, IValue>() {
					{ "selector-volume-1line", new SingleValue<string>("00") },
					{ "default-2line", new SingleValue<string>("00") },
					{ "selector-listening-1line", new SingleValue<string>("01") },
					{ "02", new SingleValue<string>("02") },
					{ "03", new SingleValue<string>("03") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DIM", new Dictionary<string, IValue>() {
					{ "bright", new SingleValue<string>("00") },
					{ "dim", new SingleValue<string>("DIM") },
					{ "dark", new SingleValue<string>("02") },
					{ "shut-off", new SingleValue<string>("03") },
					{ "bright-led-off", new SingleValue<string>("08") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "OSD", new Dictionary<string, IValue>() {
					{ "menu", new SingleValue<string>("MENU") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "right", new SingleValue<string>("RIGHT") },
					{ "left", new SingleValue<string>("LEFT") },
					{ "enter", new SingleValue<string>("ENTER") },
					{ "exit", new SingleValue<string>("EXIT") },
					{ "audio", new SingleValue<string>("AUDIO") },
					{ "video", new SingleValue<string>("VIDEO") },
					{ "home", new SingleValue<string>("HOME") },
					{ "quick", new SingleValue<string>("QUICK") },
					{ "ipv", new SingleValue<string>("IPV") }
				}
				},
				{ "MEM", new Dictionary<string, IValue>() {
					{ "str", new SingleValue<string>("STR") },
					{ "rcl", new SingleValue<string>("RCL") },
					{ "lock", new SingleValue<string>("LOCK") },
					{ "unlk", new SingleValue<string>("UNLK") }
				}
				},
				{ "RST", new Dictionary<string, IValue>() {
					{ "all", new SingleValue<string>("ALL") }
				}
				},
				{ "IFA", new Dictionary<string, IValue>() {
					{ "a-a-b-b-c-c-d-d-e-e-f-f", new SingleValue<string>("a..a,b..b,c…c,d..d,e…e,f…f,") },
					{ "a-a-b-b-c-c-d-d-e-e-f-f-g-g-h-h-i-i-j-j", new SingleValue<string>("a..a,b..b,c…c,d..d,e…e,f…f,g…g,h…h,i…I,j…j,k…k") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "IFV", new Dictionary<string, IValue>() {
					{ "a-a-b-b-c-c-d-d-e-e-f-f-g-g-h-h-i-i", new SingleValue<string>("a..a,b..b,c…c,d..d,e…e,f…f,g…g,h…h,i…i,") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "FLD", new Dictionary<string, IValue>() {
					{ "xx-xx-xx-xx-xx-x", new SingleValue<string>("{xx}{xx}{xx}{xx}{xx}x") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SLI", new Dictionary<string, IValue>() {
					{ "video1", new SingleValue<string>("00") },
					{ "vcr", new SingleValue<string>("00") },
					{ "dvr", new SingleValue<string>("00") },
					{ "stb", new SingleValue<string>("00") },
					{ "video2", new SingleValue<string>("01") },
					{ "cbl", new SingleValue<string>("01") },
					{ "sat", new SingleValue<string>("01") },
					{ "video3", new SingleValue<string>("02") },
					{ "game/tv", new SingleValue<string>("02") },
					{ "game", new SingleValue<string>("02") },
					{ "game1", new SingleValue<string>("02") },
					{ "video4", new SingleValue<string>("03") },
					{ "aux1", new SingleValue<string>("03") },
					{ "video5", new SingleValue<string>("04") },
					{ "aux2", new SingleValue<string>("04") },
					{ "game2", new SingleValue<string>("04") },
					{ "video6", new SingleValue<string>("05") },
					{ "pc", new SingleValue<string>("05") },
					{ "video7", new SingleValue<string>("06") },
					{ "07", new SingleValue<string>("07") },
					{ "08", new SingleValue<string>("08") },
					{ "09", new SingleValue<string>("09") },
					{ "dvd", new SingleValue<string>("10") },
					{ "bd", new SingleValue<string>("10") },
					{ "strm-box", new SingleValue<string>("11") },
					{ "tv", new SingleValue<string>("12") },
					{ "tape-1", new SingleValue<string>("20") },
					{ "tv/tape", new SingleValue<string>("20") },
					{ "tape2", new SingleValue<string>("21") },
					{ "phono", new SingleValue<string>("22") },
					{ "cd", new SingleValue<string>("23") },
					{ "tv/cd", new SingleValue<string>("23") },
					{ "fm", new SingleValue<string>("24") },
					{ "am", new SingleValue<string>("25") },
					{ "tuner", new SingleValue<string>("26") },
					{ "music-server", new SingleValue<string>("27") },
					{ "p4s", new SingleValue<string>("27") },
					{ "dlna", new SingleValue<string>("27") },
					{ "internet-radio", new SingleValue<string>("28") },
					{ "iradio-favorite", new SingleValue<string>("28") },
					{ "usb", new SingleValue<string>("2C") },
					{ "network", new SingleValue<string>("2B") },
					{ "net", new SingleValue<string>("2B") },
					{ "aiplay", new SingleValue<string>("2D") },
					{ "bluetooth", new SingleValue<string>("2E") },
					{ "usb-dac-in", new SingleValue<string>("2F") },
					{ "line", new SingleValue<string>("41") },
					{ "line2", new SingleValue<string>("42") },
					{ "optical", new SingleValue<string>("44") },
					{ "coaxial", new SingleValue<string>("45") },
					{ "universal-port", new SingleValue<string>("40") },
					{ "multi-ch", new SingleValue<string>("30") },
					{ "xm", new SingleValue<string>("31") },
					{ "sirius", new SingleValue<string>("32") },
					{ "dab", new SingleValue<string>("33") },
					{ "hdmi-5", new SingleValue<string>("55") },
					{ "hdmi-6", new SingleValue<string>("56") },
					{ "hdmi-7", new SingleValue<string>("57") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SLR", new Dictionary<string, IValue>() {
					{ "video1", new SingleValue<string>("00") },
					{ "video2", new SingleValue<string>("01") },
					{ "video3", new SingleValue<string>("02") },
					{ "video4", new SingleValue<string>("03") },
					{ "video5", new SingleValue<string>("04") },
					{ "video6", new SingleValue<string>("05") },
					{ "video7", new SingleValue<string>("06") },
					{ "dvd", new SingleValue<string>("10") },
					{ "tape", new SingleValue<string>("20") },
					{ "tape2", new SingleValue<string>("21") },
					{ "phono", new SingleValue<string>("22") },
					{ "cd", new SingleValue<string>("23") },
					{ "fm", new SingleValue<string>("24") },
					{ "am", new SingleValue<string>("25") },
					{ "tuner", new SingleValue<string>("26") },
					{ "music-server", new SingleValue<string>("27") },
					{ "internet-radio", new SingleValue<string>("28") },
					{ "multi-ch", new SingleValue<string>("30") },
					{ "xm", new SingleValue<string>("31") },
					{ "off", new SingleValue<string>("7F") },
					{ "source", new SingleValue<string>("80") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SLA", new Dictionary<string, IValue>() {
					{ "auto", new SingleValue<string>("00") },
					{ "multi-channel", new SingleValue<string>("01") },
					{ "analog", new SingleValue<string>("02") },
					{ "ilink", new SingleValue<string>("03") },
					{ "hdmi", new SingleValue<string>("04") },
					{ "coax", new SingleValue<string>("05") },
					{ "opt", new SingleValue<string>("05") },
					{ "balance", new SingleValue<string>("06") },
					{ "arc", new SingleValue<string>("07") },
					{ "none", new SingleValue<string>("0F") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TGA", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TGB", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TGC", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "VOS", new Dictionary<string, IValue>() {
					{ "d4", new SingleValue<string>("00") },
					{ "component", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HDO", new Dictionary<string, IValue>() {
					{ "no", new SingleValue<string>("00") },
					{ "analog", new SingleValue<string>("00") },
					{ "yes", new SingleValue<string>("01") },
					{ "out", new SingleValue<string>("01") },
					{ "out-sub", new SingleValue<string>("02") },
					{ "sub", new SingleValue<string>("03") },
					{ "hdbaset", new SingleValue<string>("02") },
					{ "both", new SingleValue<string>("05") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HAO", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "auto", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HAS", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CEC", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CCM", new Dictionary<string, IValue>() {
					{ "main", new SingleValue<string>("01") },
					{ "zone2", new SingleValue<string>("02") },
					{ "sub", new SingleValue<string>("10") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "RES", new Dictionary<string, IValue>() {
					{ "through", new SingleValue<string>("00") },
					{ "auto", new SingleValue<string>("01") },
					{ "480p", new SingleValue<string>("02") },
					{ "720p", new SingleValue<string>("03") },
					{ "1680x720p", new SingleValue<string>("13") },
					{ "1080i", new SingleValue<string>("04") },
					{ "1080p", new SingleValue<string>("07") },
					{ "24fs", new SingleValue<string>("07") },
					{ "2560x1080p", new SingleValue<string>("15") },
					{ "4k-upcaling", new SingleValue<string>("08") },
					{ "source", new SingleValue<string>("06") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SPR", new Dictionary<string, IValue>()
				{
					{ "no-0-3", new MultiValue<string>(new string[] {"0","3"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HOI", new Dictionary<string, IValue>() {
					{ "a-1-for-zone-b-sub-0-none", new SingleValue<string>("ab") },
					{ "1-for-zone", new SingleValue<string>("ab") },
					{ "2-for-zone-2", new SingleValue<string>("ab") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ISF", new Dictionary<string, IValue>() {
					{ "custom", new SingleValue<string>("00") },
					{ "day", new SingleValue<string>("01") },
					{ "night", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "VWM", new Dictionary<string, IValue>() {
					{ "auto", new SingleValue<string>("00") },
					{ "4-3", new SingleValue<string>("01") },
					{ "full", new SingleValue<string>("02") },
					{ "zoom", new SingleValue<string>("04") },
					{ "smart-zoom", new SingleValue<string>("05") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "VPM", new Dictionary<string, IValue>() {
					{ "through", new SingleValue<string>("00") },
					{ "standard", new SingleValue<string>("00") },
					{ "custom", new SingleValue<string>("01") },
					{ "cinema", new SingleValue<string>("02") },
					{ "game", new SingleValue<string>("03") },
					{ "isf-day", new SingleValue<string>("05") },
					{ "isf-night", new SingleValue<string>("06") },
					{ "streaming", new SingleValue<string>("07") },
					{ "direct", new SingleValue<string>("08") },
					{ "bypass", new SingleValue<string>("08") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "LMD", new Dictionary<string, IValue>() {
					{ "stereo", new SingleValue<string>("00") },
					{ "direct", new SingleValue<string>("01") },
					{ "surround", new SingleValue<string>("02") },
					{ "film", new SingleValue<string>("03") },
					{ "game-rpg", new SingleValue<string>("03") },
					{ "thx", new SingleValue<string>("THX") },
					{ "action", new SingleValue<string>("25") },
					{ "game-action", new SingleValue<string>("05") },
					{ "musical", new SingleValue<string>("06") },
					{ "game-rock", new SingleValue<string>("06") },
					{ "mono-movie", new SingleValue<string>("07") },
					{ "orchestra", new SingleValue<string>("08") },
					{ "unplugged", new SingleValue<string>("09") },
					{ "studio-mix", new SingleValue<string>("0A") },
					{ "tv-logic", new SingleValue<string>("0B") },
					{ "all-ch-stereo", new SingleValue<string>("0C") },
					{ "theater-dimensional", new SingleValue<string>("0D") },
					{ "enhanced-7", new SingleValue<string>("0E") },
					{ "enhance", new SingleValue<string>("0E") },
					{ "game-sports", new SingleValue<string>("0E") },
					{ "mono", new SingleValue<string>("0F") },
					{ "pure-audio", new SingleValue<string>("11") },
					{ "multiplex", new SingleValue<string>("12") },
					{ "full-mono", new SingleValue<string>("13") },
					{ "dolby-virtual", new SingleValue<string>("14") },
					{ "surround-enhancer", new SingleValue<string>("14") },
					{ "dts-surround-sensation", new SingleValue<string>("15") },
					{ "audyssey-dsx", new SingleValue<string>("16") },
					{ "whole-house", new SingleValue<string>("1F") },
					{ "stage", new SingleValue<string>("23") },
					{ "music", new SingleValue<string>("MUSIC") },
					{ "sports", new SingleValue<string>("2E") },
					{ "straight-decode", new SingleValue<string>("40") },
					{ "dolby-ex", new SingleValue<string>("41") },
					{ "thx-cinema", new SingleValue<string>("42") },
					{ "thx-surround-ex", new SingleValue<string>("43") },
					{ "thx-music", new SingleValue<string>("44") },
					{ "thx-games", new SingleValue<string>("52") },
					{ "thx-u2", new SingleValue<string>("52") },
					{ "s2", new SingleValue<string>("52") },
					{ "i", new SingleValue<string>("52") },
					{ "s-cinema", new SingleValue<string>("50") },
					{ "cinema2", new SingleValue<string>("50") },
					{ "thx-musicmode", new SingleValue<string>("51") },
					{ "s-music", new SingleValue<string>("51") },
					{ "s-games", new SingleValue<string>("52") },
					{ "plii", new SingleValue<string>("8B") },
					{ "pliix-movie", new SingleValue<string>("80") },
					{ "dolby-atmos", new SingleValue<string>("80") },
					{ "dolby-surround", new SingleValue<string>("80") },
					{ "pliix-music", new SingleValue<string>("81") },
					{ "neo-6-cinema", new SingleValue<string>("82") },
					{ "neo-x-cinema", new SingleValue<string>("82") },
					{ "dts-x", new SingleValue<string>("82") },
					{ "neural-x", new SingleValue<string>("82") },
					{ "neo-6-music", new SingleValue<string>("83") },
					{ "neo-x-music", new SingleValue<string>("83") },
					{ "pliix-thx-cinema", new SingleValue<string>("84") },
					{ "dolby-surround-thx-cinema", new SingleValue<string>("84") },
					{ "neo-6", new SingleValue<string>("8C") },
					{ "neo-x-thx-cinema", new SingleValue<string>("85") },
					{ "dts-neural-x-thx-cinema", new SingleValue<string>("85") },
					{ "pliix-game", new SingleValue<string>("86") },
					{ "neural-surr", new SingleValue<string>("87") },
					{ "neural-thx", new SingleValue<string>("88") },
					{ "neural-surround", new SingleValue<string>("88") },
					{ "pliix-thx-games", new SingleValue<string>("89") },
					{ "dolby-surround-thx-games", new SingleValue<string>("89") },
					{ "neo-x-thx-games", new SingleValue<string>("8A") },
					{ "dts-neural-x-thx-games", new SingleValue<string>("8A") },
					{ "pliix-thx-music", new SingleValue<string>("8B") },
					{ "dolby-surround-thx-music", new SingleValue<string>("8B") },
					{ "neo-x-thx-music", new SingleValue<string>("8C") },
					{ "dts-neural-x-thx-music", new SingleValue<string>("8C") },
					{ "neural-thx-cinema", new SingleValue<string>("8D") },
					{ "neural-thx-music", new SingleValue<string>("8E") },
					{ "neural-thx-games", new SingleValue<string>("8F") },
					{ "pliiz-height", new SingleValue<string>("90") },
					{ "neo-6-cinema-dts-surround-sensation", new SingleValue<string>("91") },
					{ "neo-6-music-dts-surround-sensation", new SingleValue<string>("92") },
					{ "neural-digital-music", new SingleValue<string>("93") },
					{ "pliiz-height-thx-cinema", new SingleValue<string>("94") },
					{ "pliiz-height-thx-music", new SingleValue<string>("95") },
					{ "pliiz-height-thx-games", new SingleValue<string>("96") },
					{ "pliiz-height-thx-u2", new SingleValue<string>("99") },
					{ "s2-cinema", new SingleValue<string>("97") },
					{ "s2-music", new SingleValue<string>("98") },
					{ "s2-games", new SingleValue<string>("99") },
					{ "neo-x-game", new SingleValue<string>("9A") },
					{ "pliix", new SingleValue<string>("A2") },
					{ "plii-movie-audyssey-dsx", new SingleValue<string>("A0") },
					{ "plii-music-audyssey-dsx", new SingleValue<string>("A1") },
					{ "plii-game-audyssey-dsx", new SingleValue<string>("A2") },
					{ "neo-6-cinema-audyssey-dsx", new SingleValue<string>("A3") },
					{ "neo-6-music-audyssey-dsx", new SingleValue<string>("A4") },
					{ "neural-surround-audyssey-dsx", new SingleValue<string>("A5") },
					{ "neural-digital-music-audyssey-dsx", new SingleValue<string>("A6") },
					{ "dolby-ex-audyssey-dsx", new SingleValue<string>("A7") },
					{ "auto-surround", new SingleValue<string>("FF") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "movie", new SingleValue<string>("MOVIE") },
					{ "game", new SingleValue<string>("GAME") },
					{ "auto", new SingleValue<string>("AUTO") },
					{ "surr", new SingleValue<string>("SURR") },
					{ "ster", new SingleValue<string>("STEREO") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DIR", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "LTN", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "low-dolbydigital", new SingleValue<string>("01") },
					{ "on-dolby-truehd", new SingleValue<string>("01") },
					{ "high-dolbydigital", new SingleValue<string>("02") },
					{ "auto-dolby-truehd", new SingleValue<string>("03") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "RAS", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ADY", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "movie", new SingleValue<string>("01") },
					{ "music", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ADQ", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ADV", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "light", new SingleValue<string>("01") },
					{ "medium", new SingleValue<string>("02") },
					{ "heavy", new SingleValue<string>("03") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DVL", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "low", new SingleValue<string>("01") },
					{ "on", new SingleValue<string>("01") },
					{ "mid", new SingleValue<string>("02") },
					{ "high", new SingleValue<string>("03") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "AEQ", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "MCM", new Dictionary<string, IValue>() {
					{ "memory-1", new SingleValue<string>("01") },
					{ "memory-2", new SingleValue<string>("02") },
					{ "memory-3", new SingleValue<string>("03") },
					{ "memory-4", new SingleValue<string>("04") },
					{ "memory-5", new SingleValue<string>("05") },
					{ "memory-6", new SingleValue<string>("06") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "EQS", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "preset-1", new SingleValue<string>("01") },
					{ "preset-2", new SingleValue<string>("02") },
					{ "preset-3", new SingleValue<string>("03") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "STW", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PCT", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "full-band-on", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PCP", new Dictionary<string, IValue>()
				{
					{ "0msec-16msec", new MultiValue<string>(new string[] {"0","16"}) },
					{ "auto", new SingleValue<string>("AT") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "LFE", new Dictionary<string, IValue>() {
					{ "00-0db-01-1db-02-2db-03-3db-04-4db-05-5db-0a-10db-0f-15db-14-20db-ff-oodb", new SingleValue<string>("xx") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ACE", new Dictionary<string, IValue>() {
					{ "eq", new SingleValue<string>("aaabbbcccdddeeefffggghhhiii") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "MCC", new Dictionary<string, IValue>() {
					{ "00", new SingleValue<string>("00") },
					{ "01", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "MFB", new Dictionary<string, IValue>() {
					{ "00", new SingleValue<string>("00") },
					{ "01", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "MOT", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "AVS", new Dictionary<string, IValue>() {
					{ "offset", new SingleValue<string>("snnn") },
					{ "is-increased", new SingleValue<string>("UP") },
					{ "is-decreased", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ASC", new Dictionary<string, IValue>() {
					{ "auto", new SingleValue<string>("00") },
					{ "manual", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "UPS", new Dictionary<string, IValue>() {
					{ "x1", new SingleValue<string>("00") },
					{ "x2", new SingleValue<string>("01") },
					{ "x4", new SingleValue<string>("02") },
					{ "x8", new SingleValue<string>("03") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HBT", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DGF", new Dictionary<string, IValue>() {
					{ "slow", new SingleValue<string>("00") },
					{ "sharp", new SingleValue<string>("01") },
					{ "short", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "LRA", new Dictionary<string, IValue>()
				{
					{ "no-1-7", new MultiValue<string>(new string[] {"1","7"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("Down") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PBS", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SBS", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SCD", new Dictionary<string, IValue>() {
					{ "enhancement-off", new SingleValue<string>("00") },
					{ "enhancement-on", new SingleValue<string>("01") },
					{ "up1-up4", new MultiValue<string>(new string[] {"2","5"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CTS", new Dictionary<string, IValue>() {
					{ "center-off", new SingleValue<string>("00") },
					{ "center-on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PNR", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DMS", new Dictionary<string, IValue>()
				{
					{ "no--3-3", new MultiValue<string>(new string[] {"-3","3"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CTW", new Dictionary<string, IValue>()
				{
					{ "no-0-7", new MultiValue<string>(new string[] {"0","7"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CTI", new Dictionary<string, IValue>() {
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DLC", new Dictionary<string, IValue>()
				{
					{ "no-0-6", new MultiValue<string>(new string[] {"0","6"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DCE", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SPI", new Dictionary<string, IValue>() {
					{ "a-subwoofer-0-no", new SingleValue<string>("abcdefghhhijk") },
					{ "1-yes", new SingleValue<string>("abcdefghhhijk") },
					{ "1ch", new SingleValue<string>("abcdefghhhijk") },
					{ "2-2ch-b-front-1-small", new SingleValue<string>("abcdefghhhijk") },
					{ "2-large-c-center-0-none", new SingleValue<string>("abcdefghhhijk") },
					{ "1-small", new SingleValue<string>("abcdefghhhijk") },
					{ "2-lage-d-surround-0-none", new SingleValue<string>("abcdefghhhijk") },
					{ "2-lage-e-surround-back-0-none", new SingleValue<string>("abcdefghhhijk") },
					{ "2-lage-f-height-1-0-none", new SingleValue<string>("abcdefghhhijk") },
					{ "2-lage-g-height-2-0-none", new SingleValue<string>("abcdefghhhijk") },
					{ "2-lage-hhh-crossover-50", new SingleValue<string>("abcdefghhhijk") },
					{ "80", new SingleValue<string>("abcdefghhhijk") },
					{ "100", new SingleValue<string>("abcdefghhhijk") },
					{ "150", new SingleValue<string>("abcdefghhhijk") },
					{ "200-i-height-1-position-0-no", new SingleValue<string>("abcdefghhhijk") },
					{ "1-fh", new SingleValue<string>("abcdefghhhijk") },
					{ "2-tf", new SingleValue<string>("abcdefghhhijk") },
					{ "3-tm", new SingleValue<string>("abcdefghhhijk") },
					{ "4-tr", new SingleValue<string>("abcdefghhhijk") },
					{ "5-rh", new SingleValue<string>("abcdefghhhijk") },
					{ "6-dd-sp-f", new SingleValue<string>("abcdefghhhijk") },
					{ "7-dd-sp-s", new SingleValue<string>("abcdefghhhijk") },
					{ "8-dd-sp-b-j-height-2-position-0-no", new SingleValue<string>("abcdefghhhijk") },
					{ "8-dd-sp-b-k-bi-amp-0-no", new SingleValue<string>("abcdefghhhijk") },
					{ "1-f", new SingleValue<string>("abcdefghhhijk") },
					{ "3-f-c", new SingleValue<string>("abcdefghhhijk") },
					{ "5-f-s", new SingleValue<string>("abcdefghhhijk") },
					{ "6-c-s", new SingleValue<string>("abcdefghhhijk") },
					{ "7-f-c-s", new SingleValue<string>("abcdefghhhijk") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SPD", new Dictionary<string, IValue>() {
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DMN", new Dictionary<string, IValue>() {
					{ "main", new SingleValue<string>("00") },
					{ "sub", new SingleValue<string>("01") },
					{ "main-sub", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "LDM", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ITV", new Dictionary<string, IValue>()
				{
					{ "12-0db-0db-12-0db", new MultiValue<string>(new string[] {"-24","24"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "IRN", new Dictionary<string, IValue>() {
					{ "name-10-characters-ii-number-the-same-as-for-sli-command-xxxxxxxxxx-name", new SingleValue<string>("iixxxxxxxxxx") }
				}
				},
				{ "FXP", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HST", new Dictionary<string, IValue>() {
					{ "xx-sli-number", new SingleValue<string>("xx") },
					{ "off", new SingleValue<string>("OFF") },
					{ "last", new SingleValue<string>("LAST") },
					{ "throguh-auto", new SingleValue<string>("AT") },
					{ "auto", new SingleValue<string>("ATE") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PQL", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ARC", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "auto", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "LPS", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "APD", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PAM", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "front", new SingleValue<string>("01") },
					{ "front-center", new SingleValue<string>("03") },
					{ "all", new SingleValue<string>("07") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ECO", new Dictionary<string, IValue>() {
					{ "volume-1db-down-and-dimmer-level-dark", new SingleValue<string>("01") },
					{ "volume-3db-down-and-dimmer-level-dark", new SingleValue<string>("03") },
					{ "volume-6db-down-and-dimmer-level-dark", new SingleValue<string>("06") }
				}
				},
				{ "FWV", new Dictionary<string, IValue>() {
					{ "version", new SingleValue<string>("abce-fhik-lmno-qrtu") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "UPD", new Dictionary<string, IValue>() {
					{ "net", new SingleValue<string>("NET") },
					{ "usb", new SingleValue<string>("USB") },
					{ "d-nn", new SingleValue<string>("D**-nn") },
					{ "cmp", new SingleValue<string>("CMP") },
					{ "e-xx-yy", new SingleValue<string>("E{xx}-yy") },
					{ "00", new SingleValue<string>("00") },
					{ "01", new SingleValue<string>("01") },
					{ "force", new SingleValue<string>("02") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "POP", new Dictionary<string, IValue>() {
					{ "t", new SingleValue<string>("t----<.....>") },
					{ "ullt", new SingleValue<string>("Ullt<.....>") }
				}
				},
				{ "TPD", new Dictionary<string, IValue>() {
					{ "temp", new SingleValue<string>("-99-999") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TUN", new Dictionary<string, IValue>() {
					{ "freq-nnnnn", new SingleValue<string>("nnnnn") },
					{ "band", new SingleValue<string>("BAND") },
					{ "direct", new SingleValue<string>("DIRECT") },
					{ "0-in-direct-mode", new SingleValue<string>("0") },
					{ "1-in-direct-mode", new SingleValue<string>("1") },
					{ "2-in-direct-mode", new SingleValue<string>("2") },
					{ "3-in-direct-mode", new SingleValue<string>("3") },
					{ "4-in-direct-mode", new SingleValue<string>("4") },
					{ "5-in-direct-mode", new SingleValue<string>("5") },
					{ "6-in-direct-mode", new SingleValue<string>("6") },
					{ "7-in-direct-mode", new SingleValue<string>("7") },
					{ "8-in-direct-mode", new SingleValue<string>("8") },
					{ "9-in-direct-mode", new SingleValue<string>("9") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PRS", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PRM", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) }
				}
				},
				{ "RDS", new Dictionary<string, IValue>() {
					{ "00", new SingleValue<string>("00") },
					{ "01", new SingleValue<string>("01") },
					{ "02", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") }
				}
				},
				{ "PTS", new Dictionary<string, IValue>()
				{
					{ "no-1-29", new MultiValue<string>(new string[] {"1","29"}) },
					{ "enter", new SingleValue<string>("ENTER") }
				}
				},
				{ "TPS", new Dictionary<string, IValue>() {
					{ "start", new SingleValue<string>("") },
					{ "finish", new SingleValue<string>("ENTER") }
				}
				},
				{ "XCN", new Dictionary<string, IValue>() {
					{ "channel-name", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "XAT", new Dictionary<string, IValue>() {
					{ "artist-name", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "XTI", new Dictionary<string, IValue>() {
					{ "title", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "XCH", new Dictionary<string, IValue>()
				{
					{ "channel-no-0-597", new MultiValue<string>(new string[] {"0","597"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "XCT", new Dictionary<string, IValue>() {
					{ "category-info", new SingleValue<string>("nnnnnnnnnn") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SCN", new Dictionary<string, IValue>() {
					{ "channel-name", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SAT", new Dictionary<string, IValue>() {
					{ "artist-name", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "STI", new Dictionary<string, IValue>() {
					{ "title", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SCH", new Dictionary<string, IValue>()
				{
					{ "channel-no-0-597", new MultiValue<string>(new string[] {"0","597"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SCT", new Dictionary<string, IValue>() {
					{ "category-info", new SingleValue<string>("nnnnnnnnnn") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SLK", new Dictionary<string, IValue>() {
					{ "password", new SingleValue<string>("nnnn") },
					{ "input", new SingleValue<string>("INPUT") },
					{ "wrong", new SingleValue<string>("WRONG") }
				}
				},
				{ "HAT", new Dictionary<string, IValue>() {
					{ "artist-name", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HCN", new Dictionary<string, IValue>() {
					{ "channel-name", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HTI", new Dictionary<string, IValue>() {
					{ "title", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HDS", new Dictionary<string, IValue>() {
					{ "info", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HPR", new Dictionary<string, IValue>()
				{
					{ "directly", new MultiValue<string>(new string[] {"1","8"}) },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HBL", new Dictionary<string, IValue>() {
					{ "auto", new SingleValue<string>("00") },
					{ "analog", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "HTS", new Dictionary<string, IValue>() {
					{ "mmnnoo", new SingleValue<string>("mmnnoo") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "BCS", new Dictionary<string, IValue>() {
					{ "charging", new SingleValue<string>("00") },
					{ "completed", new SingleValue<string>("01") },
					{ "low", new SingleValue<string>("10") },
					{ "middle", new SingleValue<string>("11") },
					{ "high", new SingleValue<string>("12") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CCD", new Dictionary<string, IValue>() {
					{ "play", new SingleValue<string>("PLAY") },
					{ "stop", new SingleValue<string>("STOP") },
					{ "pause", new SingleValue<string>("PAUSE") },
					{ "next", new SingleValue<string>("SKIP.F") },
					{ "previous", new SingleValue<string>("SKIP.R") },
					{ "repeat", new SingleValue<string>("REPEAT") },
					{ "random", new SingleValue<string>("RANDOM") }
				}
				},
				{ "CST", new Dictionary<string, IValue>() {
					{ "status", new SingleValue<string>("prs") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "DST", new Dictionary<string, IValue>() {
					{ "none", new SingleValue<string>("00") },
					{ "cd", new SingleValue<string>("04") },
					{ "mp3-cd", new SingleValue<string>("07") },
					{ "unknown", new SingleValue<string>("FF") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CFS", new Dictionary<string, IValue>()
				{
					{ "folder-no-1-153", new MultiValue<string>(new string[] {"1","153"}) },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CTM", new Dictionary<string, IValue>() {
					{ "time-mm-ss-mm-ss", new SingleValue<string>("mm:ss/mm:ss") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SCE", new Dictionary<string, IValue>() {
					{ "time-mm-ss", new SingleValue<string>("mm:ss") }
				}
				},
				{ "DSN", new Dictionary<string, IValue>() {
					{ "station-name", new SingleValue<string>("xx…xx") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "CTV", new Dictionary<string, IValue>() {
					{ "power", new SingleValue<string>("POWER") },
					{ "power-on", new SingleValue<string>("PWRON") },
					{ "power-off", new SingleValue<string>("PWROFF") },
					{ "chup", new SingleValue<string>("CHUP") },
					{ "chdown", new SingleValue<string>("CHDN") },
					{ "volume-up", new SingleValue<string>("VLUP") },
					{ "volume-down", new SingleValue<string>("VLDN") },
					{ "mute", new SingleValue<string>("MUTE") },
					{ "display", new SingleValue<string>("DISP") },
					{ "input", new SingleValue<string>("INPUT") },
					{ "1", new SingleValue<string>("1") },
					{ "2", new SingleValue<string>("2") },
					{ "3", new SingleValue<string>("3") },
					{ "4", new SingleValue<string>("4") },
					{ "5", new SingleValue<string>("5") },
					{ "6", new SingleValue<string>("6") },
					{ "7", new SingleValue<string>("7") },
					{ "8", new SingleValue<string>("8") },
					{ "9", new SingleValue<string>("9") },
					{ "0", new SingleValue<string>("0") },
					{ "clear", new SingleValue<string>("CLEAR") },
					{ "setup", new SingleValue<string>("SETUP") },
					{ "guide", new SingleValue<string>("GUIDE") },
					{ "chprev", new SingleValue<string>("PREV") },
					{ "cursor-up", new SingleValue<string>("UP") },
					{ "cursor-down", new SingleValue<string>("DOWN") },
					{ "cursor-left", new SingleValue<string>("LEFT") },
					{ "cursor-right", new SingleValue<string>("RIGHT") },
					{ "enter", new SingleValue<string>("ENTER") },
					{ "return", new SingleValue<string>("RETURN") },
					{ "a", new SingleValue<string>("A") },
					{ "b", new SingleValue<string>("B") },
					{ "c", new SingleValue<string>("C") },
					{ "d", new SingleValue<string>("D") }
				}
				}
			}
			},
			{ "zone2", new Dictionary<string, Dictionary<string, IValue>>() {
				{ "ZPW", new Dictionary<string, IValue>() {
					{ "standby", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ZPA", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ZPB", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ZMT", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ZVL", new Dictionary<string, IValue>()
				{
					{ "vol-0-100", new MultiValue<string>(new string[] {"0","100"}) },
					{ "level-up", new SingleValue<string>("UP") },
					{ "level-down", new SingleValue<string>("DOWN") },
					{ "level-up-1db-step", new SingleValue<string>("UP1") },
					{ "level-down-1db-step", new SingleValue<string>("DOWN1") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ZTN", new Dictionary<string, IValue>() {
					{ "bass-xx-is-a-00-a-10-0-10-1-step", new SingleValue<string>("B{xx}") },
					{ "treble-xx-is-a-00-a-10-0-10-1-step", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ZBL", new Dictionary<string, IValue>() {
					{ "xx-is-a-00-a-l-10-0-r-10-1-step", new SingleValue<string>("{xx}") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SLZ", new Dictionary<string, IValue>() {
					{ "video1", new SingleValue<string>("00") },
					{ "vcr", new SingleValue<string>("00") },
					{ "dvr", new SingleValue<string>("00") },
					{ "stb", new SingleValue<string>("00") },
					{ "video2", new SingleValue<string>("01") },
					{ "cbl", new SingleValue<string>("01") },
					{ "sat", new SingleValue<string>("01") },
					{ "video3", new SingleValue<string>("02") },
					{ "game/tv", new SingleValue<string>("02") },
					{ "game", new SingleValue<string>("02") },
					{ "game1", new SingleValue<string>("02") },
					{ "video4", new SingleValue<string>("03") },
					{ "aux1", new SingleValue<string>("03") },
					{ "video5", new SingleValue<string>("04") },
					{ "aux2", new SingleValue<string>("04") },
					{ "game2", new SingleValue<string>("04") },
					{ "video6", new SingleValue<string>("05") },
					{ "pc", new SingleValue<string>("05") },
					{ "video7", new SingleValue<string>("06") },
					{ "hidden1", new SingleValue<string>("07") },
					{ "extra1", new SingleValue<string>("07") },
					{ "hidden2", new SingleValue<string>("08") },
					{ "extra2", new SingleValue<string>("08") },
					{ "hidden3", new SingleValue<string>("09") },
					{ "extra3", new SingleValue<string>("09") },
					{ "dvd", new SingleValue<string>("10") },
					{ "bd", new SingleValue<string>("10") },
					{ "strm-box", new SingleValue<string>("11") },
					{ "tv", new SingleValue<string>("12") },
					{ "tape", new SingleValue<string>("20") },
					{ "tape2", new SingleValue<string>("21") },
					{ "phono", new SingleValue<string>("22") },
					{ "cd", new SingleValue<string>("23") },
					{ "tv/cd", new SingleValue<string>("23") },
					{ "fm", new SingleValue<string>("24") },
					{ "am", new SingleValue<string>("25") },
					{ "tuner", new SingleValue<string>("26") },
					{ "music-server", new SingleValue<string>("27") },
					{ "p4s", new SingleValue<string>("27") },
					{ "dlna", new SingleValue<string>("27") },
					{ "internet-radio", new SingleValue<string>("28") },
					{ "iradio-favorite", new SingleValue<string>("28") },
					{ "usb", new SingleValue<string>("2C") },
					{ "network", new SingleValue<string>("2B") },
					{ "net", new SingleValue<string>("2B") },
					{ "airplay", new SingleValue<string>("2D") },
					{ "bluetooth", new SingleValue<string>("2E") },
					{ "universal-port", new SingleValue<string>("40") },
					{ "multi-ch", new SingleValue<string>("30") },
					{ "xm", new SingleValue<string>("31") },
					{ "sirius", new SingleValue<string>("32") },
					{ "dab", new SingleValue<string>("33") },
					{ "hdmi-5", new SingleValue<string>("55") },
					{ "hdmi-6", new SingleValue<string>("56") },
					{ "hdmi-7", new SingleValue<string>("57") },
					{ "off", new SingleValue<string>("7F") },
					{ "source", new SingleValue<string>("80") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TUN", new Dictionary<string, IValue>() {
					{ "freq-nnnnn", new SingleValue<string>("nnnnn") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TUZ", new Dictionary<string, IValue>() {
					{ "freq-nnnnn", new SingleValue<string>("nnnnn") },
					{ "direct", new SingleValue<string>("DIRECT") },
					{ "band", new SingleValue<string>("BAND") },
					{ "0-in-direct-mode", new SingleValue<string>("0") },
					{ "1-in-direct-mode", new SingleValue<string>("1") },
					{ "2-in-direct-mode", new SingleValue<string>("2") },
					{ "3-in-direct-mode", new SingleValue<string>("3") },
					{ "4-in-direct-mode", new SingleValue<string>("4") },
					{ "5-in-direct-mode", new SingleValue<string>("5") },
					{ "6-in-direct-mode", new SingleValue<string>("6") },
					{ "7-in-direct-mode", new SingleValue<string>("7") },
					{ "8-in-direct-mode", new SingleValue<string>("8") },
					{ "9-in-direct-mode", new SingleValue<string>("9") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PRS", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PRZ", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NTC", new Dictionary<string, IValue>() {
					{ "playz", new SingleValue<string>("PLAYz") },
					{ "stopz", new SingleValue<string>("STOPz") },
					{ "pausez", new SingleValue<string>("PAUSEz") },
					{ "trupz", new SingleValue<string>("TRUPz") },
					{ "trdnz", new SingleValue<string>("TRDNz") }
				}
				},
				{ "NTZ", new Dictionary<string, IValue>() {
					{ "play", new SingleValue<string>("PLAY") },
					{ "stop", new SingleValue<string>("STOP") },
					{ "pause", new SingleValue<string>("PAUSE") },
					{ "p-p", new SingleValue<string>("P/P") },
					{ "trup", new SingleValue<string>("TRUP") },
					{ "trdn", new SingleValue<string>("TRDN") },
					{ "chup", new SingleValue<string>("CHUP") },
					{ "chdn", new SingleValue<string>("CHDN") },
					{ "ff", new SingleValue<string>("FF") },
					{ "rew", new SingleValue<string>("REW") },
					{ "repeat", new SingleValue<string>("REPEAT") },
					{ "random", new SingleValue<string>("RANDOM") },
					{ "rep-shf", new SingleValue<string>("REP/SHF") },
					{ "display", new SingleValue<string>("DISPLAY") },
					{ "memory", new SingleValue<string>("MEMORY") },
					{ "mode", new SingleValue<string>("MODE") },
					{ "right", new SingleValue<string>("RIGHT") },
					{ "left", new SingleValue<string>("LEFT") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "select", new SingleValue<string>("SELECT") },
					{ "return", new SingleValue<string>("RETURN") }
				}
				},
				{ "NPZ", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) }
				}
				},
				{ "LMZ", new Dictionary<string, IValue>() {
					{ "stereo", new SingleValue<string>("00") },
					{ "direct", new SingleValue<string>("01") },
					{ "mono", new SingleValue<string>("0F") },
					{ "multiplex", new SingleValue<string>("12") },
					{ "dvs", new SingleValue<string>("88") }
				}
				},
				{ "LTZ", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "low", new SingleValue<string>("01") },
					{ "high", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "RAZ", new Dictionary<string, IValue>() {
					{ "both-off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("02") },
					{ "up", new SingleValue<string>("UP") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				}
			}
			},
			{ "zone3", new Dictionary<string, Dictionary<string, IValue>>() {
				{ "PW3", new Dictionary<string, IValue>() {
					{ "standby", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "MT3", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "VL3", new Dictionary<string, IValue>()
				{
					{ "vol-0-100", new MultiValue<string>(new string[] {"0","100"}) },
					{ "level-up", new SingleValue<string>("UP") },
					{ "level-down", new SingleValue<string>("DOWN") },
					{ "level-up-1db-step", new SingleValue<string>("UP1") },
					{ "level-down-1db-step", new SingleValue<string>("DOWN1") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TN3", new Dictionary<string, IValue>() {
					{ "b-xx", new SingleValue<string>("B{xx}") },
					{ "t-xx", new SingleValue<string>("T{xx}") },
					{ "bass-up", new SingleValue<string>("BUP") },
					{ "bass-down", new SingleValue<string>("BDOWN") },
					{ "treble-up", new SingleValue<string>("TUP") },
					{ "treble-down", new SingleValue<string>("TDOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "BL3", new Dictionary<string, IValue>() {
					{ "xx", new SingleValue<string>("{xx}") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SL3", new Dictionary<string, IValue>() {
					{ "video1", new SingleValue<string>("00") },
					{ "vcr", new SingleValue<string>("00") },
					{ "dvr", new SingleValue<string>("00") },
					{ "stb", new SingleValue<string>("00") },
					{ "video2", new SingleValue<string>("01") },
					{ "cbl", new SingleValue<string>("01") },
					{ "sat", new SingleValue<string>("01") },
					{ "video3", new SingleValue<string>("02") },
					{ "game/tv", new SingleValue<string>("02") },
					{ "game", new SingleValue<string>("02") },
					{ "game1", new SingleValue<string>("02") },
					{ "video4", new SingleValue<string>("03") },
					{ "aux1", new SingleValue<string>("03") },
					{ "video5", new SingleValue<string>("04") },
					{ "aux2", new SingleValue<string>("04") },
					{ "game2", new SingleValue<string>("04") },
					{ "video6", new SingleValue<string>("05") },
					{ "pc", new SingleValue<string>("05") },
					{ "video7", new SingleValue<string>("06") },
					{ "hidden1", new SingleValue<string>("07") },
					{ "extra1", new SingleValue<string>("07") },
					{ "hidden2", new SingleValue<string>("08") },
					{ "extra2", new SingleValue<string>("08") },
					{ "hidden3", new SingleValue<string>("09") },
					{ "extra3", new SingleValue<string>("09") },
					{ "dvd", new SingleValue<string>("10") },
					{ "strm-box", new SingleValue<string>("11") },
					{ "tv", new SingleValue<string>("12") },
					{ "tape", new SingleValue<string>("20") },
					{ "tape2", new SingleValue<string>("21") },
					{ "phono", new SingleValue<string>("22") },
					{ "cd", new SingleValue<string>("23") },
					{ "tv/cd", new SingleValue<string>("23") },
					{ "fm", new SingleValue<string>("24") },
					{ "am", new SingleValue<string>("25") },
					{ "tuner", new SingleValue<string>("26") },
					{ "music-server", new SingleValue<string>("27") },
					{ "p4s", new SingleValue<string>("27") },
					{ "dlna", new SingleValue<string>("27") },
					{ "internet-radio", new SingleValue<string>("28") },
					{ "iradio-favorite", new SingleValue<string>("28") },
					{ "usb", new SingleValue<string>("2C") },
					{ "network", new SingleValue<string>("2B") },
					{ "net", new SingleValue<string>("2B") },
					{ "airplay", new SingleValue<string>("2D") },
					{ "bluetooth", new SingleValue<string>("2E") },
					{ "universal-port", new SingleValue<string>("40") },
					{ "multi-ch", new SingleValue<string>("30") },
					{ "xm", new SingleValue<string>("31") },
					{ "sirius", new SingleValue<string>("32") },
					{ "dab", new SingleValue<string>("33") },
					{ "source", new SingleValue<string>("80") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TUN", new Dictionary<string, IValue>() {
					{ "freq-nnnnn", new SingleValue<string>("nnnnn") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TU3", new Dictionary<string, IValue>() {
					{ "freq-nnnnn", new SingleValue<string>("nnnnn") },
					{ "band", new SingleValue<string>("BAND") },
					{ "direct", new SingleValue<string>("DIRECT") },
					{ "0-in-direct-mode", new SingleValue<string>("0") },
					{ "1-in-direct-mode", new SingleValue<string>("1") },
					{ "2-in-direct-mode", new SingleValue<string>("2") },
					{ "3-in-direct-mode", new SingleValue<string>("3") },
					{ "4-in-direct-mode", new SingleValue<string>("4") },
					{ "5-in-direct-mode", new SingleValue<string>("5") },
					{ "6-in-direct-mode", new SingleValue<string>("6") },
					{ "7-in-direct-mode", new SingleValue<string>("7") },
					{ "8-in-direct-mode", new SingleValue<string>("8") },
					{ "9-in-direct-mode", new SingleValue<string>("9") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PRS", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PR3", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NTC", new Dictionary<string, IValue>() {
					{ "playz", new SingleValue<string>("PLAYz") },
					{ "stopz", new SingleValue<string>("STOPz") },
					{ "pausez", new SingleValue<string>("PAUSEz") },
					{ "trupz", new SingleValue<string>("TRUPz") },
					{ "trdnz", new SingleValue<string>("TRDNz") }
				}
				},
				{ "NT3", new Dictionary<string, IValue>() {
					{ "play", new SingleValue<string>("PLAY") },
					{ "stop", new SingleValue<string>("STOP") },
					{ "pause", new SingleValue<string>("PAUSE") },
					{ "p-p", new SingleValue<string>("P/P") },
					{ "trup", new SingleValue<string>("TRUP") },
					{ "trdn", new SingleValue<string>("TRDN") },
					{ "chup", new SingleValue<string>("CHUP") },
					{ "chdn", new SingleValue<string>("CHDN") },
					{ "ff", new SingleValue<string>("FF") },
					{ "rew", new SingleValue<string>("REW") },
					{ "repeat", new SingleValue<string>("REPEAT") },
					{ "random", new SingleValue<string>("RANDOM") },
					{ "rep-shf", new SingleValue<string>("REP/SHF") },
					{ "display", new SingleValue<string>("DISPLAY") },
					{ "memory", new SingleValue<string>("MEMORY") },
					{ "right", new SingleValue<string>("RIGHT") },
					{ "left", new SingleValue<string>("LEFT") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "select", new SingleValue<string>("SELECT") },
					{ "return", new SingleValue<string>("RETURN") }
				}
				},
				{ "NP3", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) }
				}
				}
			}
			},
			{ "zone4", new Dictionary<string, Dictionary<string, IValue>>() {
				{ "PW4", new Dictionary<string, IValue>() {
					{ "standby", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "MT4", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("00") },
					{ "on", new SingleValue<string>("01") },
					{ "toggle", new SingleValue<string>("TG") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "VL4", new Dictionary<string, IValue>()
				{
					{ "vol-0-100", new MultiValue<string>(new string[] {"0","100"}) },
					{ "level-up", new SingleValue<string>("UP") },
					{ "level-down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "SL4", new Dictionary<string, IValue>() {
					{ "video1", new SingleValue<string>("00") },
					{ "vcr", new SingleValue<string>("00") },
					{ "dvr", new SingleValue<string>("00") },
					{ "stb", new SingleValue<string>("00") },
					{ "video2", new SingleValue<string>("01") },
					{ "cbl", new SingleValue<string>("01") },
					{ "sat", new SingleValue<string>("01") },
					{ "video3", new SingleValue<string>("02") },
					{ "game/tv", new SingleValue<string>("02") },
					{ "game", new SingleValue<string>("02") },
					{ "game1", new SingleValue<string>("02") },
					{ "video4", new SingleValue<string>("03") },
					{ "aux1", new SingleValue<string>("03") },
					{ "video5", new SingleValue<string>("04") },
					{ "aux2", new SingleValue<string>("04") },
					{ "game2", new SingleValue<string>("04") },
					{ "video6", new SingleValue<string>("05") },
					{ "pc", new SingleValue<string>("05") },
					{ "video7", new SingleValue<string>("06") },
					{ "hidden1", new SingleValue<string>("07") },
					{ "extra1", new SingleValue<string>("07") },
					{ "hidden2", new SingleValue<string>("08") },
					{ "extra2", new SingleValue<string>("08") },
					{ "hidden3", new SingleValue<string>("09") },
					{ "extra3", new SingleValue<string>("09") },
					{ "dvd", new SingleValue<string>("10") },
					{ "bd", new SingleValue<string>("10") },
					{ "tape-1", new SingleValue<string>("20") },
					{ "tv/tape", new SingleValue<string>("20") },
					{ "tape2", new SingleValue<string>("21") },
					{ "phono", new SingleValue<string>("22") },
					{ "cd", new SingleValue<string>("23") },
					{ "tv/cd", new SingleValue<string>("23") },
					{ "fm", new SingleValue<string>("24") },
					{ "am", new SingleValue<string>("25") },
					{ "tuner", new SingleValue<string>("26") },
					{ "music-server", new SingleValue<string>("27") },
					{ "p4s", new SingleValue<string>("27") },
					{ "dlna", new SingleValue<string>("27") },
					{ "internet-radio", new SingleValue<string>("28") },
					{ "iradio-favorite", new SingleValue<string>("28") },
					{ "usb", new SingleValue<string>("2C") },
					{ "network", new SingleValue<string>("2B") },
					{ "net", new SingleValue<string>("2B") },
					{ "airplay", new SingleValue<string>("2D") },
					{ "bluetooth", new SingleValue<string>("2E") },
					{ "universal-port", new SingleValue<string>("40") },
					{ "multi-ch", new SingleValue<string>("30") },
					{ "xm", new SingleValue<string>("31") },
					{ "sirius", new SingleValue<string>("32") },
					{ "dab", new SingleValue<string>("33") },
					{ "source", new SingleValue<string>("80") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TUN", new Dictionary<string, IValue>() {
					{ "freq-nnnnn,", new SingleValue<string>("nnnnn") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "TU4", new Dictionary<string, IValue>() {
					{ "freq-nnnnn,", new SingleValue<string>("nnnnn") },
					{ "direct", new SingleValue<string>("DIRECT") },
					{ "0-in-direct-mode", new SingleValue<string>("0") },
					{ "1-in-direct-mode", new SingleValue<string>("1") },
					{ "2-in-direct-mode", new SingleValue<string>("2") },
					{ "3-in-direct-mode", new SingleValue<string>("3") },
					{ "4-in-direct-mode", new SingleValue<string>("4") },
					{ "5-in-direct-mode", new SingleValue<string>("5") },
					{ "6-in-direct-mode", new SingleValue<string>("6") },
					{ "7-in-direct-mode", new SingleValue<string>("7") },
					{ "8-in-direct-mode", new SingleValue<string>("8") },
					{ "9-in-direct-mode", new SingleValue<string>("9") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PRS", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "PR4", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "no-1-30", new MultiValue<string>(new string[] {"1","30"}) },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NTC", new Dictionary<string, IValue>() {
					{ "playz", new SingleValue<string>("PLAYz") },
					{ "stopz", new SingleValue<string>("STOPz") },
					{ "pausez", new SingleValue<string>("PAUSEz") },
					{ "trupz", new SingleValue<string>("TRUPz") },
					{ "trdnz", new SingleValue<string>("TRDNz") }
				}
				},
				{ "NT4", new Dictionary<string, IValue>() {
					{ "play", new SingleValue<string>("PLAY") },
					{ "stop", new SingleValue<string>("STOP") },
					{ "pause", new SingleValue<string>("PAUSE") },
					{ "trup", new SingleValue<string>("TRUP") },
					{ "trdn", new SingleValue<string>("TRDN") },
					{ "ff", new SingleValue<string>("FF") },
					{ "rew", new SingleValue<string>("REW") },
					{ "repeat", new SingleValue<string>("REPEAT") },
					{ "random", new SingleValue<string>("RANDOM") },
					{ "display", new SingleValue<string>("DISPLAY") },
					{ "right", new SingleValue<string>("RIGHT") },
					{ "left", new SingleValue<string>("LEFT") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "select", new SingleValue<string>("SELECT") },
					{ "return", new SingleValue<string>("RETURN") }
				}
				},
				{ "NP4", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) }
				}
				}
			}
			},
			{ "dock", new Dictionary<string, Dictionary<string, IValue>>() {
				{ "NTC", new Dictionary<string, IValue>() {
					{ "play", new SingleValue<string>("PLAY") },
					{ "stop", new SingleValue<string>("STOP") },
					{ "pause", new SingleValue<string>("PAUSE") },
					{ "p-p", new SingleValue<string>("P/P") },
					{ "trup", new SingleValue<string>("TRUP") },
					{ "trdn", new SingleValue<string>("TRDN") },
					{ "ff", new SingleValue<string>("FF") },
					{ "rew", new SingleValue<string>("REW") },
					{ "repeat", new SingleValue<string>("REPEAT") },
					{ "random", new SingleValue<string>("RANDOM") },
					{ "rep-shf", new SingleValue<string>("REP/SHF") },
					{ "display", new SingleValue<string>("DISPLAY") },
					{ "album", new SingleValue<string>("ALBUM") },
					{ "artist", new SingleValue<string>("ARTIST") },
					{ "genre", new SingleValue<string>("GENRE") },
					{ "playlist", new SingleValue<string>("PLAYLIST") },
					{ "right", new SingleValue<string>("RIGHT") },
					{ "left", new SingleValue<string>("LEFT") },
					{ "up", new SingleValue<string>("UP") },
					{ "down", new SingleValue<string>("DOWN") },
					{ "select", new SingleValue<string>("SELECT") },
					{ "0", new SingleValue<string>("0") },
					{ "1", new SingleValue<string>("1") },
					{ "2", new SingleValue<string>("2") },
					{ "3", new SingleValue<string>("3") },
					{ "4", new SingleValue<string>("4") },
					{ "5", new SingleValue<string>("5") },
					{ "6", new SingleValue<string>("6") },
					{ "7", new SingleValue<string>("7") },
					{ "8", new SingleValue<string>("8") },
					{ "9", new SingleValue<string>("9") },
					{ "delete", new SingleValue<string>("DELETE") },
					{ "caps", new SingleValue<string>("CAPS") },
					{ "location", new SingleValue<string>("LOCATION") },
					{ "language", new SingleValue<string>("LANGUAGE") },
					{ "setup", new SingleValue<string>("SETUP") },
					{ "return", new SingleValue<string>("RETURN") },
					{ "chup", new SingleValue<string>("CHUP") },
					{ "chdn", new SingleValue<string>("CHDN") },
					{ "menu", new SingleValue<string>("MENU") },
					{ "top", new SingleValue<string>("TOP") },
					{ "mode", new SingleValue<string>("MODE") },
					{ "list", new SingleValue<string>("LIST") },
					{ "memory", new SingleValue<string>("MEMORY") },
					{ "f1", new SingleValue<string>("F1") },
					{ "f2", new SingleValue<string>("F2") }
				}
				},
				{ "NBS", new Dictionary<string, IValue>() {
					{ "off", new SingleValue<string>("OFF") },
					{ "on", new SingleValue<string>("ON") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NBT", new Dictionary<string, IValue>() {
					{ "pairing", new SingleValue<string>("PAIRING") },
					{ "clear", new SingleValue<string>("CLEAR") }
				}
				},
				{ "NAT", new Dictionary<string, IValue>() {
					{ "artist-name", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NAL", new Dictionary<string, IValue>() {
					{ "album-name", new SingleValue<string>("nnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NTI", new Dictionary<string, IValue>() {
					{ "title", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NTM", new Dictionary<string, IValue>() {
					{ "mm-ss-mm-ss", new SingleValue<string>("mm:ss/mm:ss") },
					{ "hh-mm-ss-hh-mm-ss", new SingleValue<string>("hh:mm:ss/hh:mm:ss") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NTR", new Dictionary<string, IValue>() {
					{ "cccc-tttt", new SingleValue<string>("cccc/tttt") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NST", new Dictionary<string, IValue>() {
					{ "prs", new SingleValue<string>("prs") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NMS", new Dictionary<string, IValue>() {
					{ "maabbstii", new SingleValue<string>("maabbstii") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NTS", new Dictionary<string, IValue>() {
					{ "mm-ss", new SingleValue<string>("mm:ss") },
					{ "hh-mm-ss", new SingleValue<string>("hh:mm:ss") }
				}
				},
				{ "NPR", new Dictionary<string, IValue>()
				{
					{ "no-1-40", new MultiValue<string>(new string[] {"1","40"}) },
					{ "set", new SingleValue<string>("SET") }
				}
				},
				{ "NDS", new Dictionary<string, IValue>() {
					{ "nfr", new SingleValue<string>("nfr") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NLS", new Dictionary<string, IValue>() {
					{ "info", new SingleValue<string>("tlpnnnnnnnnnn") },
					{ "ti", new SingleValue<string>("ti") }
				}
				},
				{ "NLA", new Dictionary<string, IValue>() {
					{ "tzzzzsurr", new SingleValue<string>("tzzzzsurr<.....>") },
					{ "lzzzzll-xx-xx-yyyy", new SingleValue<string>("Lzzzzll{xx}{xx}yyyy") },
					{ "izzzzll-xx-xx", new SingleValue<string>("Izzzzll{xx}{xx}----") }
				}
				},
				{ "NJA", new Dictionary<string, IValue>() {
					{ "tp-xx-xx-xx-xx-xx-xx", new SingleValue<string>("tp{xx}{xx}{xx}{xx}{xx}{xx}") },
					{ "disable", new SingleValue<string>("DIS") },
					{ "enable", new SingleValue<string>("ENA") },
					{ "enable-and-image-type-bmp", new SingleValue<string>("BMP") },
					{ "enable-and-image-type-link", new SingleValue<string>("LINK") },
					{ "up", new SingleValue<string>("UP") },
					{ "req", new SingleValue<string>("REQ") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NSV", new Dictionary<string, IValue>() {
					{ "service-id", new SingleValue<string>("ssiaaaa…aaaabbbb…bbbb") }
				}
				},
				{ "NKY", new Dictionary<string, IValue>() {
					{ "ll", new SingleValue<string>("ll") },
					{ "input", new SingleValue<string>("nnnnnnnnn") }
				}
				},
				{ "NPU", new Dictionary<string, IValue>() {
					{ "popup", new SingleValue<string>("xaaa…aaaybbb…bbb") }
				}
				},
				{ "NLT", new Dictionary<string, IValue>() {
					{ "title-info", new SingleValue<string>("{xx}uycccciiiillrraabbssnnn...nnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NMD", new Dictionary<string, IValue>() {
					{ "std", new SingleValue<string>("STD") },
					{ "ext", new SingleValue<string>("EXT") },
					{ "vdc", new SingleValue<string>("VDC") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NSB", new Dictionary<string, IValue>() {
					{ "is-off", new SingleValue<string>("OFF") },
					{ "is-on", new SingleValue<string>("ON") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NRI", new Dictionary<string, IValue>() {
					{ "xml", new SingleValue<string>("<…>") },
					{ "query", new SingleValue<string>("QSTN") },
					{ "t", new SingleValue<string>("t----<.....>") },
					{ "ullt", new SingleValue<string>("Ullt<.....>") }
				}
				},
				{ "NLU", new Dictionary<string, IValue>() {
					{ "xx-xx-yyyy", new SingleValue<string>("{xx}{xx}yyyy") }
				}
				},
				{ "NPB", new Dictionary<string, IValue>() {
					{ "pudtsrrr", new SingleValue<string>("pudtsrrr") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "NAF", new Dictionary<string, IValue>() {
					{ "xx-xx", new SingleValue<string>("{xx}{xx}") }
				}
				},
				{ "NRF", new Dictionary<string, IValue>()
				{
					{ "fav-no-1-40", new MultiValue<string>(new string[] {"1","40"}) }
				}
				},
				{ "NSD", new Dictionary<string, IValue>() {
					{ "xx-xx-xx-xx-xx-x", new SingleValue<string>("{xx}{xx}{xx}{xx}{xx}x") }
				}
				},
				{ "AAT", new Dictionary<string, IValue>() {
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "AAL", new Dictionary<string, IValue>() {
					{ "album-name", new SingleValue<string>("nnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ATI", new Dictionary<string, IValue>() {
					{ "title", new SingleValue<string>("nnnnnnnnnn") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "ATM", new Dictionary<string, IValue>() {
					{ "mm-ss-mm-ss", new SingleValue<string>("mm:ss/mm:ss") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				},
				{ "AST", new Dictionary<string, IValue>() {
					{ "prs", new SingleValue<string>("prs") },
					{ "query", new SingleValue<string>("QSTN") }
				}
				}
			}
			}
		};
	}
}
