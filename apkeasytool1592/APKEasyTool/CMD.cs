using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x0200000A RID: 10
	public class CMD
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00009BA5 File Offset: 0x00007DA5
		public CMD(AMF Main)
		{
			CMD.A = Main;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00009BC0 File Offset: 0x00007DC0
		private static string A()
		{
			string text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			if (CMD.A.H.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.De();
			}
			if (CMD.A.K.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DF();
			}
			if (CMD.A.g.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Df();
			}
			if (CMD.A.G.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DG();
			}
			if (CMD.A.I.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dg();
			}
			if (CMD.A.h.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DH();
			}
			if (CMD.A.e.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dh();
			}
			if (CMD.A.k.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				text = text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DI() + CMD.A.k.Text;
			}
			List<string> list = new List<string>
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Di(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DJ(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dj(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DK(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dk(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DL(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DL(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dl(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DM(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dm(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DN(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dn(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DO(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Do()
			};
			if (CMD.A.L.Checked && !list.Contains(Vars.ApkToolVer))
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DP();
			}
			return text;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00009DA0 File Offset: 0x00007FA0
		private static string a()
		{
			string text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			if (CMD.A.j.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dp();
			}
			if (CMD.A.i.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DQ();
			}
			if (CMD.A.J.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DF();
			}
			if (CMD.A.f.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dq();
			}
			if (CMD.A.K.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				text = text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DI() + CMD.A.K.Text;
			}
			if (CMD.A.F.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DR();
			}
			if (CMD.A.l.Checked)
			{
				text = text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dr() + CMD.A.L.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DS();
			}
			return text;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00009EAC File Offset: 0x000080AC
		private static string B()
		{
			string text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			if (CMD.A.c.SelectedIndex == 1)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ds();
			}
			else if (CMD.A.c.SelectedIndex == 2)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DT();
			}
			if (CMD.A.b.SelectedIndex == 1)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dt();
			}
			else if (CMD.A.b.SelectedIndex == 2)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DU();
			}
			if (CMD.A.C.SelectedIndex == 1)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Du();
			}
			else if (CMD.A.C.SelectedIndex == 2)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DV();
			}
			else if (CMD.A.C.SelectedIndex == 3)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dv();
			}
			return text;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00009F9C File Offset: 0x0000819C
		private static string b()
		{
			string text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			if (CMD.A.zipFcheckBox.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DF();
			}
			if (CMD.A.zipPcheckBox.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DW();
			}
			if (CMD.A.zipZcheckBox.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dw();
			}
			if (CMD.A.zipVcheckBox.Checked)
			{
				text += 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DX();
			}
			return text;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000A024 File Offset: 0x00008224
		public static string ProcessStartWithOutput(string FileName, string Arguments)
		{
			string result = string.Empty;
			try
			{
				using (Process process = new Process())
				{
					process.StartInfo.FileName = FileName;
					process.StartInfo.Arguments = Arguments;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.RedirectStandardError = true;
					process.StartInfo.UseShellExecute = false;
					Encoding encoding = Encoding.Default;
					try
					{
						encoding = Encoding.GetEncoding(int.Parse(Vars.CodePage));
					}
					catch (Exception)
					{
					}
					process.StartInfo.StandardOutputEncoding = encoding;
					process.StartInfo.StandardErrorEncoding = encoding;
					process.Start();
					result = process.StandardOutput.ReadToEnd().Trim() + process.StandardError.ReadToEnd().Trim();
					process.WaitForExit(5000);
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000A12C File Offset: 0x0000832C
		public static void ProcessStartWithArgs(string FileName, string Arguments)
		{
			try
			{
				using (Process process = new Process())
				{
					process.StartInfo.FileName = FileName;
					process.StartInfo.Arguments = Arguments;
					process.Start();
					process.WaitForExit(5000);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000A198 File Offset: 0x00008398
		public static void startProgram(string filename, string commandLine, string workingDir, bool logoutput, out int ExitCode)
		{
			CMD.A a = new CMD.A();
			a.A = logoutput;
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = filename;
			processStartInfo.Arguments = commandLine;
			processStartInfo.WorkingDirectory = workingDir;
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.CreateNoWindow = true;
			using (Process process = new Process())
			{
				process.StartInfo = processStartInfo;
				process.OutputDataReceived += a.A;
				process.ErrorDataReceived += CMD.a.A.A;
				process.Start();
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
				process.WaitForExit();
				ExitCode = process.ExitCode;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000A26C File Offset: 0x0000846C
		public static void Command(string Type, string path1, string path2)
		{
			CMD.B b;
			b.A = AsyncVoidMethodBuilder.Create();
			b.A = Type;
			b.a = path1;
			b.B = path2;
			b.A = -1;
			b.A.Start<CMD.B>(ref b);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000A2B4 File Offset: 0x000084B4
		private static Task C()
		{
			CMD.b b;
			b.A = AsyncTaskMethodBuilder.Create();
			b.A = -1;
			b.A.Start<CMD.b>(ref b);
			return b.A.Task;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000A2EF File Offset: 0x000084EF
		internal void A(object A_1, DoWorkEventArgs A_2)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000A2F4 File Offset: 0x000084F4
		internal void A(object A_1, RunWorkerCompletedEventArgs A_2)
		{
			CMD.A.tMain.Enabled = true;
			CMD.signApkClicked = false;
			if (CMD.A.Opacity > 0.0 && CMD.A.k.Checked)
			{
				JList.TaskBar(0);
			}
			if (CMD.B == 0)
			{
				CMD.A.LogOutput(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), AMF.Type.Info, null, true);
				CMD.A.LogOutput(CMD.C, AMF.Type.Info, null, true);
				CMD.A.LogOutput(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dx());
				if (CMD.task == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DY() && CMD.miniWinMode)
				{
					MessageBox.Show(CMD.C, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					CMD.task = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				}
				try
				{
					if (File.Exists(Path.GetDirectoryName(CMD.F) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(CMD.F) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DZ()))
					{
						File.Delete(Path.GetDirectoryName(CMD.F) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(CMD.F) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV());
						File.Move(Path.GetDirectoryName(CMD.F) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(CMD.F) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DZ(), CMD.F);
					}
				}
				catch
				{
				}
				if (CMD.task == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
				{
					SystemSounds.Beep.Play();
				}
			}
			else
			{
				if (CMD.isCancelled)
				{
					CMD.isCancelled = false;
					return;
				}
				CMD.A.LogOutput(CMD.c, AMF.Type.Error, null, true);
				CMD.A.LogToRichTextBox(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dz() + Lang.PLEASE_READ_FAQ + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dA(), new Color?(Color.Yellow));
				CMD.A.LogOutput(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dx());
				SystemSounds.Beep.Play();
				if (CMD.miniWinMode)
				{
					if (CMD.b.Length > 300)
					{
						CMD.b = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					}
					MessageBox.Show(CMD.c + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dz() + CMD.b, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					try
					{
						File.WriteAllText(Vars.LogPath, CMD.A.richTextBoxLogs.Text);
					}
					catch (Exception)
					{
					}
					if (!MF.a)
					{
						CMD.A.tMain.SelectedIndex = 2;
					}
				}
				CMD.b = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				CMD.task = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				CMD.isCancelled = false;
				if (!CMD.miniWinMode)
				{
					return;
				}
				Application.Exit();
			}
			if (CMD.miniWinMode && !CMD.signApkAfterCom)
			{
				Application.Exit();
			}
			CMD.signApkAfterCom = false;
			if (CMD.draganddropmass)
			{
				try
				{
					if (DD.multifiles.Length > 1)
					{
						CMD.A++;
						if (DD.multifiles.Length > CMD.A)
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b());
							return;
						}
						CMD.A = 0;
						CMD.a = 0;
						CMD.draganddropmass = false;
						return;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			if (CMD.task == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dB())
			{
				if (CMD.A.zipAfterSignChkBox.Checked)
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dB(), CMD.e, CMD.e);
				}
			}
			else
			{
				this.c();
			}
			if (CMD.A.k.Checked)
			{
				CMD.A.FlashNotification();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000A680 File Offset: 0x00008880
		private void c()
		{
			if (CMD.task == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da())
			{
				if (CMD.A.signApkCheckBox.Checked)
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da(), CMD.e, CMD.e);
					return;
				}
			}
			else
			{
				this.D();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000A6C0 File Offset: 0x000088C0
		private void D()
		{
			if (CMD.task == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.db() && CMD.A.installApkChkBox.Checked)
			{
				CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.db(), CMD.F, CMD.e);
			}
			CMD.task = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
		}

		// Token: 0x04000142 RID: 322
		private static AMF A;

		// Token: 0x04000143 RID: 323
		internal static string A;

		// Token: 0x04000144 RID: 324
		internal static string a;

		// Token: 0x04000145 RID: 325
		internal static string B;

		// Token: 0x04000146 RID: 326
		internal static string b;

		// Token: 0x04000147 RID: 327
		internal static string C;

		// Token: 0x04000148 RID: 328
		internal static string c;

		// Token: 0x04000149 RID: 329
		internal static string D;

		// Token: 0x0400014A RID: 330
		internal static string d;

		// Token: 0x0400014B RID: 331
		internal static string E;

		// Token: 0x0400014C RID: 332
		internal static string e;

		// Token: 0x0400014D RID: 333
		internal static string F;

		// Token: 0x0400014E RID: 334
		internal static string f;

		// Token: 0x0400014F RID: 335
		internal static string G;

		// Token: 0x04000150 RID: 336
		internal static string g;

		// Token: 0x04000151 RID: 337
		public static string task = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();

		// Token: 0x04000152 RID: 338
		private static int A = 0;

		// Token: 0x04000153 RID: 339
		private static int a = 0;

		// Token: 0x04000154 RID: 340
		public static bool signApkClicked;

		// Token: 0x04000155 RID: 341
		public static bool miniWinMode;

		// Token: 0x04000156 RID: 342
		public static bool isCancelled;

		// Token: 0x04000157 RID: 343
		public static bool draganddropmass = false;

		// Token: 0x04000158 RID: 344
		public static bool signApkAfterCom;

		// Token: 0x04000159 RID: 345
		public Process p = new Process();

		// Token: 0x0400015A RID: 346
		private static int B = 0;

		// Token: 0x0200000B RID: 11
		[CompilerGenerated]
		private sealed class A
		{
			// Token: 0x060000C1 RID: 193 RVA: 0x0000A734 File Offset: 0x00008934
			internal void A(object A_1, DataReceivedEventArgs A_2)
			{
				if (this.A && A_2.Data != null)
				{
					CMD.A.LogOutput(A_2.Data, AMF.Type.Info, null, true);
				}
			}

			// Token: 0x0400015B RID: 347
			public bool A;
		}

		// Token: 0x0200000C RID: 12
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060000C4 RID: 196 RVA: 0x0000A778 File Offset: 0x00008978
			internal void A(object A_1, DataReceivedEventArgs A_2)
			{
				if (A_2.Data != null)
				{
					CMD.A.LogOutput(A_2.Data, AMF.Type.Info, null, true);
				}
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x0000A7A8 File Offset: 0x000089A8
			internal void A()
			{
				CMD.startProgram(CMD.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dS() + CMD.G, string.Concat(new string[]
				{
					Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ID())
				}), true, out CMD.B);
			}

			// Token: 0x0400015C RID: 348
			public static readonly CMD.a A = new CMD.a();

			// Token: 0x0400015D RID: 349
			public static DataReceivedEventHandler A;

			// Token: 0x0400015E RID: 350
			public static Action A;
		}
	}
}
