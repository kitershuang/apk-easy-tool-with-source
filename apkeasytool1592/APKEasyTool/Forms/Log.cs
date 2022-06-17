using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool.Forms
{
	// Token: 0x02000036 RID: 54
	public partial class Log : Form
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00017644 File Offset: 0x00015844
		public Log()
		{
			this.A();
			this.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fx(), this.Text);
			this.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gI(), this.A.Text);
			Log._Main = this;
			base.ShowInTaskbar = false;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000176A0 File Offset: 0x000158A0
		public Log(AMF Main)
		{
			Log.A = Main;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000176B0 File Offset: 0x000158B0
		private void A(object A_1, EventArgs A_2)
		{
			this.richTextBoxLogs.Text = Log.A.richTextBoxLogs.Text;
			this.richTextBoxLogs.SelectionStart = this.richTextBoxLogs.Text.Length;
			this.richTextBoxLogs.ScrollToCaret();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000176FD File Offset: 0x000158FD
		private void a(object A_1, EventArgs A_2)
		{
			File.Delete(Vars.LogPath);
			this.richTextBoxLogs.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			Log.A.richTextBoxLogs.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00009A3A File Offset: 0x00007C3A
		private void A(object A_1, LinkClickedEventArgs A_2)
		{
			Process.Start(A_2.LinkText);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001774C File Offset: 0x0001594C
		private void A()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Log));
			this.richTextBoxLogs = new RichTextBox();
			this.A = new Button();
			base.SuspendLayout();
			this.richTextBoxLogs.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.richTextBoxLogs.BackColor = Color.Black;
			this.richTextBoxLogs.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.c(), 9.75f);
			this.richTextBoxLogs.ForeColor = Color.White;
			this.richTextBoxLogs.Location = new Point(5, 5);
			this.richTextBoxLogs.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.az();
			this.richTextBoxLogs.ReadOnly = true;
			this.richTextBoxLogs.Size = new Size(555, 524);
			this.richTextBoxLogs.TabIndex = 55;
			this.richTextBoxLogs.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			this.richTextBoxLogs.LinkClicked += this.A;
			this.A.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.A.ImeMode = ImeMode.NoControl;
			this.A.Location = new Point(440, 533);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BA();
			this.A.Size = new Size(120, 25);
			this.A.TabIndex = 60;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jI();
			this.A.UseVisualStyleBackColor = true;
			this.A.Click += this.a;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(565, 566);
			base.Controls.Add(this.richTextBoxLogs);
			base.Controls.Add(this.A);
			this.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			base.Icon = (Icon)componentResourceManager.GetObject(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.F());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ji();
			this.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ji();
			base.Load += this.A;
			base.ResumeLayout(false);
		}

		// Token: 0x040002BE RID: 702
		public static Log _Main;

		// Token: 0x040002BF RID: 703
		private static AMF A;

		// Token: 0x040002C1 RID: 705
		public RichTextBox richTextBoxLogs;

		// Token: 0x040002C2 RID: 706
		internal Button A;
	}
}
