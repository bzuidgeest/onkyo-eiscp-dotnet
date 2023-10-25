// Generated
// by 
// from 
// at 25-10-2023 21:01:16

using System.Collections;
using System.Collections.Specialized;

namespace Eiscp.Core
{
	public static partial class EiscpCommands
	{
		public static readonly Dictionary<string, object>  Commands = new Dictionary<string, Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>>() {
			{
 				"main", new Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>() {					{
 						"PWR", new ISCPCommandDocumentation() {
							Name = @"system-power",
,							Description = @"System Power Command",
,							Aliases =  new string[] { "power" })
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "standby","off" }), 
									Description = @"sets System Standby",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets System On",,
								}
								"ALL", new ISCPCommandValueDocumentation() {
									Name = @"standby-all",, 
									Description = @"All Zone(including Main Zone) Standby",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the System Power Status",,
								}

						}
					},					{
 						"AMT", new ISCPCommandDocumentation() {
							Name = @"audio-muting",
,							Description = @"Audio Muting Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Audio Muting Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Audio Muting On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Audio Muting Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Audio Muting State",,
								}

						}
					},					{
 						"CMT", new ISCPCommandDocumentation() {
							Name = @"audio-muting-by-channel",
,							Description = @"Audio Muting by Channel Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"aabbccddeeffgghhiijjkkllmm", new ISCPCommandValueDocumentation() {
									Name = @"aabbccddeeffgghhiijjkkllmm",, 
									Description = @"sets Audio Muting by Channel
xx=00 Muting Off
xx=01 Muting On
xx=TG Muting Wrap-Around
for not exist channel is always 00.

aa:Front Left
bb:Front Right
cc:Center
dd:Surround Left
ee:Surround Right
ff:Surround Back Left
gg:Surround Back Right
hh:Subwoofer 1
ii:Height 1 Left
jj:Height 1 Right
kk:Height 2 Left
ll:Height2 Right
mm:Subwoofer 2",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Audio Muting State",,
								}

						}
					},					{
 						"SPA", new ISCPCommandDocumentation() {
							Name = @"speaker-a",
,							Description = @"Speaker A Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Speaker Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Speaker On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Speaker Switch Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Speaker State",,
								}

						}
					},					{
 						"SPB", new ISCPCommandDocumentation() {
							Name = @"speaker-b",
,							Description = @"Speaker B Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Speaker Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Speaker On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Speaker Switch Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Speaker State",,
								}

						}
					},					{
 						"SPL", new ISCPCommandDocumentation() {
							Name = @"speaker-layout",
,							Description = @"Speaker Layout Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"SB", new ISCPCommandValueDocumentation() {
									Name = @"surrback",, 
									Description = @"sets SurrBack Speaker",,
								}
								"FH", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "front-high","surrback-front-high-speakers" }), 
									Description = @"sets Front High Speaker / SurrBack+Front High Speakers",,
								}
								"FW", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "front-wide","surrback-front-wide-speakers" }), 
									Description = @"sets Front Wide Speaker / SurrBack+Front Wide Speakers",,
								}
								"HW", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "front-high-front-wide-speakers" }), 
									Description = @"sets, Front High+Front Wide Speakers",,
								}
								"H1", new ISCPCommandValueDocumentation() {
									Name = @"height1-speakers",, 
									Description = @"sets Height1 Speakers",,
								}
								"H2", new ISCPCommandValueDocumentation() {
									Name = @"height2-speakers",, 
									Description = @"sets Height2 Speakers",,
								}
								"BH", new ISCPCommandValueDocumentation() {
									Name = @"back-height1-speakers",, 
									Description = @"sets Back+Height1 Speakers",,
								}
								"BW", new ISCPCommandValueDocumentation() {
									Name = @"back-wide-speakers",, 
									Description = @"sets Back+Wide Speakers",,
								}
								"HH", new ISCPCommandValueDocumentation() {
									Name = @"height1-height2-speakers",, 
									Description = @"sets Height1+Height2 Speakers",,
								}
								"A", new ISCPCommandValueDocumentation() {
									Name = @"speakers-a",, 
									Description = @"sets Speakers A",,
								}
								"B", new ISCPCommandValueDocumentation() {
									Name = @"speakers-b",, 
									Description = @"sets Speakers B",,
								}
								"AB", new ISCPCommandValueDocumentation() {
									Name = @"speakers-a-b",, 
									Description = @"sets Speakers A+B",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Speaker Switch Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Spea  ker State",,
								}

						}
					},					{
 						"MVL", new ISCPCommandDocumentation() {
							Name = @"master-volume",
,							Description = @"Master Volume Command",
,							Aliases =  new string[] { "volume" })
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"Volume Level 0.0 – 100.0 ( 0.5 Step In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"vol-0-100,",, 
									Description = @"Volume Level 0 – 100 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"Volume Level 0 – 80 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"vol-0-50,",, 
									Description = @"Volume Level 0 – 50 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"level-up",, 
									Description = @"sets Volume Level Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"level-down",, 
									Description = @"sets Volume Level Down",,
								}
								"UP1", new ISCPCommandValueDocumentation() {
									Name = @"level-up-1db-step",, 
									Description = @"sets Volume Level Up 1dB Step",,
								}
								"DOWN1", new ISCPCommandValueDocumentation() {
									Name = @"level-down-1db-step",, 
									Description = @"sets Volume Level Down 1dB Step",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Volume Level",,
								}

						}
					},					{
 						"TFR", new ISCPCommandDocumentation() {
							Name = @"tone-front",
,							Description = @"Tone(Front) Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Front Bass (xx is "-A"..."00"..."+A"[-10...0...+10 1 step]",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"t-xx",, 
									Description = @"Front Treble (xx is "-A"..."00"..."+A"[-10...0...+10 1 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Front Bass up(1 step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Front Bass down(1 step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Front Treble up(1 step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Front Treble down(1 step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Front Tone ("BxxTxx")",,
								}

						}
					},					{
 						"TFW", new ISCPCommandDocumentation() {
							Name = @"tone-front-wide",
,							Description = @"Tone(Front Wide) Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Front Wide Bass (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"t-xx",, 
									Description = @"Front Wide Treble (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Front Wide Bass up(2 step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Front Wide Bass down(2 step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Front Wide Treble up(2 step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Front Wide Treble down(2 step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Front Wide Tone ("BxxTxx")",,
								}

						}
					},					{
 						"TFH", new ISCPCommandDocumentation() {
							Name = @"tone-front-high",
,							Description = @"Tone(Front High) Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Front High Bass (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"t-xx",, 
									Description = @"Front High Treble (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Front High Bass up(2 step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Front High Bass down(2 step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Front High Treble up(2 step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Front High Treble down(2 step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Front High Tone ("BxxTxx")",,
								}

						}
					},					{
 						"TCT", new ISCPCommandDocumentation() {
							Name = @"tone-center",
,							Description = @"Tone(Center) Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Center Bass (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"t-xx",, 
									Description = @"Center Treble (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Center Bass up(2 step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Center Bass down(2 step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Center Treble up(2 step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Center Treble down(2 step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Cetner Tone ("BxxTxx")",,
								}

						}
					},					{
 						"TSR", new ISCPCommandDocumentation() {
							Name = @"tone-surround",
,							Description = @"Tone(Surround) Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Surround Bass (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"t-xx",, 
									Description = @"Surround Treble (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Surround Bass up(2 step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Surround Bass down(2 step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Surround Treble up(2 step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Surround Treble down(2 step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Surround Tone ("BxxTxx")",,
								}

						}
					},					{
 						"TSB", new ISCPCommandDocumentation() {
							Name = @"tone-surround-back",
,							Description = @"Tone(Surround Back) Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Surround Back Bass (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"t-xx",, 
									Description = @"Surround Back Treble (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Surround Back Bass up(2 step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Surround Back Bass down(2 step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Surround Back Treble up(2 step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Surround Back Treble down(2 step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Surround Back Tone ("BxxTxx")",,
								}

						}
					},					{
 						"TSW", new ISCPCommandDocumentation() {
							Name = @"tone-subwoofer",
,							Description = @"Tone(Subwoofer) Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Subwoofer Bass (xx is "-A"..."00"..."+A"[-10...0...+10 2 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Subwoofer Bass up(2 step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Subwoofer Bass down(2 step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Subwoofer Tone ("BxxTxx")",,
								}

						}
					},					{
 						"PMB", new ISCPCommandDocumentation() {
							Name = @"phase-matching-bass",
,							Description = @"Phase Matching Bass Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Phase Matching Bass Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Phase Matching Bass",,
								}

						}
					},					{
 						"SLP", new ISCPCommandDocumentation() {
							Name = @"sleep-set",
,							Description = @"Sleep Set Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"time-1-90min",, 
									Description = @"sets Sleep Time 1 - 90min ( In hexadecimal representation)",,
								}
								"OFF", new ISCPCommandValueDocumentation() {
									Name = @"time-off",, 
									Description = @"sets Sleep Time Off",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Sleep Time Wrap-Around UP",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"qstn",, 
									Description = @"gets The Sleep Time",,
								}

						}
					},					{
 						"SLC", new ISCPCommandDocumentation() {
							Name = @"speaker-level-calibration",
,							Description = @"Speaker Level Calibration Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"TEST", new ISCPCommandValueDocumentation() {
									Name = @"test",, 
									Description = @"TEST Key",,
								}
								"OFF", new ISCPCommandValueDocumentation() {
									Name = @"test-tone-off",, 
									Description = @"sets TEST TONE OFF",,
								}
								"CHSEL", new ISCPCommandValueDocumentation() {
									Name = @"chsel",, 
									Description = @"CH SEL Key",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"LEVEL + Key",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"LEVEL – KEY",,
								}

						}
					},					{
 						"SWL", new ISCPCommandDocumentation() {
							Name = @"subwoofer-temporary-level",
,							Description = @"Subwoofer (temporary) Level Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"15-0db-0-0db-12-0db",, 
									Description = @"sets Subwoofer Level -15.0dB - 0.0dB - +12.0dB(0.5dB Step)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"15db-0db-12db",, 
									Description = @"sets Subwoofer Level -15dB - 0dB - +12dB",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"LEVEL + Key",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"LEVEL – KEY",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Subwoofer Level",,
								}

						}
					},					{
 						"SW2", new ISCPCommandDocumentation() {
							Name = @"subwoofer-2-temporary-level",
,							Description = @"Subwoofer 2 (temporary) Level Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"15-0db-0-0db-12-0db",, 
									Description = @"sets Subwoofer 2 Level -15.0dB - 0.0dB - +12.0dB(0.5dB Step)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"15db-0db-12db",, 
									Description = @"sets Subwoofer 2 Level -15dB - 0dB - +12dB",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"LEVEL + Key",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"LEVEL – KEY",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Subwoofer Level",,
								}

						}
					},					{
 						"CTL", new ISCPCommandDocumentation() {
							Name = @"center-temporary-level",
,							Description = @"Center (temporary) Level Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"12-0db-0-0db-12-0db",, 
									Description = @"sets Center Level -12.0dB - 0.0dB - +12.0dB(0.5dB Step)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"12db-0db-12db",, 
									Description = @"sets Center Level -12dB - 0dB - +12dB",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"LEVEL + Key",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"LEVEL – KEY",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Subwoofer Level",,
								}

						}
					},					{
 						"TCL", new ISCPCommandDocumentation() {
							Name = @"temporary-channel-level",
,							Description = @"Temporary Channel Level Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"aaabbbcccdddeeefffggghhhiiijjjkkklllmmm", new ISCPCommandValueDocumentation() {
									Name = @"levels",, 
									Description = @"sets Temporary Channel Level
Subwoofer1/2 xxx=-1E(-15.0dB)~000(0.0dB)~+18(+12.0dB)
Other Ch xxx=-18(-12.0dB)~000(0.0dB)~+18(+12.0dB)
for not exist channel is always 000.

aaa:Front Left
bbb:Front Right
ccc:Center
ddd:Surround Left
eee:Surround Right
fff:Surround Back Left
ggg:Surround Back Right
hhh:Subwoofer 1
iii:Height 1 Left
jjj:Height 1 Right
kkk:Height 2 Left
lll:Height2 Right
mmm:Subwoofer 2",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Subwoofer Level",,
								}

						}
					},					{
 						"DIF", new ISCPCommandDocumentation() {
							Name = @"display-mode",
,							Description = @"Display Mode Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "selector-volume-1line","default-2line" }), 
									Description = @"sets Selector + Volume Display Mode@1line, Default@2line",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"selector-listening-1line",, 
									Description = @"sets Selector + Listening Mode Display Mode@1line",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"02",, 
									Description = @"Display Digital Format(temporary display)",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"03",, 
									Description = @"Display Video Format(temporary display)",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Display Mode Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Display Mode",,
								}

						}
					},					{
 						"DIM", new ISCPCommandDocumentation() {
							Name = @"dimmer-level",
,							Description = @"Dimmer Level Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"bright",, 
									Description = @"sets Dimmer Level "Bright"",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"dim",, 
									Description = @"sets Dimmer Level "Dim"",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"dark",, 
									Description = @"sets Dimmer Level "Dark"",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"shut-off",, 
									Description = @"sets Dimmer Level "Shut-Off"",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name = @"bright-led-off",, 
									Description = @"sets Dimmer Level "Bright & LED OFF"",,
								}
								"DIM", new ISCPCommandValueDocumentation() {
									Name = @"dim",, 
									Description = @"sets Dimmer Level Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Dimmer Level",,
								}

						}
					},					{
 						"OSD", new ISCPCommandDocumentation() {
							Name = @"setup",
,							Description = @"Setup Operation Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"MENU", new ISCPCommandValueDocumentation() {
									Name = @"menu",, 
									Description = @"Menu Key              Setup Key",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"Up Key",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"Down Key",,
								}
								"RIGHT", new ISCPCommandValueDocumentation() {
									Name = @"right",, 
									Description = @"Right Key",,
								}
								"LEFT", new ISCPCommandValueDocumentation() {
									Name = @"left",, 
									Description = @"Left Key",,
								}
								"ENTER", new ISCPCommandValueDocumentation() {
									Name = @"enter",, 
									Description = @"Enter Key",,
								}
								"EXIT", new ISCPCommandValueDocumentation() {
									Name = @"exit",, 
									Description = @"Exit Key",,
								}
								"AUDIO", new ISCPCommandValueDocumentation() {
									Name = @"audio",, 
									Description = @"Audio Adjust Key",,
								}
								"VIDEO", new ISCPCommandValueDocumentation() {
									Name = @"video",, 
									Description = @"Video Adjust Key",,
								}
								"HOME", new ISCPCommandValueDocumentation() {
									Name = @"home",, 
									Description = @"Home Key",,
								}
								"QUICK", new ISCPCommandValueDocumentation() {
									Name = @"quick",, 
									Description = @"Quick Setup Key     Quick Menu Key/AV Adjust Key",,
								}
								"IPV", new ISCPCommandValueDocumentation() {
									Name = @"ipv",, 
									Description = @"Instaprevue Key",,
								}

						}
					},					{
 						"MEM", new ISCPCommandDocumentation() {
							Name = @"memory-setup",
,							Description = @"Memory Setup Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"STR", new ISCPCommandValueDocumentation() {
									Name = @"str",, 
									Description = @"stores memory",,
								}
								"RCL", new ISCPCommandValueDocumentation() {
									Name = @"rcl",, 
									Description = @"recalls memory",,
								}
								"LOCK", new ISCPCommandValueDocumentation() {
									Name = @"lock",, 
									Description = @"locks memory",,
								}
								"UNLK", new ISCPCommandValueDocumentation() {
									Name = @"unlk",, 
									Description = @"unlocks memory",,
								}

						}
					},					{
 						"RST", new ISCPCommandDocumentation() {
							Name = @"reset",
,							Description = @"Reset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"ALL", new ISCPCommandValueDocumentation() {
									Name = @"all",, 
									Description = @"Reset All",,
								}

						}
					},					{
 						"IFA", new ISCPCommandDocumentation() {
							Name = @"audio-information",
,							Description = @"Audio Information Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"a..a,b..b,c…c,d..d,e…e,f…f,", new ISCPCommandValueDocumentation() {
									Name = @"a-a-b-b-c-c-d-d-e-e-f-f",, 
									Description = @"Infomation of Audio(Same Immediate Display ',' is separator of infomations)
a...a: Audio Input Port
b…b: Input Signal Format
c…c: Sampling Frequency
d…d: Input Signal Channel
e…e: Listening Mode
f…f: Output Signal Channel",,
								}
								"a..a,b..b,c…c,d..d,e…e,f…f,g…g,h…h,i…I,j…j,k…k", new ISCPCommandValueDocumentation() {
									Name = @"a-a-b-b-c-c-d-d-e-e-f-f-g-g-h-h-i-i-j-j",, 
									Description = @"Information of Audio(Same Immediate Display ',' is separator of infomartions)
a...a: Audio Input Port
b…b: Input Signal Format
c…c: Sampling Frequency
d…d: Input Signal Channel
e…e: Listening Mode
f…f: Output Signal Channel
g…g: Output Sampling Frequency
h...h: PQLS (Off/2ch/Multich/Bitstream)
i...i: Auto Phase Control Current Delay (0ms - 16ms / ---)
j...j: Auto Phase Control Phase (Normal/Reverse)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Infomation of Audio",,
								}

						}
					},					{
 						"IFV", new ISCPCommandDocumentation() {
							Name = @"video-information",
,							Description = @"Video Information Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"a..a,b..b,c…c,d..d,e…e,f…f,g…g,h…h,i…i,", new ISCPCommandValueDocumentation() {
									Name = @"a-a-b-b-c-c-d-d-e-e-f-f-g-g-h-h-i-i",, 
									Description = @"information of Video(Same Immediate Display ',' is separator of informations)
a…a: Video Input Port
b…b: Input Resolution, Frame Rate
c…c: RGB/YCbCr
d…d: Color Depth 
e…e: Video Output Port
f…f: Output Resolution, Frame Rate
g…g: RGB/YCbCr
h…h: Color Depth
i...i: Picture Mode",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Information of Video",,
								}

						}
					},					{
 						"FLD", new ISCPCommandDocumentation() {
							Name = @"fl-display-information",
,							Description = @"FL Display Information Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"{xx}{xx}{xx}{xx}{xx}x", new ISCPCommandValueDocumentation() {
									Name = @"xx-xx-xx-xx-xx-x",, 
									Description = @"FL Display Information
Character Code for FL Display (UTF-8 encoded)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets FL Display Information",,
								}

						}
					},					{
 						"SLI", new ISCPCommandDocumentation() {
							Name = @"input-selector",
,							Description = @"Input Selector Command",
,							Aliases =  new string[] { "source" })
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video1","vcr","dvr","stb","dvr" }), 
									Description = @"sets VIDEO1, VCR/DVR, STB/DVR",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video2","cbl","sat" }), 
									Description = @"sets VIDEO2, CBL/SAT",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video3","game/tv","game","game1" }), 
									Description = @"sets VIDEO3, GAME/TV, GAME, GAME1",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video4","aux1" }), 
									Description = @"sets VIDEO4, AUX1(AUX)",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video5","aux2","game2" }), 
									Description = @"sets VIDEO5, AUX2, GAME2",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video6","pc" }), 
									Description = @"sets VIDEO6, PC",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"video7",, 
									Description = @"sets VIDEO7",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name = @"07",, 
									Description = @"Hidden1     EXTRA1",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name = @"08",, 
									Description = @"Hidden2     EXTRA2",,
								}
								"09", new ISCPCommandValueDocumentation() {
									Name = @"09",, 
									Description = @"Hidden3     EXTRA3",,
								}
								"10", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "dvd","bd","dvd" }), 
									Description = @"sets DVD, BD/DVD",,
								}
								"11", new ISCPCommandValueDocumentation() {
									Name = @"strm-box",, 
									Description = @"sets STRM BOX",,
								}
								"12", new ISCPCommandValueDocumentation() {
									Name = @"tv",, 
									Description = @"sets TV",,
								}
								"20", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "tape-1","tv/tape" }), 
									Description = @"sets TAPE(1), TV/TAPE",,
								}
								"21", new ISCPCommandValueDocumentation() {
									Name = @"tape2",, 
									Description = @"sets TAPE2",,
								}
								"22", new ISCPCommandValueDocumentation() {
									Name = @"phono",, 
									Description = @"sets PHONO",,
								}
								"23", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "cd","tv/cd" }), 
									Description = @"sets CD, TV/CD",,
								}
								"24", new ISCPCommandValueDocumentation() {
									Name = @"fm",, 
									Description = @"sets FM",,
								}
								"25", new ISCPCommandValueDocumentation() {
									Name = @"am",, 
									Description = @"sets AM",,
								}
								"26", new ISCPCommandValueDocumentation() {
									Name = @"tuner",, 
									Description = @"sets TUNER",,
								}
								"27", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "music-server","p4s","dlna" }), 
									Description = @"sets MUSIC SERVER, P4S, DLNA",,
								}
								"28", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "internet-radio","iradio-favorite" }), 
									Description = @"sets INTERNET RADIO, iRadio Favorite",,
								}
								"29", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "usb","usb" }), 
									Description = @"sets USB/USB(Front)",,
								}
								"2A", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(Rear)",,
								}
								"2B", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "network","net" }), 
									Description = @"sets NETWORK, NET",,
								}
								"2C", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(toggle)",,
								}
								"2D", new ISCPCommandValueDocumentation() {
									Name = @"aiplay",, 
									Description = @"sets Aiplay",,
								}
								"2E", new ISCPCommandValueDocumentation() {
									Name = @"bluetooth",, 
									Description = @"sets Bluetooth",,
								}
								"2F", new ISCPCommandValueDocumentation() {
									Name = @"usb-dac-in",, 
									Description = @"sets USB DAC In",,
								}
								"41", new ISCPCommandValueDocumentation() {
									Name = @"line",, 
									Description = @"sets LINE",,
								}
								"42", new ISCPCommandValueDocumentation() {
									Name = @"line2",, 
									Description = @"sets LINE2",,
								}
								"44", new ISCPCommandValueDocumentation() {
									Name = @"optical",, 
									Description = @"sets OPTICAL",,
								}
								"45", new ISCPCommandValueDocumentation() {
									Name = @"coaxial",, 
									Description = @"sets COAXIAL",,
								}
								"40", new ISCPCommandValueDocumentation() {
									Name = @"universal-port",, 
									Description = @"sets Universal PORT",,
								}
								"30", new ISCPCommandValueDocumentation() {
									Name = @"multi-ch",, 
									Description = @"sets MULTI CH",,
								}
								"31", new ISCPCommandValueDocumentation() {
									Name = @"xm",, 
									Description = @"sets XM",,
								}
								"32", new ISCPCommandValueDocumentation() {
									Name = @"sirius",, 
									Description = @"sets SIRIUS",,
								}
								"33", new ISCPCommandValueDocumentation() {
									Name = @"dab",, 
									Description = @"sets DAB ",,
								}
								"55", new ISCPCommandValueDocumentation() {
									Name = @"hdmi-5",, 
									Description = @"sets HDMI 5",,
								}
								"56", new ISCPCommandValueDocumentation() {
									Name = @"hdmi-6",, 
									Description = @"sets HDMI 6",,
								}
								"57", new ISCPCommandValueDocumentation() {
									Name = @"hdmi-7",, 
									Description = @"sets HDMI 7",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Selector Position Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Selector Position Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Selector Position",,
								}

						}
					},					{
 						"SLR", new ISCPCommandDocumentation() {
							Name = @"recout-selector",
,							Description = @"RECOUT Selector Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"video1",, 
									Description = @"sets VIDEO1",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"video2",, 
									Description = @"sets VIDEO2",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"video3",, 
									Description = @"sets VIDEO3",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"video4",, 
									Description = @"sets VIDEO4",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name = @"video5",, 
									Description = @"sets VIDEO5",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name = @"video6",, 
									Description = @"sets VIDEO6",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"video7",, 
									Description = @"sets VIDEO7",,
								}
								"10", new ISCPCommandValueDocumentation() {
									Name = @"dvd",, 
									Description = @"sets DVD",,
								}
								"20", new ISCPCommandValueDocumentation() {
									Name = @"tape",, 
									Description = @"sets TAPE(1)",,
								}
								"21", new ISCPCommandValueDocumentation() {
									Name = @"tape2",, 
									Description = @"sets TAPE2",,
								}
								"22", new ISCPCommandValueDocumentation() {
									Name = @"phono",, 
									Description = @"sets PHONO",,
								}
								"23", new ISCPCommandValueDocumentation() {
									Name = @"cd",, 
									Description = @"sets CD",,
								}
								"24", new ISCPCommandValueDocumentation() {
									Name = @"fm",, 
									Description = @"sets FM",,
								}
								"25", new ISCPCommandValueDocumentation() {
									Name = @"am",, 
									Description = @"sets AM",,
								}
								"26", new ISCPCommandValueDocumentation() {
									Name = @"tuner",, 
									Description = @"sets TUNER",,
								}
								"27", new ISCPCommandValueDocumentation() {
									Name = @"music-server",, 
									Description = @"sets MUSIC SERVER",,
								}
								"28", new ISCPCommandValueDocumentation() {
									Name = @"internet-radio",, 
									Description = @"sets INTERNET RADIO",,
								}
								"30", new ISCPCommandValueDocumentation() {
									Name = @"multi-ch",, 
									Description = @"sets MULTI CH",,
								}
								"31", new ISCPCommandValueDocumentation() {
									Name = @"xm",, 
									Description = @"sets XM",,
								}
								"7F", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets OFF",,
								}
								"80", new ISCPCommandValueDocumentation() {
									Name = @"source",, 
									Description = @"sets SOURCE",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Selector Position",,
								}

						}
					},					{
 						"SLA", new ISCPCommandDocumentation() {
							Name = @"audio-selector",
,							Description = @"Audio Selector Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets AUTO",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"multi-channel",, 
									Description = @"sets MULTI-CHANNEL",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"analog",, 
									Description = @"sets ANALOG",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"ilink",, 
									Description = @"sets iLINK",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name = @"hdmi",, 
									Description = @"sets HDMI",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "coax","opt" }), 
									Description = @"sets COAX/OPT",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"balance",, 
									Description = @"sets BALANCE",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name = @"arc",, 
									Description = @"sets ARC",,
								}
								"0F", new ISCPCommandValueDocumentation() {
									Name = @"none",, 
									Description = @"sets None",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Audio Selector Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Audio Selector Status",,
								}

						}
					},					{
 						"TGA", new ISCPCommandDocumentation() {
							Name = @"12v-trigger-a",
,							Description = @"12V Trigger A Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets 12V Trigger A Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets 12V Trigger A On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets 12V Trigger A Status",,
								}

						}
					},					{
 						"TGB", new ISCPCommandDocumentation() {
							Name = @"12v-trigger-b",
,							Description = @"12V Trigger B Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets 12V Trigger B Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets 12V Trigger B On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets 12V Trigger B Status",,
								}

						}
					},					{
 						"TGC", new ISCPCommandDocumentation() {
							Name = @"12v-trigger-c",
,							Description = @"12V Trigger C Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets 12V Trigger C Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets 12V Trigger C On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets 12V Trigger C Status",,
								}

						}
					},					{
 						"VOS", new ISCPCommandDocumentation() {
							Name = @"video-output-selector",
,							Description = @"Video Output Selector (Japanese Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"d4",, 
									Description = @"sets D4",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"component",, 
									Description = @"sets Component",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Selector Position",,
								}

						}
					},					{
 						"HDO", new ISCPCommandDocumentation() {
							Name = @"hdmi-output-selector",
,							Description = @"HDMI Output Selector",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "no","analog" }), 
									Description = @"sets No, Analog",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "yes","out" }), 
									Description = @"sets Yes/Out Main, HDMI Main, HDMI",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "out-sub","sub","hdbaset" }), 
									Description = @"sets Out Sub, HDMI Sub, HDBaseT",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "both","sub" }), 
									Description = @"sets, Both, Main+Sub",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "both" }), 
									Description = @"sets, Both(Main)",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "both" }), 
									Description = @"sets, Both(Sub)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets HDMI Out Selector Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The HDMI Out Selector",,
								}

						}
					},					{
 						"HAO", new ISCPCommandDocumentation() {
							Name = @"hdmi-audio-out",
,							Description = @"HDMI Audio Out (Main)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets On",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets Auto",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets HDMI Audio Out Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HDMI Audio Out",,
								}

						}
					},					{
 						"HAS", new ISCPCommandDocumentation() {
							Name = @"hdmi-audio-out-sub",
,							Description = @"HDMI Audio Out (Sub)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets HDMI Audio Out Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HDMI Audio Out",,
								}

						}
					},					{
 						"CEC", new ISCPCommandDocumentation() {
							Name = @"hdmi-cec",
,							Description = @"HDMI CEC",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets HDMI CEC Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HDMI CEC",,
								}

						}
					},					{
 						"CCM", new ISCPCommandDocumentation() {
							Name = @"hdmi-cec-control-monitor",
,							Description = @"HDMI CEC Control Monitor",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"01", new ISCPCommandValueDocumentation() {
									Name = @"main",, 
									Description = @"sets Main",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"zone2",, 
									Description = @"sets Zone2",,
								}
								"10", new ISCPCommandValueDocumentation() {
									Name = @"sub",, 
									Description = @"sets Sub",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Control Monitor Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Control Monitor",,
								}

						}
					},					{
 						"RES", new ISCPCommandDocumentation() {
							Name = @"monitor-out-resolution",
,							Description = @"Monitor Out Resolution",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"through",, 
									Description = @"sets Through",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets Auto(HDMI Output Only)",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"480p",, 
									Description = @"sets 480p",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"720p",, 
									Description = @"sets 720p",,
								}
								"13", new ISCPCommandValueDocumentation() {
									Name = @"1680x720p",, 
									Description = @"sets 1680x720p",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name = @"1080i",, 
									Description = @"sets 1080i",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name = @"1080p",, 
									Description = @"sets 1080p(HDMI Output Only)",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "1080p","24fs" }), 
									Description = @"sets 1080p/24fs(HDMI Output Only)",,
								}
								"15", new ISCPCommandValueDocumentation() {
									Name = @"2560x1080p",, 
									Description = @"sets 2560x1080p",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name = @"4k-upcaling",, 
									Description = @"sets 4K Upcaling(HDMI Output Only) 4K(HDMI Output Only)",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"source",, 
									Description = @"sets Source",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Monitor Out Resolution Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Monitor Out Resolution",,
								}

						}
					},					{
 						"SPR", new ISCPCommandDocumentation() {
							Name = @"super-resolution",
,							Description = @"Super Resolution",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-0-3",, 
									Description = @"sets Super Resolution",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Super Resolution Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Super Resolution Wrap-Around DOWN",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Super Resolution State",,
								}

						}
					},					{
 						"HOI", new ISCPCommandDocumentation() {
							Name = @"hdmi-out-information",
,							Description = @"HDMI Out Information",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"ab", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "a-1-for-zone-b-sub-0-none","1-for-zone","2-for-zone-2" }), 
									Description = @"sets HDMI Information
