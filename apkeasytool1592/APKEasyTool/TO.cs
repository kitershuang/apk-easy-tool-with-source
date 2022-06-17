using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x0200002A RID: 42
	public class TO
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00014BC6 File Offset: 0x00012DC6
		public TO(AMF Main)
		{
			TO.A = Main;
		}

		// Token: 0x060001E9 RID: 489
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x060001EA RID: 490 RVA: 0x00014BD4 File Offset: 0x00012DD4
		public static void SetButtonShield(Button btn, bool showShield)
		{
			TO.SendMessage(new HandleRef(btn, btn.Handle), 5644U, IntPtr.Zero, showShield ? new IntPtr(1) : IntPtr.Zero);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00014C04 File Offset: 0x00012E04
		internal void A(object A_1, EventArgs A_2)
		{
			TO.A a;
			a.A = AsyncVoidMethodBuilder.Create();
			a.A = this;
			a.A = -1;
			a.A.Start<TO.A>(ref a);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00014C3C File Offset: 0x00012E3C
		internal void a(object A_1, EventArgs A_2)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = Lang.SEL_ALL_DIR_DIAG;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Directory.CreateDirectory(folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iF());
					TO.A.B.Text = (folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iF()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@if(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy());
					Directory.CreateDirectory(folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iG());
					TO.A.a.Text = (folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iG()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@if(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy());
					Directory.CreateDirectory(folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ig());
					TO.A.A.Text = (folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ig()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@if(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy());
					Directory.CreateDirectory(folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iH());
					TO.A.b.Text = (folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iH()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@if(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy());
					Directory.CreateDirectory(folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ih());
					TO.A.I.Text = (folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ih()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@if(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy());
					Directory.CreateDirectory(folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iI());
					TO.A.h.Text = (folderBrowserDialog.SelectedPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iI()).Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@if(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy());
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00014E34 File Offset: 0x00013034
		internal void B(object A_1, EventArgs A_2)
		{
			TO.A.LogOutput(Lang.HIS_CLEAR_MBOX, AMF.Type.Info, null, true);
			TO.A.pathOfApk.Items.Clear();
			TO.A.a.Items.Clear();
			TO.A.B.Items.Clear();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00014E98 File Offset: 0x00013098
		internal void b(object A_1, EventArgs A_2)
		{
			if (MessageBox.Show(Lang.RES_DIAG, Lang.WIN_TITLE, MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					File.Delete(Vars.GetPath() + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.IA());
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				Application.Restart();
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00014EF8 File Offset: 0x000130F8
		private void A()
		{
			try
			{
				Vars.ApkToolVer = CMD.ProcessStartWithOutput(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hE(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ii() + Vars.Apktool + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iJ());
				TO.A.Invoke(new Action(TO.a.A.A));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00014F68 File Offset: 0x00013168
		[CompilerGenerated]
		private void a()
		{
			this.A();
		}

		// Token: 0x04000277 RID: 631
		private static AMF A;

		// Token: 0x0200002C RID: 44
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x00015092 File Offset: 0x00013292
			internal void A()
			{
				TO.A.apkvLbl.Text = Vars.ApkToolVer;
			}

			// Token: 0x0400027C RID: 636
			public static readonly TO.a A = new TO.a();

			// Token: 0x0400027D RID: 637
			public static Action A;
		}
	}
}
