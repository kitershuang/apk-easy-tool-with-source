using System;
using System.Text.RegularExpressions;

namespace APKEasyTool
{
	// Token: 0x0200001D RID: 29
	public class S
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00011F3C File Offset: 0x0001013C
		public static string Regex(string text, string match)
		{
			return new Regex(text).Match(match).ToString();
		}
	}
}
