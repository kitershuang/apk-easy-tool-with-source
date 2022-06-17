using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};
using A;
using APKEasyTool.Forms;

namespace APKEasyTool
{
	// Token: 0x02000020 RID: 32
	public class TMain
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00012248 File Offset: 0x00010448
		public TMain(AMF Main)
		{
			TMain.A = Main;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001227C File Offset: 0x0001047C
		internal static void A(string A_0)
		{
			if (A_0 == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dD())
			{
				TMain.A.J.Enabled = true;
				TMain.A.A.Enabled = true;
				TMain.A.a.Enabled = true;
				TMain.A.K.Enabled = true;
				TMain.A.J.Enabled = true;
				TMain.A.j.Enabled = true;
				TMain.A.C.Enabled = true;
				TMain.A.b.Enabled = true;
				TMain.A.B.Enabled = true;
				TMain.A.a.Enabled = true;
				TMain.A.B.Enabled = true;
				TMain.A.a.Enabled = true;
				TMain.A.b.Enabled = true;
				TMain.A.D.Enabled = true;
				TMain.A.c.Enabled = true;
				TMain.A.zipAfterSignChkBox.Enabled = true;
				TMain.A.signApkCheckBox.Enabled = true;
				TMain.A.installApkChkBox.Enabled = true;
				TMain.A.overApkChecked.Enabled = true;
				return;
			}
			if (A_0 == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dd())
			{
				TMain.A.apkicon.Image = null;
				TMain.A.pakLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.vercLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.verLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.minLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.tarLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.J.Enabled = false;
				TMain.A.A.Enabled = true;
				TMain.A.a.Enabled = true;
				TMain.A.K.Enabled = true;
				TMain.A.J.Enabled = true;
				TMain.A.j.Enabled = false;
				TMain.A.C.Enabled = false;
				TMain.A.b.Enabled = false;
				TMain.A.B.Enabled = false;
				TMain.A.a.Enabled = true;
				TMain.A.B.Enabled = true;
				TMain.A.a.Enabled = true;
				TMain.A.b.Enabled = true;
				TMain.A.D.Enabled = false;
				TMain.A.c.Enabled = false;
				TMain.A.zipAfterSignChkBox.Enabled = false;
				TMain.A.signApkCheckBox.Enabled = false;
				TMain.A.installApkChkBox.Enabled = false;
				TMain.A.overApkChecked.Enabled = false;
				return;
			}
			if (A_0 == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dE())
			{
				TMain.A.J.Enabled = true;
				TMain.A.A.Enabled = false;
				TMain.A.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				TMain.A.a.Enabled = false;
				TMain.A.B.Enabled = true;
				TMain.A.D.Enabled = false;
				TMain.A.c.Enabled = false;
				TMain.A.K.Enabled = true;
				TMain.A.J.Enabled = true;
				TMain.A.j.Enabled = true;
				TMain.A.C.Enabled = true;
				TMain.A.b.Enabled = true;
				TMain.A.B.Enabled = true;
				TMain.A.a.Enabled = true;
				TMain.A.b.Enabled = true;
				TMain.A.zipAfterSignChkBox.Enabled = true;
				TMain.A.signApkCheckBox.Enabled = true;
				TMain.A.installApkChkBox.Enabled = true;
				TMain.A.overApkChecked.Enabled = true;
				return;
			}
			if (!(A_0 == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dF()))
			{
				return;
			}
			TMain.A.J.Enabled = false;
			TMain.A.A.Enabled = false;
			TMain.A.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			TMain.A.a.Enabled = false;
			TMain.A.B.Enabled = true;
			TMain.A.D.Enabled = false;
			TMain.A.c.Enabled = false;
			TMain.A.K.Enabled = true;
			TMain.A.J.Enabled = true;
			TMain.A.j.Enabled = true;
			TMain.A.C.Enabled = false;
			TMain.A.b.Enabled = false;
			TMain.A.B.Enabled = false;
			TMain.A.a.Enabled = true;
			TMain.A.b.Enabled = true;
			TMain.A.zipAfterSignChkBox.Enabled = true;
			TMain.A.signApkCheckBox.Enabled = true;
			TMain.A.installApkChkBox.Enabled = true;
			TMain.A.overApkChecked.Enabled = true;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00012808 File Offset: 0x00010A08
		public void Readapk(string path)
		{
			TMain.C c;
			c.A = AsyncVoidMethodBuilder.Create();
			c.A = this;
			c.A = path;
			c.A = -1;
			c.A.Start<TMain.C>(ref c);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00012848 File Offset: 0x00010A48
		internal void a(string A_1)
		{
			TMain.E e;
			e.A = AsyncVoidMethodBuilder.Create();
			e.A = A_1;
			e.A = -1;
			e.A.Start<TMain.E>(ref e);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00012880 File Offset: 0x00010A80
		public string ShowSdkVer(string sdk)
		{
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ig())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IH();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ih())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.II();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ii())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IJ();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ij())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IK();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ik())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IL();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Il())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IM();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Im())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IN();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.In())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IO();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Io())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IP();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ip())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IQ();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Iq())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IR();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ir())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IS();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Is())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IT();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.It())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IU();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Iu())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IV();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Iv())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IW();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Iw())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IX();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ix())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IY();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Iy())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IZ();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Iz())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iA();
			}
			if (sdk == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ia())
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iB();
			}
			return sdk;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00012A20 File Offset: 0x00010C20
		internal void A()
		{
			if (!CMD.miniWinMode)
			{
				TMain._logform = Log._Main;
				if (TMain._logform != null && TMain._logform.Visible)
				{
					MF.a = false;
					string text = TMain.A.K.Text.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ib(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iC());
					TMain.A.K.Text = text;
					TMain._logform.Close();
					return;
				}
				MF.a = true;
				new Log
				{
					StartPosition = FormStartPosition.Manual,
					Top = TMain.A.Location.Y,
					Left = TMain.A.Location.X + TMain.A.Width
				}.Show();
				string text2 = TMain.A.K.Text.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iC(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ib());
				TMain.A.K.Text = text2;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00012B18 File Offset: 0x00010D18
		internal void A(object A_1, EventArgs A_2)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ic();
			openFileDialog.Title = Lang.SEL_FILES_DIAG;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				TMain.A.a.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
				TMain.A.B.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
				this.B(openFileDialog.FileName);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00012B8C File Offset: 0x00010D8C
		internal void a(object A_1, EventArgs A_2)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = TMain.fbdfolder;
			folderBrowserDialog.Description = Lang.SEL_DEC_DIAG;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				TMain.A.pathOfApk.Text = folderBrowserDialog.SelectedPath;
				TMain.fbdfolder = folderBrowserDialog.SelectedPath;
				DirectoryInfo directoryInfo = new DirectoryInfo(TMain.A.pathOfApk.Text);
				TMain.A.B.Text = directoryInfo.Name;
				TMain.A.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				this.B(folderBrowserDialog.SelectedPath);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00012C28 File Offset: 0x00010E28
		internal void B(string A_1)
		{
			try
			{
				if (Directory.Exists(A_1) && File.Exists(A_1 + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dG()) && File.Exists(A_1 + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dc()))
				{
					TMain.A.pathOfApk.Text = A_1;
					TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dE());
					this.a(A_1);
				}
				else if (Directory.Exists(A_1) && File.Exists(A_1 + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
				{
					TMain.A.pathOfApk.Text = A_1;
					TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dF());
					TMain.A.pakLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.vercLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.verLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.minLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.tarLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					if (TMain.A.apkicon.Image != null)
					{
						TMain.A.apkicon.Image.Dispose();
						TMain.A.apkicon.Image = null;
					}
				}
				else if (File.Exists(A_1))
				{
					TMain.A.pathOfApk.Text = A_1;
					if (Path.GetExtension(A_1) == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv())
					{
						TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dd());
						TMain.A.pakLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
						TMain.A.vercLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
						TMain.A.verLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
						TMain.A.minLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
						TMain.A.tarLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
						if (TMain.A.apkicon.Image != null)
						{
							TMain.A.apkicon.Image.Dispose();
							TMain.A.apkicon.Image = null;
						}
					}
					else
					{
						TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dD());
						this.Readapk(A_1);
					}
				}
				else
				{
					if (TMain.A.apkicon.Image != null)
					{
						TMain.A.apkicon.Image.Dispose();
						TMain.A.apkicon.Image = null;
					}
					TMain.A.pakLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.vercLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.verLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.minLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.tarLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					TMain.A.B.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					TMain.A.pathOfApk.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					TMain.A.LogOutput(Lang.INVALID_NOTICE, AMF.Type.Error, null, true);
					TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dD());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00012F8C File Offset: 0x0001118C
		internal void B(object A_1, EventArgs A_2)
		{
			if (TMain.A.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !TMain.A.D.Checked)
			{
				if (Directory.Exists(TMain.A.pathOfApk.Text) || File.Exists(TMain.A.pathOfApk.Text))
				{
					if (TMain.A.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !TMain.A.pathOfApk.Items.Contains(TMain.A.pathOfApk.Text))
					{
						TMain.A.pathOfApk.Items.Insert(0, TMain.A.pathOfApk.Text);
					}
					if (TMain.A.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
					{
						TMain.A.A.B(TMain.A.pathOfApk.Text);
						return;
					}
				}
				else
				{
					if (TMain.A.apkicon.Image != null)
					{
						TMain.A.apkicon.Image.Dispose();
						TMain.A.apkicon.Image = null;
					}
					TMain.A.pakLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.vercLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.verLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.minLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.tarLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
					TMain.A.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					TMain.A.B.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					TMain.A.LogOutput(Lang.INVALID_NOTICE, AMF.Type.Error, null, true);
					TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dD());
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00013180 File Offset: 0x00011380
		internal void b(object A_1, EventArgs A_2)
		{
			if (TMain.A.isLoaded)
			{
				this.B(TMain.A.pathOfApk.Text);
				TMain.A.a.Text = Path.GetFileNameWithoutExtension(TMain.A.pathOfApk.Text);
				TMain.A.B.Text = Path.GetFileNameWithoutExtension(TMain.A.pathOfApk.Text);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000131F4 File Offset: 0x000113F4
		internal void C(object A_1, EventArgs A_2)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(TMain.A.pakLbl.Text);
				Clipboard.SetText(stringBuilder.ToString());
				TMain.A.LogOutput(Lang.PAK_ID_COPY_NOTICE, AMF.Type.Info, null, true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00013268 File Offset: 0x00011468
		internal void c(object A_1, EventArgs A_2)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(TMain.A.launchLbl.Text);
				Clipboard.SetText(stringBuilder.ToString());
				TMain.A.LogOutput(Lang.LAUNCH_COPY_NOTICE, AMF.Type.Info, null, true);
			}
			catch (Exception ex)
			{
				TMain.A.LogOutput(ex.Message, AMF.Type.Error, null, true);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000132E4 File Offset: 0x000114E4
		internal void D(object A_1, EventArgs A_2)
		{
			if (TMain.A.A.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.APKTOOL_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				TMain.A.tMain.SelectedIndex = 4;
				return;
			}
			if (string.IsNullOrEmpty(TMain.A.pathOfApk.Text))
			{
				MessageBox.Show(Lang.APK_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (string.IsNullOrEmpty(TMain.A.B.Text))
			{
				MessageBox.Show(Lang.APK_DEC_NOT_SET_MBOX);
				return;
			}
			if (string.IsNullOrEmpty(TMain.A.a.Text))
			{
				MessageBox.Show(Lang.PLZ_NAME_DEC_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Directory.Exists(TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.a.Text) && MessageBox.Show(Lang.DEC_AGAIN_MBOX, Lang.WIN_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
			{
				return;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.df(), TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.a.Text, TMain.A.pathOfApk.Text);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001342C File Offset: 0x0001162C
		internal void d(object A_1, EventArgs A_2)
		{
			if (TMain.A.A.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.APKTOOL_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				TMain.A.tMain.SelectedIndex = 4;
				return;
			}
			if (string.IsNullOrEmpty(TMain.A.pathOfApk.Text))
			{
				MessageBox.Show(Lang.APK_DEX_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (string.IsNullOrEmpty(TMain.A.a.Text))
			{
				MessageBox.Show(Lang.APK_DEC_NOT_SET_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (string.IsNullOrEmpty(TMain.A.B.Text))
			{
				MessageBox.Show(Lang.ENTER_NAME_COM_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!Directory.Exists(TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.a.Text) && TMain.A.A.Enabled)
			{
				MessageBox.Show(Lang.DEC_APK_FIRST_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!TMain.A.A.Enabled)
			{
				if (File.Exists(TMain.A.pathOfApk.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dG()))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), TMain.A.pathOfApk.Text);
					return;
				}
				CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv(), TMain.A.pathOfApk.Text);
				return;
			}
			else
			{
				if (File.Exists(TMain.A.pathOfApk.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dG()) || Path.GetExtension(TMain.A.pathOfApk.Text) == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV())
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.a.Text);
					return;
				}
				CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv(), TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.a.Text);
				return;
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001370C File Offset: 0x0001190C
		internal void a()
		{
			if (string.IsNullOrEmpty(TMain.A.pathOfApk.Text))
			{
				MessageBox.Show(Lang.APK_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Path.GetExtension(TMain.A.pathOfApk.Text) == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV() && !File.Exists(TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()))
			{
				CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da(), Path.GetDirectoryName(TMain.A.pathOfApk.Text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(TMain.A.pathOfApk.Text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dI(), TMain.A.pathOfApk.Text);
				return;
			}
			if (TMain.A.zipAfterSignChkBox.Checked)
			{
				CMD.signApkClicked = true;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV());
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00013868 File Offset: 0x00011A68
		internal void B()
		{
			if (string.IsNullOrEmpty(TMain.A.pathOfApk.Text))
			{
				MessageBox.Show(Lang.APK_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!File.Exists(TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()))
			{
				MessageBox.Show(Lang.COM_APK_FIRST_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dB(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV());
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001394C File Offset: 0x00011B4C
		internal void b()
		{
			if (string.IsNullOrEmpty(TMain.A.pathOfApk.Text))
			{
				MessageBox.Show(Lang.APK_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!File.Exists(TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()))
			{
				MessageBox.Show(Lang.COM_APK_FIRST_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iD()).Length != 0)
			{
				if (MessageBox.Show(Lang.ADB_BUSY_MBOX, Lang.WIN_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
				{
					return;
				}
				Process[] processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iD());
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.db(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV());
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00013A50 File Offset: 0x00011C50
		internal void E(object A_1, EventArgs A_2)
		{
			if (File.Exists(TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hw()))
			{
				CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DY(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hw());
				return;
			}
			if (File.Exists(TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()))
			{
				CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DY(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), TMain.A.a.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TMain.A.B.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV());
				return;
			}
			MessageBox.Show(Lang.ZIPALIGN_FIRST_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00013B54 File Offset: 0x00011D54
		internal void e(object A_1, EventArgs A_2)
		{
			if (string.IsNullOrEmpty(TMain.A.pathOfApk.Text))
			{
				MessageBox.Show(Lang.APK_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.di(), TMain.A.A.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileName(TMain.A.pathOfApk.Text), TMain.A.pathOfApk.Text);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00013BD4 File Offset: 0x00011DD4
		internal void F(object A_1, EventArgs A_2)
		{
			if (string.IsNullOrEmpty(TMain.A.pathOfApk.Text))
			{
				MessageBox.Show(Lang.APK_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!Directory.Exists(TMain.A.A.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileName(TMain.A.pathOfApk.Text)))
			{
				MessageBox.Show(Lang.EXT_APK_FIRST_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dJ(), TMain.A.b.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileName(TMain.A.pathOfApk.Text), TMain.A.A.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileName(TMain.A.pathOfApk.Text));
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00013CB8 File Offset: 0x00011EB8
		internal void C()
		{
			if (MessageBox.Show(Lang.CANCEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (CMD.g == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.di() || CMD.g == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dJ())
				{
					Process[] processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.id());
					for (int i = 0; i < processesByName.Length; i++)
					{
						processesByName[i].Kill();
					}
				}
				else if (CMD.g == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.db())
				{
					Process[] processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iD());
					for (int i = 0; i < processesByName.Length; i++)
					{
						processesByName[i].Kill();
					}
				}
				else if (CMD.g == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dB())
				{
					Process[] processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iE());
					for (int i = 0; i < processesByName.Length; i++)
					{
						processesByName[i].Kill();
					}
				}
				else
				{
					Process[] processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ie());
					for (int i = 0; i < processesByName.Length; i++)
					{
						processesByName[i].Kill();
					}
				}
				TMain.A.LogOutput(Lang.CANCELLED_LOG, AMF.Type.Info, null, true);
				TMain.A.A.CancelAsync();
				CMD.isCancelled = true;
				CMD.task = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				TMain.A.tMain.Enabled = true;
			}
		}

		// Token: 0x04000255 RID: 597
		private static AMF A;

		// Token: 0x04000256 RID: 598
		private readonly string[] A = new string[]
		{
			68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IF(),
			68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.If(),
			68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IG()
		};

		// Token: 0x04000257 RID: 599
		public static string fbdfolder = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();

		// Token: 0x04000258 RID: 600
		public static string apkinfo = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();

		// Token: 0x04000259 RID: 601
		private string A;

		// Token: 0x0400025A RID: 602
		public static Log _logform;

		// Token: 0x02000021 RID: 33
		[CompilerGenerated]
		private sealed class A
		{
			// Token: 0x060001D1 RID: 465 RVA: 0x00013E10 File Offset: 0x00012010
			internal void A()
			{
				TMain.a a = new TMain.a();
				a.a = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KV();
				a.A = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				TMain.A.LogOutput(Lang.READ_APK, AMF.Type.Info, null, true);
				TMain.apkinfo = CMD.ProcessStartWithOutput(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kv()), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KW() + this.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DS());
				if (TMain.A.apkicon.Image != null)
				{
					TMain.A.apkicon.Image.Dispose();
					TMain.A.apkicon.Image = null;
				}
				try
				{
					TMain.A.Invoke(new Action(a.A));
					try
					{
						TMain.B b = new TMain.B();
						b.A = a;
						string text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kw(), TMain.apkinfo);
						b.A = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KX(), TMain.apkinfo);
						TMain.A.Invoke(new Action(b.A));
						this.A.A = b.A;
						if (Path.GetExtension(text) == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kx())
						{
							text = text.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kx(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KY());
						}
						b.a = Vars.TempPathCache + b.A.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + text;
						string directoryName = Path.GetDirectoryName(b.a);
						if (text.Contains(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ky()))
						{
							foreach (string newValue in this.A.A)
							{
								string text2 = text.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KZ(), newValue).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kz(), newValue);
								CMD.ProcessStartWithOutput(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kj()), string.Concat(new string[]
								{
									68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kA(),
									this.A,
									68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ka(),
									text2,
									68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kk(),
									directoryName,
									68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KL()
								}));
							}
						}
						else
						{
							CMD.ProcessStartWithOutput(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kj()), string.Concat(new string[]
							{
								68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kA(),
								this.A,
								68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ka(),
								text,
								68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kk(),
								directoryName,
								68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KL()
							}));
						}
						CMD.ProcessStartWithOutput(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Kj()), string.Concat(new string[]
						{
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kA(),
							this.A,
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ka(),
							Vars.TempPathCache,
							b.A.A,
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kB()
						}));
						string[] files = Directory.GetFiles(Vars.TempPathCache + b.A.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kb(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kC());
						if (!Directory.Exists(Vars.TempPathCache + b.A.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kb()))
						{
							b.A.a = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kc();
						}
						else if (files.Length != 0)
						{
							foreach (string text3 in File.ReadAllLines(files[0]))
							{
								if (text3.Contains(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kD()))
								{
									b.A.a = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kd();
									break;
								}
								if (text3.Contains(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kE()))
								{
									b.A.a = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ke();
									break;
								}
							}
						}
						TMain.A.Invoke(new Action(b.a));
					}
					catch (Exception)
					{
						TMain.A.Invoke(new Action(TMain.b.A.A));
					}
					TMain.A.LogOutput(Lang.DONE, AMF.Type.Info, null, false);
				}
				catch (Exception)
				{
					TMain.A.LogOutput(Lang.ERROR_READ_APK, AMF.Type.Error, null, true);
					TMain.A.Invoke(new Action(TMain.b.A.a));
				}
			}

			// Token: 0x0400025B RID: 603
			public string A;

			// Token: 0x0400025C RID: 604
			public TMain A;
		}

		// Token: 0x02000022 RID: 34
		[CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060001D3 RID: 467 RVA: 0x00014258 File Offset: 0x00012458
			internal void A()
			{
				TMain.A.pakLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kF(), TMain.apkinfo);
				this.A = TMain.A.pakLbl.Text;
				TMain.A.vercLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kf(), TMain.apkinfo);
				TMain.A.verLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kG(), TMain.apkinfo);
				TMain.A.minLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kg(), TMain.apkinfo);
				TMain.A.tarLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kH(), TMain.apkinfo);
			}

			// Token: 0x0400025D RID: 605
			public string A;

			// Token: 0x0400025E RID: 606
			public string a;
		}

		// Token: 0x02000023 RID: 35
		[CompilerGenerated]
		private sealed class B
		{
			// Token: 0x060001D5 RID: 469 RVA: 0x00014310 File Offset: 0x00012510
			internal void A()
			{
				TMain.A.launchLbl.Text = this.A;
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x00014328 File Offset: 0x00012528
			internal void a()
			{
				try
				{
					TMain.A.apkicon.Image = Image.FromFile(this.a);
				}
				catch (Exception)
				{
					TMain.A.apkicon.Image = global::A.a.m();
				}
				TMain.A.sigVer.Text = this.A.a;
				TMain.A.F.Enabled = true;
			}

			// Token: 0x0400025F RID: 607
			public string A;

			// Token: 0x04000260 RID: 608
			public string a;

			// Token: 0x04000261 RID: 609
			public TMain.a A;
		}

		// Token: 0x02000024 RID: 36
		[CompilerGenerated]
		[Serializable]
		private sealed class b
		{
			// Token: 0x060001D9 RID: 473 RVA: 0x000143B0 File Offset: 0x000125B0
			internal void A()
			{
				TMain.A.apkicon.Image = global::A.a.m();
				TMain.A.F.Enabled = true;
				TMain.A.sigVer.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kh();
			}

			// Token: 0x060001DA RID: 474 RVA: 0x000143EC File Offset: 0x000125EC
			internal void a()
			{
				TMain.A.apkicon.Image = null;
				TMain.A.pakLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.launchLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.vercLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.verLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.minLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.tarLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.sigVer.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
			}

			// Token: 0x060001DB RID: 475 RVA: 0x00014495 File Offset: 0x00012695
			internal void B()
			{
				TMain.A.apkicon.Image = null;
				TMain.A.F.Enabled = true;
			}

			// Token: 0x060001DC RID: 476 RVA: 0x000144B7 File Offset: 0x000126B7
			internal void b()
			{
				TMain.A.apkicon.Image = global::A.a.m();
			}

			// Token: 0x060001DD RID: 477 RVA: 0x000144D0 File Offset: 0x000126D0
			internal void C()
			{
				if (TMain.A.apkicon.Image != null)
				{
					TMain.A.apkicon.Image.Dispose();
					TMain.A.apkicon.Image = null;
				}
				TMain.A.pakLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.vercLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.verLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.minLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.tarLbl.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.sigVer.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw();
				TMain.A.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				TMain.A.B.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
				TMain.A.LogOutput(Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kI(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ki()), AMF.Type.Error, null, true);
				TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dD());
			}

			// Token: 0x04000262 RID: 610
			public static readonly TMain.b A = new TMain.b();

			// Token: 0x04000263 RID: 611
			public static Action A;

			// Token: 0x04000264 RID: 612
			public static Action a;

			// Token: 0x04000265 RID: 613
			public static Action B;

			// Token: 0x04000266 RID: 614
			public static Action b;

			// Token: 0x04000267 RID: 615
			public static Action C;
		}

		// Token: 0x02000026 RID: 38
		[CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060001E1 RID: 481 RVA: 0x000146CC File Offset: 0x000128CC
			internal void A()
			{
				TMain.A.Invoke(new Action(TMain.b.A.B));
				try
				{
					if (File.Exists(this.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
					{
						TMain.D d = new TMain.D();
						d.A = this;
						d.A = File.ReadAllText(this.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de());
						d.a = File.ReadAllText(this.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dC());
						TMain.apkinfo = d.A;
						TMain.A.Invoke(new Action(d.A));
						List<string> list = new List<string>
						{
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.If(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kJ(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kj(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kK(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IF(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kk(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kL(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kl(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kM(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IG(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.km(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kN(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kn(),
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kO()
						};
						if (File.Exists(this.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dC()))
						{
							string text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ko(), d.a);
							foreach (string newValue in list)
							{
								TMain.d d2 = new TMain.d();
								d2.A = d;
								if (text.Contains(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kP()))
								{
									d2.A = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kp() + text.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kQ(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kP(), newValue) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KY();
								}
								else
								{
									d2.A = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kp() + text.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kQ(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kq(), newValue) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.KY();
								}
								if (File.Exists(this.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + d2.A.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kR(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy())))
								{
									TMain.A.Invoke(new Action(d2.A));
									return;
								}
							}
							TMain.A.Invoke(new Action(TMain.b.A.b));
						}
					}
					else
					{
						TMain.A.Invoke(new Action(TMain.b.A.C));
					}
				}
				catch (Exception)
				{
					TMain.A.apkicon.Image = global::A.a.m();
				}
			}

			// Token: 0x0400026D RID: 621
			public string A;
		}

		// Token: 0x02000027 RID: 39
		[CompilerGenerated]
		private sealed class D
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x000149F0 File Offset: 0x00012BF0
			internal void A()
			{
				TMain.A.minLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kr(), this.A);
				TMain.A.tarLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kS(), this.A);
				TMain.A.vercLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ks(), this.A);
				TMain.A.verLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kT(), this.A);
				TMain.A.pakLbl.Text = S.Regex(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kt(), this.a);
			}

			// Token: 0x0400026E RID: 622
			public string A;

			// Token: 0x0400026F RID: 623
			public string a;

			// Token: 0x04000270 RID: 624
			public TMain.c A;
		}

		// Token: 0x02000028 RID: 40
		[CompilerGenerated]
		private sealed class d
		{
			// Token: 0x060001E5 RID: 485 RVA: 0x00014A98 File Offset: 0x00012C98
			internal void A()
			{
				TMain.A.apkicon.Image = Image.FromFile(this.A.A.A + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + this.A.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.kR(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy()));
			}

			// Token: 0x04000271 RID: 625
			public string A;

			// Token: 0x04000272 RID: 626
			public TMain.D A;
		}
	}
}
