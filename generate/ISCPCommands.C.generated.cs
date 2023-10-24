// Generated
// by 
// from 
// at 24-10-2023 15:33:00

using System.Collections;
using System.Collections.Specialized;

namespace Eiscp.Core
{
	public static partial class EiscpCommands
	{
		public static readonly Dictionary<string, object>  Commands = new Dictionary<string, object>()
		{
			{
 				"main",
				new Dictionary<string, object>()
				{
					{
 						"PWR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"system-power"
							},
							{
 								"description",
								"System Power Command"
							},
							{
 								"aliases",
								new string[]
								{
									"power"
								}
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"standby",
													"off"
												}
											},
											{
 												"description",
												"sets System Standby"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets System On"
											}
										}
									},
									{
 										"ALL",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"standby-all"
											},
											{
 												"description",
												"All Zone(including Main Zone) Standby"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the System Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"AMT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audio-muting"
							},
							{
 								"description",
								"Audio Muting Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Audio Muting Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Audio Muting On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Audio Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Audio Muting State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CMT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audio-muting-by-channel"
							},
							{
 								"description",
								"Audio Muting by Channel Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"aabbccddeeffgghhiijjkkllmm",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"aabbccddeeffgghhiijjkkllmm"
											},
											{
 												"description",
												@"sets Audio Muting by Channel
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
mm:Subwoofer 2"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Audio Muting State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"speaker-a"
							},
							{
 								"description",
								"Speaker A Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Speaker Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Speaker On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Speaker Switch Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"speaker-b"
							},
							{
 								"description",
								"Speaker B Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Speaker Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Speaker On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Speaker Switch Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"speaker-layout"
							},
							{
 								"description",
								"Speaker Layout Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"SB",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"surrback"
											},
											{
 												"description",
												"sets SurrBack Speaker"
											}
										}
									},
									{
 										"FH",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"front-high",
													"surrback-front-high-speakers"
												}
											},
											{
 												"description",
												"sets Front High Speaker / SurrBack+Front High Speakers"
											}
										}
									},
									{
 										"FW",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"front-wide",
													"surrback-front-wide-speakers"
												}
											},
											{
 												"description",
												"sets Front Wide Speaker / SurrBack+Front Wide Speakers"
											}
										}
									},
									{
 										"HW",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"front-high-front-wide-speakers"
												}
											},
											{
 												"description",
												"sets, Front High+Front Wide Speakers"
											}
										}
									},
									{
 										"H1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"height1-speakers"
											},
											{
 												"description",
												"sets Height1 Speakers"
											}
										}
									},
									{
 										"H2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"height2-speakers"
											},
											{
 												"description",
												"sets Height2 Speakers"
											}
										}
									},
									{
 										"BH",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"back-height1-speakers"
											},
											{
 												"description",
												"sets Back+Height1 Speakers"
											}
										}
									},
									{
 										"BW",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"back-wide-speakers"
											},
											{
 												"description",
												"sets Back+Wide Speakers"
											}
										}
									},
									{
 										"HH",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"height1-height2-speakers"
											},
											{
 												"description",
												"sets Height1+Height2 Speakers"
											}
										}
									},
									{
 										"A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"speakers-a"
											},
											{
 												"description",
												"sets Speakers A"
											}
										}
									},
									{
 										"B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"speakers-b"
											},
											{
 												"description",
												"sets Speakers B"
											}
										}
									},
									{
 										"AB",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"speakers-a-b"
											},
											{
 												"description",
												"sets Speakers A+B"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Speaker Switch Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Spea  ker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MVL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"master-volume"
							},
							{
 								"description",
								"Master Volume Command"
							},
							{
 								"aliases",
								new string[]
								{
									"volume"
								}
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"200"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0.0 – 100.0 ( 0.5 Step In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"100"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"vol-0-100,"
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"80"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"50"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"vol-0-50,"
											},
											{
 												"description",
												"Volume Level 0 – 50 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"UP1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-up-1db-step"
											},
											{
 												"description",
												"sets Volume Level Up 1dB Step"
											}
										}
									},
									{
 										"DOWN1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-down-1db-step"
											},
											{
 												"description",
												"sets Volume Level Down 1dB Step"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TFR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone-front"
							},
							{
 								"description",
								"Tone(Front) Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Front Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 1 step]"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Front Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 1 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Front Bass up(1 step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Front Bass down(1 step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Front Treble up(1 step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Front Treble down(1 step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Front Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TFW",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone-front-wide"
							},
							{
 								"description",
								"Tone(Front Wide) Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Front Wide Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Front Wide Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Front Wide Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Front Wide Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Front Wide Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Front Wide Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Front Wide Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TFH",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone-front-high"
							},
							{
 								"description",
								"Tone(Front High) Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Front High Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Front High Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Front High Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Front High Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Front High Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Front High Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Front High Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TCT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone-center"
							},
							{
 								"description",
								"Tone(Center) Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Center Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Center Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Center Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Center Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Center Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Center Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Cetner Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TSR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone-surround"
							},
							{
 								"description",
								"Tone(Surround) Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Surround Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Surround Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Surround Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Surround Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Surround Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Surround Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Surround Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TSB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone-surround-back"
							},
							{
 								"description",
								"Tone(Surround Back) Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Surround Back Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Surround Back Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Surround Back Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Surround Back Bass down(2 step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Surround Back Treble up(2 step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Surround Back Treble down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Surround Back Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TSW",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone-subwoofer"
							},
							{
 								"description",
								"Tone(Subwoofer) Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Subwoofer Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 2 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Subwoofer Bass up(2 step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Subwoofer Bass down(2 step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Subwoofer Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PMB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"phase-matching-bass"
							},
							{
 								"description",
								"Phase Matching Bass Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Phase Matching Bass Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Phase Matching Bass"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLP",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"sleep-set"
							},
							{
 								"description",
								"Sleep Set Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"90"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"time-1-90min"
											},
											{
 												"description",
												"sets Sleep Time 1 - 90min ( In hexadecimal representation)"
											}
										}
									},
									{
 										"OFF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"time-off"
											},
											{
 												"description",
												"sets Sleep Time Off"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Sleep Time Wrap-Around UP"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"qstn"
											},
											{
 												"description",
												"gets The Sleep Time"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"speaker-level-calibration"
							},
							{
 								"description",
								"Speaker Level Calibration Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"TEST",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"test"
											},
											{
 												"description",
												"TEST Key"
											}
										}
									},
									{
 										"OFF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"test-tone-off"
											},
											{
 												"description",
												"sets TEST TONE OFF"
											}
										}
									},
									{
 										"CHSEL",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chsel"
											},
											{
 												"description",
												"CH SEL Key"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"LEVEL + Key"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"LEVEL – KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SWL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"subwoofer-temporary-level"
							},
							{
 								"description",
								"Subwoofer (temporary) Level Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"-30",
											"24"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"15-0db-0-0db-12-0db"
											},
											{
 												"description",
												"sets Subwoofer Level -15.0dB - 0.0dB - +12.0dB(0.5dB Step)"
											}
										}
									},
									{
 										new string[]
										{
											"-15",
											"12"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"15db-0db-12db"
											},
											{
 												"description",
												"sets Subwoofer Level -15dB - 0dB - +12dB"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"LEVEL + Key"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"LEVEL – KEY"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Subwoofer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SW2",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"subwoofer-2-temporary-level"
							},
							{
 								"description",
								"Subwoofer 2 (temporary) Level Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"-30",
											"24"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"15-0db-0-0db-12-0db"
											},
											{
 												"description",
												"sets Subwoofer 2 Level -15.0dB - 0.0dB - +12.0dB(0.5dB Step)"
											}
										}
									},
									{
 										new string[]
										{
											"-15",
											"12"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"15db-0db-12db"
											},
											{
 												"description",
												"sets Subwoofer 2 Level -15dB - 0dB - +12dB"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"LEVEL + Key"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"LEVEL – KEY"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Subwoofer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CTL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"center-temporary-level"
							},
							{
 								"description",
								"Center (temporary) Level Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"-24",
											"24"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"12-0db-0-0db-12-0db"
											},
											{
 												"description",
												"sets Center Level -12.0dB - 0.0dB - +12.0dB(0.5dB Step)"
											}
										}
									},
									{
 										new string[]
										{
											"-12",
											"12"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"12db-0db-12db"
											},
											{
 												"description",
												"sets Center Level -12dB - 0dB - +12dB"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"LEVEL + Key"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"LEVEL – KEY"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Subwoofer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TCL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"temporary-channel-level"
							},
							{
 								"description",
								"Temporary Channel Level Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"aaabbbcccdddeeefffggghhhiiijjjkkklllmmm",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"levels"
											},
											{
 												"description",
												@"sets Temporary Channel Level
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
mmm:Subwoofer 2"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Subwoofer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DIF",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"display-mode"
							},
							{
 								"description",
								"Display Mode Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"selector-volume-1line",
													"default-2line"
												}
											},
											{
 												"description",
												"sets Selector + Volume Display Mode@1line, Default@2line"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"selector-listening-1line"
											},
											{
 												"description",
												"sets Selector + Listening Mode Display Mode@1line"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"02"
											},
											{
 												"description",
												"Display Digital Format(temporary display)"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"03"
											},
											{
 												"description",
												"Display Video Format(temporary display)"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Display Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Display Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DIM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"dimmer-level"
							},
							{
 								"description",
								"Dimmer Level Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bright"
											},
											{
 												"description",
												"sets Dimmer Level \"Bright\""
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dim"
											},
											{
 												"description",
												"sets Dimmer Level \"Dim\""
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dark"
											},
											{
 												"description",
												"sets Dimmer Level \"Dark\""
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"shut-off"
											},
											{
 												"description",
												"sets Dimmer Level \"Shut-Off\""
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bright-led-off"
											},
											{
 												"description",
												"sets Dimmer Level \"Bright & LED OFF\""
											}
										}
									},
									{
 										"DIM",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dim"
											},
											{
 												"description",
												"sets Dimmer Level Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dimmer Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"OSD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"setup"
							},
							{
 								"description",
								"Setup Operation Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"MENU",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"menu"
											},
											{
 												"description",
												"Menu Key              Setup Key"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"Up Key"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"Down Key"
											}
										}
									},
									{
 										"RIGHT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"Right Key"
											}
										}
									},
									{
 										"LEFT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"Left Key"
											}
										}
									},
									{
 										"ENTER",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"Enter Key"
											}
										}
									},
									{
 										"EXIT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"exit"
											},
											{
 												"description",
												"Exit Key"
											}
										}
									},
									{
 										"AUDIO",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"audio"
											},
											{
 												"description",
												"Audio Adjust Key"
											}
										}
									},
									{
 										"VIDEO",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video"
											},
											{
 												"description",
												"Video Adjust Key"
											}
										}
									},
									{
 										"HOME",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"home"
											},
											{
 												"description",
												"Home Key"
											}
										}
									},
									{
 										"QUICK",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"quick"
											},
											{
 												"description",
												"Quick Setup Key     Quick Menu Key/AV Adjust Key"
											}
										}
									},
									{
 										"IPV",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ipv"
											},
											{
 												"description",
												"Instaprevue Key"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MEM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"memory-setup"
							},
							{
 								"description",
								"Memory Setup Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"STR",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"str"
											},
											{
 												"description",
												"stores memory"
											}
										}
									},
									{
 										"RCL",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rcl"
											},
											{
 												"description",
												"recalls memory"
											}
										}
									},
									{
 										"LOCK",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"lock"
											},
											{
 												"description",
												"locks memory"
											}
										}
									},
									{
 										"UNLK",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"unlk"
											},
											{
 												"description",
												"unlocks memory"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RST",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"reset"
							},
							{
 								"description",
								"Reset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"ALL",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"all"
											},
											{
 												"description",
												"Reset All"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IFA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audio-information"
							},
							{
 								"description",
								"Audio Information Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"a..a,b..b,c…c,d..d,e…e,f…f,",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"a-a-b-b-c-c-d-d-e-e-f-f"
											},
											{
 												"description",
												"Infomation of Audio(Same Immediate Display \',\' is separator of infomations)\na...a" +
    ": Audio Input Port\nb…b: Input Signal Format\nc…c: Sampling Frequency\nd…d: Input S" +
    "ignal Channel\ne…e: Listening Mode\nf…f: Output Signal Channel"
											}
										}
									},
									{
 										"a..a,b..b,c…c,d..d,e…e,f…f,g…g,h…h,i…I,j…j,k…k",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"a-a-b-b-c-c-d-d-e-e-f-f-g-g-h-h-i-i-j-j"
											},
											{
 												"description",
												@"Information of Audio(Same Immediate Display ',' is separator of infomartions)
a...a: Audio Input Port
b…b: Input Signal Format
c…c: Sampling Frequency
d…d: Input Signal Channel
e…e: Listening Mode
f…f: Output Signal Channel
g…g: Output Sampling Frequency
h...h: PQLS (Off/2ch/Multich/Bitstream)
i...i: Auto Phase Control Current Delay (0ms - 16ms / ---)
j...j: Auto Phase Control Phase (Normal/Reverse)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Infomation of Audio"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IFV",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"video-information"
							},
							{
 								"description",
								"Video Information Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"a..a,b..b,c…c,d..d,e…e,f…f,g…g,h…h,i…i,",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"a-a-b-b-c-c-d-d-e-e-f-f-g-g-h-h-i-i"
											},
											{
 												"description",
												@"information of Video(Same Immediate Display ',' is separator of informations)
a…a: Video Input Port
b…b: Input Resolution, Frame Rate
c…c: RGB/YCbCr
d…d: Color Depth 
e…e: Video Output Port
f…f: Output Resolution, Frame Rate
g…g: RGB/YCbCr
h…h: Color Depth
i...i: Picture Mode"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Information of Video"
											}
										}
									}
								}
							}
						}
					},
					{
 						"FLD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"fl-display-information"
							},
							{
 								"description",
								"FL Display Information Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"{xx}{xx}{xx}{xx}{xx}x",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xx-xx-xx-xx-xx-x"
											},
											{
 												"description",
												"FL Display Information\nCharacter Code for FL Display (UTF-8 encoded)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets FL Display Information"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"input-selector"
							},
							{
 								"description",
								"Input Selector Command"
							},
							{
 								"aliases",
								new string[]
								{
									"source"
								}
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video1",
													"vcr",
													"dvr",
													"stb",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR, STB/DVR"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video3",
													"game/tv",
													"game",
													"game1"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME, GAME1"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video5",
													"aux2",
													"game2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2, GAME2"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video6",
													"pc"
												}
											},
											{
 												"description",
												"sets VIDEO6, PC"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"07"
											},
											{
 												"description",
												"Hidden1     EXTRA1"
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"08"
											},
											{
 												"description",
												"Hidden2     EXTRA2"
											}
										}
									},
									{
 										"09",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"09"
											},
											{
 												"description",
												"Hidden3     EXTRA3"
											}
										}
									},
									{
 										"10",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"dvd",
													"bd",
													"dvd"
												}
											},
											{
 												"description",
												"sets DVD, BD/DVD"
											}
										}
									},
									{
 										"11",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"strm-box"
											},
											{
 												"description",
												"sets STRM BOX"
											}
										}
									},
									{
 										"12",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tv"
											},
											{
 												"description",
												"sets TV"
											}
										}
									},
									{
 										"20",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"tape-1",
													"tv/tape"
												}
											},
											{
 												"description",
												"sets TAPE(1), TV/TAPE"
											}
										}
									},
									{
 										"21",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"cd",
													"tv/cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"2D",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"aiplay"
											},
											{
 												"description",
												"sets Aiplay"
											}
										}
									},
									{
 										"2E",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bluetooth"
											},
											{
 												"description",
												"sets Bluetooth"
											}
										}
									},
									{
 										"2F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb-dac-in"
											},
											{
 												"description",
												"sets USB DAC In"
											}
										}
									},
									{
 										"41",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"line"
											},
											{
 												"description",
												"sets LINE"
											}
										}
									},
									{
 										"42",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"line2"
											},
											{
 												"description",
												"sets LINE2"
											}
										}
									},
									{
 										"44",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"optical"
											},
											{
 												"description",
												"sets OPTICAL"
											}
										}
									},
									{
 										"45",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"coaxial"
											},
											{
 												"description",
												"sets COAXIAL"
											}
										}
									},
									{
 										"40",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"33",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dab"
											},
											{
 												"description",
												"sets DAB "
											}
										}
									},
									{
 										"55",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hdmi-5"
											},
											{
 												"description",
												"sets HDMI 5"
											}
										}
									},
									{
 										"56",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hdmi-6"
											},
											{
 												"description",
												"sets HDMI 6"
											}
										}
									},
									{
 										"57",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hdmi-7"
											},
											{
 												"description",
												"sets HDMI 7"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"recout-selector"
							},
							{
 								"description",
								"RECOUT Selector Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video1"
											},
											{
 												"description",
												"sets VIDEO1"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video2"
											},
											{
 												"description",
												"sets VIDEO2"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video3"
											},
											{
 												"description",
												"sets VIDEO3"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video4"
											},
											{
 												"description",
												"sets VIDEO4"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video5"
											},
											{
 												"description",
												"sets VIDEO5"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video6"
											},
											{
 												"description",
												"sets VIDEO6"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"10",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dvd"
											},
											{
 												"description",
												"sets DVD"
											}
										}
									},
									{
 										"20",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape"
											},
											{
 												"description",
												"sets TAPE(1)"
											}
										}
									},
									{
 										"21",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cd"
											},
											{
 												"description",
												"sets CD"
											}
										}
									},
									{
 										"24",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"music-server"
											},
											{
 												"description",
												"sets MUSIC SERVER"
											}
										}
									},
									{
 										"28",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"internet-radio"
											},
											{
 												"description",
												"sets INTERNET RADIO"
											}
										}
									},
									{
 										"30",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"7F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets OFF"
											}
										}
									},
									{
 										"80",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audio-selector"
							},
							{
 								"description",
								"Audio Selector Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets AUTO"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multi-channel"
											},
											{
 												"description",
												"sets MULTI-CHANNEL"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"analog"
											},
											{
 												"description",
												"sets ANALOG"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ilink"
											},
											{
 												"description",
												"sets iLINK"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hdmi"
											},
											{
 												"description",
												"sets HDMI"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"coax",
													"opt"
												}
											},
											{
 												"description",
												"sets COAX/OPT"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"balance"
											},
											{
 												"description",
												"sets BALANCE"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"arc"
											},
											{
 												"description",
												"sets ARC"
											}
										}
									},
									{
 										"0F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"none"
											},
											{
 												"description",
												"sets None"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audio Selector Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audio Selector Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TGA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"12v-trigger-a"
							},
							{
 								"description",
								"12V Trigger A Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets 12V Trigger A Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets 12V Trigger A On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets 12V Trigger A Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TGB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"12v-trigger-b"
							},
							{
 								"description",
								"12V Trigger B Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets 12V Trigger B Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets 12V Trigger B On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets 12V Trigger B Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TGC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"12v-trigger-c"
							},
							{
 								"description",
								"12V Trigger C Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets 12V Trigger C Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets 12V Trigger C On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets 12V Trigger C Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VOS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"video-output-selector"
							},
							{
 								"description",
								"Video Output Selector (Japanese Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"d4"
											},
											{
 												"description",
												"sets D4"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"component"
											},
											{
 												"description",
												"sets Component"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HDO",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hdmi-output-selector"
							},
							{
 								"description",
								"HDMI Output Selector"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"no",
													"analog"
												}
											},
											{
 												"description",
												"sets No, Analog"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"yes",
													"out"
												}
											},
											{
 												"description",
												"sets Yes/Out Main, HDMI Main, HDMI"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"out-sub",
													"sub",
													"hdbaset"
												}
											},
											{
 												"description",
												"sets Out Sub, HDMI Sub, HDBaseT"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"both",
													"sub"
												}
											},
											{
 												"description",
												"sets, Both, Main+Sub"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"both"
												}
											},
											{
 												"description",
												"sets, Both(Main)"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"both"
												}
											},
											{
 												"description",
												"sets, Both(Sub)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets HDMI Out Selector Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The HDMI Out Selector"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HAO",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hdmi-audio-out"
							},
							{
 								"description",
								"HDMI Audio Out (Main)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets On"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Auto"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets HDMI Audio Out Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HDMI Audio Out"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HAS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hdmi-audio-out-sub"
							},
							{
 								"description",
								"HDMI Audio Out (Sub)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets HDMI Audio Out Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HDMI Audio Out"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CEC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hdmi-cec"
							},
							{
 								"description",
								"HDMI CEC"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets HDMI CEC Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HDMI CEC"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CCM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hdmi-cec-control-monitor"
							},
							{
 								"description",
								"HDMI CEC Control Monitor"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"main"
											},
											{
 												"description",
												"sets Main"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"zone2"
											},
											{
 												"description",
												"sets Zone2"
											}
										}
									},
									{
 										"10",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sub"
											},
											{
 												"description",
												"sets Sub"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Control Monitor Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Control Monitor"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RES",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"monitor-out-resolution"
							},
							{
 								"description",
								"Monitor Out Resolution"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"through"
											},
											{
 												"description",
												"sets Through"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Auto(HDMI Output Only)"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"480p"
											},
											{
 												"description",
												"sets 480p"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"720p"
											},
											{
 												"description",
												"sets 720p"
											}
										}
									},
									{
 										"13",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1680x720p"
											},
											{
 												"description",
												"sets 1680x720p"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1080i"
											},
											{
 												"description",
												"sets 1080i"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1080p"
											},
											{
 												"description",
												"sets 1080p(HDMI Output Only)"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"1080p",
													"24fs"
												}
											},
											{
 												"description",
												"sets 1080p/24fs(HDMI Output Only)"
											}
										}
									},
									{
 										"15",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"2560x1080p"
											},
											{
 												"description",
												"sets 2560x1080p"
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4k-upcaling"
											},
											{
 												"description",
												"sets 4K Upcaling(HDMI Output Only) 4K(HDMI Output Only)"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets Source"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Monitor Out Resolution Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Monitor Out Resolution"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"super-resolution"
							},
							{
 								"description",
								"Super Resolution"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"3"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-0-3"
											},
											{
 												"description",
												"sets Super Resolution"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Super Resolution Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Super Resolution Wrap-Around DOWN"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Super Resolution State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HOI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hdmi-out-information"
							},
							{
 								"description",
								"HDMI Out Information"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"ab",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"a-1-for-zone-b-sub-0-none",
													"1-for-zone",
													"2-for-zone-2"
												}
											},
											{
 												"description",
												"sets HDMI Information\na:HDMI Out MAIN 1:for Main Zone\nb:HDMI Out SUB 0:None,1:for" +
    " Main Zone,2:for Zone 2"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The HDMI Out Information State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ISF",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"isf-mode"
							},
							{
 								"description",
								"ISF Mode"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"custom"
											},
											{
 												"description",
												"sets ISF Mode Custom"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"day"
											},
											{
 												"description",
												"sets ISF Mode Day"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"night"
											},
											{
 												"description",
												"sets ISF Mode Night"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets ISF Mode State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The ISF Mode State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VWM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"video-wide-mode"
							},
							{
 								"description",
								"Video Wide Mode"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Auto"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4-3"
											},
											{
 												"description",
												"sets 4:3"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"full"
											},
											{
 												"description",
												"sets Full"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"zoom"
											},
											{
 												"description",
												"sets Zoom"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"zoom"
											},
											{
 												"description",
												"sets Wide Zoom"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"smart-zoom"
											},
											{
 												"description",
												"sets Smart Zoom"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Video Zoom Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Video Zoom Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VPM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"video-picture-mode"
							},
							{
 								"description",
								"Video Picture Mode"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"through",
													"standard"
												}
											},
											{
 												"description",
												"sets Through, Standard"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"custom"
											},
											{
 												"description",
												"sets Custom"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cinema"
											},
											{
 												"description",
												"sets Cinema"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"game"
											},
											{
 												"description",
												"sets Game"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"isf-day"
											},
											{
 												"description",
												"sets ISF Day"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"isf-night"
											},
											{
 												"description",
												"sets ISF Night"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"streaming"
											},
											{
 												"description",
												"sets Streaming"
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"direct",
													"bypass"
												}
											},
											{
 												"description",
												"sets Direct, Bypass"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Video Zoom Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Video Zoom Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LMD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"listening-mode"
							},
							{
 								"description",
								"Listening Mode Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stereo"
											},
											{
 												"description",
												"sets STEREO"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"sets DIRECT"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"surround"
											},
											{
 												"description",
												"sets SURROUND"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"film",
													"game-rpg"
												}
											},
											{
 												"description",
												"sets FILM, Game-RPG"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"thx"
											},
											{
 												"description",
												"sets THX"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"action",
													"game-action"
												}
											},
											{
 												"description",
												"sets ACTION, Game-Action"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"musical",
													"game-rock"
												}
											},
											{
 												"description",
												"sets MUSICAL, Game-Rock"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mono-movie"
											},
											{
 												"description",
												"sets MONO MOVIE"
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"orchestra"
											},
											{
 												"description",
												"sets ORCHESTRA"
											}
										}
									},
									{
 										"09",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"unplugged"
											},
											{
 												"description",
												"sets UNPLUGGED"
											}
										}
									},
									{
 										"0A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"studio-mix"
											},
											{
 												"description",
												"sets STUDIO-MIX"
											}
										}
									},
									{
 										"0B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tv-logic"
											},
											{
 												"description",
												"sets TV LOGIC"
											}
										}
									},
									{
 										"0C",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"all-ch-stereo"
											},
											{
 												"description",
												"sets ALL CH STEREO"
											}
										}
									},
									{
 										"0D",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"theater-dimensional"
											},
											{
 												"description",
												"sets THEATER-DIMENSIONAL"
											}
										}
									},
									{
 										"0E",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"enhanced-7",
													"enhance",
													"game-sports"
												}
											},
											{
 												"description",
												"sets ENHANCED 7/ENHANCE, Game-Sports"
											}
										}
									},
									{
 										"0F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mono"
											},
											{
 												"description",
												"sets MONO"
											}
										}
									},
									{
 										"11",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pure-audio"
											},
											{
 												"description",
												"sets PURE AUDIO"
											}
										}
									},
									{
 										"12",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multiplex"
											},
											{
 												"description",
												"sets MULTIPLEX"
											}
										}
									},
									{
 										"13",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"full-mono"
											},
											{
 												"description",
												"sets FULL MONO"
											}
										}
									},
									{
 										"14",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"dolby-virtual",
													"surround-enhancer"
												}
											},
											{
 												"description",
												"sets DOLBY VIRTUAL / Surround Enhancer"
											}
										}
									},
									{
 										"15",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dts-surround-sensation"
											},
											{
 												"description",
												"sets DTS Surround Sensation"
											}
										}
									},
									{
 										"16",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"audyssey-dsx"
											},
											{
 												"description",
												"sets Audyssey DSX"
											}
										}
									},
									{
 										"1F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"whole-house"
											},
											{
 												"description",
												"sets Whole House Mode"
											}
										}
									},
									{
 										"23",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stage"
											},
											{
 												"description",
												"sets Stage (when Genre Control is Enable in Japan Model)"
											}
										}
									},
									{
 										"25",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"action"
											},
											{
 												"description",
												"sets Action (when Genre Control is Enable in Japan Model)"
											}
										}
									},
									{
 										"26",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"music"
											},
											{
 												"description",
												"sets Music (when Genre Contorl is Enable in Japan Model)"
											}
										}
									},
									{
 										"2E",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sports"
											},
											{
 												"description",
												"sets Sports (when Genre Control is Enable in Japan Model)"
											}
										}
									},
									{
 										"40",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"straight-decode"
											},
											{
 												"description",
												"sets Straight Decode"
											}
										}
									},
									{
 										"41",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dolby-ex"
											},
											{
 												"description",
												"sets Dolby EX"
											}
										}
									},
									{
 										"42",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"thx-cinema"
											},
											{
 												"description",
												"sets THX Cinema"
											}
										}
									},
									{
 										"43",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"thx-surround-ex"
											},
											{
 												"description",
												"sets THX Surround EX"
											}
										}
									},
									{
 										"44",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"thx-music"
											},
											{
 												"description",
												"sets THX Music"
											}
										}
									},
									{
 										"45",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"thx-games"
											},
											{
 												"description",
												"sets THX Games"
											}
										}
									},
									{
 										"50",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"thx-u2",
													"s2",
													"i",
													"s-cinema",
													"cinema2"
												}
											},
											{
 												"description",
												"sets THX U2/S2/I/S Cinema/Cinema2"
											}
										}
									},
									{
 										"51",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"thx-musicmode",
													"thx-u2",
													"s2",
													"i",
													"s-music"
												}
											},
											{
 												"description",
												"sets THX MusicMode,THX U2/S2/I/S Music"
											}
										}
									},
									{
 										"52",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"thx-games",
													"thx-u2",
													"s2",
													"i",
													"s-games"
												}
											},
											{
 												"description",
												"sets THX Games Mode,THX U2/S2/I/S Games"
											}
										}
									},
									{
 										"80",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"plii",
													"pliix-movie",
													"dolby-atmos",
													"dolby-surround"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx Movie, Dolby Atmos/Dolby Surround"
											}
										}
									},
									{
 										"81",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"plii",
													"pliix-music"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx Music"
											}
										}
									},
									{
 										"82",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"neo-6-cinema",
													"neo-x-cinema",
													"dts-x",
													"neural-x"
												}
											},
											{
 												"description",
												"sets Neo:6 Cinema/Neo:X Cinema, DTS:X/Neural:X"
											}
										}
									},
									{
 										"83",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"neo-6-music",
													"neo-x-music"
												}
											},
											{
 												"description",
												"sets Neo:6 Music/Neo:X Music"
											}
										}
									},
									{
 										"84",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"plii",
													"pliix-thx-cinema",
													"dolby-surround-thx-cinema"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx THX Cinema, Dolby Surround THX Cinema"
											}
										}
									},
									{
 										"85",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"neo-6",
													"neo-x-thx-cinema",
													"dts-neural-x-thx-cinema"
												}
											},
											{
 												"description",
												"sets Neo:6/Neo:X THX Cinema, DTS Neural:X THX Cinema"
											}
										}
									},
									{
 										"86",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"plii",
													"pliix-game"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx Game"
											}
										}
									},
									{
 										"87",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neural-surr"
											},
											{
 												"description",
												"sets Neural Surr"
											}
										}
									},
									{
 										"88",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"neural-thx",
													"neural-surround"
												}
											},
											{
 												"description",
												"sets Neural THX/Neural Surround"
											}
										}
									},
									{
 										"89",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"plii",
													"pliix-thx-games",
													"dolby-surround-thx-games"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx THX Games, Dolby Surround THX Games"
											}
										}
									},
									{
 										"8A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"neo-6",
													"neo-x-thx-games",
													"dts-neural-x-thx-games"
												}
											},
											{
 												"description",
												"sets Neo:6/Neo:X THX Games, DTS Neural:X THX Games"
											}
										}
									},
									{
 										"8B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"plii",
													"pliix-thx-music",
													"dolby-surround-thx-music"
												}
											},
											{
 												"description",
												"sets PLII/PLIIx THX Music, Dolby Surround THX Music"
											}
										}
									},
									{
 										"8C",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"neo-6",
													"neo-x-thx-music",
													"dts-neural-x-thx-music"
												}
											},
											{
 												"description",
												"sets Neo:6/Neo:X THX Music, DTS Neural:X THX Music"
											}
										}
									},
									{
 										"8D",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neural-thx-cinema"
											},
											{
 												"description",
												"sets Neural THX Cinema"
											}
										}
									},
									{
 										"8E",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neural-thx-music"
											},
											{
 												"description",
												"sets Neural THX Music"
											}
										}
									},
									{
 										"8F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neural-thx-games"
											},
											{
 												"description",
												"sets Neural THX Games"
											}
										}
									},
									{
 										"90",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pliiz-height"
											},
											{
 												"description",
												"sets PLIIz Height"
											}
										}
									},
									{
 										"91",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neo-6-cinema-dts-surround-sensation"
											},
											{
 												"description",
												"sets Neo:6 Cinema DTS Surround Sensation"
											}
										}
									},
									{
 										"92",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neo-6-music-dts-surround-sensation"
											},
											{
 												"description",
												"sets Neo:6 Music DTS Surround Sensation"
											}
										}
									},
									{
 										"93",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neural-digital-music"
											},
											{
 												"description",
												"sets Neural Digital Music"
											}
										}
									},
									{
 										"94",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pliiz-height-thx-cinema"
											},
											{
 												"description",
												"sets PLIIz Height + THX Cinema"
											}
										}
									},
									{
 										"95",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pliiz-height-thx-music"
											},
											{
 												"description",
												"sets PLIIz Height + THX Music"
											}
										}
									},
									{
 										"96",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pliiz-height-thx-games"
											},
											{
 												"description",
												"sets PLIIz Height + THX Games"
											}
										}
									},
									{
 										"97",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"pliiz-height-thx-u2",
													"s2-cinema"
												}
											},
											{
 												"description",
												"sets PLIIz Height + THX U2/S2 Cinema"
											}
										}
									},
									{
 										"98",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"pliiz-height-thx-u2",
													"s2-music"
												}
											},
											{
 												"description",
												"sets PLIIz Height + THX U2/S2 Music"
											}
										}
									},
									{
 										"99",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"pliiz-height-thx-u2",
													"s2-games"
												}
											},
											{
 												"description",
												"sets PLIIz Height + THX U2/S2 Games"
											}
										}
									},
									{
 										"9A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neo-x-game"
											},
											{
 												"description",
												"sets Neo:X Game"
											}
										}
									},
									{
 										"A0",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"pliix",
													"plii-movie-audyssey-dsx"
												}
											},
											{
 												"description",
												"sets PLIIx/PLII Movie + Audyssey DSX"
											}
										}
									},
									{
 										"A1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"pliix",
													"plii-music-audyssey-dsx"
												}
											},
											{
 												"description",
												"sets PLIIx/PLII Music + Audyssey DSX"
											}
										}
									},
									{
 										"A2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"pliix",
													"plii-game-audyssey-dsx"
												}
											},
											{
 												"description",
												"sets PLIIx/PLII Game + Audyssey DSX"
											}
										}
									},
									{
 										"A3",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neo-6-cinema-audyssey-dsx"
											},
											{
 												"description",
												"sets Neo:6 Cinema + Audyssey DSX"
											}
										}
									},
									{
 										"A4",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neo-6-music-audyssey-dsx"
											},
											{
 												"description",
												"sets Neo:6 Music + Audyssey DSX"
											}
										}
									},
									{
 										"A5",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neural-surround-audyssey-dsx"
											},
											{
 												"description",
												"sets Neural Surround + Audyssey DSX"
											}
										}
									},
									{
 										"A6",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"neural-digital-music-audyssey-dsx"
											},
											{
 												"description",
												"sets Neural Digital Music + Audyssey DSX"
											}
										}
									},
									{
 										"A7",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dolby-ex-audyssey-dsx"
											},
											{
 												"description",
												"sets Dolby EX + Audyssey DSX"
											}
										}
									},
									{
 										"FF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto-surround"
											},
											{
 												"description",
												"sets Auto Surround"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Down"
											}
										}
									},
									{
 										"MOVIE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"movie"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"MUSIC",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"music"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"GAME",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"game"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"THX",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"thx"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"AUTO",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"SURR",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"surr"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"STEREO",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ster"
											},
											{
 												"description",
												"sets Listening Mode Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Listening Mode"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DIR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"direct"
							},
							{
 								"description",
								"Direct Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Direct Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Direct Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LTN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"late-night"
							},
							{
 								"description",
								"Late Night Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Late Night Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"low-dolbydigital",
													"on-dolby-truehd"
												}
											},
											{
 												"description",
												"sets Late Night Low@DolbyDigital,On@Dolby TrueHD"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"high-dolbydigital"
												}
											},
											{
 												"description",
												"sets Late Night High@DolbyDigital,(On@Dolby TrueHD)"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto-dolby-truehd"
											},
											{
 												"description",
												"sets Late Night Auto@Dolby TrueHD"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Late Night State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Late Night Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RAS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"cinema-filter"
							},
							{
 								"description",
								"Cinema Filter Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Cinema Filter Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Cinema Filter On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Cinema Filter State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Cinema Filter State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ADY",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audyssey-2eq-multeq-multeq-xt"
							},
							{
 								"description",
								"Audyssey 2EQ/MultEQ/MultEQ XT"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"off"
												}
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"on",
													"movie"
												}
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT On/Movie"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"music"
												}
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT Music"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audyssey 2EQ/MultEQ/MultEQ XT State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audyssey 2EQ/MultEQ/MultEQ XT State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ADQ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audyssey-dynamic-eq"
							},
							{
 								"description",
								"Audyssey Dynamic EQ"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Audyssey Dynamic EQ Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Audyssey Dynamic EQ On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audyssey Dynamic EQ State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audyssey Dynamic EQ State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ADV",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audyssey-dynamic-volume"
							},
							{
 								"description",
								"Audyssey Dynamic Volume"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"light"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Light"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"medium"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Medium"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"heavy"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume Heavy"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audyssey Dynamic Volume State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audyssey Dynamic Volume State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DVL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"dolby-volume"
							},
							{
 								"description",
								"Dolby Volume"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Dolby Volume Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"low",
													"on"
												}
											},
											{
 												"description",
												"sets Dolby Volume Low/On"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mid"
											},
											{
 												"description",
												"sets Dolby Volume Mid"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"high"
											},
											{
 												"description",
												"sets Dolby Volume High"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Dolby Volume State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dolby Volume State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"AEQ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"accueq"
							},
							{
 								"description",
								"AccuEQ"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets AccuEQ Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"on",
													"on"
												}
											},
											{
 												"description",
												"sets AccuEQ On, On(All Ch)"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"on"
												}
											},
											{
 												"description",
												"sets AccuEQ, On(ex. Front L/R)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets AccuEQ State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The AccuEQ State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MCM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"mcacc-eq"
							},
							{
 								"description",
								"MCACC EQ"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory-1"
											},
											{
 												"description",
												"sets MCACC MEMORY 1"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory-2"
											},
											{
 												"description",
												"sets MCACC MEMORY 2"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory-3"
											},
											{
 												"description",
												"sets MCACC MEMORY 3"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory-4"
											},
											{
 												"description",
												"sets MCACC MEMORY 4"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory-5"
											},
											{
 												"description",
												"sets MCACC MEMORY 5"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory-6"
											},
											{
 												"description",
												"sets MCACC MEMORY 6"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets MCACC MEMORY Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets MCACC MEMORY Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The MCACC MEMORY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"EQS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"equalizer-select"
							},
							{
 								"description",
								"Equalizer Select(O/I:Equalizer, P:Manual EQ Select)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Equalizer Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"preset-1"
											},
											{
 												"description",
												"sets Equalizer Preset 1"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"preset-2"
											},
											{
 												"description",
												"sets Equalizer Preset 2"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"preset-3"
											},
											{
 												"description",
												"sets Equalizer Preset 3"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Equalizer Preset Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Equalizer Preset Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Equalizer Preset"
											}
										}
									}
								}
							}
						}
					},
					{
 						"STW",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"eq-for-standing-wave-standing-wave"
							},
							{
 								"description",
								"EQ for Standing Wave / Standing Wave"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Standing Wave Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Standing Wave On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Standing Wave Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Standing Wave"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PCT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"phase-control"
							},
							{
 								"description",
								"Phase Control"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Phase Control Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Phase Control On"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"full-band-on"
											},
											{
 												"description",
												"sets Full Band Phase Control On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Phase Control Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Phase Control"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PCP",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"phase-control-plus"
							},
							{
 								"description",
								"Phase Control Plus"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"16"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"0msec-16msec"
											},
											{
 												"description",
												"sets Phase Control Plus 0msec - 16msec"
											}
										}
									},
									{
 										"AT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Auto Phase Control Plus"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Phase Control Plus Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Phase Control Plus Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Phase Control Plus"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LFE",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"lfe-level-lfe-mute-level"
							},
							{
 								"description",
								"LFE Level / LFE Mute Level"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"xx",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"00-0db-01-1db-02-2db-03-3db-04-4db-05-5db-0a-10db-0f-15db-14-20db-ff-oodb"
											},
											{
 												"description",
												"sets LFE Mute Level\n00:0dB\n01:-1dB\n02:-2dB\n03:-3dB\n04:-4dB\n05:-5dB\n0A:-10dB\n0F:-1" +
    "5dB\n14:-20dB\nFF:-oodB"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets LFE Mute Level Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets LFE Mute Level Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The LFE Mute Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ACE",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"all-channel-eq-for-temporary-value"
							},
							{
 								"description",
								"All Channel EQ for Temporary Value"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"aaabbbcccdddeeefffggghhhiii",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"eq"
											},
											{
 												"description",
												"sets All Channel EQ for Temporary Value\nxxx=-18(-12.0dB)~000(0.0dB)~+18(+12.0dB)\n" +
    "\naaa:63Hz\nbbb:125Hz\nccc:250Hz\nddd:500Hz\neee:1kHz\nfff:2kHz\nggg:4kHz\nhhh:8kHz\niii:" +
    "16kHz"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Phase Control"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MCC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"mcacc-calibration"
							},
							{
 								"description",
								"MCACC Calibration"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"00"
											},
											{
 												"description",
												"not complete MCACC calibration"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"01"
											},
											{
 												"description",
												"complete MCACC calibration"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The MCACC calibration"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MFB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"fullband-mcacc-calibration"
							},
							{
 								"description",
								"Fullband MCACC Calibration"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"00"
											},
											{
 												"description",
												"not complete Fullband MCACC calibration or\nnot have Fullband MCACC function"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"01"
											},
											{
 												"description",
												"complete Fullband MCACC calibration"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Fullband MCACC calibration"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MOT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"music-optimizer-sound-retriever"
							},
							{
 								"description",
								"Music Optimizer / Sound Retriever"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Music Optimizer Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Music Optimizer On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Music Optimizer State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Music Optimizer State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"AVS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"a-v-sync"
							},
							{
 								"description",
								"A/V Sync"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"snnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"offset"
											},
											{
 												"description",
												"sets A/V Sync\n s: sign ( \"+\" or \"-\" or \"0\")\n If set minus value, s=\"-\". (only HDM" +
    "I Lipsync is available)\n If set plus value, s=\"+\"\n If set zero value, s=\"0\"\nnnn " +
    ": value; If set 100msec, nnn=\"100\""
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"is-increased"
												}
											},
											{
 												"description",
												"sets A/V Sync is increased (step is depend on model)"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"is-decreased"
												}
											},
											{
 												"description",
												"sets A/V Sync is decreased (step is depend on model)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets A/V Sync Value"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ASC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audio-scalar"
							},
							{
 								"description",
								"Audio Scalar"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Audio Scalar Auto"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"manual"
											},
											{
 												"description",
												"sets Audio Scalar Manual"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audio Scalar Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audio Scalar State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UPS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"upsampling"
							},
							{
 								"description",
								"Upsampling"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"x1"
											},
											{
 												"description",
												"sets Upsampling x1"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"x2"
											},
											{
 												"description",
												"sets Upsampling x2"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"x4"
											},
											{
 												"description",
												"sets Upsampling x4"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"x8"
											},
											{
 												"description",
												"sets Upsampling x8"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Upsampling Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Upscaling State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HBT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hi-bit"
							},
							{
 								"description",
								"Hi-Bit"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Hi-Bit Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Hi-Bit On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Hi-Bit Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Hi-Bit State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DGF",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"digital-filter"
							},
							{
 								"description",
								"Digital Filter"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"slow"
											},
											{
 												"description",
												"sets Digital Filter Slow"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sharp"
											},
											{
 												"description",
												"sets Digital Filter Sharp"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"short"
											},
											{
 												"description",
												"sets Digital Filter Short"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Digital Filter Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Digital Filter State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LRA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"lock-range-adjust"
							},
							{
 								"description",
								"Lock Range Adjust"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"7"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-7"
											},
											{
 												"description",
												"sets Lock Range Adjust"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Lock Range Adjust Up"
											}
										}
									},
									{
 										"Down",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Lock Range Adjust Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Lock Range Adjust State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PBS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"p-bass"
							},
							{
 								"description",
								"P.BASS"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets P.BASS Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets P.BASS On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets P.BASS Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The P.BASS State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SBS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"s-bass"
							},
							{
 								"description",
								"S.BASS"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets S.BASS Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets S.BASS On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets S.BASS Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The S.BASS State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"screen-centered-dialog-dialog-enahncement"
							},
							{
 								"description",
								"Screen Centered Dialog / Dialog Enahncement"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enhancement-off"
											},
											{
 												"description",
												"sets Dialog Enhancement Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enhancement-on"
											},
											{
 												"description",
												"sets Dialog Enhancement On"
											}
										}
									},
									{
 										new string[]
										{
											"2",
											"5"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up1-up4"
											},
											{
 												"description",
												"sets Dialog Enahncement UP1-UP4"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Dialog Enhancement Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dialog Enhancement State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CTS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"center-spread-for-dolby-surround"
							},
							{
 								"description",
								"Center Spread for Dolby Surround"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"center-off"
											},
											{
 												"description",
												"sets Center Spread Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"center-on"
											},
											{
 												"description",
												"sets Center Spread On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Center Spread Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Center Spread State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PNR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"panorama-for-plii-music"
							},
							{
 								"description",
								"Panorama for PLII Music"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Panorama Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Panorama On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Panorama Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Panorama State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DMS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"dimension-for-plii-music"
							},
							{
 								"description",
								"Dimension for PLII Music"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"-3",
											"3"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no--3-3"
											},
											{
 												"description",
												"sets Dimension"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Dimension Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Dimension Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dimension State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CTW",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"center-width-for-plii-music"
							},
							{
 								"description",
								"Center Width for PLII Music"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"7"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-0-7"
											},
											{
 												"description",
												"sets Center Width"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Center Width Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Center Width Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Center Width State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CTI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"center-image-for-neo-6-music"
							},
							{
 								"description",
								"Center Image for Neo:6 Music"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"10"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"sets Center Image"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Center Image Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Center Image Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Center Image State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DLC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"dialog-control"
							},
							{
 								"description",
								"Dialog Control"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"6"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-0-6"
											},
											{
 												"description",
												"sets Dialog Control"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Dialog Control Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Dialog Control Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dialog Control State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DCE",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"dialog-control-enabled"
							},
							{
 								"description",
								"Dialog Control Enabled"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"Dialog Control is disabled"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"Dialog Control is enabled"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Dialog Control Enabled State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"speaker-information"
							},
							{
 								"description",
								"Speaker Information"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"abcdefghhhijk",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"a-subwoofer-0-no",
													"1-yes",
													"1ch",
													"2-2ch-b-front-1-small",
													"2-large-c-center-0-none",
													"1-small",
													"2-lage-d-surround-0-none",
													"1-small",
													"2-lage-e-surround-back-0-none",
													"1-small",
													"2-lage-f-height-1-0-none",
													"1-small",
													"2-lage-g-height-2-0-none",
													"1-small",
													"2-lage-hhh-crossover-50",
													"80",
													"100",
													"150",
													"200-i-height-1-position-0-no",
													"1-fh",
													"2-tf",
													"3-tm",
													"4-tr",
													"5-rh",
													"6-dd-sp-f",
													"7-dd-sp-s",
													"8-dd-sp-b-j-height-2-position-0-no",
													"1-fh",
													"2-tf",
													"3-tm",
													"4-tr",
													"5-rh",
													"6-dd-sp-f",
													"7-dd-sp-s",
													"8-dd-sp-b-k-bi-amp-0-no",
													"1-f",
													"3-f-c",
													"5-f-s",
													"6-c-s",
													"7-f-c-s"
												}
											},
											{
 												"description",
												@"sets Speaker Information

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
k:Bi-Amp 0:No,1:F,3:F+C,5:F+S,6:C+S,7:F+C+S"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Speaker Information"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SPD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"speaker-distance"
							},
							{
 								"description",
								"Speaker Distance Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"Muaaabbbcccdddeeefffggghhhiiijjjkkklllmmm",
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												@"sets Speaker Distance
xxx=001-384 (0.01m - 9.00m unit is meters)
xxx=001-12C (0.1ft - 30.0ft unit is feet)
xxx=001-2D0 (0'0-1/2"" - 30'0"" unit is feet/inch)
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
mmm:Subwoofer 2"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker Distance"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DMN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"input-channel-multiplex-dual-mono"
							},
							{
 								"description",
								"Input Channel (Multiplex) / Dual Mono"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"main"
											},
											{
 												"description",
												"sets DUAL MONO MAIN"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sub"
											},
											{
 												"description",
												"sets DUAL MONO SUB"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"main-sub"
											},
											{
 												"description",
												"sets DUAL MONO MAIN+SUB"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Panorama Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Panorama State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LDM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"loudness-management"
							},
							{
 								"description",
								"Loudness Management"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Loudness Management Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Loudness management On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Panorama Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Panorama State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ITV",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"intellivolume-input-volume-absorber"
							},
							{
 								"description",
								"IntelliVolume / Input Volume Absorber"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"-24",
											"24"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"12-0db-0db-12-0db"
											},
											{
 												"description",
												"sets IntelliVolume -12.0dB~0dB~+12.0dB(0.5dB Step)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets IntelliVolume Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets IntelliVolume Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The IntelliVolume State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"IRN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"input-selector-rename-input-function-rename"
							},
							{
 								"description",
								"Input Selector Rename / Input Function Rename"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"iixxxxxxxxxx",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"name-10-characters-ii-number-the-same-as-for-sli-command-xxxxxxxxxx-name"
											},
											{
 												"description",
												"sets Input Selector Name (10 characters)\nii: Selector Number (the same as for SLI" +
    " command)\nxxxxxxxxxx: Name(Max 10 characters)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"FXP",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"pcm-fixed-mode-fixed-pcm-mode"
							},
							{
 								"description",
								"PCM Fixed Mode / Fixed PCM Mode"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets PCM Fixed Mode Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets PCM Fixed Mode On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets PCM Fixed Mode Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The PCM Fixed Mode State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HST",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hdmi-standby-through"
							},
							{
 								"description",
								"HDMI Standby Through"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"xx",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xx-sli-number"
											},
											{
 												"description",
												"sets HDMI Standby Through xx=SLI Number"
											}
										}
									},
									{
 										"OFF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets HDMI Standby Through Off"
											}
										}
									},
									{
 										"LAST",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"last"
											},
											{
 												"description",
												"sets HDMI Standby Through Last"
											}
										}
									},
									{
 										"AT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"throguh-auto"
											},
											{
 												"description",
												"sets HDMI Standby Throguh Auto"
											}
										}
									},
									{
 										"ATE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets HDMI Standby Through Auto(Eco)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets HDMI Standby Through Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The HDMI Standby Through State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PQL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"pqls"
							},
							{
 								"description",
								"PQLS"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets PQLS Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets PQLS On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets PQLS Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The PQLS State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ARC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"audio-return-channel"
							},
							{
 								"description",
								"Audio Return Channel"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Audio Return Channel Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets Audio Return Channel Auto"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Audio Return Channel Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Audio Return Channel State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LPS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"lip-sync-auto-delay"
							},
							{
 								"description",
								"Lip Sync / Auto Delay"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Lip Sync Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Lip Sync On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Lip Sync Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Lip Sync State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"APD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"auto-power-down"
							},
							{
 								"description",
								"Auto Power Down"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Auto Power Down Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Auto Power Down On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Auto Power Down Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Auto Power Down State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PAM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"pre-amp-mode-amp-mode"
							},
							{
 								"description",
								"Pre Amp Mode / AMP Mode"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Pre Amp Mode Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"front"
											},
											{
 												"description",
												"sets Pre Amp Mode Front"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"front-center"
											},
											{
 												"description",
												"sets Pre Amp Mode Front+Center"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"all"
											},
											{
 												"description",
												"sets Pre Amp Mode All"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Auto Power Down Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Auto Power Down State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ECO",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"for-smart-grid"
							},
							{
 								"description",
								"for Smart Grid Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"volume-1db-down-and-dimmer-level-dark"
											},
											{
 												"description",
												"sets Volume 1dB down and Dimmer Level \"Dark\""
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"volume-3db-down-and-dimmer-level-dark"
											},
											{
 												"description",
												"sets Volume 3dB down and Dimmer Level \"Dark\""
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"volume-6db-down-and-dimmer-level-dark"
											},
											{
 												"description",
												"sets Volume 6dB down and Dimmer Level \"Dark\""
											}
										}
									}
								}
							}
						}
					},
					{
 						"FWV",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"firmware-version"
							},
							{
 								"description",
								"Firmware Version"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"abce-fhik-lmno-qrtu",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"version"
											},
											{
 												"description",
												"sets Firmware Version"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Firmware Version State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"UPD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"update"
							},
							{
 								"description",
								"Update"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"NET",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"net"
											},
											{
 												"description",
												"start Device Update via Network"
											}
										}
									},
									{
 										"USB",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"start Device Update via USB"
											}
										}
									},
									{
 										"D**-nn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"d-nn"
											},
											{
 												"description",
												"nn Progress (%)\n**=DL Downloading\n**=NT Arm writng\n**=D1 DSP1\n**=D2 DSP2\n**=D3 DS" +
    "P3\n**=VM VMPU\n**=OS OSD\n**=MP MMPU"
											}
										}
									},
									{
 										"CMP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cmp"
											},
											{
 												"description",
												"Device Update is completed"
											}
										}
									},
									{
 										"E{xx}-yy",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"e-xx-yy"
											},
											{
 												"description",
												"xx=ErrorCode1\nyy=ErrorCode2"
											}
										}
									},
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"00"
											},
											{
 												"description",
												"not exist new firmware"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"01"
											},
											{
 												"description",
												"exist new firmware"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"force"
											},
											{
 												"description",
												"exist new firmware(force)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets exist new firmware"
											}
										}
									}
								}
							}
						}
					},
					{
 						"POP",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"popup-message"
							},
							{
 								"description",
								"Popup Message"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"t----<.....>",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t"
											},
											{
 												"description",
												"t -> message type \'X\' : XML\n---- -> reserved\n<.....> : XML data ( [CR] and [LF] a" +
    "re removed )"
											}
										}
									},
									{
 										"Ullt<.....>",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ullt"
											},
											{
 												"description",
												"U : UI Type\n 0 : List, 1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, 5 : Menu " +
    "List\nll -> number of layer (00-FF)\nt : Update Type\n 0 : All, 1 : Button, 2 : Tex" +
    "tbox, 3 : Listbox\n<.....> : XML data ( [CR] and [LF] are removed )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TPD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"temperature-data"
							},
							{
 								"description",
								"Temperature Data"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"-99-999",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"temp"
											},
											{
 												"description",
												@"The temperature Data(Fahrenheit and Celsius) 0 – 999
""F-99C-73"": -99 degree Fahrenheit / -73 degree Celsius
""F 32C  0"": 32 degree Fahrenheit / 0 degree Celsius
""F 41C  5"": 41 degree Fahrenheit / 5 degree Celsius
""F 50C 10"": 50 degree Fahrenheit / 10 degree Celsius
""F122C 50"": 122 degree Fahrenheit / 50 degree Celsius
""F212C100"": 212 degree Fahrenheit / 100 degree Celsius
""F302C150"": 302 degree Fahrenheit / 150 degree Celsius

Reference Information:
[TX-NR474/NR575E/8270/NR575/NR676/NR676E/RZ620/NR777/RZ720/RZ820, DTM-7, DRX-2.1/3.1/4.1/5.1 VSX-832/932/LX102/LX302]
 Yellow Zone: ""F150C 66"" or more & ""F210C 99"" or less
 Red Zone:"" F212C100"" or more
[TX-RZ920, DRX-7.1/R1.1, DRC-R1.1]
 Yellow Zone: ""F176C 80"" or more & ""F246C119"" or less
 Red Zone: ""F248C120"" or more"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Temperature Data"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command (Include Tuner Pack Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"freq-nnnnn"
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)\nput 0" +
    " in the first two digits of nnnnn at SR"
											}
										}
									},
									{
 										"BAND",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"band"
											},
											{
 												"description",
												"Change BAND"
											}
										}
									},
									{
 										"DIRECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"0",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command (Include Tuner Pack Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset-memory"
							},
							{
 								"description",
								"Preset Memory Command (Include Tuner Pack Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RDS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"rds-information"
							},
							{
 								"description",
								"RDS Information Command (RDS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"00"
											},
											{
 												"description",
												"Display RT Information"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"01"
											},
											{
 												"description",
												"Display PTY Information"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"02"
											},
											{
 												"description",
												"Display TP Information"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"Display RDS Information Wrap-Around Change"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PTS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"pty-scan"
							},
							{
 								"description",
								"PTY Scan Command (RDS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"29"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-29"
											},
											{
 												"description",
												"sets PTY No “1 - 29” ( In hexadecimal representation)"
											}
										}
									},
									{
 										"ENTER",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"Finish PTY Scan"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TPS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tp-scan"
							},
							{
 								"description",
								"TP Scan Command (RDS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"start"
											},
											{
 												"description",
												"Start TP Scan (When Don’t Have Parameter)"
											}
										}
									},
									{
 										"ENTER",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"finish"
											},
											{
 												"description",
												"Finish TP Scan"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XCN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"xm-channel-name-info"
							},
							{
 								"description",
								"XM Channel Name Info (XM Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"channel-name"
											},
											{
 												"description",
												"XM Channel Name"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Channel Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XAT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"xm-artist-name-info"
							},
							{
 								"description",
								"XM Artist Name Info (XM Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"artist-name"
											},
											{
 												"description",
												"XM Artist Name"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XTI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"xm-title-info"
							},
							{
 								"description",
								"XM Title Info (XM Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"title"
											},
											{
 												"description",
												"XM Title"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XCH",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"xm-channel-number"
							},
							{
 								"description",
								"XM Channel Number Command (XM Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"597"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"channel-no-0-597"
											},
											{
 												"description",
												"XM Channel Number  “000 - 255”"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets XM Channel Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets XM Channel Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Channel Number"
											}
										}
									}
								}
							}
						}
					},
					{
 						"XCT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"xm-category"
							},
							{
 								"description",
								"XM Category Command (XM Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"category-info"
											},
											{
 												"description",
												"XM Category Info"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets XM Category Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets XM Category Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets XM Category"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"sirius-channel-name-info"
							},
							{
 								"description",
								"SIRIUS Channel Name Info (SIRIUS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"channel-name"
											},
											{
 												"description",
												"SIRIUS Channel Name"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Channel Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SAT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"sirius-artist-name-info"
							},
							{
 								"description",
								"SIRIUS Artist Name Info (SIRIUS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"artist-name"
											},
											{
 												"description",
												"SIRIUS Artist Name"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"STI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"sirius-title-info"
							},
							{
 								"description",
								"SIRIUS Title Info (SIRIUS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"title"
											},
											{
 												"description",
												"SIRIUS Title"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCH",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"sirius-channel-number"
							},
							{
 								"description",
								"SIRIUS Channel Number Command (SIRIUS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"597"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"channel-no-0-597"
											},
											{
 												"description",
												"SIRIUS Channel Number  “000 - 255”"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets SIRIUS Channel Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets SIRIUS Channel Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Channel Number"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"sirius-category"
							},
							{
 								"description",
								"SIRIUS Category Command (SIRIUS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"category-info"
											},
											{
 												"description",
												"SIRIUS Category Info"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets SIRIUS Category Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets SIRIUS Category Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets SIRIUS Category"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLK",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"sirius-parental-lock"
							},
							{
 								"description",
								"SIRIUS Parental Lock Command (SIRIUS Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"password"
											},
											{
 												"description",
												"Lock Password (4Digits)"
											}
										}
									},
									{
 										"INPUT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"input"
											},
											{
 												"description",
												"displays \"Please input the Lock password\""
											}
										}
									},
									{
 										"WRONG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"wrong"
											},
											{
 												"description",
												"displays \"The Lock password is wrong\""
											}
										}
									}
								}
							}
						}
					},
					{
 						"HAT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hd-radio-artist-name-info"
							},
							{
 								"description",
								"HD Radio Artist Name Info (HD Radio Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"artist-name"
											},
											{
 												"description",
												"HD Radio Artist Name (variable-length, 64 digits max)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HCN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hd-radio-channel-name-info"
							},
							{
 								"description",
								"HD Radio Channel Name Info (HD Radio Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"channel-name"
											},
											{
 												"description",
												"HD Radio Channel Name (Station Name) (7 digits)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Channel Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HTI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hd-radio-title-info"
							},
							{
 								"description",
								"HD Radio Title Info (HD Radio Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"title"
											},
											{
 												"description",
												"HD Radio Title (variable-length, 64 digits max)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HDS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hd-radio-detail-info"
							},
							{
 								"description",
								"HD Radio Detail Info (HD Radio Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"info"
											},
											{
 												"description",
												"HD Radio Title"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HPR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hd-radio-channel-program"
							},
							{
 								"description",
								"HD Radio Channel Program Command (HD Radio Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"8"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"directly"
											},
											{
 												"description",
												"sets directly HD Radio Channel Program"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Channel Program"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HBL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hd-radio-blend-mode"
							},
							{
 								"description",
								"HD Radio Blend Mode Command (HD Radio Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"auto"
											},
											{
 												"description",
												"sets HD Radio Blend Mode \"Auto\""
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"analog"
											},
											{
 												"description",
												"sets HD Radio Blend Mode \"Analog\""
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the HD Radio Blend Mode Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"HTS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"hd-radio-tuner-status"
							},
							{
 								"description",
								"HD Radio Tuner Status (HD Radio Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"mmnnoo",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mmnnoo"
											},
											{
 												"description",
												"HD Radio Tuner Status (3 bytes)\nmm -> \"00\" not HD, \"01\" HD\nnn -> current Program " +
    "\"01\"-\"08\"\noo -> receivable Program (8 bits are represented in hexadecimal notati" +
    "on. Each bit shows receivable or not.)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the HD Radio Tuner Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"BCS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"battery-charge-status"
							},
							{
 								"description",
								"Battery Charge Status Command (Battery Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"charging"
											},
											{
 												"description",
												"charging"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"completed"
											},
											{
 												"description",
												"charge completed"
											}
										}
									},
									{
 										"10",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"low"
											},
											{
 												"description",
												"battery level Low"
											}
										}
									},
									{
 										"11",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"middle"
											},
											{
 												"description",
												"battery level Middle"
											}
										}
									},
									{
 										"12",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"high"
											},
											{
 												"description",
												"battery level High"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets battery charge status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CCD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"cd-player"
							},
							{
 								"description",
								"CD Player Operation Command  (Include CD Function Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY"
											}
										}
									},
									{
 										"STOP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP"
											}
										}
									},
									{
 										"PAUSE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE"
											}
										}
									},
									{
 										"SKIP.F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"next"
											},
											{
 												"description",
												">>I"
											}
										}
									},
									{
 										"SKIP.R",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"previous"
											},
											{
 												"description",
												"I<<"
											}
										}
									},
									{
 										"REPEAT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT"
											}
										}
									},
									{
 										"RANDOM",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CST",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"cd-play-status"
							},
							{
 								"description",
								"CD Play Status"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"prs",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"status"
											},
											{
 												"description",
												"CD Play Status (3 letters)\np -> Play Status: \"S\": STOP, \"P\": Play, \"p\": Pause, \"F" +
    "\": FF, \"R\": FR\nr -> Repeat Status: \"-\": Off, \"R\": All,  \"1\": Repeat 1\ns -> Shuff" +
    "le(Random) Status: \"-\": Off, \"S\": All"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets CD Play Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DST",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"current-disc-status-notice"
							},
							{
 								"description",
								"Current disc status notice"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"none"
											},
											{
 												"description",
												"No disc"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cd"
											},
											{
 												"description",
												"Audio CD"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mp3-cd"
											},
											{
 												"description",
												"MP3 CD"
											}
										}
									},
									{
 										"FF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"unknown"
											},
											{
 												"description",
												"Unknown"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Disc Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CFS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"current-folder-status-no"
							},
							{
 								"description",
								"Current Folder Status（No.）"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"153"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"folder-no-1-153"
											},
											{
 												"description",
												"Folder Number"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Folder Number Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CTM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"cd-time-info"
							},
							{
 								"description",
								"CD Time Info"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"mm:ss/mm:ss",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"time-mm-ss-mm-ss"
											},
											{
 												"description",
												"CD Time Info (Elapsed time/Track Time Max 99:59)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets CDTime Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SCE",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"set-cd-elapsed-time"
							},
							{
 								"description",
								"Set　CD Elapsed　Time"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"mm:ss",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"time-mm-ss"
											},
											{
 												"description",
												"Specified　Elapsed CD Time"
											}
										}
									}
								}
							}
						}
					},
					{
 						"DSN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"dab-station-name"
							},
							{
 								"description",
								"DAB Station Name"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"xx…xx",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"station-name"
											},
											{
 												"description",
												"xx…xx   : DAB Station Name (UTF-8)\n下記文字は特殊コードで送信する\n0x02  ： ←\n0x03  ： ↑\n0x04  ： →\n" +
    "0x05  ： ↓\n0x06  ： ║\n上記以外の0x00~0x1F、0x80~0xA0はスペース表示とする"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Station Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"CTV",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"ctv"
							},
							{
 								"description",
								"Control TV over HDMI-CEC"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"POWER",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"power"
											},
											{
 												"description",
												"Toggle Power State"
											}
										}
									},
									{
 										"PWRON",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"power-on"
											},
											{
 												"description",
												"Power On"
											}
										}
									},
									{
 										"PWROFF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"power-off"
											},
											{
 												"description",
												"Standby"
											}
										}
									},
									{
 										"CHUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chup"
											},
											{
 												"description",
												"CH Up"
											}
										}
									},
									{
 										"CHDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chdown"
											},
											{
 												"description",
												"CH Down"
											}
										}
									},
									{
 										"VLUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"volume-up"
											},
											{
 												"description",
												"Volume Up"
											}
										}
									},
									{
 										"VLDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"volume-down"
											},
											{
 												"description",
												"Volume Down"
											}
										}
									},
									{
 										"MUTE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mute"
											},
											{
 												"description",
												"Muting"
											}
										}
									},
									{
 										"DISP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"Display"
											}
										}
									},
									{
 										"INPUT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"input"
											},
											{
 												"description",
												"Input"
											}
										}
									},
									{
 										"1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1 command"
											}
										}
									},
									{
 										"2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2 command"
											}
										}
									},
									{
 										"3",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3 command"
											}
										}
									},
									{
 										"4",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4 command"
											}
										}
									},
									{
 										"5",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5 command"
											}
										}
									},
									{
 										"6",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6 command"
											}
										}
									},
									{
 										"7",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7 command"
											}
										}
									},
									{
 										"8",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8 command"
											}
										}
									},
									{
 										"9",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9 command"
											}
										}
									},
									{
 										"0",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"0"
											},
											{
 												"description",
												"0 command"
											}
										}
									},
									{
 										"CLEAR",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"clear"
											},
											{
 												"description",
												"Clear"
											}
										}
									},
									{
 										"SETUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"setup"
											},
											{
 												"description",
												"Setup"
											}
										}
									},
									{
 										"GUIDE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"guide"
											},
											{
 												"description",
												"Guide / Top Menu"
											}
										}
									},
									{
 										"PREV",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chprev"
											},
											{
 												"description",
												"Previous"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cursor-up"
											},
											{
 												"description",
												"Cursor Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cursor-down"
											},
											{
 												"description",
												"Cursor Down"
											}
										}
									},
									{
 										"LEFT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cursor-left"
											},
											{
 												"description",
												"Cursor Left"
											}
										}
									},
									{
 										"RIGHT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cursor-right"
											},
											{
 												"description",
												"Cursor Right"
											}
										}
									},
									{
 										"ENTER",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enter"
											},
											{
 												"description",
												"Enter"
											}
										}
									},
									{
 										"RETURN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"Return"
											}
										}
									},
									{
 										"A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"a"
											},
											{
 												"description",
												"A for CEC US:R,EU:R,JP:B"
											}
										}
									},
									{
 										"B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b"
											},
											{
 												"description",
												"B for CEC US:G,EU:G,JP:R"
											}
										}
									},
									{
 										"C",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"c"
											},
											{
 												"description",
												"C for CEC US:B,EU:Y,JP:G"
											}
										}
									},
									{
 										"D",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"d"
											},
											{
 												"description",
												"D for CEC US:Y,EU:B,JP:Y"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"zone2",
				new Dictionary<string, object>()
				{
					{
 						"ZPW",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"power"
							},
							{
 								"description",
								"Zone2 Power Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets Zone2 Standby"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone2 On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone2 Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZPA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"zone-2-a"
							},
							{
 								"description",
								"Zone 2 A Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"off"
												}
											},
											{
 												"description",
												"sets Zone 2 A Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"on"
												}
											},
											{
 												"description",
												"sets Zone 2 A On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZPB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"zone-2-b"
							},
							{
 								"description",
								"Zone 2 B Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"off"
												}
											},
											{
 												"description",
												"sets Zone 2 B Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"on"
												}
											},
											{
 												"description",
												"sets Zone 2 B On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Speaker State"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZMT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"muting"
							},
							{
 								"description",
								"Zone2 Muting Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Zone2 Muting Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone2 Muting On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Zone2 Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone2 Muting Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZVL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"volume"
							},
							{
 								"description",
								"Zone2 Volume Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"200"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0.0 – 100.0 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"100"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"vol-0-100"
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"80"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"UP1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-up-1db-step"
											},
											{
 												"description",
												"sets Volume Level Up 1dB Step"
											}
										}
									},
									{
 										"DOWN1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-down-1db-step"
											},
											{
 												"description",
												"sets Volume Level Down 1dB Step"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZTN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone"
							},
							{
 								"description",
								"Zone2 Tone Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-xx-is-a-00-a-10-0-10-1-step"
											},
											{
 												"description",
												"sets Zone2 Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 1 step]"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-xx-is-a-00-a-10-0-10-1-step"
											},
											{
 												"description",
												"sets Zone2 Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 1 step]"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Bass Up (1 Step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Bass Down (1 Step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Treble Up (1 Step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Treble Down (1 Step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone2 Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ZBL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"balance"
							},
							{
 								"description",
								"Zone2 Balance Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xx-is-a-00-a-l-10-0-r-10-1-step"
											},
											{
 												"description",
												"sets Zone2 Balance (xx is \"-A\"...\"00\"...\"+A\"[L+10...0...R+10 1 step]"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Balance Up (to R 1 Step)"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Balance Down (to L 1 Step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone2 Balance"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SLZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"selector"
							},
							{
 								"description",
								"ZONE2 Selector Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video1",
													"vcr",
													"dvr",
													"stb",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR, STB/DVR"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video3",
													"game/tv",
													"game",
													"game1"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME, GAME1"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video5",
													"aux2",
													"game2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2, GAME2"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video6",
													"pc"
												}
											},
											{
 												"description",
												"sets VIDEO6, PC"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden1",
													"extra1"
												}
											},
											{
 												"description",
												"sets Hidden1, EXTRA1"
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden2",
													"extra2"
												}
											},
											{
 												"description",
												"sets Hidden2, EXTRA2"
											}
										}
									},
									{
 										"09",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden3",
													"extra3"
												}
											},
											{
 												"description",
												"sets Hidden3, EXTRA3"
											}
										}
									},
									{
 										"10",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"dvd",
													"bd",
													"dvd"
												}
											},
											{
 												"description",
												"sets DVD, BD/DVD"
											}
										}
									},
									{
 										"11",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"strm-box"
											},
											{
 												"description",
												"sets STRM BOX"
											}
										}
									},
									{
 										"12",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tv"
											},
											{
 												"description",
												"sets TV"
											}
										}
									},
									{
 										"20",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape"
											},
											{
 												"description",
												"sets TAPE(1)"
											}
										}
									},
									{
 										"21",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"cd",
													"tv/cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"2D",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"airplay"
											},
											{
 												"description",
												"sets Airplay"
											}
										}
									},
									{
 										"2E",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bluetooth"
											},
											{
 												"description",
												"sets Bluetooth"
											}
										}
									},
									{
 										"40",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"33",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dab"
											},
											{
 												"description",
												"sets DAB "
											}
										}
									},
									{
 										"55",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hdmi-5"
											},
											{
 												"description",
												"sets HDMI 5"
											}
										}
									},
									{
 										"56",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hdmi-6"
											},
											{
 												"description",
												"sets HDMI 6"
											}
										}
									},
									{
 										"57",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hdmi-7"
											},
											{
 												"description",
												"sets HDMI 7"
											}
										}
									},
									{
 										"7F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets OFF"
											}
										}
									},
									{
 										"80",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"freq-nnnnn"
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / XM nnnnn ch)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"freq-nnnnn"
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)"
											}
										}
									},
									{
 										"DIRECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"BAND",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"band"
											},
											{
 												"description",
												"Change BAND"
											}
										}
									},
									{
 										"0",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Net-Tune Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAYz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"playz"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOPz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stopz"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSEz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pausez"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUPz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trupz"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDNz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trdnz"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Network Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"P/P",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"p-p"
											},
											{
 												"description",
												"PLAY / PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"CHUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chup"
											},
											{
 												"description",
												"CH UP(for iRadio)"
											}
										}
									},
									{
 										"CHDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chdn"
											},
											{
 												"description",
												"CH DOWN(for iRadio)"
											}
										}
									},
									{
 										"FF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REW",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REPEAT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RANDOM",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"REP/SHF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rep-shf"
											},
											{
 												"description",
												"REPEAT / SHUFFLE KEY"
											}
										}
									},
									{
 										"DISPLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"MEMORY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory"
											},
											{
 												"description",
												"MEMORY KEY"
											}
										}
									},
									{
 										"MODE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mode"
											},
											{
 												"description",
												"MODE KEY"
											}
										}
									},
									{
 										"RIGHT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"LEFT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"SELECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RETURN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY(for iPod 1wire)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NPZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command (Network Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LMZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"listening-mode"
							},
							{
 								"description",
								"Listening Mode Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stereo"
											},
											{
 												"description",
												"sets STEREO"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"sets DIRECT"
											}
										}
									},
									{
 										"0F",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mono"
											},
											{
 												"description",
												"sets MONO"
											}
										}
									},
									{
 										"12",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multiplex"
											},
											{
 												"description",
												"sets MULTIPLEX"
											}
										}
									},
									{
 										"87",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dvs"
											},
											{
 												"description",
												"sets DVS(Pl2)"
											}
										}
									},
									{
 										"88",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dvs"
											},
											{
 												"description",
												"sets DVS(NEO6)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"LTZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"late-night"
							},
							{
 								"description",
								"Late Night Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Late Night Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"low"
											},
											{
 												"description",
												"sets Late Night Low"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"high"
											},
											{
 												"description",
												"sets Late Night High"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Late Night State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Late Night Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"RAZ",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"re-eq-academy-filter"
							},
							{
 								"description",
								"Re-EQ/Academy Filter Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"both-off"
											},
											{
 												"description",
												"sets Both Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Re-EQ On"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Academy On"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Re-EQ/Academy State Wrap-Around Up"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Re-EQ/Academy State"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"zone3",
				new Dictionary<string, object>()
				{
					{
 						"PW3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"power"
							},
							{
 								"description",
								"Zone3 Power Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets Zone3 Standby"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone3 On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone3 Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MT3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"muting"
							},
							{
 								"description",
								"Zone3 Muting Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Zone3 Muting Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone3 Muting On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Zone3 Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone3 Muting Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VL3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"volume"
							},
							{
 								"description",
								"Zone3 Volume Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"200"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0.0 – 100.0 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"100"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"vol-0-100"
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"80"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"UP1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-up-1db-step"
											},
											{
 												"description",
												"sets Volume Level Up 1dB Step"
											}
										}
									},
									{
 										"DOWN1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-down-1db-step"
											},
											{
 												"description",
												"sets Volume Level Down 1dB Step"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TN3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tone"
							},
							{
 								"description",
								"Zone3 Tone Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"B{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"b-xx"
											},
											{
 												"description",
												"Zone3 Bass (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 1 step])"
											}
										}
									},
									{
 										"T{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t-xx"
											},
											{
 												"description",
												"Zone3 Treble (xx is \"-A\"...\"00\"...\"+A\"[-10...0...+10 1 step])"
											}
										}
									},
									{
 										"BUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-up"
											},
											{
 												"description",
												"sets Bass Up (1 Step)"
											}
										}
									},
									{
 										"BDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bass-down"
											},
											{
 												"description",
												"sets Bass Down (1 Step)"
											}
										}
									},
									{
 										"TUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-up"
											},
											{
 												"description",
												"sets Treble Up (1 Step)"
											}
										}
									},
									{
 										"TDOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"treble-down"
											},
											{
 												"description",
												"sets Treble Down (1 Step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone3 Tone (\"BxxTxx\")"
											}
										}
									}
								}
							}
						}
					},
					{
 						"BL3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"balance"
							},
							{
 								"description",
								"Zone3 Balance Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xx"
											},
											{
 												"description",
												"Zone3 Balance (xx is \"-A\"...\"00\"...\"+A\"[L+10...0...R+10 1 step])"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Balance Up (to R 1 Step)"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Balance Down (to L 1 Step)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Zone3 Balance"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SL3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"selector"
							},
							{
 								"description",
								"ZONE3 Selector Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video1",
													"vcr",
													"dvr",
													"stb",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR, STB/DVR"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video3",
													"game/tv",
													"game",
													"game1"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME, GAME1"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video5",
													"aux2",
													"game2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2, GAME2"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video6",
													"pc"
												}
											},
											{
 												"description",
												"sets VIDEO6, PC"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden1",
													"extra1"
												}
											},
											{
 												"description",
												"sets Hidden1, EXTRA1"
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden2",
													"extra2"
												}
											},
											{
 												"description",
												"sets Hidden2, EXTRA2"
											}
										}
									},
									{
 										"09",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden3",
													"extra3"
												}
											},
											{
 												"description",
												"sets Hidden3, EXTRA3"
											}
										}
									},
									{
 										"10",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dvd"
											},
											{
 												"description",
												"sets DVD"
											}
										}
									},
									{
 										"11",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"strm-box"
											},
											{
 												"description",
												"sets STRM BOX"
											}
										}
									},
									{
 										"12",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tv"
											},
											{
 												"description",
												"sets TV"
											}
										}
									},
									{
 										"20",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape"
											},
											{
 												"description",
												"sets TAPE(1)"
											}
										}
									},
									{
 										"21",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"cd",
													"tv/cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"2D",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"airplay"
											},
											{
 												"description",
												"sets Airplay"
											}
										}
									},
									{
 										"2E",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bluetooth"
											},
											{
 												"description",
												"sets Bluetooth"
											}
										}
									},
									{
 										"40",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"33",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dab"
											},
											{
 												"description",
												"sets DAB "
											}
										}
									},
									{
 										"80",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"freq-nnnnn"
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TU3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"freq-nnnnn"
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz / SR nnnnn ch)"
											}
										}
									},
									{
 										"BAND",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"band"
											},
											{
 												"description",
												"Change BAND"
											}
										}
									},
									{
 										"DIRECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"0",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PR3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Net-Tune Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAYz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"playz"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOPz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stopz"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSEz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pausez"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUPz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trupz"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDNz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trdnz"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NT3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Network Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"P/P",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"p-p"
											},
											{
 												"description",
												"PLAY / PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"CHUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chup"
											},
											{
 												"description",
												"CH UP(for iRadio)"
											}
										}
									},
									{
 										"CHDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chdn"
											},
											{
 												"description",
												"CH DOWNP(for iRadio)"
											}
										}
									},
									{
 										"FF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REW",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REPEAT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RANDOM",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"REP/SHF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rep-shf"
											},
											{
 												"description",
												"REPEAT / SHUFFLE KEY"
											}
										}
									},
									{
 										"DISPLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"MEMORY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory"
											},
											{
 												"description",
												"MEMORY KEY"
											}
										}
									},
									{
 										"RIGHT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"LEFT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"SELECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RETURN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY(for iPod 1wire)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NP3",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command (Network Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"zone4",
				new Dictionary<string, object>()
				{
					{
 						"PW4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"power"
							},
							{
 								"description",
								"Zone4 Power Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"standby"
											},
											{
 												"description",
												"sets Zone4 Standby"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone4 On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone4 Power Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"MT4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"muting"
							},
							{
 								"description",
								"Zone4 Muting Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Zone4 Muting Off"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Zone4 Muting On"
											}
										}
									},
									{
 										"TG",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"toggle"
											},
											{
 												"description",
												"sets Zone4 Muting Wrap-Around"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Zone4 Muting Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"VL4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"volume"
							},
							{
 								"description",
								"Zone4 Volume Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"0",
											"100"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"vol-0-100"
											},
											{
 												"description",
												"Volume Level 0 – 100 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"0",
											"80"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"Volume Level 0 – 80 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-up"
											},
											{
 												"description",
												"sets Volume Level Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"level-down"
											},
											{
 												"description",
												"sets Volume Level Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Volume Level"
											}
										}
									}
								}
							}
						}
					},
					{
 						"SL4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"selector"
							},
							{
 								"description",
								"ZONE4 Selector Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"00",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video1",
													"vcr",
													"dvr",
													"stb",
													"dvr"
												}
											},
											{
 												"description",
												"sets VIDEO1, VCR/DVR, STB/DVR"
											}
										}
									},
									{
 										"01",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video2",
													"cbl",
													"sat"
												}
											},
											{
 												"description",
												"sets VIDEO2, CBL/SAT"
											}
										}
									},
									{
 										"02",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video3",
													"game/tv",
													"game",
													"game1"
												}
											},
											{
 												"description",
												"sets VIDEO3, GAME/TV, GAME, GAME1"
											}
										}
									},
									{
 										"03",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video4",
													"aux1"
												}
											},
											{
 												"description",
												"sets VIDEO4, AUX1(AUX)"
											}
										}
									},
									{
 										"04",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video5",
													"aux2",
													"game2"
												}
											},
											{
 												"description",
												"sets VIDEO5, AUX2, GAME2"
											}
										}
									},
									{
 										"05",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"video6",
													"pc"
												}
											},
											{
 												"description",
												"sets VIDEO6, PC"
											}
										}
									},
									{
 										"06",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"video7"
											},
											{
 												"description",
												"sets VIDEO7"
											}
										}
									},
									{
 										"07",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden1",
													"extra1"
												}
											},
											{
 												"description",
												"sets Hidden1, EXTRA1"
											}
										}
									},
									{
 										"08",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden2",
													"extra2"
												}
											},
											{
 												"description",
												"sets Hidden2, EXTRA2"
											}
										}
									},
									{
 										"09",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"hidden3",
													"extra3"
												}
											},
											{
 												"description",
												"sets Hidden3, EXTRA3"
											}
										}
									},
									{
 										"10",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"dvd",
													"bd",
													"dvd"
												}
											},
											{
 												"description",
												"sets DVD, BD/DVD"
											}
										}
									},
									{
 										"20",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"tape-1",
													"tv/tape"
												}
											},
											{
 												"description",
												"sets TAPE(1), TV/TAPE"
											}
										}
									},
									{
 										"21",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tape2"
											},
											{
 												"description",
												"sets TAPE2"
											}
										}
									},
									{
 										"22",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"phono"
											},
											{
 												"description",
												"sets PHONO"
											}
										}
									},
									{
 										"23",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"cd",
													"tv/cd"
												}
											},
											{
 												"description",
												"sets CD, TV/CD"
											}
										}
									},
									{
 										"24",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"fm"
											},
											{
 												"description",
												"sets FM"
											}
										}
									},
									{
 										"25",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"am"
											},
											{
 												"description",
												"sets AM"
											}
										}
									},
									{
 										"26",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tuner"
											},
											{
 												"description",
												"sets TUNER"
											}
										}
									},
									{
 										"27",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"music-server",
													"p4s",
													"dlna"
												}
											},
											{
 												"description",
												"sets MUSIC SERVER, P4S, DLNA"
											}
										}
									},
									{
 										"28",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"internet-radio",
													"iradio-favorite"
												}
											},
											{
 												"description",
												"sets INTERNET RADIO, iRadio Favorite"
											}
										}
									},
									{
 										"29",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"usb",
													"usb"
												}
											},
											{
 												"description",
												"sets USB/USB(Front)"
											}
										}
									},
									{
 										"2A",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(Rear)"
											}
										}
									},
									{
 										"2B",
										new Dictionary<string, object>()
										{
											{
 												"name",
												new string[]
												{
													"network",
													"net"
												}
											},
											{
 												"description",
												"sets NETWORK, NET"
											}
										}
									},
									{
 										"2C",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"usb"
											},
											{
 												"description",
												"sets USB(toggle)"
											}
										}
									},
									{
 										"2D",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"airplay"
											},
											{
 												"description",
												"sets Airplay"
											}
										}
									},
									{
 										"2E",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"bluetooth"
											},
											{
 												"description",
												"sets Bluetooth"
											}
										}
									},
									{
 										"40",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"universal-port"
											},
											{
 												"description",
												"sets Universal PORT"
											}
										}
									},
									{
 										"30",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"multi-ch"
											},
											{
 												"description",
												"sets MULTI CH"
											}
										}
									},
									{
 										"31",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xm"
											},
											{
 												"description",
												"sets XM"
											}
										}
									},
									{
 										"32",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"sirius"
											},
											{
 												"description",
												"sets SIRIUS"
											}
										}
									},
									{
 										"33",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"dab"
											},
											{
 												"description",
												"sets DAB "
											}
										}
									},
									{
 										"80",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"source"
											},
											{
 												"description",
												"sets SOURCE"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Selector Position Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Selector Position"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TUN",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"freq-nnnnn,"
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"TU4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"tuning"
							},
							{
 								"description",
								"Tuning Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"freq-nnnnn,"
											},
											{
 												"description",
												"sets Directly Tuning Frequency (FM nnn.nn MHz / AM nnnnn kHz)"
											}
										}
									},
									{
 										"DIRECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"direct"
											},
											{
 												"description",
												"starts/restarts Direct Tuning Mode"
											}
										}
									},
									{
 										"0",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"0-in-direct-mode"
											},
											{
 												"description",
												"sets 0 in Direct Tuning Mode"
											}
										}
									},
									{
 										"1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1-in-direct-mode"
											},
											{
 												"description",
												"sets 1 in Direct Tuning Mode"
											}
										}
									},
									{
 										"2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"2-in-direct-mode"
											},
											{
 												"description",
												"sets 2 in Direct Tuning Mode"
											}
										}
									},
									{
 										"3",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"3-in-direct-mode"
											},
											{
 												"description",
												"sets 3 in Direct Tuning Mode"
											}
										}
									},
									{
 										"4",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4-in-direct-mode"
											},
											{
 												"description",
												"sets 4 in Direct Tuning Mode"
											}
										}
									},
									{
 										"5",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"5-in-direct-mode"
											},
											{
 												"description",
												"sets 5 in Direct Tuning Mode"
											}
										}
									},
									{
 										"6",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"6-in-direct-mode"
											},
											{
 												"description",
												"sets 6 in Direct Tuning Mode"
											}
										}
									},
									{
 										"7",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"7-in-direct-mode"
											},
											{
 												"description",
												"sets 7 in Direct Tuning Mode"
											}
										}
									},
									{
 										"8",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"8-in-direct-mode"
											},
											{
 												"description",
												"sets 8 in Direct Tuning Mode"
											}
										}
									},
									{
 										"9",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"9-in-direct-mode"
											},
											{
 												"description",
												"sets 9 in Direct Tuning Mode"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Tuning Frequency Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Tuning Frequency"
											}
										}
									}
								}
							}
						}
					},
					{
 						"PRS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"PR4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"preset"
							},
							{
 								"description",
								"Preset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										new string[]
										{
											"1",
											"30"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-30"
											},
											{
 												"description",
												"sets Preset No. 1 - 30 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Up"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"sets Preset No. Wrap-Around Down"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets The Preset No."
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Net-Tune Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAYz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"playz"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOPz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stopz"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSEz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pausez"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUPz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trupz"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDNz",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trdnz"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NT4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-tune-network"
							},
							{
 								"description",
								"Net-Tune/Network Operation Command(Network Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"FF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REW",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*) (for iPod 1wire)"
											}
										}
									},
									{
 										"REPEAT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RANDOM",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DISPLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RIGHT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"LEFT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"SELECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY(for iPod 1wire)"
											}
										}
									},
									{
 										"RETURN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY(for iPod 1wire)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NP4",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command (Network Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					}
				}
			},
			{
 				"dock",
				new Dictionary<string, object>()
				{
					{
 						"NTC",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"network-usb"
							},
							{
 								"description",
								"Network/USB Operation Command (Network Model Only after TX-NR905)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"play"
											},
											{
 												"description",
												"PLAY KEY"
											}
										}
									},
									{
 										"STOP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"stop"
											},
											{
 												"description",
												"STOP KEY"
											}
										}
									},
									{
 										"PAUSE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pause"
											},
											{
 												"description",
												"PAUSE KEY"
											}
										}
									},
									{
 										"P/P",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"p-p"
											},
											{
 												"description",
												"PLAY/PAUSE KEY"
											}
										}
									},
									{
 										"TRUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trup"
											},
											{
 												"description",
												"TRACK UP KEY"
											}
										}
									},
									{
 										"TRDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"trdn"
											},
											{
 												"description",
												"TRACK DOWN KEY"
											}
										}
									},
									{
 										"FF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ff"
											},
											{
 												"description",
												"FF KEY (CONTINUOUS*)"
											}
										}
									},
									{
 										"REW",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rew"
											},
											{
 												"description",
												"REW KEY (CONTINUOUS*)"
											}
										}
									},
									{
 										"REPEAT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"repeat"
											},
											{
 												"description",
												"REPEAT KEY"
											}
										}
									},
									{
 										"RANDOM",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"random"
											},
											{
 												"description",
												"RANDOM KEY"
											}
										}
									},
									{
 										"REP/SHF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"rep-shf"
											},
											{
 												"description",
												"REPEAT/SHUFFLE KEY"
											}
										}
									},
									{
 										"DISPLAY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"display"
											},
											{
 												"description",
												"DISPLAY KEY"
											}
										}
									},
									{
 										"ALBUM",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"album"
											},
											{
 												"description",
												"ALBUM KEY"
											}
										}
									},
									{
 										"ARTIST",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"artist"
											},
											{
 												"description",
												"ARTIST KEY"
											}
										}
									},
									{
 										"GENRE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"genre"
											},
											{
 												"description",
												"GENRE KEY"
											}
										}
									},
									{
 										"PLAYLIST",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"playlist"
											},
											{
 												"description",
												"PLAYLIST KEY"
											}
										}
									},
									{
 										"RIGHT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"right"
											},
											{
 												"description",
												"RIGHT KEY"
											}
										}
									},
									{
 										"LEFT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"left"
											},
											{
 												"description",
												"LEFT KEY"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"UP KEY"
											}
										}
									},
									{
 										"DOWN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"down"
											},
											{
 												"description",
												"DOWN KEY"
											}
										}
									},
									{
 										"SELECT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"select"
											},
											{
 												"description",
												"SELECT KEY"
											}
										}
									},
									{
 										"0",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"0"
											},
											{
 												"description",
												"0 KEY"
											}
										}
									},
									{
 										"1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"1"
											},
											{
 												"description",
												"1 KEY"
											}
										}
									},
									{
 										"2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"2"
											},
											{
 												"description",
												"2 KEY"
											}
										}
									},
									{
 										"3",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"3"
											},
											{
 												"description",
												"3 KEY"
											}
										}
									},
									{
 										"4",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"4"
											},
											{
 												"description",
												"4 KEY"
											}
										}
									},
									{
 										"5",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"5"
											},
											{
 												"description",
												"5 KEY"
											}
										}
									},
									{
 										"6",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"6"
											},
											{
 												"description",
												"6 KEY"
											}
										}
									},
									{
 										"7",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"7"
											},
											{
 												"description",
												"7 KEY"
											}
										}
									},
									{
 										"8",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"8"
											},
											{
 												"description",
												"8 KEY"
											}
										}
									},
									{
 										"9",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"9"
											},
											{
 												"description",
												"9 KEY"
											}
										}
									},
									{
 										"DELETE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"delete"
											},
											{
 												"description",
												"DELETE KEY"
											}
										}
									},
									{
 										"CAPS",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"caps"
											},
											{
 												"description",
												"CAPS KEY"
											}
										}
									},
									{
 										"LOCATION",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"location"
											},
											{
 												"description",
												"LOCATION KEY"
											}
										}
									},
									{
 										"LANGUAGE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"language"
											},
											{
 												"description",
												"LANGUAGE KEY"
											}
										}
									},
									{
 										"SETUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"setup"
											},
											{
 												"description",
												"SETUP KEY"
											}
										}
									},
									{
 										"RETURN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"return"
											},
											{
 												"description",
												"RETURN KEY"
											}
										}
									},
									{
 										"CHUP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chup"
											},
											{
 												"description",
												"CH UP(for iRadio)"
											}
										}
									},
									{
 										"CHDN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"chdn"
											},
											{
 												"description",
												"CH DOWN(for iRadio)"
											}
										}
									},
									{
 										"MENU",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"menu"
											},
											{
 												"description",
												"MENU"
											}
										}
									},
									{
 										"TOP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"top"
											},
											{
 												"description",
												"TOP MENU"
											}
										}
									},
									{
 										"MODE",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mode"
											},
											{
 												"description",
												"MODE(for iPod) STD<->EXT"
											}
										}
									},
									{
 										"LIST",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"list"
											},
											{
 												"description",
												"LIST <-> PLAYBACK"
											}
										}
									},
									{
 										"MEMORY",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"memory"
											},
											{
 												"description",
												"MEMORY (add Favorite)"
											}
										}
									},
									{
 										"F1",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"f1"
											},
											{
 												"description",
												"Positive Feed or Mark/Unmark "
											}
										}
									},
									{
 										"F2",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"f2"
											},
											{
 												"description",
												"Negative Feed "
											}
										}
									}
								}
							}
						}
					},
					{
 						"NBS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"bluetooth-setting"
							},
							{
 								"description",
								"Bluetooth Setting Operation Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"OFF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"off"
											},
											{
 												"description",
												"sets Bluetooth Off"
											}
										}
									},
									{
 										"ON",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"on"
											},
											{
 												"description",
												"sets Bluetooth On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Bluetooth Setting"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NBT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"bluetooth-internal"
							},
							{
 								"description",
								"Bluetooth(Internal) Operation Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"PAIRING",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pairing"
											},
											{
 												"description",
												"PAIRING"
											}
										}
									},
									{
 										"CLEAR",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"clear"
											},
											{
 												"description",
												"CLEAR PAIRING INFORMATION"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NAT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-artist-name-info"
							},
							{
 								"description",
								"NET/USB Artist Name Info"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"artist-name"
											},
											{
 												"description",
												"NET/USB Artist Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , fo" +
    "r Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets NET/USB Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NAL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-album-name-info"
							},
							{
 								"description",
								"NET/USB Album Name Info"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"album-name"
											},
											{
 												"description",
												"NET/USB Album Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for" +
    " Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets NET/USB Album Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-title-name"
							},
							{
 								"description",
								"NET/USB Title Name"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"title"
											},
											{
 												"description",
												"NET/USB Title Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for" +
    " Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets NET/USB Title Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-time-info"
							},
							{
 								"description",
								"NET/USB Time Info"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"mm:ss/mm:ss",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mm-ss-mm-ss"
											},
											{
 												"description",
												"NET/USB Time Info (Elapsed time/Track Time Max 99:59. If time is unknown, this re" +
    "sponse is --:--)"
											}
										}
									},
									{
 										"hh:mm:ss/hh:mm:ss",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hh-mm-ss-hh-mm-ss"
											},
											{
 												"description",
												"NET/USB Time Info (Elapsed time/Track Time Max 99:59:59. If time is unknown, this" +
    " response is --:--)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets NET/USB Time Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-track-info"
							},
							{
 								"description",
								"NET/USB Track Info"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"cccc/tttt",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"cccc-tttt"
											},
											{
 												"description",
												"NET/USB Track Info (Current Track/Toral Track Max 9999. If Track is unknown, this" +
    " response is ----)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets NET/USB Track Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NST",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-play-status"
							},
							{
 								"description",
								"NET/USB Play Status"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"prs",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"prs"
											},
											{
 												"description",
												@"NET/USB Play Status (3 letters)
p -> Play Status: ""S"": STOP, ""P"": Play, ""p"": Pause, ""F"": FF, ""R"": FR, ""E"": EOF
r -> Repeat Status: ""-"": Off, ""R"": All, ""F"": Folder, ""1"": Repeat 1, ""x"": disable
s -> Shuffle Status: ""-"": Off, ""S"": All , ""A"": Album, ""F"": Folder, ""x"": disable"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Net/USB Play Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NMS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-menu-status"
							},
							{
 								"description",
								"NET/USB Menu Status"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"maabbstii",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"maabbstii"
											},
											{
 												"description",
												@"NET/USB Menu Status (9 letters)
m -> Track Menu: ""M"": Menu is enable, ""x"": Menu is disable
aa -> F1 button icon (Positive Feed or Mark/Unmark)
bb -> F2 button icon (Negative Feed)
 aa or bb : ""xx"":disable, ""01"":Like, ""02"":don't like, ""03"":Love, ""04"":Ban,
                  ""05"":episode, ""06"":ratings, ""07"":Ban(black), ""08"":Ban(white),
                  ""09"":Favorite(black), ""0A"":Favorite(white), ""0B"":Favorite(yellow)
s -> Time Seek ""S"": Time Seek is enable ""x"": Time Seek is disable
t -> Time Display ""1"": Elapsed Time/Total Time, ""2"": Elapsed Time, ""x"": disable
ii-> Service icon
 ii : ""00"":Music Server (DLNA), ""01"":My Favorite, ""02"":vTuner, 
      ""03"":SiriusXM, ""04"":Pandora,
      ""05"":Rhapsody, ""06"":Last.fm, ""07"":Napster, ""08"":Slacker, ""09"":Mediafly,
      ""0A"":Spotify, ""0B"":AUPEO!,
      ""0C"":radiko, ""0D"":e-onkyo, ""0E"":TuneIn, ""0F"":MP3tunes, ""10"":Simfy,
      ""11"":Home Media, ""12"":Deezer, ""13"":iHeartRadio, ""18"":Airplay,
      “1A”: onkyo Music, “1B”:TIDAL, “41”:FireConnect,
      ""F0"": USB/USB(Front), ""F1: USB(Rear), ""F2"":Internet Radio
      ""F3"":NET, ""F4"":Bluetooth"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Net/USB Menu Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NTS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-time-seek"
							},
							{
 								"description",
								"NET/USB Time Seek"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"mm:ss",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mm-ss"
											},
											{
 												"description",
												"mm: munites (00-99)\nss: seconds (00-59)\nThis command is only available when Time " +
    "Seek is enable."
											}
										}
									},
									{
 										"hh:mm:ss",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"hh-mm-ss"
											},
											{
 												"description",
												"hh: hours(00-99)\nmm: munites (00-59)\nss: seconds (00-59)\nThis command is only ava" +
    "ilable when Time Seek is enable."
											}
										}
									}
								}
							}
						}
					},
					{
 						"NPR",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"internet-radio-preset"
							},
							{
 								"description",
								"Internet Radio Preset Command"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"no-1-40"
											},
											{
 												"description",
												"sets Preset No. 1 - 40 ( In hexadecimal representation)"
											}
										}
									},
									{
 										"SET",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"set"
											},
											{
 												"description",
												"preset memory current station"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NDS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-connection-usb-device-status"
							},
							{
 								"description",
								"NET Connection/USB Device Status"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nfr",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"nfr"
											},
											{
 												"description",
												@"NET Connection/USB Device Status (3 letters)
n -> NET Connection status: ""-"": no connection, ""E"": Ether, ""W"": Wireless
f -> Front USB(USB1) Device Status: ""-"": no device, ""i"": iPod/iPhone, 
      ""M"": Memory/NAS, ""W"": Wireless Adaptor, ""B"": Bluetooth Adaptor,
      ""x"": disable
r -> Rear USB(USB2) Device Status: ""-"": no device, ""i"": iPod/iPhone, 
      ""M"": Memory/NAS, ""W"": Wireless Adaptor, ""B"": Bluetooth Adaptor, 
      ""x"": disable"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Net/USB Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NLS",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-list-info"
							},
							{
 								"description",
								"NET/USB List Info"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"tlpnnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"info"
											},
											{
 												"description",
												@"NET/USB List Info
t ->Information Type (A : ASCII letter, C : Cursor Info, U : Unicode letter)
when t = A,
  l ->Line Info (0-9 : 1st to 10th Line)
  nnnnnnnnn:Listed data (variable-length, 64 ASCII letters max)
    when AVR is not displayed NET/USB List(Keyboard,Menu,Popup…), ""nnnnnnnnn"" is ""See TV"".
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
    when AVR is not displayed NET/USB List(Keyboard,Menu,Popup…), ""nnnnnnnnn"" is ""See TV"".
  p ->Property
         - : no
         0 : Playing, A : Artist, B : Album, F : Folder, M : Music, P : Playlist, S : Search
         a : Account, b : Playlist-C, c : Starred, d : Unstarred, e : What's New"
											}
										}
									},
									{
 										"ti",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ti"
											},
											{
 												"description",
												"select the listed item\n t -> Index Type (L : Line, I : Index)\nwhen t = L,\n  i -> " +
    "Line number (0-9 : 1st to 10th Line [1 digit] )\nwhen t = I,\n  iiiii -> Index num" +
    "ber (00001-99999 : 1st to 99999th Item [5 digits] )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NLA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-list-info"
							},
							{
 								"description",
								"NET/USB List Info(All item, need processing XML data, for Network Control Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"tzzzzsurr<.....>",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tzzzzsurr"
											},
											{
 												"description",
												@"t -> responce type 'X' : XML
zzzz -> sequence number (0000-FFFF)
s -> status 'S' : success, 'E' : error
u -> UI type '0' : List, '1' : Menu, '2' : Playback, '3' : Popup, '4' : Keyboard, ""5"" : Menu List
rr -> reserved
<.....> : XML data ( [CR] and [LF] are removed )
 If s='S',
 <?xml version=""1.0"" encoding=""UFT-8""?>
 <response status=""ok"">
   <items offset=""xxxx"" totalitems=""yyyy"" >
     <item iconid=""aa"" title=""bbb…bbb"" url=""ccc...ccc""/>
     …
     <item iconid=""aa"" title=""bbb…bbb"" url=""ccc...ccc""/>
   </Items>
 </response>
 If s='E',
 <?xml version=""1.0"" encoding=""UFT-8""?>
 <response status=""fail"">
   <error code=""[error code]"" message=""[error message]"" />
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
bbb...bbb : Title"
											}
										}
									},
									{
 										"Lzzzzll{xx}{xx}yyyy",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"lzzzzll-xx-xx-yyyy"
											},
											{
 												"description",
												@"specifiy to get the listed data (from Network Control Only)
zzzz -> sequence number (0000-FFFF)
ll -> number of layer (00-FF)
xxxx -> index of start item (0000-FFFF : 1st to 65536th Item [4 HEX digits] )
yyyy -> number of items (0000-FFFF : 1 to 65536 Items [4 HEX digits] )"
											}
										}
									},
									{
 										"Izzzzll{xx}{xx}----",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"izzzzll-xx-xx"
											},
											{
 												"description",
												"select the listed item (from Network Control Only)\nzzzz -> sequence number (0000-" +
    "FFFF)\nll -> number of layer (00-FF)\nxxxx -> index number (0000-FFFF : 1st to 655" +
    "36th Item [4 HEX digits] )\n---- -> not used"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NJA",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-jacket-art"
							},
							{
 								"description",
								"NET/USB Jacket Art (When Jacket Art is available and Output for Network Control O" +
    "nly)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"tp{xx}{xx}{xx}{xx}{xx}{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"tp-xx-xx-xx-xx-xx-xx"
											},
											{
 												"description",
												"NET/USB Jacket Art/Album Art Data\nt-> Image type 0:BMP, 1:JPEG, 2:URL, n:No Image" +
    "\np-> Packet flag 0:Start, 1:Next, 2:End, -:not used\nxxxxxxxxxxxxxx -> Jacket/Alb" +
    "um Art Data (valiable length, 1024 ASCII HEX letters max)"
											}
										}
									},
									{
 										"DIS",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"disable"
											},
											{
 												"description",
												"sets Jacket Art disable"
											}
										}
									},
									{
 										"ENA",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enable"
											},
											{
 												"description",
												"sets Jacket Art enable"
											}
										}
									},
									{
 										"BMP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enable-and-image-type-bmp"
											},
											{
 												"description",
												"sets Jacket Art enable and Image type BMP"
											}
										}
									},
									{
 										"LINK",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"enable-and-image-type-link"
											},
											{
 												"description",
												"sets Jacket Art enable and Image type LINK"
											}
										}
									},
									{
 										"UP",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"up"
											},
											{
 												"description",
												"sets Jacket Art Wrap-Around Up"
											}
										}
									},
									{
 										"REQ",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"req"
											},
											{
 												"description",
												"gets Jacket Art data"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Jacket Art enable/disable"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NSV",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-service"
							},
							{
 								"description",
								"NET Service(for Network Control Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"ssiaaaa…aaaabbbb…bbbb",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"service-id"
											},
											{
 												"description",
												@"select Network Service directly
ss -> Network Serveice
 00:Music Server (DLNA), 01:Favorite, 02:vTuner, 03:SiriusXM, 04:Pandora, 05:Rhapsody, 06:Last.fm,
 07:Napster, 08:Slacker, 09:Mediafly, 0A:Spotify, 0B:AUPEO!, 0C:Radiko, 0D:e-onkyo,
 0E:TuneIn Radio, 0F:mp3tunes, 10:Simfy, 11:Home Media, 12:Deezer, 13:iHeartRadio, 18:Airplay, 19:TIDAL, 1A:onkyo music, F0;USB/USB(Front), F1:USB(Rear)
i-> Acount Info
 0: No
 1: Yes
""aaaa...aaaa"": User Name ( 128 Unicode letters [UTF-8 encoded] max )
""bbbb...bbbb"": Password ( 128 Unicode letters [UTF-8 encoded] max )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NKY",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-keyboard"
							},
							{
 								"description",
								"NET Keyboard(for Network Control Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"ll",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ll"
											},
											{
 												"description",
												@"waiting Keyboard Input
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
 0D: URL"
											}
										}
									},
									{
 										"nnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"input"
											},
											{
 												"description",
												"set Keyboard Input letter\n\"nnnnnnnn\" is variable-length, 128 Unicode letters [UTF" +
    "-8 encoded] max"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NPU",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-popup-message"
							},
							{
 								"description",
								"NET Popup Message(for Network Control Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"xaaa…aaaybbb…bbb",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"popup"
											},
											{
 												"description",
												@"x -> Popup Display Type
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
    (valiable-length Unicode letter [UTF-8 encoded] )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NLT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-list-title-info"
							},
							{
 								"description",
								"NET/USB List Title Info(for Network Control Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"{xx}uycccciiiillrraabbssnnn...nnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"title-info"
											},
											{
 												"description",
												"NET/USB List Title Info\nxx : Service Type\n 00 : DLNA, 01 : Favorite, 02 : vTuner," +
    " 03 : SiriusXM, 04 : Pandora, 05 : Rhapsody, 06 : Last.fm,\n 07 : Napster, 08 : S" +
    "lacker, 09 : Mediafly, 0A : Spotify, 0B : AUPEO!, 0C : radiko, 0D : e-onkyo,\n 0E" +
    " : TuneIn Radio, 0F : MP3tunes, 10 : Simfy, 11:Home Media, 12:Deezer, 13:iHeartR" +
    "adio,\n F0 : USB Front, F1 : USB Rear, F2 : Internet Radio, F3 : NET, FF : None\nu" +
    " : UI Type\n 0 : List, 1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, \"5\" : Men" +
    "u List\ny : Layer Info\n 0 : NET TOP, 1 : Service Top,DLNA/USB/iPod Top, 2 : under" +
    " 2nd Layer\ncccc : Current Cursor Position (HEX 4 letters)\niiii : Number of List " +
    "Items (HEX 4 letters)\nll : Number of Layer(HEX 2 letters)\nrr : Reserved (2 leter" +
    "s)\naa : Icon on Left of Title Bar\n 00 : Internet Radio, 01 : Server, 02 : USB, 0" +
    "3 : iPod, 04 : DLNA, 05 : WiFi, 06 : Favorite\n 10 : Account(Spotify), 11 : Album" +
    "(Spotify), 12 : Playlist(Spotify), 13 : Playlist-C(Spotify)\n 14 : Starred(Spotif" +
    "y), 15 : What\'s New(Spotify), 16 : Track(Spotify), 17 : Artist(Spotify)\n 18 : Pl" +
    "ay(Spotify), 19 : Search(Spotify), 1A : Folder(Spotify)\n FF : None\nbb : Icon on " +
    "Right of Title Bar\n 00 : DLNA, 01 : Favorite, 02 : vTuner, 03 : SiriusXM, 04 : P" +
    "andora, 05 : Rhapsody, 06 : Last.fm,\n 07 : Napster, 08 : Slacker, 09 : Mediafly," +
    " 0A : Spotify, 0B : AUPEO!, 0C : radiko, 0D : e-onkyo,\n 0E : TuneIn Radio, 0F : " +
    "MP3tunes, 10 : Simfy, 11:Home Media, 12:Deezer, 13:iHeartRadio,\n FF : None\nss : " +
    "Status Info\n 00 : None, 01 : Connecting, 02 : Acquiring License, 03 : Buffering\n" +
    " 04 : Cannot Play, 05 : Searching, 06 : Profile update, 07 : Operation disabled\n" +
    " 08 : Server Start-up, 09 : Song rated as Favorite, 0A : Song banned from statio" +
    "n,\n 0B : Authentication Failed, 0C : Spotify Paused(max 1 device), 0D : Track No" +
    "t Available, 0E : Cannot Skip\nnnn...nnn : Character of Title Bar (variable-lengt" +
    "h, 64 Unicode letters [UTF-8 encoded] max)"
											}
										}
									},
									{
 										"{xx}uycccciiiillsraabbssnnn...nnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"NET/USB List Title Info\nxx : Service Type\n 00 : Music Server (DLNA), 01 : Favorit" +
    "e, 02 : vTuner, 03 : SiriusXM, 04 : Pandora, 05 : Rhapsody, 06 : Last.fm,\n 07 : " +
    "Napster, 08 : Slacker, 09 : Mediafly, 0A : Spotify, 0B : AUPEO!, 0C : radiko, 0D" +
    " : e-onkyo,\n 0E : TuneIn Radio, 0F : MP3tunes, 10 : Simfy, 11:Home Media, 12:Dee" +
    "zer, 13:iHeartRadio, 18:Airplay, 19:TIDAL, 1A:onkyo music,\n F0 : USB/USB(Front) " +
    "F1 : USB(Rear), F2 : Internet Radio, F3 : NET, FF : None\nu : UI Type\n 0 : List, " +
    "1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, \"5\" : Menu List\ny : Layer Info\n" +
    " 0 : NET TOP, 1 : Service Top,DLNA/USB/iPod Top, 2 : under 2nd Layer\ncccc : Curr" +
    "ent Cursor Position (HEX 4 letters)\niiii : Number of List Items (HEX 4 letters)\n" +
    "ll : Number of Layer(HEX 2 letters)\ns : Start Flag\n 0 : Not First, 1 : First\nr :" +
    " Reserved (1 leters, don\'t care)\naa : Icon on Left of Title Bar\n 00 : Internet R" +
    "adio, 01 : Server, 02 : USB, 03 : iPod, 04 : DLNA, 05 : WiFi, 06 : Favorite\n 10 " +
    ": Account(Spotify), 11 : Album(Spotify), 12 : Playlist(Spotify), 13 : Playlist-C" +
    "(Spotify)\n 14 : Starred(Spotify), 15 : What\'s New(Spotify), 16 : Track(Spotify)," +
    " 17 : Artist(Spotify)\n 18 : Play(Spotify), 19 : Search(Spotify), 1A : Folder(Spo" +
    "tify)\n FF : None\nbb : Icon on Right of Title Bar\n 00 : Muisc Server (DLNA), 01 :" +
    " Favorite, 02 : vTuner, 03 : SiriusXM, 04 : Pandora, 05 : Rhapsody, 06 : Last.fm" +
    ",\n 07 : Napster, 08 : Slacker, 09 : Mediafly, 0A : Spotify, 0B : AUPEO!, 0C : ra" +
    "diko, 0D : e-onkyo,\n 0E : TuneIn Radio, 0F : MP3tunes, 10 : Simfy, 11:Home Media" +
    ", 12:Deezer, 13:iHeartRadio, 18:Airplay, 19:TIDAL, 1A:onkyo music,\nF0:USB/USB(Fr" +
    "ont), F1:USB(Rear),\n FF : None\nss : Status Info\n 00 : None, 01 : Connecting, 02 " +
    ": Acquiring License, 03 : Buffering\n 04 : Cannot Play, 05 : Searching, 06 : Prof" +
    "ile update, 07 : Operation disabled\n 08 : Server Start-up, 09 : Song rated as Fa" +
    "vorite, 0A : Song banned from station,\n 0B : Authentication Failed, 0C : Spotify" +
    " Paused(max 1 device), 0D : Track Not Available, 0E : Cannot Skip\nnnn...nnn : Ch" +
    "aracter of Title Bar (variable-length, 64 Unicode letters [UTF-8 encoded] max)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets List Title Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NMD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"ipod-mode-change"
							},
							{
 								"description",
								"iPod Mode Change (with USB Connection Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"STD",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"std"
											},
											{
 												"description",
												"Standerd Mode"
											}
										}
									},
									{
 										"EXT",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ext"
											},
											{
 												"description",
												"Extend Mode(If available)"
											}
										}
									},
									{
 										"VDC",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"vdc"
											},
											{
 												"description",
												"Video Contents in Extended Mode"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Mode Status"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NSB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"network-standby-settings"
							},
							{
 								"description",
								"Network Standby Settings (for Network Control Only and Available in AVR is PowerO" +
    "n)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"OFF",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"is-off"
											},
											{
 												"description",
												"sets Network Standby is Off"
											}
										}
									},
									{
 										"ON",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"is-on"
											},
											{
 												"description",
												"sets Network Standby is On"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets Network Standby Setting"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NRI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"receiver-information"
							},
							{
 								"description",
								"Receiver Information (for Network Control Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"<…>",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xml"
											},
											{
 												"description",
												"<…>: XML Data <?xml…>"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Receiver Information Status"
											}
										}
									},
									{
 										"t----<.....>",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"t"
											},
											{
 												"description",
												"t -> message type \'X\' : XML\n---- -> reserved\n<.....> : XML data ( [CR] and [LF] a" +
    "re removed )"
											}
										}
									},
									{
 										"Ullt<.....>",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"ullt"
											},
											{
 												"description",
												"U : UI Type\n 0 : List, 1 : Menu, 2 : Playback, 3 : Popup, 4 : Keyboard, 5 : Menu " +
    "List\nll -> number of layer (00-FF)\nt : Update Type\n 0 : All, 1 : Button, 2 : Tex" +
    "tbox, 3 : Listbox\n<.....> : XML data ( [CR] and [LF] are removed )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NLU",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-list-info"
							},
							{
 								"description",
								"NET/USB List Info (Update item, need processing XML data, for Network Control Onl" +
    "y)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"{xx}{xx}yyyy",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xx-xx-yyyy"
											},
											{
 												"description",
												"xxxx -> index of update item (0000-FFFF : 1st to 65536th Item [4 HEX digits] )\nyy" +
    "yy : number of items (0000-FFFF : 1 to 65536 Items [4 HEX digits] )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NPB",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-playback-view-button"
							},
							{
 								"description",
								"NET/USB Playback view Button"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"pudtsrrr",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"pudtsrrr"
											},
											{
 												"description",
												@"NET/USB Playback view Status (5 letters)
p -> Play/Pause button: ""1"": button is enable, ""0"": button is disable
u ->  Skip up button : ""1"": button is enable, ""0"": button is disable
d -> Skip down button : ""1"": button is enable, ""0"": button is disable
t -> Timer button : ""1"": button is enable, ""0"": button is disable
s -> Preset button : ""1"": button is enable, ""0"": button is disable
 rrr-> reserved"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Net/USB Playback view Button"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NAF",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-add-favorite-list-in-list-view"
							},
							{
 								"description",
								"NET/USB Add Favorite List in List View"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"{xx}{xx}",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xx-xx"
											},
											{
 												"description",
												"Add Favorite Lsit in List View (from Network Control Only)\nxxxx -> index number (" +
    "0000-FFFF : 1st to 65536th Item [4 HEX digits] )"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NRF",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-remove-favorite-list"
							},
							{
 								"description",
								"NET/USB Remove Favorite List"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										new string[]
										{
											"1",
											"40"
										},
										new Dictionary<string, object>()
										{
											{
 												"name",
												"fav-no-1-40"
											},
											{
 												"description",
												"Remove Item from Favorite List ( In hexadecimal representation)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"NSD",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"net-usb-music-server-dlna-search-list"
							},
							{
 								"description",
								"NET/USB Music Server(DLNA) Search List"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"{xx}{xx}{xx}{xx}{xx}x",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"xx-xx-xx-xx-xx-x"
											},
											{
 												"description",
												"Search Word (Max 128 Character)"
											}
										}
									}
								}
							}
						}
					},
					{
 						"AAT",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"airplay-artist-name-info"
							},
							{
 								"description",
								"Airplay Artist Name Info (Airplay Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												null
											},
											{
 												"description",
												"NET/USB Artist Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , fo" +
    "r Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Artist Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"AAL",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"airplay-album-name-info"
							},
							{
 								"description",
								"Airplay Album Name Info (Airplay Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"album-name"
											},
											{
 												"description",
												"NET/USB Album Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for" +
    " Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Album Name"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ATI",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"airplay-title-name"
							},
							{
 								"description",
								"Airplay Title Name (Airplay Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"nnnnnnnnnn",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"title"
											},
											{
 												"description",
												"NET/USB Title Name (variable-length, 64 Unicode letters [UTF-8 encoded] max , for" +
    " Network Control only)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets HD Radio Title"
											}
										}
									}
								}
							}
						}
					},
					{
 						"ATM",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"airplay-time-info"
							},
							{
 								"description",
								"Airplay Time Info (Airplay Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"mm:ss/mm:ss",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"mm-ss-mm-ss"
											},
											{
 												"description",
												"NET/USB Time Info (Elapsed time/Track Time Max 99:59)"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets iPod Time Info"
											}
										}
									}
								}
							}
						}
					},
					{
 						"AST",
						new Dictionary<string, object>()
						{
							{
 								"name",
								"airplay-play-status"
							},
							{
 								"description",
								"Airplay Play Status (Airplay Model Only)"
							},
							{
 								"aliases",
								null
							},
							{
 								"values",
								new Dictionary<string, object>()
								{
									{
 										"prs",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"prs"
											},
											{
 												"description",
												"NET/USB Play Status (3 letters)\np -> Play Status: \"S\": STOP, \"P\": Play, \"p\": Paus" +
    "e\nr -> Repeat Status: \"-\": Off\ns -> Shuffle Status: \"-\": Off"
											}
										}
									},
									{
 										"QSTN",
										new Dictionary<string, object>()
										{
											{
 												"name",
												"query"
											},
											{
 												"description",
												"gets the Net/USB Status"
											}
										}
									}
								}
							}
						}
					}
				}
			}
		};
	}
}
