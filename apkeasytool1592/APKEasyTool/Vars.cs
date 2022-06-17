using System;
using System.IO;
using System.Reflection;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x02000030 RID: 48
	public static class Vars
	{
		// Token: 0x06000207 RID: 519 RVA: 0x000161E0 File Offset: 0x000143E0
		public static string Today()
		{
			return DateTime.Now.ToString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JG());
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00016200 File Offset: 0x00014400
		public static string GetPath()
		{
			if (Path.GetPathRoot(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())) == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jg() && !Path.GetFullPath(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())).Contains(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)))
			{
				return Vars.MyDocPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JH();
			}
			return Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b());
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001625F File Offset: 0x0001445F
		public static string RealPath(string path = "")
		{
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + path;
		}

		// Token: 0x04000294 RID: 660
		public static readonly string Version = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jh();

		// Token: 0x04000295 RID: 661
		public static readonly string MyDocPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x04000296 RID: 662
		public static readonly string LegacyLogPath = Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JI();

		// Token: 0x04000297 RID: 663
		public static readonly string ApkSignerPath = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DS() + Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ji());

		// Token: 0x04000298 RID: 664
		public static readonly string GetDiskLetter = Path.GetPathRoot(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b());

		// Token: 0x04000299 RID: 665
		public static string LogPath = Path.GetTempPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JJ();

		// Token: 0x0400029A RID: 666
		public static string TempPath = Path.GetTempPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jj();

		// Token: 0x0400029B RID: 667
		public static string TempPathCache = Path.GetTempPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JK();

		// Token: 0x0400029C RID: 668
		public static string Apktool;

		// Token: 0x0400029D RID: 669
		public static string InsCount;

		// Token: 0x0400029E RID: 670
		public static string CodePage;

		// Token: 0x0400029F RID: 671
		public static string ApkToolVer;
	}
}