a:HDMI Out MAIN 1:for Main Zone
b:HDMI Out SUB 0:None,1:for Main Zone,2:for Zone 2",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The HDMI Out Information State",,
								}

						}
					},					{
 						"ISF", new ISCPCommandDocumentation() {
							Name = @"isf-mode",
,							Description = @"ISF Mode",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"custom",, 
									Description = @"sets ISF Mode Custom",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"day",, 
									Description = @"sets ISF Mode Day",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"night",, 
									Description = @"sets ISF Mode Night",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets ISF Mode State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The ISF Mode State",,
								}

						}
					},					{
 						"VWM", new ISCPCommandDocumentation() {
							Name = @"video-wide-mode",
,							Description = @"Video Wide Mode",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets Auto",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"4-3",, 
									Description = @"sets 4:3",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"full",, 
									Description = @"sets Full",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"zoom",, 
									Description = @"sets Zoom",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name = @"zoom",, 
									Description = @"sets Wide Zoom",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name = @"smart-zoom",, 
									Description = @"sets Smart Zoom",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Video Zoom Mode Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Video Zoom Mode",,
								}

						}
					},					{
 						"VPM", new ISCPCommandDocumentation() {
							Name = @"video-picture-mode",
,							Description = @"Video Picture Mode",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "through","standard" }), 
									Description = @"sets Through, Standard",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"custom",, 
									Description = @"sets Custom",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"cinema",, 
									Description = @"sets Cinema",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"game",, 
									Description = @"sets Game",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name = @"isf-day",, 
									Description = @"sets ISF Day",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"isf-night",, 
									Description = @"sets ISF Night",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name = @"streaming",, 
									Description = @"sets Streaming",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "direct","bypass" }), 
									Description = @"sets Direct, Bypass",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Video Zoom Mode Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Video Zoom Mode",,
								}

						}
					},					{
 						"LMD", new ISCPCommandDocumentation() {
							Name = @"listening-mode",
,							Description = @"Listening Mode Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"stereo",, 
									Description = @"sets STEREO",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"direct",, 
									Description = @"sets DIRECT",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"surround",, 
									Description = @"sets SURROUND",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "film","game-rpg" }), 
									Description = @"sets FILM, Game-RPG",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name = @"thx",, 
									Description = @"sets THX",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "action","game-action" }), 
									Description = @"sets ACTION, Game-Action",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "musical","game-rock" }), 
									Description = @"sets MUSICAL, Game-Rock",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name = @"mono-movie",, 
									Description = @"sets MONO MOVIE",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name = @"orchestra",, 
									Description = @"sets ORCHESTRA",,
								}
								"09", new ISCPCommandValueDocumentation() {
									Name = @"unplugged",, 
									Description = @"sets UNPLUGGED",,
								}
								"0A", new ISCPCommandValueDocumentation() {
									Name = @"studio-mix",, 
									Description = @"sets STUDIO-MIX",,
								}
								"0B", new ISCPCommandValueDocumentation() {
									Name = @"tv-logic",, 
									Description = @"sets TV LOGIC",,
								}
								"0C", new ISCPCommandValueDocumentation() {
									Name = @"all-ch-stereo",, 
									Description = @"sets ALL CH STEREO",,
								}
								"0D", new ISCPCommandValueDocumentation() {
									Name = @"theater-dimensional",, 
									Description = @"sets THEATER-DIMENSIONAL",,
								}
								"0E", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "enhanced-7","enhance","game-sports" }), 
									Description = @"sets ENHANCED 7/ENHANCE, Game-Sports",,
								}
								"0F", new ISCPCommandValueDocumentation() {
									Name = @"mono",, 
									Description = @"sets MONO",,
								}
								"11", new ISCPCommandValueDocumentation() {
									Name = @"pure-audio",, 
									Description = @"sets PURE AUDIO",,
								}
								"12", new ISCPCommandValueDocumentation() {
									Name = @"multiplex",, 
									Description = @"sets MULTIPLEX",,
								}
								"13", new ISCPCommandValueDocumentation() {
									Name = @"full-mono",, 
									Description = @"sets FULL MONO",,
								}
								"14", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "dolby-virtual","surround-enhancer" }), 
									Description = @"sets DOLBY VIRTUAL / Surround Enhancer",,
								}
								"15", new ISCPCommandValueDocumentation() {
									Name = @"dts-surround-sensation",, 
									Description = @"sets DTS Surround Sensation",,
								}
								"16", new ISCPCommandValueDocumentation() {
									Name = @"audyssey-dsx",, 
									Description = @"sets Audyssey DSX",,
								}
								"1F", new ISCPCommandValueDocumentation() {
									Name = @"whole-house",, 
									Description = @"sets Whole House Mode",,
								}
								"23", new ISCPCommandValueDocumentation() {
									Name = @"stage",, 
									Description = @"sets Stage (when Genre Control is Enable in Japan Model)",,
								}
								"25", new ISCPCommandValueDocumentation() {
									Name = @"action",, 
									Description = @"sets Action (when Genre Control is Enable in Japan Model)",,
								}
								"26", new ISCPCommandValueDocumentation() {
									Name = @"music",, 
									Description = @"sets Music (when Genre Contorl is Enable in Japan Model)",,
								}
								"2E", new ISCPCommandValueDocumentation() {
									Name = @"sports",, 
									Description = @"sets Sports (when Genre Control is Enable in Japan Model)",,
								}
								"40", new ISCPCommandValueDocumentation() {
									Name = @"straight-decode",, 
									Description = @"sets Straight Decode",,
								}
								"41", new ISCPCommandValueDocumentation() {
									Name = @"dolby-ex",, 
									Description = @"sets Dolby EX",,
								}
								"42", new ISCPCommandValueDocumentation() {
									Name = @"thx-cinema",, 
									Description = @"sets THX Cinema",,
								}
								"43", new ISCPCommandValueDocumentation() {
									Name = @"thx-surround-ex",, 
									Description = @"sets THX Surround EX",,
								}
								"44", new ISCPCommandValueDocumentation() {
									Name = @"thx-music",, 
									Description = @"sets THX Music",,
								}
								"45", new ISCPCommandValueDocumentation() {
									Name = @"thx-games",, 
									Description = @"sets THX Games",,
								}
								"50", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "thx-u2","s2","i","s-cinema","cinema2" }), 
									Description = @"sets THX U2/S2/I/S Cinema/Cinema2",,
								}
								"51", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "thx-musicmode","thx-u2","s2","i","s-music" }), 
									Description = @"sets THX MusicMode,THX U2/S2/I/S Music",,
								}
								"52", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "thx-games","thx-u2","s2","i","s-games" }), 
									Description = @"sets THX Games Mode,THX U2/S2/I/S Games",,
								}
								"80", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "plii","pliix-movie","dolby-atmos","dolby-surround" }), 
									Description = @"sets PLII/PLIIx Movie, Dolby Atmos/Dolby Surround",,
								}
								"81", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "plii","pliix-music" }), 
									Description = @"sets PLII/PLIIx Music",,
								}
								"82", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "neo-6-cinema","neo-x-cinema","dts-x","neural-x" }), 
									Description = @"sets Neo:6 Cinema/Neo:X Cinema, DTS:X/Neural:X",,
								}
								"83", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "neo-6-music","neo-x-music" }), 
									Description = @"sets Neo:6 Music/Neo:X Music",,
								}
								"84", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "plii","pliix-thx-cinema","dolby-surround-thx-cinema" }), 
									Description = @"sets PLII/PLIIx THX Cinema, Dolby Surround THX Cinema",,
								}
								"85", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "neo-6","neo-x-thx-cinema","dts-neural-x-thx-cinema" }), 
									Description = @"sets Neo:6/Neo:X THX Cinema, DTS Neural:X THX Cinema",,
								}
								"86", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "plii","pliix-game" }), 
									Description = @"sets PLII/PLIIx Game",,
								}
								"87", new ISCPCommandValueDocumentation() {
									Name = @"neural-surr",, 
									Description = @"sets Neural Surr",,
								}
								"88", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "neural-thx","neural-surround" }), 
									Description = @"sets Neural THX/Neural Surround",,
								}
								"89", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "plii","pliix-thx-games","dolby-surround-thx-games" }), 
									Description = @"sets PLII/PLIIx THX Games, Dolby Surround THX Games",,
								}
								"8A", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "neo-6","neo-x-thx-games","dts-neural-x-thx-games" }), 
									Description = @"sets Neo:6/Neo:X THX Games, DTS Neural:X THX Games",,
								}
								"8B", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "plii","pliix-thx-music","dolby-surround-thx-music" }), 
									Description = @"sets PLII/PLIIx THX Music, Dolby Surround THX Music",,
								}
								"8C", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "neo-6","neo-x-thx-music","dts-neural-x-thx-music" }), 
									Description = @"sets Neo:6/Neo:X THX Music, DTS Neural:X THX Music",,
								}
								"8D", new ISCPCommandValueDocumentation() {
									Name = @"neural-thx-cinema",, 
									Description = @"sets Neural THX Cinema",,
								}
								"8E", new ISCPCommandValueDocumentation() {
									Name = @"neural-thx-music",, 
									Description = @"sets Neural THX Music",,
								}
								"8F", new ISCPCommandValueDocumentation() {
									Name = @"neural-thx-games",, 
									Description = @"sets Neural THX Games",,
								}
								"90", new ISCPCommandValueDocumentation() {
									Name = @"pliiz-height",, 
									Description = @"sets PLIIz Height",,
								}
								"91", new ISCPCommandValueDocumentation() {
									Name = @"neo-6-cinema-dts-surround-sensation",, 
									Description = @"sets Neo:6 Cinema DTS Surround Sensation",,
								}
								"92", new ISCPCommandValueDocumentation() {
									Name = @"neo-6-music-dts-surround-sensation",, 
									Description = @"sets Neo:6 Music DTS Surround Sensation",,
								}
								"93", new ISCPCommandValueDocumentation() {
									Name = @"neural-digital-music",, 
									Description = @"sets Neural Digital Music",,
								}
								"94", new ISCPCommandValueDocumentation() {
									Name = @"pliiz-height-thx-cinema",, 
									Description = @"sets PLIIz Height + THX Cinema",,
								}
								"95", new ISCPCommandValueDocumentation() {
									Name = @"pliiz-height-thx-music",, 
									Description = @"sets PLIIz Height + THX Music",,
								}
								"96", new ISCPCommandValueDocumentation() {
									Name = @"pliiz-height-thx-games",, 
									Description = @"sets PLIIz Height + THX Games",,
								}
								"97", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "pliiz-height-thx-u2","s2-cinema" }), 
									Description = @"sets PLIIz Height + THX U2/S2 Cinema",,
								}
								"98", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "pliiz-height-thx-u2","s2-music" }), 
									Description = @"sets PLIIz Height + THX U2/S2 Music",,
								}
								"99", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "pliiz-height-thx-u2","s2-games" }), 
									Description = @"sets PLIIz Height + THX U2/S2 Games",,
								}
								"9A", new ISCPCommandValueDocumentation() {
									Name = @"neo-x-game",, 
									Description = @"sets Neo:X Game",,
								}
								"A0", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "pliix","plii-movie-audyssey-dsx" }), 
									Description = @"sets PLIIx/PLII Movie + Audyssey DSX",,
								}
								"A1", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "pliix","plii-music-audyssey-dsx" }), 
									Description = @"sets PLIIx/PLII Music + Audyssey DSX",,
								}
								"A2", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "pliix","plii-game-audyssey-dsx" }), 
									Description = @"sets PLIIx/PLII Game + Audyssey DSX",,
								}
								"A3", new ISCPCommandValueDocumentation() {
									Name = @"neo-6-cinema-audyssey-dsx",, 
									Description = @"sets Neo:6 Cinema + Audyssey DSX",,
								}
								"A4", new ISCPCommandValueDocumentation() {
									Name = @"neo-6-music-audyssey-dsx",, 
									Description = @"sets Neo:6 Music + Audyssey DSX",,
								}
								"A5", new ISCPCommandValueDocumentation() {
									Name = @"neural-surround-audyssey-dsx",, 
									Description = @"sets Neural Surround + Audyssey DSX",,
								}
								"A6", new ISCPCommandValueDocumentation() {
									Name = @"neural-digital-music-audyssey-dsx",, 
									Description = @"sets Neural Digital Music + Audyssey DSX",,
								}
								"A7", new ISCPCommandValueDocumentation() {
									Name = @"dolby-ex-audyssey-dsx",, 
									Description = @"sets Dolby EX + Audyssey DSX",,
								}
								"FF", new ISCPCommandValueDocumentation() {
									Name = @"auto-surround",, 
									Description = @"sets Auto Surround",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Listening Mode Wrap-Around Down",,
								}
								"MOVIE", new ISCPCommandValueDocumentation() {
									Name = @"movie",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"MUSIC", new ISCPCommandValueDocumentation() {
									Name = @"music",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"GAME", new ISCPCommandValueDocumentation() {
									Name = @"game",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"THX", new ISCPCommandValueDocumentation() {
									Name = @"thx",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"AUTO", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"SURR", new ISCPCommandValueDocumentation() {
									Name = @"surr",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"STEREO", new ISCPCommandValueDocumentation() {
									Name = @"ster",, 
									Description = @"sets Listening Mode Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Listening Mode",,
								}

						}
					},					{
 						"DIR", new ISCPCommandDocumentation() {
							Name = @"direct",
,							Description = @"Direct Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Direct Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Direct Status",,
								}

						}
					},					{
 						"LTN", new ISCPCommandDocumentation() {
							Name = @"late-night",
,							Description = @"Late Night Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Late Night Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "low-dolbydigital","on-dolby-truehd" }), 
									Description = @"sets Late Night Low@DolbyDigital,On@Dolby TrueHD",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "high-dolbydigital" }), 
									Description = @"sets Late Night High@DolbyDigital,(On@Dolby TrueHD)",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"auto-dolby-truehd",, 
									Description = @"sets Late Night Auto@Dolby TrueHD",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Late Night State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Late Night Level",,
								}

						}
					},					{
 						"RAS", new ISCPCommandDocumentation() {
							Name = @"cinema-filter",
,							Description = @"Cinema Filter Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Cinema Filter Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Cinema Filter On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Cinema Filter State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Cinema Filter State",,
								}

						}
					},					{
 						"ADY", new ISCPCommandDocumentation() {
							Name = @"audyssey-2eq-multeq-multeq-xt",
,							Description = @"Audyssey 2EQ/MultEQ/MultEQ XT",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "off" }), 
									Description = @"sets Audyssey 2EQ/MultEQ/MultEQ XT Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "on","movie" }), 
									Description = @"sets Audyssey 2EQ/MultEQ/MultEQ XT On/Movie",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "music" }), 
									Description = @"sets Audyssey 2EQ/MultEQ/MultEQ XT Music",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Audyssey 2EQ/MultEQ/MultEQ XT State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Audyssey 2EQ/MultEQ/MultEQ XT State",,
								}

						}
					},					{
 						"ADQ", new ISCPCommandDocumentation() {
							Name = @"audyssey-dynamic-eq",
,							Description = @"Audyssey Dynamic EQ",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Audyssey Dynamic EQ Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Audyssey Dynamic EQ On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Audyssey Dynamic EQ State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Audyssey Dynamic EQ State",,
								}

						}
					},					{
 						"ADV", new ISCPCommandDocumentation() {
							Name = @"audyssey-dynamic-volume",
,							Description = @"Audyssey Dynamic Volume",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Audyssey Dynamic Volume Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"light",, 
									Description = @"sets Audyssey Dynamic Volume Light",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"medium",, 
									Description = @"sets Audyssey Dynamic Volume Medium",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"heavy",, 
									Description = @"sets Audyssey Dynamic Volume Heavy",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Audyssey Dynamic Volume State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Audyssey Dynamic Volume State",,
								}

						}
					},					{
 						"DVL", new ISCPCommandDocumentation() {
							Name = @"dolby-volume",
,							Description = @"Dolby Volume",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Dolby Volume Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "low","on" }), 
									Description = @"sets Dolby Volume Low/On",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"mid",, 
									Description = @"sets Dolby Volume Mid",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"high",, 
									Description = @"sets Dolby Volume High",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Dolby Volume State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Dolby Volume State",,
								}

						}
					},					{
 						"AEQ", new ISCPCommandDocumentation() {
							Name = @"accueq",
,							Description = @"AccuEQ",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets AccuEQ Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "on","on" }), 
									Description = @"sets AccuEQ On, On(All Ch)",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "on" }), 
									Description = @"sets AccuEQ, On(ex. Front L/R)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets AccuEQ State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The AccuEQ State",,
								}

						}
					},					{
 						"MCM", new ISCPCommandDocumentation() {
							Name = @"mcacc-eq",
,							Description = @"MCACC EQ",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"01", new ISCPCommandValueDocumentation() {
									Name = @"memory-1",, 
									Description = @"sets MCACC MEMORY 1",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"memory-2",, 
									Description = @"sets MCACC MEMORY 2",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"memory-3",, 
									Description = @"sets MCACC MEMORY 3",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name = @"memory-4",, 
									Description = @"sets MCACC MEMORY 4",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name = @"memory-5",, 
									Description = @"sets MCACC MEMORY 5",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"memory-6",, 
									Description = @"sets MCACC MEMORY 6",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets MCACC MEMORY Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets MCACC MEMORY Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The MCACC MEMORY",,
								}

						}
					},					{
 						"EQS", new ISCPCommandDocumentation() {
							Name = @"equalizer-select",
,							Description = @"Equalizer Select(O/I:Equalizer, P:Manual EQ Select)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Equalizer Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"preset-1",, 
									Description = @"sets Equalizer Preset 1",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"preset-2",, 
									Description = @"sets Equalizer Preset 2",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"preset-3",, 
									Description = @"sets Equalizer Preset 3",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Equalizer Preset Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Equalizer Preset Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Equalizer Preset",,
								}

						}
					},					{
 						"STW", new ISCPCommandDocumentation() {
							Name = @"eq-for-standing-wave-standing-wave",
,							Description = @"EQ for Standing Wave / Standing Wave",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Standing Wave Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Standing Wave On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Standing Wave Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Standing Wave",,
								}

						}
					},					{
 						"PCT", new ISCPCommandDocumentation() {
							Name = @"phase-control",
,							Description = @"Phase Control",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Phase Control Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Phase Control On",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"full-band-on",, 
									Description = @"sets Full Band Phase Control On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Phase Control Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Phase Control",,
								}

						}
					},					{
 						"PCP", new ISCPCommandDocumentation() {
							Name = @"phase-control-plus",
,							Description = @"Phase Control Plus",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"0msec-16msec",, 
									Description = @"sets Phase Control Plus 0msec - 16msec",,
								}
								"AT", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets Auto Phase Control Plus",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Phase Control Plus Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Phase Control Plus Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Phase Control Plus",,
								}

						}
					},					{
 						"LFE", new ISCPCommandDocumentation() {
							Name = @"lfe-level-lfe-mute-level",
,							Description = @"LFE Level / LFE Mute Level",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"xx", new ISCPCommandValueDocumentation() {
									Name = @"00-0db-01-1db-02-2db-03-3db-04-4db-05-5db-0a-10db-0f-15db-14-20db-ff-oodb",, 
									Description = @"sets LFE Mute Level
00:0dB
01:-1dB
02:-2dB
03:-3dB
04:-4dB
05:-5dB
0A:-10dB
0F:-15dB
14:-20dB
FF:-oodB",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets LFE Mute Level Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets LFE Mute Level Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The LFE Mute Level",,
								}

						}
					},					{
 						"ACE", new ISCPCommandDocumentation() {
							Name = @"all-channel-eq-for-temporary-value",
,							Description = @"All Channel EQ for Temporary Value",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"aaabbbcccdddeeefffggghhhiii", new ISCPCommandValueDocumentation() {
									Name = @"eq",, 
									Description = @"sets All Channel EQ for Temporary Value
xxx=-18(-12.0dB)~000(0.0dB)~+18(+12.0dB)

aaa:63Hz
bbb:125Hz
ccc:250Hz
ddd:500Hz
eee:1kHz
fff:2kHz
ggg:4kHz
hhh:8kHz
iii:16kHz",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Phase Control",,
								}

						}
					},					{
 						"MCC", new ISCPCommandDocumentation() {
							Name = @"mcacc-calibration",
,							Description = @"MCACC Calibration",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"00",, 
									Description = @"not complete MCACC calibration",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"01",, 
									Description = @"complete MCACC calibration",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The MCACC calibration",,
								}

						}
					},					{
 						"MFB", new ISCPCommandDocumentation() {
							Name = @"fullband-mcacc-calibration",
,							Description = @"Fullband MCACC Calibration",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"00",, 
									Description = @"not complete Fullband MCACC calibration or
not have Fullband MCACC function",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"01",, 
									Description = @"complete Fullband MCACC calibration",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Fullband MCACC calibration",,
								}

						}
					},					{
 						"MOT", new ISCPCommandDocumentation() {
							Name = @"music-optimizer-sound-retriever",
,							Description = @"Music Optimizer / Sound Retriever",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Music Optimizer Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Music Optimizer On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Music Optimizer State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Music Optimizer State",,
								}

						}
					},					{
 						"AVS", new ISCPCommandDocumentation() {
							Name = @"a-v-sync",
,							Description = @"A/V Sync",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"snnn", new ISCPCommandValueDocumentation() {
									Name = @"offset",, 
									Description = @"sets A/V Sync
 s: sign ( "+" or "-" or "0")
 If set minus value, s="-". (only HDMI Lipsync is available)
 If set plus value, s="+"
 If set zero value, s="0"
nnn : value; If set 100msec, nnn="100"",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "is-increased" }), 
									Description = @"sets A/V Sync is increased (step is depend on model)",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "is-decreased" }), 
									Description = @"sets A/V Sync is decreased (step is depend on model)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets A/V Sync Value",,
								}

						}
					},					{
 						"ASC", new ISCPCommandDocumentation() {
							Name = @"audio-scalar",
,							Description = @"Audio Scalar",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets Audio Scalar Auto",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"manual",, 
									Description = @"sets Audio Scalar Manual",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Audio Scalar Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Audio Scalar State",,
								}

						}
					},					{
 						"UPS", new ISCPCommandDocumentation() {
							Name = @"upsampling",
,							Description = @"Upsampling",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"x1",, 
									Description = @"sets Upsampling x1",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"x2",, 
									Description = @"sets Upsampling x2",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"x4",, 
									Description = @"sets Upsampling x4",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"x8",, 
									Description = @"sets Upsampling x8",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Upsampling Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Upscaling State",,
								}

						}
					},					{
 						"HBT", new ISCPCommandDocumentation() {
							Name = @"hi-bit",
,							Description = @"Hi-Bit",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Hi-Bit Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Hi-Bit On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Hi-Bit Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Hi-Bit State",,
								}

						}
					},					{
 						"DGF", new ISCPCommandDocumentation() {
							Name = @"digital-filter",
,							Description = @"Digital Filter",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"slow",, 
									Description = @"sets Digital Filter Slow",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"sharp",, 
									Description = @"sets Digital Filter Sharp",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"short",, 
									Description = @"sets Digital Filter Short",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Digital Filter Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Digital Filter State",,
								}

						}
					},					{
 						"LRA", new ISCPCommandDocumentation() {
							Name = @"lock-range-adjust",
,							Description = @"Lock Range Adjust",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-7",, 
									Description = @"sets Lock Range Adjust",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Lock Range Adjust Up",,
								}
								"Down", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Lock Range Adjust Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Lock Range Adjust State",,
								}

						}
					},					{
 						"PBS", new ISCPCommandDocumentation() {
							Name = @"p-bass",
,							Description = @"P.BASS",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets P.BASS Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets P.BASS On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets P.BASS Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The P.BASS State",,
								}

						}
					},					{
 						"SBS", new ISCPCommandDocumentation() {
							Name = @"s-bass",
,							Description = @"S.BASS",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets S.BASS Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets S.BASS On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets S.BASS Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The S.BASS State",,
								}

						}
					},					{
 						"SCD", new ISCPCommandDocumentation() {
							Name = @"screen-centered-dialog-dialog-enahncement",
,							Description = @"Screen Centered Dialog / Dialog Enahncement",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"enhancement-off",, 
									Description = @"sets Dialog Enhancement Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"enhancement-on",, 
									Description = @"sets Dialog Enhancement On",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"up1-up4",, 
									Description = @"sets Dialog Enahncement UP1-UP4",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Dialog Enhancement Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Dialog Enhancement State",,
								}

						}
					},					{
 						"CTS", new ISCPCommandDocumentation() {
							Name = @"center-spread-for-dolby-surround",
,							Description = @"Center Spread for Dolby Surround",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"center-off",, 
									Description = @"sets Center Spread Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"center-on",, 
									Description = @"sets Center Spread On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Center Spread Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Center Spread State",,
								}

						}
					},					{
 						"PNR", new ISCPCommandDocumentation() {
							Name = @"panorama-for-plii-music",
,							Description = @"Panorama for PLII Music",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Panorama Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Panorama On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Panorama Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Panorama State",,
								}

						}
					},					{
 						"DMS", new ISCPCommandDocumentation() {
							Name = @"dimension-for-plii-music",
,							Description = @"Dimension for PLII Music",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no--3-3",, 
									Description = @"sets Dimension",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Dimension Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Dimension Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Dimension State",,
								}

						}
					},					{
 						"CTW", new ISCPCommandDocumentation() {
							Name = @"center-width-for-plii-music",
,							Description = @"Center Width for PLII Music",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-0-7",, 
									Description = @"sets Center Width",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Center Width Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Center Width Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Center Width State",,
								}

						}
					},					{
 						"CTI", new ISCPCommandDocumentation() {
							Name = @"center-image-for-neo-6-music",
,							Description = @"Center Image for Neo:6 Music",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"sets Center Image",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Center Image Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Center Image Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Center Image State",,
								}

						}
					},					{
 						"DLC", new ISCPCommandDocumentation() {
							Name = @"dialog-control",
,							Description = @"Dialog Control",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-0-6",, 
									Description = @"sets Dialog Control",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Dialog Control Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Dialog Control Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Dialog Control State",,
								}

						}
					},					{
 						"DCE", new ISCPCommandDocumentation() {
							Name = @"dialog-control-enabled",
,							Description = @"Dialog Control Enabled",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"Dialog Control is disabled",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"Dialog Control is enabled",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Dialog Control Enabled State",,
								}

						}
					},					{
 						"SPI", new ISCPCommandDocumentation() {
							Name = @"speaker-information",
,							Description = @"Speaker Information",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"abcdefghhhijk", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "a-subwoofer-0-no","1-yes","1ch","2-2ch-b-front-1-small","2-large-c-center-0-none","1-small","2-lage-d-surround-0-none","1-small","2-lage-e-surround-back-0-none","1-small","2-lage-f-height-1-0-none","1-small","2-lage-g-height-2-0-none","1-small","2-lage-hhh-crossover-50","80","100","150","200-i-height-1-position-0-no","1-fh","2-tf","3-tm","4-tr","5-rh","6-dd-sp-f","7-dd-sp-s","8-dd-sp-b-j-height-2-position-0-no","1-fh","2-tf","3-tm","4-tr","5-rh","6-dd-sp-f","7-dd-sp-s","8-dd-sp-b-k-bi-amp-0-no","1-f","3-f-c","5-f-s","6-c-s","7-f-c-s" }), 
									Description = @"sets Speaker Information

