using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x0200001E RID: 30
	public class TFW
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00011F4F File Offset: 0x0001014F
		public TFW(AMF Main)
		{
			TFW.A = Main;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00011F60 File Offset: 0x00010160
		internal void A(object A_1, EventArgs A_2)
		{
			if (TFW.A.A.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.APKTOOL_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (string.IsNullOrEmpty(TFW.A.C.Text))
			{
				MessageBox.Show(Lang.FW_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dK(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), TFW.A.C.Text);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00011FE4 File Offset: 0x000101E4
		internal void a(object A_1, EventArgs A_2)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = Lang.SEL_FW_FOLDER_DIAG;
			folderBrowserDialog.SelectedPath = TFW.tempfwfolder;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				TFW.A.e.Text = folderBrowserDialog.SelectedPath;
				TFW.tempfwfolder = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00012038 File Offset: 0x00010238
		internal void B(object A_1, EventArgs A_2)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = Lang.SEL_FW_STORED_DIAG;
			folderBrowserDialog.SelectedPath = TFW.tempfwfolder;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				TFW.A.F.Text = folderBrowserDialog.SelectedPath;
				TFW.tempfwfolder2 = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0001208C File Offset: 0x0001028C
		internal void b(object A_1, EventArgs A_2)
		{
			if (TFW.A.F.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), TFW.A.F.Text);
				return;
			}
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Id()))
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Id());
				return;
			}
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IE());
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00012120 File Offset: 0x00010320
		internal void C(object A_1, EventArgs A_2)
		{
			if (TFW.A.A.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.APKTOOL_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				TFW.A.tMain.SelectedIndex = 4;
				return;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ie(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b());
		}

		// Token: 0x04000250 RID: 592
		private static AMF A;

		// Token: 0x04000251 RID: 593
		public static string tempfwfolder = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();

		// Token: 0x04000252 RID: 594
		public static string tempfwfolder2 = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
	}
}
