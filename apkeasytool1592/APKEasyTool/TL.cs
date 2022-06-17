using System;
using System.IO;
using System.Text;
using APKEasyTool.Forms;

namespace APKEasyTool
{
	// Token: 0x0200001F RID: 31
	public class TL
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00012196 File Offset: 0x00010396
		public TL(AMF Main)
		{
			TL.A = Main;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000121A4 File Offset: 0x000103A4
		internal static void A()
		{
			TL._logform = Log._Main;
			try
			{
				if (File.Exists(Vars.LogPath))
				{
					string text = File.ReadAllText(Vars.LogPath, Encoding.UTF8);
					TL.A.richTextBoxLogs.Text = text;
					if (TL._logform != null)
					{
						TL._logform.richTextBoxLogs.Text = text;
						TL._logform.richTextBoxLogs.SelectionStart = TL._logform.richTextBoxLogs.Text.Length;
						TL._logform.richTextBoxLogs.ScrollToCaret();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000253 RID: 595
		private static AMF A;

		// Token: 0x04000254 RID: 596
		public static Log _logform;
	}
}