a:Subwoofer 0:No,1:Yes/1ch,2:2ch
b:Front 1:Small,2:Large
c:Center 0:None,1:Small,2:Lage
d:Surround 0:None,1:Small,2:Lage
e:Surround Back 0:None,1:Small,2:Lage
f:Height 1 0:None,1:Small,2:Lage
g:Height 2 0:None,1:Small,2:Lage
hhh:Crossover 50,80,100,150,200
i:Height 1 Position 0:No,1:FH,2:TF,3:TM,4:TR,5:RH,6:DD SP(F),7:DD SP(S),8:DD SP(B)
j:Height 2 Position 0:No,1:FH,2:TF,3:TM,4:TR,5:RH,6:DD SP(F),7:DD SP(S),8:DD SP(B)
k:Bi-Amp 0:No,1:F,3:F+C,5:F+S,6:C+S,7:F+C+S",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Speaker Information",,
								}

						}
					},					{
 						"SPD", new ISCPCommandDocumentation() {
							Name = @"speaker-distance",
,							Description = @"Speaker Distance Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"Muaaabbbcccdddeeefffggghhhiiijjjkkklllmmm", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"sets Speaker Distance
xxx=001-384 (0.01m - 9.00m unit is meters)
xxx=001-12C (0.1ft - 30.0ft unit is feet)
xxx=001-2D0 (0'0-1/2" - 30'0" unit is feet/inch)
for not exist channel is always 000.

M:MCACC Memory 1-6
u:Unit 0:feet,1:meters,2:feet/inch
aaa:Front Left
bbb:Front Right
ccc:Center
ddd:Surround Left
eee:Surround Right
fff:Surround Back Left
ggg:Surround Back Right
hhh:Subwoofer 1
iii:Height 1 Left
jjj:Height 1 Right
kkk:Height 2 Left
lll:Height2 Right
mmm:Subwoofer 2",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Speaker Distance",,
								}

						}
					},					{
 						"DMN", new ISCPCommandDocumentation() {
							Name = @"input-channel-multiplex-dual-mono",
,							Description = @"Input Channel (Multiplex) / Dual Mono",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"main",, 
									Description = @"sets DUAL MONO MAIN",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"sub",, 
									Description = @"sets DUAL MONO SUB",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"main-sub",, 
									Description = @"sets DUAL MONO MAIN+SUB",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Panorama Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Panorama State",,
								}

						}
					},					{
 						"LDM", new ISCPCommandDocumentation() {
							Name = @"loudness-management",
,							Description = @"Loudness Management",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Loudness Management Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Loudness management On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Panorama Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Panorama State",,
								}

						}
					},					{
 						"ITV", new ISCPCommandDocumentation() {
							Name = @"intellivolume-input-volume-absorber",
,							Description = @"IntelliVolume / Input Volume Absorber",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"12-0db-0db-12-0db",, 
									Description = @"sets IntelliVolume -12.0dB~0dB~+12.0dB(0.5dB Step)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets IntelliVolume Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets IntelliVolume Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The IntelliVolume State",,
								}

						}
					},					{
 						"IRN", new ISCPCommandDocumentation() {
							Name = @"input-selector-rename-input-function-rename",
,							Description = @"Input Selector Rename / Input Function Rename",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"iixxxxxxxxxx", new ISCPCommandValueDocumentation() {
									Name = @"name-10-characters-ii-number-the-same-as-for-sli-command-xxxxxxxxxx-name",, 
									Description = @"sets Input Selector Name (10 characters)
ii: Selector Number (the same as for SLI command)
xxxxxxxxxx: Name(Max 10 characters)",,
								}

						}
					},					{
 						"FXP", new ISCPCommandDocumentation() {
							Name = @"pcm-fixed-mode-fixed-pcm-mode",
,							Description = @"PCM Fixed Mode / Fixed PCM Mode",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets PCM Fixed Mode Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets PCM Fixed Mode On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets PCM Fixed Mode Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The PCM Fixed Mode State",,
								}

						}
					},					{
 						"HST", new ISCPCommandDocumentation() {
							Name = @"hdmi-standby-through",
,							Description = @"HDMI Standby Through",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"xx", new ISCPCommandValueDocumentation() {
									Name = @"xx-sli-number",, 
									Description = @"sets HDMI Standby Through xx=SLI Number",,
								}
								"OFF", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets HDMI Standby Through Off",,
								}
								"LAST", new ISCPCommandValueDocumentation() {
									Name = @"last",, 
									Description = @"sets HDMI Standby Through Last",,
								}
								"AT", new ISCPCommandValueDocumentation() {
									Name = @"throguh-auto",, 
									Description = @"sets HDMI Standby Throguh Auto",,
								}
								"ATE", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets HDMI Standby Through Auto(Eco)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets HDMI Standby Through Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The HDMI Standby Through State",,
								}

						}
					},					{
 						"PQL", new ISCPCommandDocumentation() {
							Name = @"pqls",
,							Description = @"PQLS",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets PQLS Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets PQLS On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets PQLS Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The PQLS State",,
								}

						}
					},					{
 						"ARC", new ISCPCommandDocumentation() {
							Name = @"audio-return-channel",
,							Description = @"Audio Return Channel",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Audio Return Channel Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets Audio Return Channel Auto",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Audio Return Channel Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Audio Return Channel State",,
								}

						}
					},					{
 						"LPS", new ISCPCommandDocumentation() {
							Name = @"lip-sync-auto-delay",
,							Description = @"Lip Sync / Auto Delay",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Lip Sync Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Lip Sync On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Lip Sync Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Lip Sync State",,
								}

						}
					},					{
 						"APD", new ISCPCommandDocumentation() {
							Name = @"auto-power-down",
,							Description = @"Auto Power Down",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Auto Power Down Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Auto Power Down On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Auto Power Down Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Auto Power Down State",,
								}

						}
					},					{
 						"PAM", new ISCPCommandDocumentation() {
							Name = @"pre-amp-mode-amp-mode",
,							Description = @"Pre Amp Mode / AMP Mode",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Pre Amp Mode Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"front",, 
									Description = @"sets Pre Amp Mode Front",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"front-center",, 
									Description = @"sets Pre Amp Mode Front+Center",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name = @"all",, 
									Description = @"sets Pre Amp Mode All",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Auto Power Down Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Auto Power Down State",,
								}

						}
					},					{
 						"ECO", new ISCPCommandDocumentation() {
							Name = @"for-smart-grid",
,							Description = @"for Smart Grid Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"01", new ISCPCommandValueDocumentation() {
									Name = @"volume-1db-down-and-dimmer-level-dark",, 
									Description = @"sets Volume 1dB down and Dimmer Level "Dark"",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name = @"volume-3db-down-and-dimmer-level-dark",, 
									Description = @"sets Volume 3dB down and Dimmer Level "Dark"",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"volume-6db-down-and-dimmer-level-dark",, 
									Description = @"sets Volume 6dB down and Dimmer Level "Dark"",,
								}

						}
					},					{
 						"FWV", new ISCPCommandDocumentation() {
							Name = @"firmware-version",
,							Description = @"Firmware Version",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"abce-fhik-lmno-qrtu", new ISCPCommandValueDocumentation() {
									Name = @"version",, 
									Description = @"sets Firmware Version",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Firmware Version State",,
								}

						}
					},					{
 						"UPD", new ISCPCommandDocumentation() {
							Name = @"update",
,							Description = @"Update",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"NET", new ISCPCommandValueDocumentation() {
									Name = @"net",, 
									Description = @"start Device Update via Network",,
								}
								"USB", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"start Device Update via USB",,
								}
								"D**-nn", new ISCPCommandValueDocumentation() {
									Name = @"d-nn",, 
									Description = @"nn Progress (%)
**=DL Downloading
**=NT Arm writng
**=D1 DSP1
**=D2 DSP2
**=D3 DSP3
**=VM VMPU
**=OS OSD
**=MP MMPU",,
								}
								"CMP", new ISCPCommandValueDocumentation() {
									Name = @"cmp",, 
									Description = @"Device Update is completed",,
								}
								"E{xx}-yy", new ISCPCommandValueDocumentation() {
									Name = @"e-xx-yy",, 
									Description = @"xx=ErrorCode1
yy=ErrorCode2",,
								}
								"00", new ISCPCommandValueDocumentation() {
									Name = @"00",, 
									Description = @"not exist new firmware",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"01",, 
									Description = @"exist new firmware",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"force",, 
									Description = @"exist new firmware(force)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets exist new firmware",,
								}

						}
					},					{
 						"POP", new ISCPCommandDocumentation() {
							Name = @"popup-message",
,							Description = @"Popup Message",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"t----<.....>", new ISCPCommandValueDocumentation() {
									Name = @"t",, 
									Description = @"t -> message type 'X' : XML
---- -> reserved
<.....> : XML data ( [CR] and [LF] are removed )",,
								}
								"Ullt<.....>", new ISCPCommandValueDocumentation() {
									Name = @"ullt",, 
									Description = @"U : UI Type
 0 : List, 1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, 5 : Menu List
ll -> number of layer (00-FF)
t : Update Type
 0 : All, 1 : Button, 2 : Textbox, 3 : Listbox
<.....> : XML data ( [CR] and [LF] are removed )",,
								}

						}
					},					{
 						"TPD", new ISCPCommandDocumentation() {
							Name = @"temperature-data",
,							Description = @"Temperature Data",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"-99-999", new ISCPCommandValueDocumentation() {
									Name = @"temp",, 
									Description = @"The temperature Data(Fahrenheit and Celsius) 0 – 999
"F-99C-73": -99 degree Fahrenheit / -73 degree Celsius
"F 32C  0": 32 degree Fahrenheit / 0 degree Celsius
"F 41C  5": 41 degree Fahrenheit / 5 degree Celsius
"F 50C 10": 50 degree Fahrenheit / 10 degree Celsius
"F122C 50": 122 degree Fahrenheit / 50 degree Celsius
"F212C100": 212 degree Fahrenheit / 100 degree Celsius
"F302C150": 302 degree Fahrenheit / 150 degree Celsius

Reference Information:
[TX-NR474/NR575E/8270/NR575/NR676/NR676E/RZ620/NR777/RZ720/RZ820, DTM-7, DRX-2.1/3.1/4.1/5.1 VSX-832/932/LX102/LX302]
 Yellow Zone: "F150C 66" or more & "F210C 99" or less
 Red Zone:" F212C100" or more
[TX-RZ920, DRX-7.1/R1.1, DRC-R1.1]
 Yellow Zone: "F176C 80" or more & "F246C119" or less
 Red Zone: "F248C120" or more",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Temperature Data",,
								}

						}
					},					{
 						"TUN", new ISCPCommandDocumentation() {
							Name = @"tuning",
,							Description = @"Tuning Command (Include Tuner Pack Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnn", new ISCPCommandValueDocumentation() {
									Name = @"freq-nnnnn",, 
									Description = @"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)
put 0 in the first two digits of nnnnn at SR",,
								}
								"BAND", new ISCPCommandValueDocumentation() {
									Name = @"band",, 
									Description = @"Change BAND",,
								}
								"DIRECT", new ISCPCommandValueDocumentation() {
									Name = @"direct",, 
									Description = @"starts/restarts Direct Tuning Mode",,
								}
								"0", new ISCPCommandValueDocumentation() {
									Name = @"0-in-direct-mode",, 
									Description = @"sets 0 in Direct Tuning Mode",,
								}
								"1", new ISCPCommandValueDocumentation() {
									Name = @"1-in-direct-mode",, 
									Description = @"sets 1 in Direct Tuning Mode",,
								}
								"2", new ISCPCommandValueDocumentation() {
									Name = @"2-in-direct-mode",, 
									Description = @"sets 2 in Direct Tuning Mode",,
								}
								"3", new ISCPCommandValueDocumentation() {
									Name = @"3-in-direct-mode",, 
									Description = @"sets 3 in Direct Tuning Mode",,
								}
								"4", new ISCPCommandValueDocumentation() {
									Name = @"4-in-direct-mode",, 
									Description = @"sets 4 in Direct Tuning Mode",,
								}
								"5", new ISCPCommandValueDocumentation() {
									Name = @"5-in-direct-mode",, 
									Description = @"sets 5 in Direct Tuning Mode",,
								}
								"6", new ISCPCommandValueDocumentation() {
									Name = @"6-in-direct-mode",, 
									Description = @"sets 6 in Direct Tuning Mode",,
								}
								"7", new ISCPCommandValueDocumentation() {
									Name = @"7-in-direct-mode",, 
									Description = @"sets 7 in Direct Tuning Mode",,
								}
								"8", new ISCPCommandValueDocumentation() {
									Name = @"8-in-direct-mode",, 
									Description = @"sets 8 in Direct Tuning Mode",,
								}
								"9", new ISCPCommandValueDocumentation() {
									Name = @"9-in-direct-mode",, 
									Description = @"sets 9 in Direct Tuning Mode",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Tuning Frequency Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Tuning Frequency Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Tuning Frequency",,
								}

						}
					},					{
 						"PRS", new ISCPCommandDocumentation() {
							Name = @"preset",
,							Description = @"Preset Command (Include Tuner Pack Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Preset No. Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Preset No. Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Preset No.",,
								}

						}
					},					{
 						"PRM", new ISCPCommandDocumentation() {
							Name = @"preset-memory",
,							Description = @"Preset Memory Command (Include Tuner Pack Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}

						}
					},					{
 						"RDS", new ISCPCommandDocumentation() {
							Name = @"rds-information",
,							Description = @"RDS Information Command (RDS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"00",, 
									Description = @"Display RT Information",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"01",, 
									Description = @"Display PTY Information",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"02",, 
									Description = @"Display TP Information",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"Display RDS Information Wrap-Around Change",,
								}

						}
					},					{
 						"PTS", new ISCPCommandDocumentation() {
							Name = @"pty-scan",
,							Description = @"PTY Scan Command (RDS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-29",, 
									Description = @"sets PTY No “1 - 29” ( In hexadecimal representation)",,
								}
								"ENTER", new ISCPCommandValueDocumentation() {
									Name = @"enter",, 
									Description = @"Finish PTY Scan",,
								}

						}
					},					{
 						"TPS", new ISCPCommandDocumentation() {
							Name = @"tp-scan",
,							Description = @"TP Scan Command (RDS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"", new ISCPCommandValueDocumentation() {
									Name = @"start",, 
									Description = @"Start TP Scan (When Don’t Have Parameter)",,
								}
								"ENTER", new ISCPCommandValueDocumentation() {
									Name = @"finish",, 
									Description = @"Finish TP Scan",,
								}

						}
					},					{
 						"XCN", new ISCPCommandDocumentation() {
							Name = @"xm-channel-name-info",
,							Description = @"XM Channel Name Info (XM Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"channel-name",, 
									Description = @"XM Channel Name",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets XM Channel Name",,
								}

						}
					},					{
 						"XAT", new ISCPCommandDocumentation() {
							Name = @"xm-artist-name-info",
,							Description = @"XM Artist Name Info (XM Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"artist-name",, 
									Description = @"XM Artist Name",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets XM Artist Name",,
								}

						}
					},					{
 						"XTI", new ISCPCommandDocumentation() {
							Name = @"xm-title-info",
,							Description = @"XM Title Info (XM Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"title",, 
									Description = @"XM Title",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets XM Title",,
								}

						}
					},					{
 						"XCH", new ISCPCommandDocumentation() {
							Name = @"xm-channel-number",
,							Description = @"XM Channel Number Command (XM Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"channel-no-0-597",, 
									Description = @"XM Channel Number  “000 - 255”",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets XM Channel Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets XM Channel Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets XM Channel Number",,
								}

						}
					},					{
 						"XCT", new ISCPCommandDocumentation() {
							Name = @"xm-category",
,							Description = @"XM Category Command (XM Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"category-info",, 
									Description = @"XM Category Info",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets XM Category Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets XM Category Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets XM Category",,
								}

						}
					},					{
 						"SCN", new ISCPCommandDocumentation() {
							Name = @"sirius-channel-name-info",
,							Description = @"SIRIUS Channel Name Info (SIRIUS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"channel-name",, 
									Description = @"SIRIUS Channel Name",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets SIRIUS Channel Name",,
								}

						}
					},					{
 						"SAT", new ISCPCommandDocumentation() {
							Name = @"sirius-artist-name-info",
,							Description = @"SIRIUS Artist Name Info (SIRIUS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"artist-name",, 
									Description = @"SIRIUS Artist Name",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets SIRIUS Artist Name",,
								}

						}
					},					{
 						"STI", new ISCPCommandDocumentation() {
							Name = @"sirius-title-info",
,							Description = @"SIRIUS Title Info (SIRIUS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"title",, 
									Description = @"SIRIUS Title",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets SIRIUS Title",,
								}

						}
					},					{
 						"SCH", new ISCPCommandDocumentation() {
							Name = @"sirius-channel-number",
,							Description = @"SIRIUS Channel Number Command (SIRIUS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"channel-no-0-597",, 
									Description = @"SIRIUS Channel Number  “000 - 255”",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets SIRIUS Channel Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets SIRIUS Channel Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets SIRIUS Channel Number",,
								}

						}
					},					{
 						"SCT", new ISCPCommandDocumentation() {
							Name = @"sirius-category",
,							Description = @"SIRIUS Category Command (SIRIUS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"category-info",, 
									Description = @"SIRIUS Category Info",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets SIRIUS Category Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets SIRIUS Category Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets SIRIUS Category",,
								}

						}
					},					{
 						"SLK", new ISCPCommandDocumentation() {
							Name = @"sirius-parental-lock",
,							Description = @"SIRIUS Parental Lock Command (SIRIUS Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnn", new ISCPCommandValueDocumentation() {
									Name = @"password",, 
									Description = @"Lock Password (4Digits)",,
								}
								"INPUT", new ISCPCommandValueDocumentation() {
									Name = @"input",, 
									Description = @"displays "Please input the Lock password"",,
								}
								"WRONG", new ISCPCommandValueDocumentation() {
									Name = @"wrong",, 
									Description = @"displays "The Lock password is wrong"",,
								}

						}
					},					{
 						"HAT", new ISCPCommandDocumentation() {
							Name = @"hd-radio-artist-name-info",
,							Description = @"HD Radio Artist Name Info (HD Radio Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"artist-name",, 
									Description = @"HD Radio Artist Name (variable-length, 64 digits max)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HD Radio Artist Name",,
								}

						}
					},					{
 						"HCN", new ISCPCommandDocumentation() {
							Name = @"hd-radio-channel-name-info",
,							Description = @"HD Radio Channel Name Info (HD Radio Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"channel-name",, 
									Description = @"HD Radio Channel Name (Station Name) (7 digits)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HD Radio Channel Name",,
								}

						}
					},					{
 						"HTI", new ISCPCommandDocumentation() {
							Name = @"hd-radio-title-info",
,							Description = @"HD Radio Title Info (HD Radio Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"title",, 
									Description = @"HD Radio Title (variable-length, 64 digits max)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HD Radio Title",,
								}

						}
					},					{
 						"HDS", new ISCPCommandDocumentation() {
							Name = @"hd-radio-detail-info",
,							Description = @"HD Radio Detail Info (HD Radio Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"info",, 
									Description = @"HD Radio Title",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HD Radio Title",,
								}

						}
					},					{
 						"HPR", new ISCPCommandDocumentation() {
							Name = @"hd-radio-channel-program",
,							Description = @"HD Radio Channel Program Command (HD Radio Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"directly",, 
									Description = @"sets directly HD Radio Channel Program",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HD Radio Channel Program",,
								}

						}
					},					{
 						"HBL", new ISCPCommandDocumentation() {
							Name = @"hd-radio-blend-mode",
,							Description = @"HD Radio Blend Mode Command (HD Radio Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"auto",, 
									Description = @"sets HD Radio Blend Mode "Auto"",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"analog",, 
									Description = @"sets HD Radio Blend Mode "Analog"",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the HD Radio Blend Mode Status",,
								}

						}
					},					{
 						"HTS", new ISCPCommandDocumentation() {
							Name = @"hd-radio-tuner-status",
,							Description = @"HD Radio Tuner Status (HD Radio Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"mmnnoo", new ISCPCommandValueDocumentation() {
									Name = @"mmnnoo",, 
									Description = @"HD Radio Tuner Status (3 bytes)
mm -> "00" not HD, "01" HD
nn -> current Program "01"-"08"
oo -> receivable Program (8 bits are represented in hexadecimal notation. Each bit shows receivable or not.)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the HD Radio Tuner Status",,
								}

						}
					},					{
 						"BCS", new ISCPCommandDocumentation() {
							Name = @"battery-charge-status",
,							Description = @"Battery Charge Status Command (Battery Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"charging",, 
									Description = @"charging",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"completed",, 
									Description = @"charge completed",,
								}
								"10", new ISCPCommandValueDocumentation() {
									Name = @"low",, 
									Description = @"battery level Low",,
								}
								"11", new ISCPCommandValueDocumentation() {
									Name = @"middle",, 
									Description = @"battery level Middle",,
								}
								"12", new ISCPCommandValueDocumentation() {
									Name = @"high",, 
									Description = @"battery level High",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets battery charge status",,
								}

						}
					},					{
 						"CCD", new ISCPCommandDocumentation() {
							Name = @"cd-player",
,							Description = @"CD Player Operation Command  (Include CD Function Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAY", new ISCPCommandValueDocumentation() {
									Name = @"play",, 
									Description = @"PLAY",,
								}
								"STOP", new ISCPCommandValueDocumentation() {
									Name = @"stop",, 
									Description = @"STOP",,
								}
								"PAUSE", new ISCPCommandValueDocumentation() {
									Name = @"pause",, 
									Description = @"PAUSE",,
								}
								"SKIP.F", new ISCPCommandValueDocumentation() {
									Name = @"next",, 
									Description = @">>I",,
								}
								"SKIP.R", new ISCPCommandValueDocumentation() {
									Name = @"previous",, 
									Description = @"I<<",,
								}
								"REPEAT", new ISCPCommandValueDocumentation() {
									Name = @"repeat",, 
									Description = @"REPEAT",,
								}
								"RANDOM", new ISCPCommandValueDocumentation() {
									Name = @"random",, 
									Description = @"RANDOM",,
								}

						}
					},					{
 						"CST", new ISCPCommandDocumentation() {
							Name = @"cd-play-status",
,							Description = @"CD Play Status",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"prs", new ISCPCommandValueDocumentation() {
									Name = @"status",, 
									Description = @"CD Play Status (3 letters)
p -> Play Status: "S": STOP, "P": Play, "p": Pause, "F": FF, "R": FR
r -> Repeat Status: "-": Off, "R": All,  "1": Repeat 1
s -> Shuffle(Random) Status: "-": Off, "S": All",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets CD Play Status",,
								}

						}
					},					{
 						"DST", new ISCPCommandDocumentation() {
							Name = @"current-disc-status-notice",
,							Description = @"Current disc status notice",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"none",, 
									Description = @"No disc",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name = @"cd",, 
									Description = @"Audio CD",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name = @"mp3-cd",, 
									Description = @"MP3 CD",,
								}
								"FF", new ISCPCommandValueDocumentation() {
									Name = @"unknown",, 
									Description = @"Unknown",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Disc Status",,
								}

						}
					},					{
 						"CFS", new ISCPCommandDocumentation() {
							Name = @"current-folder-status-no",
,							Description = @"Current Folder Status（No.）",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"folder-no-1-153",, 
									Description = @"Folder Number",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Folder Number Info",,
								}

						}
					},					{
 						"CTM", new ISCPCommandDocumentation() {
							Name = @"cd-time-info",
,							Description = @"CD Time Info",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"mm:ss/mm:ss", new ISCPCommandValueDocumentation() {
									Name = @"time-mm-ss-mm-ss",, 
									Description = @"CD Time Info (Elapsed time/Track Time Max 99:59)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets CDTime Info",,
								}

						}
					},					{
 						"SCE", new ISCPCommandDocumentation() {
							Name = @"set-cd-elapsed-time",
,							Description = @"Set　CD Elapsed　Time",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"mm:ss", new ISCPCommandValueDocumentation() {
									Name = @"time-mm-ss",, 
									Description = @"Specified　Elapsed CD Time",,
								}

						}
					},					{
 						"DSN", new ISCPCommandDocumentation() {
							Name = @"dab-station-name",
,							Description = @"DAB Station Name",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"xx…xx", new ISCPCommandValueDocumentation() {
									Name = @"station-name",, 
									Description = @"xx…xx   : DAB Station Name (UTF-8)
下記文字は特殊コードで送信する
0x02  ： ←
0x03  ： ↑
0x04  ： →
0x05  ： ↓
0x06  ： ║
上記以外の0x00~0x1F、0x80~0xA0はスペース表示とする",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Station Name",,
								}

						}
					},					{
 						"CTV", new ISCPCommandDocumentation() {
							Name = @"ctv",
,							Description = @"Control TV over HDMI-CEC",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"POWER", new ISCPCommandValueDocumentation() {
									Name = @"power",, 
									Description = @"Toggle Power State",,
								}
								"PWRON", new ISCPCommandValueDocumentation() {
									Name = @"power-on",, 
									Description = @"Power On",,
								}
								"PWROFF", new ISCPCommandValueDocumentation() {
									Name = @"power-off",, 
									Description = @"Standby",,
								}
								"CHUP", new ISCPCommandValueDocumentation() {
									Name = @"chup",, 
									Description = @"CH Up",,
								}
								"CHDN", new ISCPCommandValueDocumentation() {
									Name = @"chdown",, 
									Description = @"CH Down",,
								}
								"VLUP", new ISCPCommandValueDocumentation() {
									Name = @"volume-up",, 
									Description = @"Volume Up",,
								}
								"VLDN", new ISCPCommandValueDocumentation() {
									Name = @"volume-down",, 
									Description = @"Volume Down",,
								}
								"MUTE", new ISCPCommandValueDocumentation() {
									Name = @"mute",, 
									Description = @"Muting",,
								}
								"DISP", new ISCPCommandValueDocumentation() {
									Name = @"display",, 
									Description = @"Display",,
								}
								"INPUT", new ISCPCommandValueDocumentation() {
									Name = @"input",, 
									Description = @"Input",,
								}
								"1", new ISCPCommandValueDocumentation() {
									Name = @"1",, 
									Description = @"1 command",,
								}
								"2", new ISCPCommandValueDocumentation() {
									Name = @"2",, 
									Description = @"2 command",,
								}
								"3", new ISCPCommandValueDocumentation() {
									Name = @"3",, 
									Description = @"3 command",,
								}
								"4", new ISCPCommandValueDocumentation() {
									Name = @"4",, 
									Description = @"4 command",,
								}
								"5", new ISCPCommandValueDocumentation() {
									Name = @"5",, 
									Description = @"5 command",,
								}
								"6", new ISCPCommandValueDocumentation() {
									Name = @"6",, 
									Description = @"6 command",,
								}
								"7", new ISCPCommandValueDocumentation() {
									Name = @"7",, 
									Description = @"7 command",,
								}
								"8", new ISCPCommandValueDocumentation() {
									Name = @"8",, 
									Description = @"8 command",,
								}
								"9", new ISCPCommandValueDocumentation() {
									Name = @"9",, 
									Description = @"9 command",,
								}
								"0", new ISCPCommandValueDocumentation() {
									Name = @"0",, 
									Description = @"0 command",,
								}
								"CLEAR", new ISCPCommandValueDocumentation() {
									Name = @"clear",, 
									Description = @"Clear",,
								}
								"SETUP", new ISCPCommandValueDocumentation() {
									Name = @"setup",, 
									Description = @"Setup",,
								}
								"GUIDE", new ISCPCommandValueDocumentation() {
									Name = @"guide",, 
									Description = @"Guide / Top Menu",,
								}
								"PREV", new ISCPCommandValueDocumentation() {
									Name = @"chprev",, 
									Description = @"Previous",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"cursor-up",, 
									Description = @"Cursor Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"cursor-down",, 
									Description = @"Cursor Down",,
								}
								"LEFT", new ISCPCommandValueDocumentation() {
									Name = @"cursor-left",, 
									Description = @"Cursor Left",,
								}
								"RIGHT", new ISCPCommandValueDocumentation() {
									Name = @"cursor-right",, 
									Description = @"Cursor Right",,
								}
								"ENTER", new ISCPCommandValueDocumentation() {
									Name = @"enter",, 
									Description = @"Enter",,
								}
								"RETURN", new ISCPCommandValueDocumentation() {
									Name = @"return",, 
									Description = @"Return",,
								}
								"A", new ISCPCommandValueDocumentation() {
									Name = @"a",, 
									Description = @"A for CEC US:R,EU:R,JP:B",,
								}
								"B", new ISCPCommandValueDocumentation() {
									Name = @"b",, 
									Description = @"B for CEC US:G,EU:G,JP:R",,
								}
								"C", new ISCPCommandValueDocumentation() {
									Name = @"c",, 
									Description = @"C for CEC US:B,EU:Y,JP:G",,
								}
								"D", new ISCPCommandValueDocumentation() {
									Name = @"d",, 
									Description = @"D for CEC US:Y,EU:B,JP:Y",,
								}

						}
					}
				}
			},			{
 				"zone2", new Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>() {					{
 						"ZPW", new ISCPCommandDocumentation() {
							Name = @"power",
,							Description = @"Zone2 Power Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"standby",, 
									Description = @"sets Zone2 Standby",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Zone2 On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Zone2 Power Status",,
								}

						}
					},					{
 						"ZPA", new ISCPCommandDocumentation() {
							Name = @"zone-2-a",
,							Description = @"Zone 2 A Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "off" }), 
									Description = @"sets Zone 2 A Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "on" }), 
									Description = @"sets Zone 2 A On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Speaker State",,
								}

						}
					},					{
 						"ZPB", new ISCPCommandDocumentation() {
							Name = @"zone-2-b",
,							Description = @"Zone 2 B Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "off" }), 
									Description = @"sets Zone 2 B Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "on" }), 
									Description = @"sets Zone 2 B On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Speaker State",,
								}

						}
					},					{
 						"ZMT", new ISCPCommandDocumentation() {
							Name = @"muting",
,							Description = @"Zone2 Muting Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Zone2 Muting Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Zone2 Muting On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Zone2 Muting Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Zone2 Muting Status",,
								}

						}
					},					{
 						"ZVL", new ISCPCommandDocumentation() {
							Name = @"volume",
,							Description = @"Zone2 Volume Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"Volume Level 0.0 – 100.0 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"vol-0-100",, 
									Description = @"Volume Level 0 – 100 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"Volume Level 0 – 80 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"level-up",, 
									Description = @"sets Volume Level Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"level-down",, 
									Description = @"sets Volume Level Down",,
								}
								"UP1", new ISCPCommandValueDocumentation() {
									Name = @"level-up-1db-step",, 
									Description = @"sets Volume Level Up 1dB Step",,
								}
								"DOWN1", new ISCPCommandValueDocumentation() {
									Name = @"level-down-1db-step",, 
									Description = @"sets Volume Level Down 1dB Step",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Volume Level",,
								}

						}
					},					{
 						"ZTN", new ISCPCommandDocumentation() {
							Name = @"tone",
,							Description = @"Zone2 Tone Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"bass-xx-is-a-00-a-10-0-10-1-step",, 
									Description = @"sets Zone2 Bass (xx is "-A"..."00"..."+A"[-10...0...+10 1 step]",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"treble-xx-is-a-00-a-10-0-10-1-step",, 
									Description = @"sets Zone2 Treble (xx is "-A"..."00"..."+A"[-10...0...+10 1 step]",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Bass Up (1 Step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Bass Down (1 Step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Treble Up (1 Step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Treble Down (1 Step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Zone2 Tone ("BxxTxx")",,
								}

						}
					},					{
 						"ZBL", new ISCPCommandDocumentation() {
							Name = @"balance",
,							Description = @"Zone2 Balance Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"{xx}", new ISCPCommandValueDocumentation() {
									Name = @"xx-is-a-00-a-l-10-0-r-10-1-step",, 
									Description = @"sets Zone2 Balance (xx is "-A"..."00"..."+A"[L+10...0...R+10 1 step]",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Balance Up (to R 1 Step)",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Balance Down (to L 1 Step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Zone2 Balance",,
								}

						}
					},					{
 						"SLZ", new ISCPCommandDocumentation() {
							Name = @"selector",
,							Description = @"ZONE2 Selector Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video1","vcr","dvr","stb","dvr" }), 
									Description = @"sets VIDEO1, VCR/DVR, STB/DVR",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video2","cbl","sat" }), 
									Description = @"sets VIDEO2, CBL/SAT",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video3","game/tv","game","game1" }), 
									Description = @"sets VIDEO3, GAME/TV, GAME, GAME1",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video4","aux1" }), 
									Description = @"sets VIDEO4, AUX1(AUX)",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video5","aux2","game2" }), 
									Description = @"sets VIDEO5, AUX2, GAME2",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video6","pc" }), 
									Description = @"sets VIDEO6, PC",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"video7",, 
									Description = @"sets VIDEO7",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden1","extra1" }), 
									Description = @"sets Hidden1, EXTRA1",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden2","extra2" }), 
									Description = @"sets Hidden2, EXTRA2",,
								}
								"09", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden3","extra3" }), 
									Description = @"sets Hidden3, EXTRA3",,
								}
								"10", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "dvd","bd","dvd" }), 
									Description = @"sets DVD, BD/DVD",,
								}
								"11", new ISCPCommandValueDocumentation() {
									Name = @"strm-box",, 
									Description = @"sets STRM BOX",,
								}
								"12", new ISCPCommandValueDocumentation() {
									Name = @"tv",, 
									Description = @"sets TV",,
								}
								"20", new ISCPCommandValueDocumentation() {
									Name = @"tape",, 
									Description = @"sets TAPE(1)",,
								}
								"21", new ISCPCommandValueDocumentation() {
									Name = @"tape2",, 
									Description = @"sets TAPE2",,
								}
								"22", new ISCPCommandValueDocumentation() {
									Name = @"phono",, 
									Description = @"sets PHONO",,
								}
								"23", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "cd","tv/cd" }), 
									Description = @"sets CD, TV/CD",,
								}
								"24", new ISCPCommandValueDocumentation() {
									Name = @"fm",, 
									Description = @"sets FM",,
								}
								"25", new ISCPCommandValueDocumentation() {
									Name = @"am",, 
									Description = @"sets AM",,
								}
								"26", new ISCPCommandValueDocumentation() {
									Name = @"tuner",, 
									Description = @"sets TUNER",,
								}
								"27", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "music-server","p4s","dlna" }), 
									Description = @"sets MUSIC SERVER, P4S, DLNA",,
								}
								"28", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "internet-radio","iradio-favorite" }), 
									Description = @"sets INTERNET RADIO, iRadio Favorite",,
								}
								"29", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "usb","usb" }), 
									Description = @"sets USB/USB(Front)",,
								}
								"2A", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(Rear)",,
								}
								"2B", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "network","net" }), 
									Description = @"sets NETWORK, NET",,
								}
								"2C", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(toggle)",,
								}
								"2D", new ISCPCommandValueDocumentation() {
									Name = @"airplay",, 
									Description = @"sets Airplay",,
								}
								"2E", new ISCPCommandValueDocumentation() {
									Name = @"bluetooth",, 
									Description = @"sets Bluetooth",,
								}
								"40", new ISCPCommandValueDocumentation() {
									Name = @"universal-port",, 
									Description = @"sets Universal PORT",,
								}
								"30", new ISCPCommandValueDocumentation() {
									Name = @"multi-ch",, 
									Description = @"sets MULTI CH",,
								}
								"31", new ISCPCommandValueDocumentation() {
									Name = @"xm",, 
									Description = @"sets XM",,
								}
								"32", new ISCPCommandValueDocumentation() {
									Name = @"sirius",, 
									Description = @"sets SIRIUS",,
								}
								"33", new ISCPCommandValueDocumentation() {
									Name = @"dab",, 
									Description = @"sets DAB ",,
								}
								"55", new ISCPCommandValueDocumentation() {
									Name = @"hdmi-5",, 
									Description = @"sets HDMI 5",,
								}
								"56", new ISCPCommandValueDocumentation() {
									Name = @"hdmi-6",, 
									Description = @"sets HDMI 6",,
								}
								"57", new ISCPCommandValueDocumentation() {
									Name = @"hdmi-7",, 
									Description = @"sets HDMI 7",,
								}
								"7F", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets OFF",,
								}
								"80", new ISCPCommandValueDocumentation() {
									Name = @"source",, 
									Description = @"sets SOURCE",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Selector Position Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Selector Position Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Selector Position",,
								}

						}
					},					{
 						"TUN", new ISCPCommandDocumentation() {
							Name = @"tuning",
,							Description = @"Tuning Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnn", new ISCPCommandValueDocumentation() {
									Name = @"freq-nnnnn",, 
									Description = @"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / XM nnnnn ch)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Tuning Frequency Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Tuning Frequency Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Tuning Frequency",,
								}

						}
					},					{
 						"TUZ", new ISCPCommandDocumentation() {
							Name = @"tuning",
,							Description = @"Tuning Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnn", new ISCPCommandValueDocumentation() {
									Name = @"freq-nnnnn",, 
									Description = @"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)",,
								}
								"DIRECT", new ISCPCommandValueDocumentation() {
									Name = @"direct",, 
									Description = @"starts/restarts Direct Tuning Mode",,
								}
								"BAND", new ISCPCommandValueDocumentation() {
									Name = @"band",, 
									Description = @"Change BAND",,
								}
								"0", new ISCPCommandValueDocumentation() {
									Name = @"0-in-direct-mode",, 
									Description = @"sets 0 in Direct Tuning Mode",,
								}
								"1", new ISCPCommandValueDocumentation() {
									Name = @"1-in-direct-mode",, 
									Description = @"sets 1 in Direct Tuning Mode",,
								}
								"2", new ISCPCommandValueDocumentation() {
									Name = @"2-in-direct-mode",, 
									Description = @"sets 2 in Direct Tuning Mode",,
								}
								"3", new ISCPCommandValueDocumentation() {
									Name = @"3-in-direct-mode",, 
									Description = @"sets 3 in Direct Tuning Mode",,
								}
								"4", new ISCPCommandValueDocumentation() {
									Name = @"4-in-direct-mode",, 
									Description = @"sets 4 in Direct Tuning Mode",,
								}
								"5", new ISCPCommandValueDocumentation() {
									Name = @"5-in-direct-mode",, 
									Description = @"sets 5 in Direct Tuning Mode",,
								}
								"6", new ISCPCommandValueDocumentation() {
									Name = @"6-in-direct-mode",, 
									Description = @"sets 6 in Direct Tuning Mode",,
								}
								"7", new ISCPCommandValueDocumentation() {
									Name = @"7-in-direct-mode",, 
									Description = @"sets 7 in Direct Tuning Mode",,
								}
								"8", new ISCPCommandValueDocumentation() {
									Name = @"8-in-direct-mode",, 
									Description = @"sets 8 in Direct Tuning Mode",,
								}
								"9", new ISCPCommandValueDocumentation() {
									Name = @"9-in-direct-mode",, 
									Description = @"sets 9 in Direct Tuning Mode",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Tuning Frequency Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Tuning Frequency Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Tuning Frequency",,
								}

						}
					},					{
 						"PRS", new ISCPCommandDocumentation() {
							Name = @"preset",
,							Description = @"Preset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Preset No. Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Preset No. Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Preset No.",,
								}

						}
					},					{
 						"PRZ", new ISCPCommandDocumentation() {
							Name = @"preset",
,							Description = @"Preset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Preset No. Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Preset No. Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Preset No.",,
								}

						}
					},					{
 						"NTC", new ISCPCommandDocumentation() {
							Name = @"net-tune-network",
,							Description = @"Net-Tune/Network Operation Command(Net-Tune Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAYz", new ISCPCommandValueDocumentation() {
									Name = @"playz",, 
									Description = @"PLAY KEY",,
								}
								"STOPz", new ISCPCommandValueDocumentation() {
									Name = @"stopz",, 
									Description = @"STOP KEY",,
								}
								"PAUSEz", new ISCPCommandValueDocumentation() {
									Name = @"pausez",, 
									Description = @"PAUSE KEY",,
								}
								"TRUPz", new ISCPCommandValueDocumentation() {
									Name = @"trupz",, 
									Description = @"TRACK UP KEY",,
								}
								"TRDNz", new ISCPCommandValueDocumentation() {
									Name = @"trdnz",, 
									Description = @"TRACK DOWN KEY",,
								}

						}
					},					{
 						"NTZ", new ISCPCommandDocumentation() {
							Name = @"net-tune-network",
,							Description = @"Net-Tune/Network Operation Command(Network Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAY", new ISCPCommandValueDocumentation() {
									Name = @"play",, 
									Description = @"PLAY KEY",,
								}
								"STOP", new ISCPCommandValueDocumentation() {
									Name = @"stop",, 
									Description = @"STOP KEY",,
								}
								"PAUSE", new ISCPCommandValueDocumentation() {
									Name = @"pause",, 
									Description = @"PAUSE KEY",,
								}
								"P/P", new ISCPCommandValueDocumentation() {
									Name = @"p-p",, 
									Description = @"PLAY / PAUSE KEY",,
								}
								"TRUP", new ISCPCommandValueDocumentation() {
									Name = @"trup",, 
									Description = @"TRACK UP KEY",,
								}
								"TRDN", new ISCPCommandValueDocumentation() {
									Name = @"trdn",, 
									Description = @"TRACK DOWN KEY",,
								}
								"CHUP", new ISCPCommandValueDocumentation() {
									Name = @"chup",, 
									Description = @"CH UP(for iRadio)",,
								}
								"CHDN", new ISCPCommandValueDocumentation() {
									Name = @"chdn",, 
									Description = @"CH DOWN(for iRadio)",,
								}
								"FF", new ISCPCommandValueDocumentation() {
									Name = @"ff",, 
									Description = @"FF KEY (CONTINUOUS*) (for iPod 1wire)",,
								}
								"REW", new ISCPCommandValueDocumentation() {
									Name = @"rew",, 
									Description = @"REW KEY (CONTINUOUS*) (for iPod 1wire)",,
								}
								"REPEAT", new ISCPCommandValueDocumentation() {
									Name = @"repeat",, 
									Description = @"REPEAT KEY(for iPod 1wire)",,
								}
								"RANDOM", new ISCPCommandValueDocumentation() {
									Name = @"random",, 
									Description = @"RANDOM KEY(for iPod 1wire)",,
								}
								"REP/SHF", new ISCPCommandValueDocumentation() {
									Name = @"rep-shf",, 
									Description = @"REPEAT / SHUFFLE KEY",,
								}
								"DISPLAY", new ISCPCommandValueDocumentation() {
									Name = @"display",, 
									Description = @"DISPLAY KEY(for iPod 1wire)",,
								}
								"MEMORY", new ISCPCommandValueDocumentation() {
									Name = @"memory",, 
									Description = @"MEMORY KEY",,
								}
								"MODE", new ISCPCommandValueDocumentation() {
									Name = @"mode",, 
									Description = @"MODE KEY",,
								}
								"RIGHT", new ISCPCommandValueDocumentation() {
									Name = @"right",, 
									Description = @"RIGHT KEY(for iPod 1wire)",,
								}
								"LEFT", new ISCPCommandValueDocumentation() {
									Name = @"left",, 
									Description = @"LEFT KEY(for iPod 1wire)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"UP KEY(for iPod 1wire)",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"DOWN KEY(for iPod 1wire)",,
								}
								"SELECT", new ISCPCommandValueDocumentation() {
									Name = @"select",, 
									Description = @"SELECT KEY(for iPod 1wire)",,
								}
								"RETURN", new ISCPCommandValueDocumentation() {
									Name = @"return",, 
									Description = @"RETURN KEY(for iPod 1wire)",,
								}

						}
					},					{
 						"NPZ", new ISCPCommandDocumentation() {
							Name = @"internet-radio-preset",
,							Description = @"Internet Radio Preset Command (Network Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}

						}
					},					{
 						"LMZ", new ISCPCommandDocumentation() {
							Name = @"listening-mode",
,							Description = @"Listening Mode Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"stereo",, 
									Description = @"sets STEREO",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"direct",, 
									Description = @"sets DIRECT",,
								}
								"0F", new ISCPCommandValueDocumentation() {
									Name = @"mono",, 
									Description = @"sets MONO",,
								}
								"12", new ISCPCommandValueDocumentation() {
									Name = @"multiplex",, 
									Description = @"sets MULTIPLEX",,
								}
								"87", new ISCPCommandValueDocumentation() {
									Name = @"dvs",, 
									Description = @"sets DVS(Pl2)",,
								}
								"88", new ISCPCommandValueDocumentation() {
									Name = @"dvs",, 
									Description = @"sets DVS(NEO6)",,
								}

						}
					},					{
 						"LTZ", new ISCPCommandDocumentation() {
							Name = @"late-night",
,							Description = @"Late Night Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Late Night Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"low",, 
									Description = @"sets Late Night Low",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"high",, 
									Description = @"sets Late Night High",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Late Night State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Late Night Level",,
								}

						}
					},					{
 						"RAZ", new ISCPCommandDocumentation() {
							Name = @"re-eq-academy-filter",
,							Description = @"Re-EQ/Academy Filter Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"both-off",, 
									Description = @"sets Both Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Re-EQ On",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Academy On",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Re-EQ/Academy State Wrap-Around Up",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Re-EQ/Academy State",,
								}

						}
					}
				}
			},			{
 				"zone3", new Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>() {					{
 						"PW3", new ISCPCommandDocumentation() {
							Name = @"power",
,							Description = @"Zone3 Power Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"standby",, 
									Description = @"sets Zone3 Standby",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Zone3 On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Zone3 Power Status",,
								}

						}
					},					{
 						"MT3", new ISCPCommandDocumentation() {
							Name = @"muting",
,							Description = @"Zone3 Muting Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Zone3 Muting Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Zone3 Muting On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Zone3 Muting Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Zone3 Muting Status",,
								}

						}
					},					{
 						"VL3", new ISCPCommandDocumentation() {
							Name = @"volume",
,							Description = @"Zone3 Volume Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"Volume Level 0.0 – 100.0 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"vol-0-100",, 
									Description = @"Volume Level 0 – 100 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"Volume Level 0 – 80 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"level-up",, 
									Description = @"sets Volume Level Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"level-down",, 
									Description = @"sets Volume Level Down",,
								}
								"UP1", new ISCPCommandValueDocumentation() {
									Name = @"level-up-1db-step",, 
									Description = @"sets Volume Level Up 1dB Step",,
								}
								"DOWN1", new ISCPCommandValueDocumentation() {
									Name = @"level-down-1db-step",, 
									Description = @"sets Volume Level Down 1dB Step",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Volume Level",,
								}

						}
					},					{
 						"TN3", new ISCPCommandDocumentation() {
							Name = @"tone",
,							Description = @"Zone3 Tone Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"B{xx}", new ISCPCommandValueDocumentation() {
									Name = @"b-xx",, 
									Description = @"Zone3 Bass (xx is "-A"..."00"..."+A"[-10...0...+10 1 step])",,
								}
								"T{xx}", new ISCPCommandValueDocumentation() {
									Name = @"t-xx",, 
									Description = @"Zone3 Treble (xx is "-A"..."00"..."+A"[-10...0...+10 1 step])",,
								}
								"BUP", new ISCPCommandValueDocumentation() {
									Name = @"bass-up",, 
									Description = @"sets Bass Up (1 Step)",,
								}
								"BDOWN", new ISCPCommandValueDocumentation() {
									Name = @"bass-down",, 
									Description = @"sets Bass Down (1 Step)",,
								}
								"TUP", new ISCPCommandValueDocumentation() {
									Name = @"treble-up",, 
									Description = @"sets Treble Up (1 Step)",,
								}
								"TDOWN", new ISCPCommandValueDocumentation() {
									Name = @"treble-down",, 
									Description = @"sets Treble Down (1 Step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Zone3 Tone ("BxxTxx")",,
								}

						}
					},					{
 						"BL3", new ISCPCommandDocumentation() {
							Name = @"balance",
,							Description = @"Zone3 Balance Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"{xx}", new ISCPCommandValueDocumentation() {
									Name = @"xx",, 
									Description = @"Zone3 Balance (xx is "-A"..."00"..."+A"[L+10...0...R+10 1 step])",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Balance Up (to R 1 Step)",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Balance Down (to L 1 Step)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Zone3 Balance",,
								}

						}
					},					{
 						"SL3", new ISCPCommandDocumentation() {
							Name = @"selector",
,							Description = @"ZONE3 Selector Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video1","vcr","dvr","stb","dvr" }), 
									Description = @"sets VIDEO1, VCR/DVR, STB/DVR",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video2","cbl","sat" }), 
									Description = @"sets VIDEO2, CBL/SAT",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video3","game/tv","game","game1" }), 
									Description = @"sets VIDEO3, GAME/TV, GAME, GAME1",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video4","aux1" }), 
									Description = @"sets VIDEO4, AUX1(AUX)",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video5","aux2","game2" }), 
									Description = @"sets VIDEO5, AUX2, GAME2",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video6","pc" }), 
									Description = @"sets VIDEO6, PC",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"video7",, 
									Description = @"sets VIDEO7",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden1","extra1" }), 
									Description = @"sets Hidden1, EXTRA1",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden2","extra2" }), 
									Description = @"sets Hidden2, EXTRA2",,
								}
								"09", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden3","extra3" }), 
									Description = @"sets Hidden3, EXTRA3",,
								}
								"10", new ISCPCommandValueDocumentation() {
									Name = @"dvd",, 
									Description = @"sets DVD",,
								}
								"11", new ISCPCommandValueDocumentation() {
									Name = @"strm-box",, 
									Description = @"sets STRM BOX",,
								}
								"12", new ISCPCommandValueDocumentation() {
									Name = @"tv",, 
									Description = @"sets TV",,
								}
								"20", new ISCPCommandValueDocumentation() {
									Name = @"tape",, 
									Description = @"sets TAPE(1)",,
								}
								"21", new ISCPCommandValueDocumentation() {
									Name = @"tape2",, 
									Description = @"sets TAPE2",,
								}
								"22", new ISCPCommandValueDocumentation() {
									Name = @"phono",, 
									Description = @"sets PHONO",,
								}
								"23", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "cd","tv/cd" }), 
									Description = @"sets CD, TV/CD",,
								}
								"24", new ISCPCommandValueDocumentation() {
									Name = @"fm",, 
									Description = @"sets FM",,
								}
								"25", new ISCPCommandValueDocumentation() {
									Name = @"am",, 
									Description = @"sets AM",,
								}
								"26", new ISCPCommandValueDocumentation() {
									Name = @"tuner",, 
									Description = @"sets TUNER",,
								}
								"27", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "music-server","p4s","dlna" }), 
									Description = @"sets MUSIC SERVER, P4S, DLNA",,
								}
								"28", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "internet-radio","iradio-favorite" }), 
									Description = @"sets INTERNET RADIO, iRadio Favorite",,
								}
								"29", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "usb","usb" }), 
									Description = @"sets USB/USB(Front)",,
								}
								"2A", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(Rear)",,
								}
								"2B", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "network","net" }), 
									Description = @"sets NETWORK, NET",,
								}
								"2C", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(toggle)",,
								}
								"2D", new ISCPCommandValueDocumentation() {
									Name = @"airplay",, 
									Description = @"sets Airplay",,
								}
								"2E", new ISCPCommandValueDocumentation() {
									Name = @"bluetooth",, 
									Description = @"sets Bluetooth",,
								}
								"40", new ISCPCommandValueDocumentation() {
									Name = @"universal-port",, 
									Description = @"sets Universal PORT",,
								}
								"30", new ISCPCommandValueDocumentation() {
									Name = @"multi-ch",, 
									Description = @"sets MULTI CH",,
								}
								"31", new ISCPCommandValueDocumentation() {
									Name = @"xm",, 
									Description = @"sets XM",,
								}
								"32", new ISCPCommandValueDocumentation() {
									Name = @"sirius",, 
									Description = @"sets SIRIUS",,
								}
								"33", new ISCPCommandValueDocumentation() {
									Name = @"dab",, 
									Description = @"sets DAB ",,
								}
								"80", new ISCPCommandValueDocumentation() {
									Name = @"source",, 
									Description = @"sets SOURCE",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Selector Position Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Selector Position Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Selector Position",,
								}

						}
					},					{
 						"TUN", new ISCPCommandDocumentation() {
							Name = @"tuning",
,							Description = @"Tuning Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnn", new ISCPCommandValueDocumentation() {
									Name = @"freq-nnnnn",, 
									Description = @"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Tuning Frequency Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Tuning Frequency Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Tuning Frequency",,
								}

						}
					},					{
 						"TU3", new ISCPCommandDocumentation() {
							Name = @"tuning",
,							Description = @"Tuning Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnn", new ISCPCommandValueDocumentation() {
									Name = @"freq-nnnnn",, 
									Description = @"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)",,
								}
								"BAND", new ISCPCommandValueDocumentation() {
									Name = @"band",, 
									Description = @"Change BAND",,
								}
								"DIRECT", new ISCPCommandValueDocumentation() {
									Name = @"direct",, 
									Description = @"starts/restarts Direct Tuning Mode",,
								}
								"0", new ISCPCommandValueDocumentation() {
									Name = @"0-in-direct-mode",, 
									Description = @"sets 0 in Direct Tuning Mode",,
								}
								"1", new ISCPCommandValueDocumentation() {
									Name = @"1-in-direct-mode",, 
									Description = @"sets 1 in Direct Tuning Mode",,
								}
								"2", new ISCPCommandValueDocumentation() {
									Name = @"2-in-direct-mode",, 
									Description = @"sets 2 in Direct Tuning Mode",,
								}
								"3", new ISCPCommandValueDocumentation() {
									Name = @"3-in-direct-mode",, 
									Description = @"sets 3 in Direct Tuning Mode",,
								}
								"4", new ISCPCommandValueDocumentation() {
									Name = @"4-in-direct-mode",, 
									Description = @"sets 4 in Direct Tuning Mode",,
								}
								"5", new ISCPCommandValueDocumentation() {
									Name = @"5-in-direct-mode",, 
									Description = @"sets 5 in Direct Tuning Mode",,
								}
								"6", new ISCPCommandValueDocumentation() {
									Name = @"6-in-direct-mode",, 
									Description = @"sets 6 in Direct Tuning Mode",,
								}
								"7", new ISCPCommandValueDocumentation() {
									Name = @"7-in-direct-mode",, 
									Description = @"sets 7 in Direct Tuning Mode",,
								}
								"8", new ISCPCommandValueDocumentation() {
									Name = @"8-in-direct-mode",, 
									Description = @"sets 8 in Direct Tuning Mode",,
								}
								"9", new ISCPCommandValueDocumentation() {
									Name = @"9-in-direct-mode",, 
									Description = @"sets 9 in Direct Tuning Mode",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Tuning Frequency Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Tuning Frequency Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Tuning Frequency",,
								}

						}
					},					{
 						"PRS", new ISCPCommandDocumentation() {
							Name = @"preset",
,							Description = @"Preset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Preset No. Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Preset No. Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Preset No.",,
								}

						}
					},					{
 						"PR3", new ISCPCommandDocumentation() {
							Name = @"preset",
,							Description = @"Preset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Preset No. Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Preset No. Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Preset No.",,
								}

						}
					},					{
 						"NTC", new ISCPCommandDocumentation() {
							Name = @"net-tune-network",
,							Description = @"Net-Tune/Network Operation Command(Net-Tune Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAYz", new ISCPCommandValueDocumentation() {
									Name = @"playz",, 
									Description = @"PLAY KEY",,
								}
								"STOPz", new ISCPCommandValueDocumentation() {
									Name = @"stopz",, 
									Description = @"STOP KEY",,
								}
								"PAUSEz", new ISCPCommandValueDocumentation() {
									Name = @"pausez",, 
									Description = @"PAUSE KEY",,
								}
								"TRUPz", new ISCPCommandValueDocumentation() {
									Name = @"trupz",, 
									Description = @"TRACK UP KEY",,
								}
								"TRDNz", new ISCPCommandValueDocumentation() {
									Name = @"trdnz",, 
									Description = @"TRACK DOWN KEY",,
								}

						}
					},					{
 						"NT3", new ISCPCommandDocumentation() {
							Name = @"net-tune-network",
,							Description = @"Net-Tune/Network Operation Command(Network Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAY", new ISCPCommandValueDocumentation() {
									Name = @"play",, 
									Description = @"PLAY KEY",,
								}
								"STOP", new ISCPCommandValueDocumentation() {
									Name = @"stop",, 
									Description = @"STOP KEY",,
								}
								"PAUSE", new ISCPCommandValueDocumentation() {
									Name = @"pause",, 
									Description = @"PAUSE KEY",,
								}
								"P/P", new ISCPCommandValueDocumentation() {
									Name = @"p-p",, 
									Description = @"PLAY / PAUSE KEY",,
								}
								"TRUP", new ISCPCommandValueDocumentation() {
									Name = @"trup",, 
									Description = @"TRACK UP KEY",,
								}
								"TRDN", new ISCPCommandValueDocumentation() {
									Name = @"trdn",, 
									Description = @"TRACK DOWN KEY",,
								}
								"CHUP", new ISCPCommandValueDocumentation() {
									Name = @"chup",, 
									Description = @"CH UP(for iRadio)",,
								}
								"CHDN", new ISCPCommandValueDocumentation() {
									Name = @"chdn",, 
									Description = @"CH DOWNP(for iRadio)",,
								}
								"FF", new ISCPCommandValueDocumentation() {
									Name = @"ff",, 
									Description = @"FF KEY (CONTINUOUS*) (for iPod 1wire)",,
								}
								"REW", new ISCPCommandValueDocumentation() {
									Name = @"rew",, 
									Description = @"REW KEY (CONTINUOUS*) (for iPod 1wire)",,
								}
								"REPEAT", new ISCPCommandValueDocumentation() {
									Name = @"repeat",, 
									Description = @"REPEAT KEY(for iPod 1wire)",,
								}
								"RANDOM", new ISCPCommandValueDocumentation() {
									Name = @"random",, 
									Description = @"RANDOM KEY(for iPod 1wire)",,
								}
								"REP/SHF", new ISCPCommandValueDocumentation() {
									Name = @"rep-shf",, 
									Description = @"REPEAT / SHUFFLE KEY",,
								}
								"DISPLAY", new ISCPCommandValueDocumentation() {
									Name = @"display",, 
									Description = @"DISPLAY KEY(for iPod 1wire)",,
								}
								"MEMORY", new ISCPCommandValueDocumentation() {
									Name = @"memory",, 
									Description = @"MEMORY KEY",,
								}
								"RIGHT", new ISCPCommandValueDocumentation() {
									Name = @"right",, 
									Description = @"RIGHT KEY(for iPod 1wire)",,
								}
								"LEFT", new ISCPCommandValueDocumentation() {
									Name = @"left",, 
									Description = @"LEFT KEY(for iPod 1wire)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"UP KEY(for iPod 1wire)",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"DOWN KEY(for iPod 1wire)",,
								}
								"SELECT", new ISCPCommandValueDocumentation() {
									Name = @"select",, 
									Description = @"SELECT KEY(for iPod 1wire)",,
								}
								"RETURN", new ISCPCommandValueDocumentation() {
									Name = @"return",, 
									Description = @"RETURN KEY(for iPod 1wire)",,
								}

						}
					},					{
 						"NP3", new ISCPCommandDocumentation() {
							Name = @"internet-radio-preset",
,							Description = @"Internet Radio Preset Command (Network Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}

						}
					}
				}
			},			{
 				"zone4", new Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>() {					{
 						"PW4", new ISCPCommandDocumentation() {
							Name = @"power",
,							Description = @"Zone4 Power Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"standby",, 
									Description = @"sets Zone4 Standby",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Zone4 On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Zone4 Power Status",,
								}

						}
					},					{
 						"MT4", new ISCPCommandDocumentation() {
							Name = @"muting",
,							Description = @"Zone4 Muting Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Zone4 Muting Off",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Zone4 Muting On",,
								}
								"TG", new ISCPCommandValueDocumentation() {
									Name = @"toggle",, 
									Description = @"sets Zone4 Muting Wrap-Around",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Zone4 Muting Status",,
								}

						}
					},					{
 						"VL4", new ISCPCommandDocumentation() {
							Name = @"volume",
,							Description = @"Zone4 Volume Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"vol-0-100",, 
									Description = @"Volume Level 0 – 100 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"Volume Level 0 – 80 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"level-up",, 
									Description = @"sets Volume Level Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"level-down",, 
									Description = @"sets Volume Level Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Volume Level",,
								}

						}
					},					{
 						"SL4", new ISCPCommandDocumentation() {
							Name = @"selector",
,							Description = @"ZONE4 Selector Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"00", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video1","vcr","dvr","stb","dvr" }), 
									Description = @"sets VIDEO1, VCR/DVR, STB/DVR",,
								}
								"01", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video2","cbl","sat" }), 
									Description = @"sets VIDEO2, CBL/SAT",,
								}
								"02", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video3","game/tv","game","game1" }), 
									Description = @"sets VIDEO3, GAME/TV, GAME, GAME1",,
								}
								"03", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video4","aux1" }), 
									Description = @"sets VIDEO4, AUX1(AUX)",,
								}
								"04", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video5","aux2","game2" }), 
									Description = @"sets VIDEO5, AUX2, GAME2",,
								}
								"05", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "video6","pc" }), 
									Description = @"sets VIDEO6, PC",,
								}
								"06", new ISCPCommandValueDocumentation() {
									Name = @"video7",, 
									Description = @"sets VIDEO7",,
								}
								"07", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden1","extra1" }), 
									Description = @"sets Hidden1, EXTRA1",,
								}
								"08", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden2","extra2" }), 
									Description = @"sets Hidden2, EXTRA2",,
								}
								"09", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "hidden3","extra3" }), 
									Description = @"sets Hidden3, EXTRA3",,
								}
								"10", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "dvd","bd","dvd" }), 
									Description = @"sets DVD, BD/DVD",,
								}
								"20", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "tape-1","tv/tape" }), 
									Description = @"sets TAPE(1), TV/TAPE",,
								}
								"21", new ISCPCommandValueDocumentation() {
									Name = @"tape2",, 
									Description = @"sets TAPE2",,
								}
								"22", new ISCPCommandValueDocumentation() {
									Name = @"phono",, 
									Description = @"sets PHONO",,
								}
								"23", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "cd","tv/cd" }), 
									Description = @"sets CD, TV/CD",,
								}
								"24", new ISCPCommandValueDocumentation() {
									Name = @"fm",, 
									Description = @"sets FM",,
								}
								"25", new ISCPCommandValueDocumentation() {
									Name = @"am",, 
									Description = @"sets AM",,
								}
								"26", new ISCPCommandValueDocumentation() {
									Name = @"tuner",, 
									Description = @"sets TUNER",,
								}
								"27", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "music-server","p4s","dlna" }), 
									Description = @"sets MUSIC SERVER, P4S, DLNA",,
								}
								"28", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "internet-radio","iradio-favorite" }), 
									Description = @"sets INTERNET RADIO, iRadio Favorite",,
								}
								"29", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "usb","usb" }), 
									Description = @"sets USB/USB(Front)",,
								}
								"2A", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(Rear)",,
								}
								"2B", new ISCPCommandValueDocumentation() {
									Name =  new string[] { "network","net" }), 
									Description = @"sets NETWORK, NET",,
								}
								"2C", new ISCPCommandValueDocumentation() {
									Name = @"usb",, 
									Description = @"sets USB(toggle)",,
								}
								"2D", new ISCPCommandValueDocumentation() {
									Name = @"airplay",, 
									Description = @"sets Airplay",,
								}
								"2E", new ISCPCommandValueDocumentation() {
									Name = @"bluetooth",, 
									Description = @"sets Bluetooth",,
								}
								"40", new ISCPCommandValueDocumentation() {
									Name = @"universal-port",, 
									Description = @"sets Universal PORT",,
								}
								"30", new ISCPCommandValueDocumentation() {
									Name = @"multi-ch",, 
									Description = @"sets MULTI CH",,
								}
								"31", new ISCPCommandValueDocumentation() {
									Name = @"xm",, 
									Description = @"sets XM",,
								}
								"32", new ISCPCommandValueDocumentation() {
									Name = @"sirius",, 
									Description = @"sets SIRIUS",,
								}
								"33", new ISCPCommandValueDocumentation() {
									Name = @"dab",, 
									Description = @"sets DAB ",,
								}
								"80", new ISCPCommandValueDocumentation() {
									Name = @"source",, 
									Description = @"sets SOURCE",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Selector Position Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Selector Position Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Selector Position",,
								}

						}
					},					{
 						"TUN", new ISCPCommandDocumentation() {
							Name = @"tuning",
,							Description = @"Tuning Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnn", new ISCPCommandValueDocumentation() {
									Name = @"freq-nnnnn,",, 
									Description = @"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Tuning Frequency Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Tuning Frequency Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Tuning Frequency",,
								}

						}
					},					{
 						"TU4", new ISCPCommandDocumentation() {
							Name = @"tuning",
,							Description = @"Tuning Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnn", new ISCPCommandValueDocumentation() {
									Name = @"freq-nnnnn,",, 
									Description = @"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)",,
								}
								"DIRECT", new ISCPCommandValueDocumentation() {
									Name = @"direct",, 
									Description = @"starts/restarts Direct Tuning Mode",,
								}
								"0", new ISCPCommandValueDocumentation() {
									Name = @"0-in-direct-mode",, 
									Description = @"sets 0 in Direct Tuning Mode",,
								}
								"1", new ISCPCommandValueDocumentation() {
									Name = @"1-in-direct-mode",, 
									Description = @"sets 1 in Direct Tuning Mode",,
								}
								"2", new ISCPCommandValueDocumentation() {
									Name = @"2-in-direct-mode",, 
									Description = @"sets 2 in Direct Tuning Mode",,
								}
								"3", new ISCPCommandValueDocumentation() {
									Name = @"3-in-direct-mode",, 
									Description = @"sets 3 in Direct Tuning Mode",,
								}
								"4", new ISCPCommandValueDocumentation() {
									Name = @"4-in-direct-mode",, 
									Description = @"sets 4 in Direct Tuning Mode",,
								}
								"5", new ISCPCommandValueDocumentation() {
									Name = @"5-in-direct-mode",, 
									Description = @"sets 5 in Direct Tuning Mode",,
								}
								"6", new ISCPCommandValueDocumentation() {
									Name = @"6-in-direct-mode",, 
									Description = @"sets 6 in Direct Tuning Mode",,
								}
								"7", new ISCPCommandValueDocumentation() {
									Name = @"7-in-direct-mode",, 
									Description = @"sets 7 in Direct Tuning Mode",,
								}
								"8", new ISCPCommandValueDocumentation() {
									Name = @"8-in-direct-mode",, 
									Description = @"sets 8 in Direct Tuning Mode",,
								}
								"9", new ISCPCommandValueDocumentation() {
									Name = @"9-in-direct-mode",, 
									Description = @"sets 9 in Direct Tuning Mode",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Tuning Frequency Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Tuning Frequency Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Tuning Frequency",,
								}

						}
					},					{
 						"PRS", new ISCPCommandDocumentation() {
							Name = @"preset",
,							Description = @"Preset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Preset No. Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Preset No. Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Preset No.",,
								}

						}
					},					{
 						"PR4", new ISCPCommandDocumentation() {
							Name = @"preset",
,							Description = @"Preset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-30",, 
									Description = @"sets Preset No. 1 - 30 ( In hexadecimal representation)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Preset No. Wrap-Around Up",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"sets Preset No. Wrap-Around Down",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets The Preset No.",,
								}

						}
					},					{
 						"NTC", new ISCPCommandDocumentation() {
							Name = @"net-tune-network",
,							Description = @"Net-Tune/Network Operation Command(Net-Tune Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAYz", new ISCPCommandValueDocumentation() {
									Name = @"playz",, 
									Description = @"PLAY KEY",,
								}
								"STOPz", new ISCPCommandValueDocumentation() {
									Name = @"stopz",, 
									Description = @"STOP KEY",,
								}
								"PAUSEz", new ISCPCommandValueDocumentation() {
									Name = @"pausez",, 
									Description = @"PAUSE KEY",,
								}
								"TRUPz", new ISCPCommandValueDocumentation() {
									Name = @"trupz",, 
									Description = @"TRACK UP KEY",,
								}
								"TRDNz", new ISCPCommandValueDocumentation() {
									Name = @"trdnz",, 
									Description = @"TRACK DOWN KEY",,
								}

						}
					},					{
 						"NT4", new ISCPCommandDocumentation() {
							Name = @"net-tune-network",
,							Description = @"Net-Tune/Network Operation Command(Network Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAY", new ISCPCommandValueDocumentation() {
									Name = @"play",, 
									Description = @"PLAY KEY",,
								}
								"STOP", new ISCPCommandValueDocumentation() {
									Name = @"stop",, 
									Description = @"STOP KEY",,
								}
								"PAUSE", new ISCPCommandValueDocumentation() {
									Name = @"pause",, 
									Description = @"PAUSE KEY",,
								}
								"TRUP", new ISCPCommandValueDocumentation() {
									Name = @"trup",, 
									Description = @"TRACK UP KEY",,
								}
								"TRDN", new ISCPCommandValueDocumentation() {
									Name = @"trdn",, 
									Description = @"TRACK DOWN KEY",,
								}
								"FF", new ISCPCommandValueDocumentation() {
									Name = @"ff",, 
									Description = @"FF KEY (CONTINUOUS*) (for iPod 1wire)",,
								}
								"REW", new ISCPCommandValueDocumentation() {
									Name = @"rew",, 
									Description = @"REW KEY (CONTINUOUS*) (for iPod 1wire)",,
								}
								"REPEAT", new ISCPCommandValueDocumentation() {
									Name = @"repeat",, 
									Description = @"REPEAT KEY(for iPod 1wire)",,
								}
								"RANDOM", new ISCPCommandValueDocumentation() {
									Name = @"random",, 
									Description = @"RANDOM KEY(for iPod 1wire)",,
								}
								"DISPLAY", new ISCPCommandValueDocumentation() {
									Name = @"display",, 
									Description = @"DISPLAY KEY(for iPod 1wire)",,
								}
								"RIGHT", new ISCPCommandValueDocumentation() {
									Name = @"right",, 
									Description = @"RIGHT KEY(for iPod 1wire)",,
								}
								"LEFT", new ISCPCommandValueDocumentation() {
									Name = @"left",, 
									Description = @"LEFT KEY(for iPod 1wire)",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"UP KEY(for iPod 1wire)",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"DOWN KEY(for iPod 1wire)",,
								}
								"SELECT", new ISCPCommandValueDocumentation() {
									Name = @"select",, 
									Description = @"SELECT KEY(for iPod 1wire)",,
								}
								"RETURN", new ISCPCommandValueDocumentation() {
									Name = @"return",, 
									Description = @"RETURN KEY(for iPod 1wire)",,
								}

						}
					},					{
 						"NP4", new ISCPCommandDocumentation() {
							Name = @"internet-radio-preset",
,							Description = @"Internet Radio Preset Command (Network Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}

						}
					}
				}
			},			{
 				"dock", new Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>() {					{
 						"NTC", new ISCPCommandDocumentation() {
							Name = @"network-usb",
,							Description = @"Network/USB Operation Command (Network Model Only after TX-NR905)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PLAY", new ISCPCommandValueDocumentation() {
									Name = @"play",, 
									Description = @"PLAY KEY",,
								}
								"STOP", new ISCPCommandValueDocumentation() {
									Name = @"stop",, 
									Description = @"STOP KEY",,
								}
								"PAUSE", new ISCPCommandValueDocumentation() {
									Name = @"pause",, 
									Description = @"PAUSE KEY",,
								}
								"P/P", new ISCPCommandValueDocumentation() {
									Name = @"p-p",, 
									Description = @"PLAY/PAUSE KEY",,
								}
								"TRUP", new ISCPCommandValueDocumentation() {
									Name = @"trup",, 
									Description = @"TRACK UP KEY",,
								}
								"TRDN", new ISCPCommandValueDocumentation() {
									Name = @"trdn",, 
									Description = @"TRACK DOWN KEY",,
								}
								"FF", new ISCPCommandValueDocumentation() {
									Name = @"ff",, 
									Description = @"FF KEY (CONTINUOUS*)",,
								}
								"REW", new ISCPCommandValueDocumentation() {
									Name = @"rew",, 
									Description = @"REW KEY (CONTINUOUS*)",,
								}
								"REPEAT", new ISCPCommandValueDocumentation() {
									Name = @"repeat",, 
									Description = @"REPEAT KEY",,
								}
								"RANDOM", new ISCPCommandValueDocumentation() {
									Name = @"random",, 
									Description = @"RANDOM KEY",,
								}
								"REP/SHF", new ISCPCommandValueDocumentation() {
									Name = @"rep-shf",, 
									Description = @"REPEAT/SHUFFLE KEY",,
								}
								"DISPLAY", new ISCPCommandValueDocumentation() {
									Name = @"display",, 
									Description = @"DISPLAY KEY",,
								}
								"ALBUM", new ISCPCommandValueDocumentation() {
									Name = @"album",, 
									Description = @"ALBUM KEY",,
								}
								"ARTIST", new ISCPCommandValueDocumentation() {
									Name = @"artist",, 
									Description = @"ARTIST KEY",,
								}
								"GENRE", new ISCPCommandValueDocumentation() {
									Name = @"genre",, 
									Description = @"GENRE KEY",,
								}
								"PLAYLIST", new ISCPCommandValueDocumentation() {
									Name = @"playlist",, 
									Description = @"PLAYLIST KEY",,
								}
								"RIGHT", new ISCPCommandValueDocumentation() {
									Name = @"right",, 
									Description = @"RIGHT KEY",,
								}
								"LEFT", new ISCPCommandValueDocumentation() {
									Name = @"left",, 
									Description = @"LEFT KEY",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"UP KEY",,
								}
								"DOWN", new ISCPCommandValueDocumentation() {
									Name = @"down",, 
									Description = @"DOWN KEY",,
								}
								"SELECT", new ISCPCommandValueDocumentation() {
									Name = @"select",, 
									Description = @"SELECT KEY",,
								}
								"0", new ISCPCommandValueDocumentation() {
									Name = @"0",, 
									Description = @"0 KEY",,
								}
								"1", new ISCPCommandValueDocumentation() {
									Name = @"1",, 
									Description = @"1 KEY",,
								}
								"2", new ISCPCommandValueDocumentation() {
									Name = @"2",, 
									Description = @"2 KEY",,
								}
								"3", new ISCPCommandValueDocumentation() {
									Name = @"3",, 
									Description = @"3 KEY",,
								}
								"4", new ISCPCommandValueDocumentation() {
									Name = @"4",, 
									Description = @"4 KEY",,
								}
								"5", new ISCPCommandValueDocumentation() {
									Name = @"5",, 
									Description = @"5 KEY",,
								}
								"6", new ISCPCommandValueDocumentation() {
									Name = @"6",, 
									Description = @"6 KEY",,
								}
								"7", new ISCPCommandValueDocumentation() {
									Name = @"7",, 
									Description = @"7 KEY",,
								}
								"8", new ISCPCommandValueDocumentation() {
									Name = @"8",, 
									Description = @"8 KEY",,
								}
								"9", new ISCPCommandValueDocumentation() {
									Name = @"9",, 
									Description = @"9 KEY",,
								}
								"DELETE", new ISCPCommandValueDocumentation() {
									Name = @"delete",, 
									Description = @"DELETE KEY",,
								}
								"CAPS", new ISCPCommandValueDocumentation() {
									Name = @"caps",, 
									Description = @"CAPS KEY",,
								}
								"LOCATION", new ISCPCommandValueDocumentation() {
									Name = @"location",, 
									Description = @"LOCATION KEY",,
								}
								"LANGUAGE", new ISCPCommandValueDocumentation() {
									Name = @"language",, 
									Description = @"LANGUAGE KEY",,
								}
								"SETUP", new ISCPCommandValueDocumentation() {
									Name = @"setup",, 
									Description = @"SETUP KEY",,
								}
								"RETURN", new ISCPCommandValueDocumentation() {
									Name = @"return",, 
									Description = @"RETURN KEY",,
								}
								"CHUP", new ISCPCommandValueDocumentation() {
									Name = @"chup",, 
									Description = @"CH UP(for iRadio)",,
								}
								"CHDN", new ISCPCommandValueDocumentation() {
									Name = @"chdn",, 
									Description = @"CH DOWN(for iRadio)",,
								}
								"MENU", new ISCPCommandValueDocumentation() {
									Name = @"menu",, 
									Description = @"MENU",,
								}
								"TOP", new ISCPCommandValueDocumentation() {
									Name = @"top",, 
									Description = @"TOP MENU",,
								}
								"MODE", new ISCPCommandValueDocumentation() {
									Name = @"mode",, 
									Description = @"MODE(for iPod) STD<->EXT",,
								}
								"LIST", new ISCPCommandValueDocumentation() {
									Name = @"list",, 
									Description = @"LIST <-> PLAYBACK",,
								}
								"MEMORY", new ISCPCommandValueDocumentation() {
									Name = @"memory",, 
									Description = @"MEMORY (add Favorite)",,
								}
								"F1", new ISCPCommandValueDocumentation() {
									Name = @"f1",, 
									Description = @"Positive Feed or Mark/Unmark ",,
								}
								"F2", new ISCPCommandValueDocumentation() {
									Name = @"f2",, 
									Description = @"Negative Feed ",,
								}

						}
					},					{
 						"NBS", new ISCPCommandDocumentation() {
							Name = @"bluetooth-setting",
,							Description = @"Bluetooth Setting Operation Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"OFF", new ISCPCommandValueDocumentation() {
									Name = @"off",, 
									Description = @"sets Bluetooth Off",,
								}
								"ON", new ISCPCommandValueDocumentation() {
									Name = @"on",, 
									Description = @"sets Bluetooth On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Bluetooth Setting",,
								}

						}
					},					{
 						"NBT", new ISCPCommandDocumentation() {
							Name = @"bluetooth-internal",
,							Description = @"Bluetooth(Internal) Operation Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"PAIRING", new ISCPCommandValueDocumentation() {
									Name = @"pairing",, 
									Description = @"PAIRING",,
								}
								"CLEAR", new ISCPCommandValueDocumentation() {
									Name = @"clear",, 
									Description = @"CLEAR PAIRING INFORMATION",,
								}

						}
					},					{
 						"NAT", new ISCPCommandDocumentation() {
							Name = @"net-usb-artist-name-info",
,							Description = @"NET/USB Artist Name Info",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"artist-name",, 
									Description = @"NET/USB Artist Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for Network Control only)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets NET/USB Artist Name",,
								}

						}
					},					{
 						"NAL", new ISCPCommandDocumentation() {
							Name = @"net-usb-album-name-info",
,							Description = @"NET/USB Album Name Info",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"album-name",, 
									Description = @"NET/USB Album Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for Network Control only)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets NET/USB Album Name",,
								}

						}
					},					{
 						"NTI", new ISCPCommandDocumentation() {
							Name = @"net-usb-title-name",
,							Description = @"NET/USB Title Name",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"title",, 
									Description = @"NET/USB Title Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for Network Control only)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets NET/USB Title Name",,
								}

						}
					},					{
 						"NTM", new ISCPCommandDocumentation() {
							Name = @"net-usb-time-info",
,							Description = @"NET/USB Time Info",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"mm:ss/mm:ss", new ISCPCommandValueDocumentation() {
									Name = @"mm-ss-mm-ss",, 
									Description = @"NET/USB Time Info (Elapsed time/Track Time Max 99:59. If time is unknown, this response is --:--)",,
								}
								"hh:mm:ss/hh:mm:ss", new ISCPCommandValueDocumentation() {
									Name = @"hh-mm-ss-hh-mm-ss",, 
									Description = @"NET/USB Time Info (Elapsed time/Track Time Max 99:59:59. If time is unknown, this response is --:--)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets NET/USB Time Info",,
								}

						}
					},					{
 						"NTR", new ISCPCommandDocumentation() {
							Name = @"net-usb-track-info",
,							Description = @"NET/USB Track Info",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"cccc/tttt", new ISCPCommandValueDocumentation() {
									Name = @"cccc-tttt",, 
									Description = @"NET/USB Track Info (Current Track/Toral Track Max 9999. If Track is unknown, this response is ----)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets NET/USB Track Info",,
								}

						}
					},					{
 						"NST", new ISCPCommandDocumentation() {
							Name = @"net-usb-play-status",
,							Description = @"NET/USB Play Status",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"prs", new ISCPCommandValueDocumentation() {
									Name = @"prs",, 
									Description = @"NET/USB Play Status (3 letters)
p -> Play Status: "S": STOP, "P": Play, "p": Pause, "F": FF, "R": FR, "E": EOF
r -> Repeat Status: "-": Off, "R": All, "F": Folder, "1": Repeat 1, "x": disable
s -> Shuffle Status: "-": Off, "S": All , "A": Album, "F": Folder, "x": disable",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Net/USB Play Status",,
								}

						}
					},					{
 						"NMS", new ISCPCommandDocumentation() {
							Name = @"net-usb-menu-status",
,							Description = @"NET/USB Menu Status",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"maabbstii", new ISCPCommandValueDocumentation() {
									Name = @"maabbstii",, 
									Description = @"NET/USB Menu Status (9 letters)
m -> Track Menu: "M": Menu is enable, "x": Menu is disable
aa -> F1 button icon (Positive Feed or Mark/Unmark)
bb -> F2 button icon (Negative Feed)
 aa or bb : "xx":disable, "01":Like, "02":don't like, "03":Love, "04":Ban,
                  "05":episode, "06":ratings, "07":Ban(black), "08":Ban(white),
                  "09":Favorite(black), "0A":Favorite(white), "0B":Favorite(yellow)
s -> Time Seek "S": Time Seek is enable "x": Time Seek is disable
t -> Time Display "1": Elapsed Time/Total Time, "2": Elapsed Time, "x": disable
ii-> Service icon
 ii : "00":Music Server (DLNA), "01":My Favorite, "02":vTuner, 
      "03":SiriusXM, "04":Pandora,
      "05":Rhapsody, "06":Last.fm, "07":Napster, "08":Slacker, "09":Mediafly,
      "0A":Spotify, "0B":AUPEO!,
      "0C":radiko, "0D":e-onkyo, "0E":TuneIn, "0F":MP3tunes, "10":Simfy,
      "11":Home Media, "12":Deezer, "13":iHeartRadio, "18":Airplay,
      “1A”: onkyo Music, “1B”:TIDAL, “41”:FireConnect,
      "F0": USB/USB(Front), "F1: USB(Rear), "F2":Internet Radio
      "F3":NET, "F4":Bluetooth",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Net/USB Menu Status",,
								}

						}
					},					{
 						"NTS", new ISCPCommandDocumentation() {
							Name = @"net-usb-time-seek",
,							Description = @"NET/USB Time Seek",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"mm:ss", new ISCPCommandValueDocumentation() {
									Name = @"mm-ss",, 
									Description = @"mm: munites (00-99)
ss: seconds (00-59)
This command is only available when Time Seek is enable.",,
								}
								"hh:mm:ss", new ISCPCommandValueDocumentation() {
									Name = @"hh-mm-ss",, 
									Description = @"hh: hours(00-99)
mm: munites (00-59)
ss: seconds (00-59)
This command is only available when Time Seek is enable.",,
								}

						}
					},					{
 						"NPR", new ISCPCommandDocumentation() {
							Name = @"internet-radio-preset",
,							Description = @"Internet Radio Preset Command",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"no-1-40",, 
									Description = @"sets Preset No. 1 - 40 ( In hexadecimal representation)",,
								}
								"SET", new ISCPCommandValueDocumentation() {
									Name = @"set",, 
									Description = @"preset memory current station",,
								}

						}
					},					{
 						"NDS", new ISCPCommandDocumentation() {
							Name = @"net-connection-usb-device-status",
,							Description = @"NET Connection/USB Device Status",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nfr", new ISCPCommandValueDocumentation() {
									Name = @"nfr",, 
									Description = @"NET Connection/USB Device Status (3 letters)
n -> NET Connection status: "-": no connection, "E": Ether, "W": Wireless
f -> Front USB(USB1) Device Status: "-": no device, "i": iPod/iPhone, 
      "M": Memory/NAS, "W": Wireless Adaptor, "B": Bluetooth Adaptor,
      "x": disable
r -> Rear USB(USB2) Device Status: "-": no device, "i": iPod/iPhone, 
      "M": Memory/NAS, "W": Wireless Adaptor, "B": Bluetooth Adaptor, 
      "x": disable",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Net/USB Status",,
								}

						}
					},					{
 						"NLS", new ISCPCommandDocumentation() {
							Name = @"net-usb-list-info",
,							Description = @"NET/USB List Info",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"tlpnnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"info",, 
									Description = @"NET/USB List Info
t ->Information Type (A : ASCII letter, C : Cursor Info, U : Unicode letter)
when t = A,
  l ->Line Info (0-9 : 1st to 10th Line)
  nnnnnnnnn:Listed data (variable-length, 64 ASCII letters max)
    when AVR is not displayed NET/USB List(Keyboard,Menu,Popup…), "nnnnnnnnn" is "See TV".
  p ->Property
         - : no
         0 : Playing, A : Artist, B : Album, F : Folder, M : Music, P : Playlist, S : Search
         a : Account, b : Playlist-C, c : Starred, d : Unstarred, e : What's New
when t = C,
  l ->Cursor Position (0-9 : 1st to 10th Line, - : No Cursor)
  p ->Update Type (P : Page Information Update ( Page Clear or Disable List Info) , C : Cursor Position Update)
when t = U, (for Network Control Only)
  l ->Line Info (0-9 : 1st to 10th Line)
  nnnnnnnnn:Listed data (variable-length, 64 Unicode letters [UTF-8 encoded] max)
    when AVR is not displayed NET/USB List(Keyboard,Menu,Popup…), "nnnnnnnnn" is "See TV".
  p ->Property
         - : no
         0 : Playing, A : Artist, B : Album, F : Folder, M : Music, P : Playlist, S : Search
         a : Account, b : Playlist-C, c : Starred, d : Unstarred, e : What's New",,
								}
								"ti", new ISCPCommandValueDocumentation() {
									Name = @"ti",, 
									Description = @"select the listed item
 t -> Index Type (L : Line, I : Index)
when t = L,
  i -> Line number (0-9 : 1st to 10th Line [1 digit] )
when t = I,
  iiiii -> Index number (00001-99999 : 1st to 99999th Item [5 digits] )",,
								}

						}
					},					{
 						"NLA", new ISCPCommandDocumentation() {
							Name = @"net-usb-list-info",
,							Description = @"NET/USB List Info(All item, need processing XML data, for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"tzzzzsurr<.....>", new ISCPCommandValueDocumentation() {
									Name = @"tzzzzsurr",, 
									Description = @"t -> responce type 'X' : XML
zzzz -> sequence number (0000-FFFF)
s -> status 'S' : success, 'E' : error
u -> UI type '0' : List, '1' : Menu, '2' : Playback, '3' : Popup, '4' : Keyboard, "5" : Menu List
rr -> reserved
<.....> : XML data ( [CR] and [LF] are removed )
 If s='S',
 <?xml version="1.0" encoding="UFT-8"?>
 <response status="ok">
   <items offset="xxxx" totalitems="yyyy" >
     <item iconid="aa" title="bbb…bbb" url="ccc...ccc"/>
     …
     <item iconid="aa" title="bbb…bbb" url="ccc...ccc"/>
   </Items>
 </response>
 If s='E',
 <?xml version="1.0" encoding="UFT-8"?>
 <response status="fail">
   <error code="[error code]" message="[error message]" />
 </response>
xxxx : index of 1st item (0000-FFFF : 1st to 65536th Item [4 HEX digits] )
yyyy : number of items (0000-FFFF : 1 to 65536 Items [4 HEX digits] )
aa : Icon ID
 '29' : Folder, '2A' : Folder X, '2B' : Server, '2C' : Server X, '2D' : Title, '2E' : Title X,
 '2F' : Program, '31' : USB, '36' : Play, '37' : MultiAccount,
 for Spotify
 '38' : Account, '39' : Album, '3A' : Playlist, '3B' : Playlist-C, '3C' : starred,
 '3D' : What'sNew, '3E' : Artist, '3F' : Track, '40' : unstarred, '41' : Play, '43' : Search, '44' : Folder
 for AUPEO!
 '42' : Program
bbb...bbb : Title",,
								}
								"Lzzzzll{xx}{xx}yyyy", new ISCPCommandValueDocumentation() {
									Name = @"lzzzzll-xx-xx-yyyy",, 
									Description = @"specifiy to get the listed data (from Network Control Only)
zzzz -> sequence number (0000-FFFF)
ll -> number of layer (00-FF)
xxxx -> index of start item (0000-FFFF : 1st to 65536th Item [4 HEX digits] )
yyyy -> number of items (0000-FFFF : 1 to 65536 Items [4 HEX digits] )",,
								}
								"Izzzzll{xx}{xx}----", new ISCPCommandValueDocumentation() {
									Name = @"izzzzll-xx-xx",, 
									Description = @"select the listed item (from Network Control Only)
zzzz -> sequence number (0000-FFFF)
ll -> number of layer (00-FF)
xxxx -> index number (0000-FFFF : 1st to 65536th Item [4 HEX digits] )
---- -> not used",,
								}

						}
					},					{
 						"NJA", new ISCPCommandDocumentation() {
							Name = @"net-usb-jacket-art",
,							Description = @"NET/USB Jacket Art (When Jacket Art is available and Output for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"tp{xx}{xx}{xx}{xx}{xx}{xx}", new ISCPCommandValueDocumentation() {
									Name = @"tp-xx-xx-xx-xx-xx-xx",, 
									Description = @"NET/USB Jacket Art/Album Art Data
t-> Image type 0:BMP, 1:JPEG, 2:URL, n:No Image
p-> Packet flag 0:Start, 1:Next, 2:End, -:not used
xxxxxxxxxxxxxx -> Jacket/Album Art Data (valiable length, 1024 ASCII HEX letters max)",,
								}
								"DIS", new ISCPCommandValueDocumentation() {
									Name = @"disable",, 
									Description = @"sets Jacket Art disable",,
								}
								"ENA", new ISCPCommandValueDocumentation() {
									Name = @"enable",, 
									Description = @"sets Jacket Art enable",,
								}
								"BMP", new ISCPCommandValueDocumentation() {
									Name = @"enable-and-image-type-bmp",, 
									Description = @"sets Jacket Art enable and Image type BMP",,
								}
								"LINK", new ISCPCommandValueDocumentation() {
									Name = @"enable-and-image-type-link",, 
									Description = @"sets Jacket Art enable and Image type LINK",,
								}
								"UP", new ISCPCommandValueDocumentation() {
									Name = @"up",, 
									Description = @"sets Jacket Art Wrap-Around Up",,
								}
								"REQ", new ISCPCommandValueDocumentation() {
									Name = @"req",, 
									Description = @"gets Jacket Art data",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Jacket Art enable/disable",,
								}

						}
					},					{
 						"NSV", new ISCPCommandDocumentation() {
							Name = @"net-service",
,							Description = @"NET Service(for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"ssiaaaa…aaaabbbb…bbbb", new ISCPCommandValueDocumentation() {
									Name = @"service-id",, 
									Description = @"select Network Service directly
ss -> Network Serveice
 00:Music Server (DLNA), 01:Favorite, 02:vTuner, 03:SiriusXM, 04:Pandora, 05:Rhapsody, 06:Last.fm,
 07:Napster, 08:Slacker, 09:Mediafly, 0A:Spotify, 0B:AUPEO!, 0C:Radiko, 0D:e-onkyo,
 0E:TuneIn Radio, 0F:mp3tunes, 10:Simfy, 11:Home Media, 12:Deezer, 13:iHeartRadio, 18:Airplay, 19:TIDAL, 1A:onkyo music, F0;USB/USB(Front), F1:USB(Rear)
i-> Acount Info
 0: No
 1: Yes
"aaaa...aaaa": User Name ( 128 Unicode letters [UTF-8 encoded] max )
"bbbb...bbbb": Password ( 128 Unicode letters [UTF-8 encoded] max )",,
								}

						}
					},					{
 						"NKY", new ISCPCommandDocumentation() {
							Name = @"net-keyboard",
,							Description = @"NET Keyboard(for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"ll", new ISCPCommandValueDocumentation() {
									Name = @"ll",, 
									Description = @"waiting Keyboard Input
ll -> category
 00: Off ( Exit Keyboard Input )
 01: User Name
 02: Password
 03: Artist Name
 04: Album Name
 05: Song Name
 06: Station Name
 07: Tag Name
 08: Artist or Song
 09: Episode Name
 0A: Pin Code (some digit Number [0-9])
 0B: User Name (available ISO 8859-1 character set)
 0C: Password (available ISO 8859-1 character set)
 0D: URL",,
								}
								"nnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"input",, 
									Description = @"set Keyboard Input letter
"nnnnnnnn" is variable-length, 128 Unicode letters [UTF-8 encoded] max",,
								}

						}
					},					{
 						"NPU", new ISCPCommandDocumentation() {
							Name = @"net-popup-message",
,							Description = @"NET Popup Message(for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"xaaa…aaaybbb…bbb", new ISCPCommandValueDocumentation() {
									Name = @"popup",, 
									Description = @"x -> Popup Display Type
 'T': Popup text is top
 'B': Popup text is bottom
 'L': Popup text is list format

aaa...aaa -> Popup Title, Massage
 when x = 'T' or 'B'
    Top Title [0x00] Popup Title [0x00] Popup Message [0x00]
    (valiable-length Unicode letter [UTF-8 encoded] )

 when x = 'L'
    Top Title [0x00] Item Title 1 [0x00] Item Parameter 1 [0x00] ... [0x00] Item Title 6 [0x00] Item Parameter 6 [0x00]
    (valiable-length Unicode letter [UTF-8 encoded] )

y -> Cursor Position on button
 '0' : Button is not Displayed
 '1' : Cursor is on the button 1
 '2' : Cursor is on the button 2

bbb...bbb -> Text of Button
    Text of Button 1 [0x00] Text of Button 2 [0x00]
    (valiable-length Unicode letter [UTF-8 encoded] )",,
								}

						}
					},					{
 						"NLT", new ISCPCommandDocumentation() {
							Name = @"net-usb-list-title-info",
,							Description = @"NET/USB List Title Info(for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"{xx}uycccciiiillrraabbssnnn...nnn", new ISCPCommandValueDocumentation() {
									Name = @"title-info",, 
									Description = @"NET/USB List Title Info
xx : Service Type
 00 : DLNA, 01 : Favorite, 02 : vTuner, 03 : SiriusXM, 04 : Pandora, 05 : Rhapsody, 06 : Last.fm,
 07 : Napster, 08 : Slacker, 09 : Mediafly, 0A : Spotify, 0B : AUPEO!, 0C : radiko, 0D : e-onkyo,
 0E : TuneIn Radio, 0F : MP3tunes, 10 : Simfy, 11:Home Media, 12:Deezer, 13:iHeartRadio,
 F0 : USB Front, F1 : USB Rear, F2 : Internet Radio, F3 : NET, FF : None
u : UI Type
 0 : List, 1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, "5" : Menu List
y : Layer Info
 0 : NET TOP, 1 : Service Top,DLNA/USB/iPod Top, 2 : under 2nd Layer
cccc : Current Cursor Position (HEX 4 letters)
iiii : Number of List Items (HEX 4 letters)
ll : Number of Layer(HEX 2 letters)
rr : Reserved (2 leters)
aa : Icon on Left of Title Bar
 00 : Internet Radio, 01 : Server, 02 : USB, 03 : iPod, 04 : DLNA, 05 : WiFi, 06 : Favorite
 10 : Account(Spotify), 11 : Album(Spotify), 12 : Playlist(Spotify), 13 : Playlist-C(Spotify)
 14 : Starred(Spotify), 15 : What's New(Spotify), 16 : Track(Spotify), 17 : Artist(Spotify)
 18 : Play(Spotify), 19 : Search(Spotify), 1A : Folder(Spotify)
 FF : None
bb : Icon on Right of Title Bar
 00 : DLNA, 01 : Favorite, 02 : vTuner, 03 : SiriusXM, 04 : Pandora, 05 : Rhapsody, 06 : Last.fm,
 07 : Napster, 08 : Slacker, 09 : Mediafly, 0A : Spotify, 0B : AUPEO!, 0C : radiko, 0D : e-onkyo,
 0E : TuneIn Radio, 0F : MP3tunes, 10 : Simfy, 11:Home Media, 12:Deezer, 13:iHeartRadio,
 FF : None
ss : Status Info
 00 : None, 01 : Connecting, 02 : Acquiring License, 03 : Buffering
 04 : Cannot Play, 05 : Searching, 06 : Profile update, 07 : Operation disabled
 08 : Server Start-up, 09 : Song rated as Favorite, 0A : Song banned from station,
 0B : Authentication Failed, 0C : Spotify Paused(max 1 device), 0D : Track Not Available, 0E : Cannot Skip
nnn...nnn : Character of Title Bar (variable-length, 64 Unicode letters [UTF-8 encoded] max)",,
								}
								"{xx}uycccciiiillsraabbssnnn...nnn", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"NET/USB List Title Info
xx : Service Type
 00 : Music Server (DLNA), 01 : Favorite, 02 : vTuner, 03 : SiriusXM, 04 : Pandora, 05 : Rhapsody, 06 : Last.fm,
 07 : Napster, 08 : Slacker, 09 : Mediafly, 0A : Spotify, 0B : AUPEO!, 0C : radiko, 0D : e-onkyo,
 0E : TuneIn Radio, 0F : MP3tunes, 10 : Simfy, 11:Home Media, 12:Deezer, 13:iHeartRadio, 18:Airplay, 19:TIDAL, 1A:onkyo music,
 F0 : USB/USB(Front) F1 : USB(Rear), F2 : Internet Radio, F3 : NET, FF : None
u : UI Type
 0 : List, 1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, "5" : Menu List
y : Layer Info
 0 : NET TOP, 1 : Service Top,DLNA/USB/iPod Top, 2 : under 2nd Layer
cccc : Current Cursor Position (HEX 4 letters)
iiii : Number of List Items (HEX 4 letters)
ll : Number of Layer(HEX 2 letters)
s : Start Flag
 0 : Not First, 1 : First
r : Reserved (1 leters, don't care)
aa : Icon on Left of Title Bar
 00 : Internet Radio, 01 : Server, 02 : USB, 03 : iPod, 04 : DLNA, 05 : WiFi, 06 : Favorite
 10 : Account(Spotify), 11 : Album(Spotify), 12 : Playlist(Spotify), 13 : Playlist-C(Spotify)
 14 : Starred(Spotify), 15 : What's New(Spotify), 16 : Track(Spotify), 17 : Artist(Spotify)
 18 : Play(Spotify), 19 : Search(Spotify), 1A : Folder(Spotify)
 FF : None
bb : Icon on Right of Title Bar
 00 : Muisc Server (DLNA), 01 : Favorite, 02 : vTuner, 03 : SiriusXM, 04 : Pandora, 05 : Rhapsody, 06 : Last.fm,
 07 : Napster, 08 : Slacker, 09 : Mediafly, 0A : Spotify, 0B : AUPEO!, 0C : radiko, 0D : e-onkyo,
 0E : TuneIn Radio, 0F : MP3tunes, 10 : Simfy, 11:Home Media, 12:Deezer, 13:iHeartRadio, 18:Airplay, 19:TIDAL, 1A:onkyo music,
F0:USB/USB(Front), F1:USB(Rear),
 FF : None
ss : Status Info
 00 : None, 01 : Connecting, 02 : Acquiring License, 03 : Buffering
 04 : Cannot Play, 05 : Searching, 06 : Profile update, 07 : Operation disabled
 08 : Server Start-up, 09 : Song rated as Favorite, 0A : Song banned from station,
 0B : Authentication Failed, 0C : Spotify Paused(max 1 device), 0D : Track Not Available, 0E : Cannot Skip
nnn...nnn : Character of Title Bar (variable-length, 64 Unicode letters [UTF-8 encoded] max)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets List Title Info",,
								}

						}
					},					{
 						"NMD", new ISCPCommandDocumentation() {
							Name = @"ipod-mode-change",
,							Description = @"iPod Mode Change (with USB Connection Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"STD", new ISCPCommandValueDocumentation() {
									Name = @"std",, 
									Description = @"Standerd Mode",,
								}
								"EXT", new ISCPCommandValueDocumentation() {
									Name = @"ext",, 
									Description = @"Extend Mode(If available)",,
								}
								"VDC", new ISCPCommandValueDocumentation() {
									Name = @"vdc",, 
									Description = @"Video Contents in Extended Mode",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets iPod Mode Status",,
								}

						}
					},					{
 						"NSB", new ISCPCommandDocumentation() {
							Name = @"network-standby-settings",
,							Description = @"Network Standby Settings (for Network Control Only and Available in AVR is PowerOn)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"OFF", new ISCPCommandValueDocumentation() {
									Name = @"is-off",, 
									Description = @"sets Network Standby is Off",,
								}
								"ON", new ISCPCommandValueDocumentation() {
									Name = @"is-on",, 
									Description = @"sets Network Standby is On",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets Network Standby Setting",,
								}

						}
					},					{
 						"NRI", new ISCPCommandDocumentation() {
							Name = @"receiver-information",
,							Description = @"Receiver Information (for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"<…>", new ISCPCommandValueDocumentation() {
									Name = @"xml",, 
									Description = @"<…>: XML Data <?xml…>",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Receiver Information Status",,
								}
								"t----<.....>", new ISCPCommandValueDocumentation() {
									Name = @"t",, 
									Description = @"t -> message type 'X' : XML
---- -> reserved
<.....> : XML data ( [CR] and [LF] are removed )",,
								}
								"Ullt<.....>", new ISCPCommandValueDocumentation() {
									Name = @"ullt",, 
									Description = @"U : UI Type
 0 : List, 1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, 5 : Menu List
ll -> number of layer (00-FF)
t : Update Type
 0 : All, 1 : Button, 2 : Textbox, 3 : Listbox
<.....> : XML data ( [CR] and [LF] are removed )",,
								}

						}
					},					{
 						"NLU", new ISCPCommandDocumentation() {
							Name = @"net-usb-list-info",
,							Description = @"NET/USB List Info (Update item, need processing XML data, for Network Control Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"{xx}{xx}yyyy", new ISCPCommandValueDocumentation() {
									Name = @"xx-xx-yyyy",, 
									Description = @"xxxx -> index of update item (0000-FFFF : 1st to 65536th Item [4 HEX digits] )
yyyy : number of items (0000-FFFF : 1 to 65536 Items [4 HEX digits] )",,
								}

						}
					},					{
 						"NPB", new ISCPCommandDocumentation() {
							Name = @"net-usb-playback-view-button",
,							Description = @"NET/USB Playback view Button",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"pudtsrrr", new ISCPCommandValueDocumentation() {
									Name = @"pudtsrrr",, 
									Description = @"NET/USB Playback view Status (5 letters)
p -> Play/Pause button: "1": button is enable, "0": button is disable
u ->  Skip up button : "1": button is enable, "0": button is disable
d -> Skip down button : "1": button is enable, "0": button is disable
t -> Timer button : "1": button is enable, "0": button is disable
s -> Preset button : "1": button is enable, "0": button is disable
 rrr-> reserved",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Net/USB Playback view Button",,
								}

						}
					},					{
 						"NAF", new ISCPCommandDocumentation() {
							Name = @"net-usb-add-favorite-list-in-list-view",
,							Description = @"NET/USB Add Favorite List in List View",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"{xx}{xx}", new ISCPCommandValueDocumentation() {
									Name = @"xx-xx",, 
									Description = @"Add Favorite Lsit in List View (from Network Control Only)
xxxx -> index number (0000-FFFF : 1st to 65536th Item [4 HEX digits] )",,
								}

						}
					},					{
 						"NRF", new ISCPCommandDocumentation() {
							Name = @"net-usb-remove-favorite-list",
,							Description = @"NET/USB Remove Favorite List",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"System.Object[]", new ISCPCommandValueDocumentation() {
									Name = @"fav-no-1-40",, 
									Description = @"Remove Item from Favorite List ( In hexadecimal representation)",,
								}

						}
					},					{
 						"NSD", new ISCPCommandDocumentation() {
							Name = @"net-usb-music-server-dlna-search-list",
,							Description = @"NET/USB Music Server(DLNA) Search List",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"{xx}{xx}{xx}{xx}{xx}x", new ISCPCommandValueDocumentation() {
									Name = @"xx-xx-xx-xx-xx-x",, 
									Description = @"Search Word (Max 128 Character)",,
								}

						}
					},					{
 						"AAT", new ISCPCommandDocumentation() {
							Name = @"airplay-artist-name-info",
,							Description = @"Airplay Artist Name Info (Airplay Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = null,, 
									Description = @"NET/USB Artist Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for Network Control only)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets iPod Artist Name",,
								}

						}
					},					{
 						"AAL", new ISCPCommandDocumentation() {
							Name = @"airplay-album-name-info",
,							Description = @"Airplay Album Name Info (Airplay Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"album-name",, 
									Description = @"NET/USB Album Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for Network Control only)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets iPod Album Name",,
								}

						}
					},					{
 						"ATI", new ISCPCommandDocumentation() {
							Name = @"airplay-title-name",
,							Description = @"Airplay Title Name (Airplay Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"nnnnnnnnnn", new ISCPCommandValueDocumentation() {
									Name = @"title",, 
									Description = @"NET/USB Title Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for Network Control only)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets HD Radio Title",,
								}

						}
					},					{
 						"ATM", new ISCPCommandDocumentation() {
							Name = @"airplay-time-info",
,							Description = @"Airplay Time Info (Airplay Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"mm:ss/mm:ss", new ISCPCommandValueDocumentation() {
									Name = @"mm-ss-mm-ss",, 
									Description = @"NET/USB Time Info (Elapsed time/Track Time Max 99:59)",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets iPod Time Info",,
								}

						}
					},					{
 						"AST", new ISCPCommandDocumentation() {
							Name = @"airplay-play-status",
,							Description = @"Airplay Play Status (Airplay Model Only)",
,							Aliases = null,
,							Values = new Dictionary<string, ISCPCommandValueDocumentation>() { 
								"prs", new ISCPCommandValueDocumentation() {
									Name = @"prs",, 
									Description = @"NET/USB Play Status (3 letters)
p -> Play Status: "S": STOP, "P": Play, "p": Pause
r -> Repeat Status: "-": Off
s -> Shuffle Status: "-": Off",,
								}
								"QSTN", new ISCPCommandValueDocumentation() {
									Name = @"query",, 
									Description = @"gets the Net/USB Status",,
								}

						}
					}
				}
			}
		};
	}
}
