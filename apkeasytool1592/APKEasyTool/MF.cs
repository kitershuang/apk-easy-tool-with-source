using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Serialization;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};
using APKEasyTool.Forms;

namespace APKEasyTool
{
	// Token: 0x02000017 RID: 23
	public class MF
	{
		// Token: 0x06000193 RID: 403 RVA: 0x0000FF3E File Offset: 0x0000E13E
		public MF(AMF Main)
		{
			MF.A = Main;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000FF4C File Offset: 0x0000E14C
		public static int GetWindowsScaling()
		{
			return (int)((double)(100 * Screen.PrimaryScreen.Bounds.Width) / SystemParameters.PrimaryScreenWidth);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000FF78 File Offset: 0x0000E178
		internal void A()
		{
			MF.a a;
			a.A = AsyncVoidMethodBuilder.Create();
			a.A = this;
			a.A = -1;
			a.A.Start<MF.a>(ref a);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		private void a()
		{
			try
			{
				if (MF.A.B.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !Directory.Exists(MF.A.B.Text))
				{
					Directory.CreateDirectory(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hP());
					MF.A.B.Text = Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hP();
				}
				if (MF.A.a.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !Directory.Exists(MF.A.a.Text))
				{
					Directory.CreateDirectory(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hp());
					MF.A.a.Text = Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hp();
				}
				if (MF.A.A.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !Directory.Exists(MF.A.A.Text))
				{
					Directory.CreateDirectory(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hQ());
					MF.A.A.Text = Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hQ();
				}
				if (MF.A.b.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !Directory.Exists(MF.A.b.Text))
				{
					Directory.CreateDirectory(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hq());
					MF.A.b.Text = Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hq();
				}
				if (MF.A.I.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !Directory.Exists(MF.A.I.Text))
				{
					Directory.CreateDirectory(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hR());
					MF.A.I.Text = Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hR();
				}
				if (MF.A.h.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !Directory.Exists(MF.A.h.Text))
				{
					Directory.CreateDirectory(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hr());
					MF.A.h.Text = Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hr();
				}
			}
			catch (Exception)
			{
			}
			if (MF.A.E.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !File.Exists(MF.A.E.Text))
			{
				MF.A.E.Text = Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hS());
			}
			if (MF.A.d.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() || !File.Exists(MF.A.d.Text))
			{
				MF.A.d.Text = Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hs());
			}
			if (MF.A.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MF.A.A.B(MF.A.pathOfApk.Text);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00010304 File Offset: 0x0000E504
		private void B()
		{
			if (Directory.Exists(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hT())))
			{
				try
				{
					string[] array = Directory.GetFiles(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hT()), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ht()).Select(new Func<string, string>(MF.A.A.a)).ToArray<string>();
					ComboBox.ObjectCollection items = MF.A.langComboBox.Items;
					object[] items2 = array;
					items.AddRange(items2);
					if (MF.A.langComboBox.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
					{
						MF.A.langComboBox.SelectedItem = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hU();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000103C0 File Offset: 0x0000E5C0
		private void b()
		{
			if (Environment.GetCommandLineArgs().Length > 1)
			{
				if (Environment.GetCommandLineArgs().Length > 2)
				{
					MF.A.Opacity = 0.0;
					MF.A.Visible = false;
					MF.A.ShowInTaskbar = false;
					CMD.miniWinMode = true;
					string text = Environment.GetCommandLineArgs()[2];
					if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hu())
					{
						CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.df(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text), text);
						return;
					}
					if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hV())
					{
						if (File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dG()) && File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
						{
							if (MF.A.signApkCheckBox.Checked)
							{
								CMD.signApkAfterCom = true;
							}
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dH(), text);
							return;
						}
						if (File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dh(), text);
							return;
						}
					}
					else
					{
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hv())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dI(), text);
							return;
						}
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hW())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dB(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hw(), text);
							return;
						}
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hX())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DY(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), text);
							return;
						}
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hx())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.db(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), text);
							return;
						}
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hY())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.di(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text), text);
							return;
						}
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hy())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dJ(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dj(), text);
							return;
						}
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hZ())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dk(), text, Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text));
							return;
						}
						if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hz())
						{
							CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dL(), text, Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dl());
							return;
						}
					}
				}
				else
				{
					MF.A.A.B(Environment.GetCommandLineArgs()[1]);
					MF.A.pathOfApk.Text = Environment.GetCommandLineArgs()[1];
					MF.A.a.Text = Path.GetFileNameWithoutExtension(Environment.GetCommandLineArgs()[1]);
					MF.A.B.Text = Path.GetFileNameWithoutExtension(Environment.GetCommandLineArgs()[1]);
				}
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000106E4 File Offset: 0x0000E8E4
		private void C()
		{
			if (Environment.GetCommandLineArgs().Length > 1)
			{
				MF.A = false;
				if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hf())
				{
					Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), MF.A.B.Text);
					Environment.Exit(0);
					return;
				}
				if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hG())
				{
					Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), MF.A.a.Text);
					Environment.Exit(0);
					return;
				}
				if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hg())
				{
					Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), MF.A.A.Text);
					Environment.Exit(0);
					return;
				}
				if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hH())
				{
					Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), MF.A.b.Text);
					Environment.Exit(0);
					return;
				}
				if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hh())
				{
					Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), MF.A.I.Text);
					Environment.Exit(0);
					return;
				}
				if (Environment.GetCommandLineArgs()[1] == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hI())
				{
					Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), MF.A.h.Text);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001083C File Offset: 0x0000EA3C
		private void c()
		{
			int num = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
			if (num > 1)
			{
				MF.A.Text = string.Concat(new string[]
				{
					Lang.WIN_TITLE,
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dS(),
					Lang.INSTANCE_TITLE,
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dS(),
					num.ToString()
				});
			}
			else
			{
				MF.A.Text = Lang.WIN_TITLE;
			}
			Vars.InsCount = num.ToString();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000108BB File Offset: 0x0000EABB
		private void D()
		{
			MF.A.Invoke(new Action(MF.A.A.b));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000108E8 File Offset: 0x0000EAE8
		internal void d()
		{
			try
			{
				APKEasyTool apkeasyTool = new APKEasyTool();
				apkeasyTool.DecApiLvl = MF.A.k.Text;
				apkeasyTool.ComApiLvl = MF.A.K.Text;
				apkeasyTool.SelectedPathMain = MF.A.pathOfApk.Text;
				apkeasyTool.SelectedDexOdexOat = MF.A.H.Text;
				apkeasyTool.SelectedSmali = MF.A.g.Text;
				apkeasyTool.PathDec = MF.A.B.Text;
				apkeasyTool.PathCom = MF.A.a.Text;
				apkeasyTool.PathExt = MF.A.A.Text;
				apkeasyTool.PathZip = MF.A.b.Text;
				apkeasyTool.PathBaksmali = MF.A.I.Text;
				apkeasyTool.PathSmali = MF.A.h.Text;
				apkeasyTool.PathPem = MF.A.d.Text;
				apkeasyTool.PathPk8 = MF.A.E.Text;
				apkeasyTool.PathJksFile = MF.A.D.Text;
				apkeasyTool.PathTempDec = TMain.fbdfolder;
				apkeasyTool.PathTempFw = TFW.tempfwfolder;
				apkeasyTool.PathTempFw2 = TFW.tempfwfolder2;
				apkeasyTool.PathFw = MF.A.F.Text;
				apkeasyTool.PathJava = MF.A.j.Text;
				apkeasyTool.FileNameDec = MF.A.a.Text;
				apkeasyTool.FileNameCom = MF.A.B.Text;
				apkeasyTool.FileNameDexOdexOat = MF.A.J.Text;
				apkeasyTool.FileNameSmali = MF.A.i.Text;
				apkeasyTool.DropDownApkTool = MF.A.A.Text;
				apkeasyTool.DwordX = MF.A.Location.X;
				apkeasyTool.DwordY = MF.A.Location.Y;
				apkeasyTool.DwordXmx = MF.A.A.Text;
				apkeasyTool.Language = MF.A.langComboBox.Text;
				apkeasyTool.CheckBoxDecB = MF.A.H.Checked;
				apkeasyTool.CheckBoxDecF = MF.A.K.Checked;
				apkeasyTool.CheckBoxDecK = MF.A.g.Checked;
				apkeasyTool.CheckBoxDecM = MF.A.G.Checked;
				apkeasyTool.CheckBoxDecR = MF.A.I.Checked;
				apkeasyTool.CheckBoxDecS = MF.A.h.Checked;
				apkeasyTool.CheckBoxDecNC = MF.A.e.Checked;
				apkeasyTool.CheckBoxDecOMC = MF.A.L.Checked;
				apkeasyTool.CheckBoxComC = MF.A.j.Checked;
				apkeasyTool.CheckBoxComD = MF.A.i.Checked;
				apkeasyTool.CheckBoxComF = MF.A.J.Checked;
				apkeasyTool.CheckBoxComNC = MF.A.F.Checked;
				apkeasyTool.CheckBoxComAapt2 = MF.A.f.Checked;
				apkeasyTool.CheckBoxZipF = MF.A.zipFcheckBox.Checked;
				apkeasyTool.CheckBoxZipP = MF.A.zipPcheckBox.Checked;
				apkeasyTool.CheckBoxZipZ = MF.A.zipZcheckBox.Checked;
				apkeasyTool.CheckBoxZipV = MF.A.zipVcheckBox.Checked;
				apkeasyTool.CheckBoxUseJks = MF.A.b.Checked;
				apkeasyTool.CheckBoxSignApk = MF.A.signApkCheckBox.Checked;
				apkeasyTool.CheckBoxInstallApk = MF.A.installApkChkBox.Checked;
				apkeasyTool.CheckBoxOverApk = MF.A.overApkChecked.Checked;
				apkeasyTool.CheckBoxZipAfterSign = MF.A.zipAfterSignChkBox.Checked;
				apkeasyTool.CheckBoxChkUpdate = MF.A.A.Checked;
				apkeasyTool.CheckBoxWinPos = MF.A.a.Checked;
				apkeasyTool.CheckBoxRememberPass = MF.A.B.Checked;
				apkeasyTool.CheckBoxDisHistory = MF.A.D.Checked;
				apkeasyTool.CheckBoxUseExtJava = MF.A.d.Checked;
				apkeasyTool.CheckBoxUseJavaXmx = MF.A.m.Checked;
				apkeasyTool.isSidedLogOpened = MF.a;
				apkeasyTool.CheckBoxTaskBar = MF.A.k.Checked;
				apkeasyTool.CheckBoxAapt = MF.A.l.Checked;
				apkeasyTool.TextBoxAapt = MF.A.L.Text;
				apkeasyTool.v2SigningEnabled = MF.A.c.Text;
				apkeasyTool.v3SigningEnabled = MF.A.b.Text;
				apkeasyTool.v4SigningEnabled = MF.A.C.Text;
				if (MF.A.B.Checked)
				{
					byte[] bytes = Encoding.UTF8.GetBytes(MF.A.c.Text);
					apkeasyTool.PassJks = Convert.ToBase64String(bytes);
				}
				XMLSave.SaveData(apkeasyTool, Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IA());
				if (!MF.A.D.Checked)
				{
					StreamWriter streamWriter = new StreamWriter(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ia());
					foreach (object obj in MF.A.pathOfApk.Items)
					{
						string value = (string)obj;
						if (value != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
						{
							streamWriter.WriteLine(value);
						}
					}
					streamWriter.Close();
					StreamWriter streamWriter2 = new StreamWriter(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IB());
					foreach (object obj2 in MF.A.a.Items)
					{
						string value2 = (string)obj2;
						if (value2 != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
						{
							streamWriter2.WriteLine(value2);
						}
					}
					streamWriter2.Close();
					StreamWriter streamWriter3 = new StreamWriter(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ib());
					foreach (object obj3 in MF.A.B.Items)
					{
						string value3 = (string)obj3;
						if (value3 != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
						{
							streamWriter3.WriteLine(value3);
						}
					}
					streamWriter3.Close();
				}
			}
			catch (Exception ex)
			{
				try
				{
					File.WriteAllText(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IC(), ex.ToString());
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0400023D RID: 573
		private static AMF A;

		// Token: 0x0400023E RID: 574
		internal static bool A;

		// Token: 0x0400023F RID: 575
		internal static bool a;

		// Token: 0x04000240 RID: 576
		public static Log _logform;

		// Token: 0x02000018 RID: 24
		[CompilerGenerated]
		[Serializable]
		private sealed class A
		{
			// Token: 0x0600019F RID: 415 RVA: 0x00011080 File Offset: 0x0000F280
			internal string A(string A_1)
			{
				return Path.GetFileName(A_1);
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x00011088 File Offset: 0x0000F288
			internal void A()
			{
				if (!new JC().checkIfJavaIsInstalled() && MF.A.j.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
				{
					MF.A.Invoke(new Action(MF.A.A.a));
				}
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x000110E8 File Offset: 0x0000F2E8
			internal void a()
			{
				MF.A.LogOutput(Lang.JAVA_NOT_INSTALLED_NOTICE, AMF.Type.Error, null, true);
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x00011110 File Offset: 0x0000F310
			internal void B()
			{
				if (MF.A && Environment.GetCommandLineArgs().Length < 2 && NetworkInterface.GetIsNetworkAvailable())
				{
					MF.A.LogOutput(Lang.CHK_FOR_UPDATE, AMF.Type.Info, null, true);
					string str = Updates.RemoteVersion();
					if (str != Vars.Version)
					{
						MF.A.LogOutput(Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iK(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ks()) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dS() + str, AMF.Type.Info, null, true);
					}
				}
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00011080 File Offset: 0x0000F280
			internal string a(string A_1)
			{
				return Path.GetFileName(A_1);
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x00011194 File Offset: 0x0000F394
			internal void b()
			{
				try
				{
					if (File.Exists(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IA()))
					{
						XmlSerializer xmlSerializer = new XmlSerializer(typeof(APKEasyTool));
						FileStream fileStream = new FileStream(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IA(), FileMode.Open, FileAccess.Read, FileShare.Read);
						APKEasyTool apkeasyTool = (APKEasyTool)xmlSerializer.Deserialize(fileStream);
						MF.A.k.Text = apkeasyTool.DecApiLvl;
						MF.A.K.Text = apkeasyTool.ComApiLvl;
						MF.A.pathOfApk.Text = apkeasyTool.SelectedPathMain;
						MF.A.H.Text = apkeasyTool.SelectedDexOdexOat;
						MF.A.g.Text = apkeasyTool.SelectedSmali;
						MF.A.B.Text = apkeasyTool.PathDec;
						MF.A.a.Text = apkeasyTool.PathCom;
						MF.A.A.Text = apkeasyTool.PathExt;
						MF.A.b.Text = apkeasyTool.PathZip;
						MF.A.I.Text = apkeasyTool.PathBaksmali;
						MF.A.h.Text = apkeasyTool.PathSmali;
						MF.A.d.Text = apkeasyTool.PathPem;
						MF.A.E.Text = apkeasyTool.PathPk8;
						MF.A.D.Text = apkeasyTool.PathJksFile;
						TMain.fbdfolder = apkeasyTool.PathTempDec;
						TFW.tempfwfolder = apkeasyTool.PathTempFw;
						TFW.tempfwfolder2 = apkeasyTool.PathTempFw2;
						MF.A.F.Text = apkeasyTool.PathFw;
						MF.A.j.Text = apkeasyTool.PathJava;
						MF.A.a.Text = apkeasyTool.FileNameDec;
						MF.A.B.Text = apkeasyTool.FileNameCom;
						MF.A.J.Text = apkeasyTool.FileNameDexOdexOat;
						MF.A.i.Text = apkeasyTool.FileNameSmali;
						MF.A.A.Text = apkeasyTool.DropDownApkTool;
						MF.A.A.Text = apkeasyTool.DwordXmx;
						MF.A.langComboBox.Text = apkeasyTool.Language;
						MF.A.H.Checked = apkeasyTool.CheckBoxDecB;
						MF.A.K.Checked = apkeasyTool.CheckBoxDecF;
						MF.A.g.Checked = apkeasyTool.CheckBoxDecK;
						MF.A.G.Checked = apkeasyTool.CheckBoxDecM;
						MF.A.I.Checked = apkeasyTool.CheckBoxDecR;
						MF.A.h.Checked = apkeasyTool.CheckBoxDecS;
						MF.A.e.Checked = apkeasyTool.CheckBoxDecNC;
						MF.A.L.Checked = apkeasyTool.CheckBoxDecOMC;
						MF.A.j.Checked = apkeasyTool.CheckBoxComC;
						MF.A.i.Checked = apkeasyTool.CheckBoxComD;
						MF.A.J.Checked = apkeasyTool.CheckBoxComF;
						MF.A.F.Checked = apkeasyTool.CheckBoxComNC;
						MF.A.f.Checked = apkeasyTool.CheckBoxComAapt2;
						MF.A.zipFcheckBox.Checked = apkeasyTool.CheckBoxZipF;
						MF.A.zipPcheckBox.Checked = apkeasyTool.CheckBoxZipP;
						MF.A.zipZcheckBox.Checked = apkeasyTool.CheckBoxZipZ;
						MF.A.zipVcheckBox.Checked = apkeasyTool.CheckBoxZipV;
						MF.A.b.Checked = apkeasyTool.CheckBoxUseJks;
						MF.A.signApkCheckBox.Checked = apkeasyTool.CheckBoxSignApk;
						MF.A.signApkCheckBox.Checked = apkeasyTool.CheckBoxSignApk;
						MF.A.installApkChkBox.Checked = apkeasyTool.CheckBoxInstallApk;
						MF.A.overApkChecked.Checked = apkeasyTool.CheckBoxOverApk;
						MF.A.zipAfterSignChkBox.Checked = apkeasyTool.CheckBoxZipAfterSign;
						MF.A.A.Checked = apkeasyTool.CheckBoxChkUpdate;
						MF.A.a.Checked = apkeasyTool.CheckBoxWinPos;
						MF.A.B.Checked = apkeasyTool.CheckBoxRememberPass;
						MF.A.D.Checked = apkeasyTool.CheckBoxDisHistory;
						MF.A.d.Checked = apkeasyTool.CheckBoxUseExtJava;
						MF.A.k.Checked = apkeasyTool.CheckBoxTaskBar;
						MF.A.l.Checked = apkeasyTool.CheckBoxAapt;
						MF.A.L.Text = apkeasyTool.TextBoxAapt;
						MF.A.m.Checked = apkeasyTool.CheckBoxUseJavaXmx;
						if (apkeasyTool.v2SigningEnabled != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
						{
							MF.A.c.Text = apkeasyTool.v2SigningEnabled;
						}
						if (apkeasyTool.v3SigningEnabled != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
						{
							MF.A.b.Text = apkeasyTool.v3SigningEnabled;
						}
						if (apkeasyTool.v4SigningEnabled != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
						{
							MF.A.C.Text = apkeasyTool.v4SigningEnabled;
						}
						if (MF.A.a.Checked)
						{
							MF.A.StartPosition = FormStartPosition.Manual;
							int dwordX = apkeasyTool.DwordX;
							int dwordY = apkeasyTool.DwordY;
							MF.A.Location = new Point(dwordX, dwordY);
						}
						if (MF.A.B.Checked)
						{
							byte[] bytes = Convert.FromBase64String(apkeasyTool.PassJks);
							MF.A.c.Text = Encoding.UTF8.GetString(bytes);
						}
						fileStream.Close();
					}
				}
				catch (Exception)
				{
				}
				try
				{
					if (!MF.A.D.Checked)
					{
						if (File.Exists(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ia()))
						{
							foreach (string item in File.ReadAllLines(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ia()))
							{
								MF.A.pathOfApk.Items.Add(item);
							}
						}
						if (File.Exists(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IB()))
						{
							foreach (string item2 in File.ReadAllLines(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IB()))
							{
								MF.A.a.Items.Add(item2);
							}
						}
						if (File.Exists(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ib()))
						{
							foreach (string item3 in File.ReadAllLines(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ib()))
							{
								MF.A.B.Items.Add(item3);
							}
						}
					}
				}
				catch (Exception)
				{
				}
				if (MF.A.A.Checked)
				{
					MF.A = true;
				}
				if (MF.a)
				{
					MF.A.K.Text = Lang.LOG_OUTPUT_BTN + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KT();
					MF.A.A.A();
				}
			}

			// Token: 0x04000241 RID: 577
			public static readonly MF.A A = new MF.A();

			// Token: 0x04000242 RID: 578
			public static Func<string, string> A;

			// Token: 0x04000243 RID: 579
			public static Action A;

			// Token: 0x04000244 RID: 580
			public static Action a;

			// Token: 0x04000245 RID: 581
			public static Action B;

			// Token: 0x04000246 RID: 582
			public static Func<string, string> a;

			// Token: 0x04000247 RID: 583
			public static Action b;
		}
	}
}
