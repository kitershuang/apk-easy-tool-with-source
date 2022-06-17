using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};
using APKEasyTool;

namespace A
{
	// Token: 0x0200001A RID: 26
	internal static class A
	{
		// Token: 0x060001A7 RID: 423
		[DllImport("Shcore.dll", EntryPoint = "SetProcessDpiAwareness")]
		private static extern int A(int);

		// Token: 0x060001A8 RID: 424 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[STAThread]
		private static void A(string[] A_0)
		{
			if (Environment.OSVersion.Version.Major == 6)
			{
				global::A.A.A();
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			global::A.A.a();
			Lang.LoadStr();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			if (global::A.A.B())
			{
				Application.Run(new AMF());
				return;
			}
			MessageBox.Show(Lang.RESOURCE_MISSING_NOTICE, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060001A9 RID: 425
		[DllImport("user32.dll", EntryPoint = "SetProcessDPIAware")]
		private static extern bool A();

		// Token: 0x060001AA RID: 426 RVA: 0x00011E5C File Offset: 0x0001005C
		private static void a()
		{
			try
			{
				if (File.Exists(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IA()))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(APKEasyTool));
					FileStream fileStream = new FileStream(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IA(), FileMode.Open, FileAccess.Read, FileShare.Read);
					APKEasyTool apkeasyTool = (APKEasyTool)xmlSerializer.Deserialize(fileStream);
					Lang.LoadLocalization(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.g() + apkeasyTool.Language));
					fileStream.Close();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00011EE8 File Offset: 0x000100E8
		private static bool B()
		{
			return Directory.Exists(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ic())) && Directory.Exists(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ID()));
		}

		// Token: 0x0200001B RID: 27
		private enum A
		{
			// Token: 0x0400024D RID: 589
			A,
			// Token: 0x0400024E RID: 590
			a,
			// Token: 0x0400024F RID: 591
			B
		}
	}
}
