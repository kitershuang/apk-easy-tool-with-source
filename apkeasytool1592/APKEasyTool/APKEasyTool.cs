using System;
using System.Runtime.CompilerServices;

namespace APKEasyTool
{
	// Token: 0x02000013 RID: 19
	public class APKEasyTool
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000F265 File Offset: 0x0000D465
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000F26D File Offset: 0x0000D46D
		public string SelectedPathMain { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000F276 File Offset: 0x0000D476
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000F27E File Offset: 0x0000D47E
		public string SelectedDexOdexOat { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000F287 File Offset: 0x0000D487
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000F28F File Offset: 0x0000D48F
		public string SelectedSmali { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000F298 File Offset: 0x0000D498
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		public string PathDec { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000F2A9 File Offset: 0x0000D4A9
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000F2B1 File Offset: 0x0000D4B1
		public string PathCom { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000F2BA File Offset: 0x0000D4BA
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000F2C2 File Offset: 0x0000D4C2
		public string PathExt { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000F2CB File Offset: 0x0000D4CB
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000F2D3 File Offset: 0x0000D4D3
		public string PathZip { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		public string PathBaksmali { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000F2ED File Offset: 0x0000D4ED
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000F2F5 File Offset: 0x0000D4F5
		public string PathSmali { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000F2FE File Offset: 0x0000D4FE
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000F306 File Offset: 0x0000D506
		public string PathPem { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000F30F File Offset: 0x0000D50F
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000F317 File Offset: 0x0000D517
		public string PathPk8 { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000F320 File Offset: 0x0000D520
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000F328 File Offset: 0x0000D528
		public string PathJksFile { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000F331 File Offset: 0x0000D531
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000F339 File Offset: 0x0000D539
		public string PathTempDec { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000F342 File Offset: 0x0000D542
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000F34A File Offset: 0x0000D54A
		public string PathTempFw { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000F353 File Offset: 0x0000D553
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000F35B File Offset: 0x0000D55B
		public string PathTempFw2 { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000F364 File Offset: 0x0000D564
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000F36C File Offset: 0x0000D56C
		public string PathFw { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000F375 File Offset: 0x0000D575
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000F37D File Offset: 0x0000D57D
		public string PathJava { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000F386 File Offset: 0x0000D586
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000F38E File Offset: 0x0000D58E
		public string FileNameDec { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000F397 File Offset: 0x0000D597
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000F39F File Offset: 0x0000D59F
		public string FileNameCom { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
		public string FileNameDexOdexOat { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000F3C1 File Offset: 0x0000D5C1
		public string FileNameSmali { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000F3CA File Offset: 0x0000D5CA
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000F3D2 File Offset: 0x0000D5D2
		public string DropDownApkTool { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000F3DB File Offset: 0x0000D5DB
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000F3E3 File Offset: 0x0000D5E3
		public string DropDownApkSign { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000F3F4 File Offset: 0x0000D5F4
		public string DropDownLogLevel { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000F3FD File Offset: 0x0000D5FD
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000F405 File Offset: 0x0000D605
		public string DropDownCmdMode { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000F40E File Offset: 0x0000D60E
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000F416 File Offset: 0x0000D616
		public int DwordX { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000F41F File Offset: 0x0000D61F
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000F427 File Offset: 0x0000D627
		public int DwordY { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000F430 File Offset: 0x0000D630
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000F438 File Offset: 0x0000D638
		public string DwordXmx { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000F441 File Offset: 0x0000D641
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000F449 File Offset: 0x0000D649
		public bool CheckBoxDecB { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000F452 File Offset: 0x0000D652
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000F45A File Offset: 0x0000D65A
		public bool CheckBoxDecF { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000F463 File Offset: 0x0000D663
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000F46B File Offset: 0x0000D66B
		public bool CheckBoxDecK { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000F474 File Offset: 0x0000D674
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000F47C File Offset: 0x0000D67C
		public bool CheckBoxDecM { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000F485 File Offset: 0x0000D685
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0000F48D File Offset: 0x0000D68D
		public bool CheckBoxDecR { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000F496 File Offset: 0x0000D696
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000F49E File Offset: 0x0000D69E
		public bool CheckBoxDecS { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000F4A7 File Offset: 0x0000D6A7
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0000F4AF File Offset: 0x0000D6AF
		public bool CheckBoxDecNC { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
		public bool CheckBoxDecOMC { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000F4C9 File Offset: 0x0000D6C9
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000F4D1 File Offset: 0x0000D6D1
		public bool CheckBoxComC { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000F4DA File Offset: 0x0000D6DA
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000F4E2 File Offset: 0x0000D6E2
		public bool CheckBoxComD { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000F4EB File Offset: 0x0000D6EB
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000F4F3 File Offset: 0x0000D6F3
		public bool CheckBoxComF { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000F4FC File Offset: 0x0000D6FC
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0000F504 File Offset: 0x0000D704
		public bool CheckBoxComNC { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000F50D File Offset: 0x0000D70D
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000F515 File Offset: 0x0000D715
		public bool CheckBoxComAapt2 { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000F51E File Offset: 0x0000D71E
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000F526 File Offset: 0x0000D726
		public bool CheckBoxZipF { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000F52F File Offset: 0x0000D72F
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0000F537 File Offset: 0x0000D737
		public bool CheckBoxZipP { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000F540 File Offset: 0x0000D740
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000F548 File Offset: 0x0000D748
		public bool CheckBoxZipZ { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000F551 File Offset: 0x0000D751
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000F559 File Offset: 0x0000D759
		public bool CheckBoxZipV { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000F562 File Offset: 0x0000D762
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0000F56A File Offset: 0x0000D76A
		public bool CheckBoxShellExt { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000F573 File Offset: 0x0000D773
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000F57B File Offset: 0x0000D77B
		public bool CheckBoxEnaLog { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000F584 File Offset: 0x0000D784
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000F58C File Offset: 0x0000D78C
		public bool CheckBoxUseJks { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000F595 File Offset: 0x0000D795
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000F59D File Offset: 0x0000D79D
		public bool CheckBoxSignApk { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000F5A6 File Offset: 0x0000D7A6
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000F5AE File Offset: 0x0000D7AE
		public bool CheckBoxInstallApk { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000F5BF File Offset: 0x0000D7BF
		public bool CheckBoxOverApk { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		public bool CheckBoxZipAfterSign { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000F5D9 File Offset: 0x0000D7D9
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0000F5E1 File Offset: 0x0000D7E1
		public bool CheckBoxToolTips { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000F5EA File Offset: 0x0000D7EA
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000F5F2 File Offset: 0x0000D7F2
		public bool CheckBoxChkUpdate { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000F5FB File Offset: 0x0000D7FB
		// (set) Token: 0x06000153 RID: 339 RVA: 0x0000F603 File Offset: 0x0000D803
		public bool CheckBoxWinPos { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000F60C File Offset: 0x0000D80C
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000F614 File Offset: 0x0000D814
		public bool CheckBoxRememberPass { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000F61D File Offset: 0x0000D81D
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000F625 File Offset: 0x0000D825
		public bool CheckBoxDisHistory { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000F62E File Offset: 0x0000D82E
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000F636 File Offset: 0x0000D836
		public bool CheckBoxDisComMsgBox { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000F63F File Offset: 0x0000D83F
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000F647 File Offset: 0x0000D847
		public bool CheckBoxUseExtJava { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000F650 File Offset: 0x0000D850
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000F658 File Offset: 0x0000D858
		public bool CheckBoxReadApk { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000F661 File Offset: 0x0000D861
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0000F669 File Offset: 0x0000D869
		public bool CheckBoxReplaceSpace { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000F672 File Offset: 0x0000D872
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000F67A File Offset: 0x0000D87A
		public bool AskToSetupDir { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000F683 File Offset: 0x0000D883
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000F68B File Offset: 0x0000D88B
		public bool isSidedLogOpened { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000F694 File Offset: 0x0000D894
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000F69C File Offset: 0x0000D89C
		public bool isReset { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000F6A5 File Offset: 0x0000D8A5
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000F6AD File Offset: 0x0000D8AD
		public string PassJks { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000F6B6 File Offset: 0x0000D8B6
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000F6BE File Offset: 0x0000D8BE
		public string DecApiLvl { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000F6C7 File Offset: 0x0000D8C7
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000F6CF File Offset: 0x0000D8CF
		public string ComApiLvl { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
		public bool ReplaceWithSpace { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000F6E9 File Offset: 0x0000D8E9
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
		public bool CheckBoxTaskBar { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000F6FA File Offset: 0x0000D8FA
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000F702 File Offset: 0x0000D902
		public string v2SigningEnabled { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000F70B File Offset: 0x0000D90B
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0000F713 File Offset: 0x0000D913
		public string v3SigningEnabled { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000F71C File Offset: 0x0000D91C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000F724 File Offset: 0x0000D924
		public string v4SigningEnabled { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000F72D File Offset: 0x0000D92D
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0000F735 File Offset: 0x0000D935
		public string Language { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000F73E File Offset: 0x0000D93E
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000F746 File Offset: 0x0000D946
		public bool CheckBoxCodePage { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000F74F File Offset: 0x0000D94F
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000F757 File Offset: 0x0000D957
		public int CodePage { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000F760 File Offset: 0x0000D960
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000F768 File Offset: 0x0000D968
		public bool CheckBoxAapt { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000F771 File Offset: 0x0000D971
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000F779 File Offset: 0x0000D979
		public bool CheckBoxUseJavaXmx { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000F782 File Offset: 0x0000D982
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000F78A File Offset: 0x0000D98A
		public string TextBoxAapt { get; set; }

		// Token: 0x040001E6 RID: 486
		[CompilerGenerated]
		private string A;

		// Token: 0x040001E7 RID: 487
		[CompilerGenerated]
		private string a;

		// Token: 0x040001E8 RID: 488
		[CompilerGenerated]
		private string B;

		// Token: 0x040001E9 RID: 489
		[CompilerGenerated]
		private string b;

		// Token: 0x040001EA RID: 490
		[CompilerGenerated]
		private string C;

		// Token: 0x040001EB RID: 491
		[CompilerGenerated]
		private string c;

		// Token: 0x040001EC RID: 492
		[CompilerGenerated]
		private string D;

		// Token: 0x040001ED RID: 493
		[CompilerGenerated]
		private string d;

		// Token: 0x040001EE RID: 494
		[CompilerGenerated]
		private string E;

		// Token: 0x040001EF RID: 495
		[CompilerGenerated]
		private string e;

		// Token: 0x040001F0 RID: 496
		[CompilerGenerated]
		private string F;

		// Token: 0x040001F1 RID: 497
		[CompilerGenerated]
		private string f;

		// Token: 0x040001F2 RID: 498
		[CompilerGenerated]
		private string G;

		// Token: 0x040001F3 RID: 499
		[CompilerGenerated]
		private string g;

		// Token: 0x040001F4 RID: 500
		[CompilerGenerated]
		private string H;

		// Token: 0x040001F5 RID: 501
		[CompilerGenerated]
		private string h;

		// Token: 0x040001F6 RID: 502
		[CompilerGenerated]
		private string I;

		// Token: 0x040001F7 RID: 503
		[CompilerGenerated]
		private string i;

		// Token: 0x040001F8 RID: 504
		[CompilerGenerated]
		private string J;

		// Token: 0x040001F9 RID: 505
		[CompilerGenerated]
		private string j;

		// Token: 0x040001FA RID: 506
		[CompilerGenerated]
		private string K;

		// Token: 0x040001FB RID: 507
		[CompilerGenerated]
		private string k;

		// Token: 0x040001FC RID: 508
		[CompilerGenerated]
		private string L;

		// Token: 0x040001FD RID: 509
		[CompilerGenerated]
		private string l;

		// Token: 0x040001FE RID: 510
		[CompilerGenerated]
		private string M;

		// Token: 0x040001FF RID: 511
		[CompilerGenerated]
		private int A;

		// Token: 0x04000200 RID: 512
		[CompilerGenerated]
		private int a;

		// Token: 0x04000201 RID: 513
		[CompilerGenerated]
		private string m;

		// Token: 0x04000202 RID: 514
		[CompilerGenerated]
		private bool A;

		// Token: 0x04000203 RID: 515
		[CompilerGenerated]
		private bool a;

		// Token: 0x04000204 RID: 516
		[CompilerGenerated]
		private bool B;

		// Token: 0x04000205 RID: 517
		[CompilerGenerated]
		private bool b;

		// Token: 0x04000206 RID: 518
		[CompilerGenerated]
		private bool C;

		// Token: 0x04000207 RID: 519
		[CompilerGenerated]
		private bool c;

		// Token: 0x04000208 RID: 520
		[CompilerGenerated]
		private bool D;

		// Token: 0x04000209 RID: 521
		[CompilerGenerated]
		private bool d;

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		private bool E;

		// Token: 0x0400020B RID: 523
		[CompilerGenerated]
		private bool e;

		// Token: 0x0400020C RID: 524
		[CompilerGenerated]
		private bool F;

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private bool f;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private bool G;

		// Token: 0x0400020F RID: 527
		[CompilerGenerated]
		private bool g;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private bool H;

		// Token: 0x04000211 RID: 529
		[CompilerGenerated]
		private bool h;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private bool I;

		// Token: 0x04000213 RID: 531
		[CompilerGenerated]
		private bool i;

		// Token: 0x04000214 RID: 532
		[CompilerGenerated]
		private bool J;

		// Token: 0x04000215 RID: 533
		[CompilerGenerated]
		private bool j;

		// Token: 0x04000216 RID: 534
		[CompilerGenerated]
		private bool K;

		// Token: 0x04000217 RID: 535
		[CompilerGenerated]
		private bool k;

		// Token: 0x04000218 RID: 536
		[CompilerGenerated]
		private bool L;

		// Token: 0x04000219 RID: 537
		[CompilerGenerated]
		private bool l;

		// Token: 0x0400021A RID: 538
		[CompilerGenerated]
		private bool M;

		// Token: 0x0400021B RID: 539
		[CompilerGenerated]
		private bool m;

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		private bool N;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private bool n;

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		private bool O;

		// Token: 0x0400021F RID: 543
		[CompilerGenerated]
		private bool o;

		// Token: 0x04000220 RID: 544
		[CompilerGenerated]
		private bool P;

		// Token: 0x04000221 RID: 545
		[CompilerGenerated]
		private bool p;

		// Token: 0x04000222 RID: 546
		[CompilerGenerated]
		private bool Q;

		// Token: 0x04000223 RID: 547
		[CompilerGenerated]
		private bool q;

		// Token: 0x04000224 RID: 548
		[CompilerGenerated]
		private bool R;

		// Token: 0x04000225 RID: 549
		[CompilerGenerated]
		private bool r;

		// Token: 0x04000226 RID: 550
		[CompilerGenerated]
		private string N;

		// Token: 0x04000227 RID: 551
		[CompilerGenerated]
		private string n;

		// Token: 0x04000228 RID: 552
		[CompilerGenerated]
		private string O;

		// Token: 0x04000229 RID: 553
		[CompilerGenerated]
		private bool S;

		// Token: 0x0400022A RID: 554
		[CompilerGenerated]
		private bool s;

		// Token: 0x0400022B RID: 555
		[CompilerGenerated]
		private string o;

		// Token: 0x0400022C RID: 556
		[CompilerGenerated]
		private string P;

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		private string p;

		// Token: 0x0400022E RID: 558
		[CompilerGenerated]
		private string Q;

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private bool T;

		// Token: 0x04000230 RID: 560
		[CompilerGenerated]
		private int B;

		// Token: 0x04000231 RID: 561
		[CompilerGenerated]
		private bool t;

		// Token: 0x04000232 RID: 562
		[CompilerGenerated]
		private bool U;

		// Token: 0x04000233 RID: 563
		[CompilerGenerated]
		private string q;
	}
}
