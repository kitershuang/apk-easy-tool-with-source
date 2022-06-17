using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x0200002E RID: 46
	public partial class U : Form
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x000152C3 File Offset: 0x000134C3
		public U(AMF Main)
		{
			U.A = Main;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000152D4 File Offset: 0x000134D4
		public U()
		{
			this.A();
			this.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ij(), this.Text);
			this.a.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iK(), this.a.Text);
			this.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ik(), this.A.Text);
			this.B.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iL(), this.B.Text);
			this.b.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.il(), this.b.Text);
			this.C.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iM(), this.C.Text);
			this.c.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.im(), this.c.Text);
			this.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iN(), this.A.Text);
			this.a.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.il(), this.a.Text);
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(U.A.Location.X + 30, U.A.Location.Y + 30);
			this.A.RunWorkerAsync();
			string str = Updates.RemoteVersion();
			if (str == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@in())
			{
				MessageBox.Show(Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iO(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.io()), Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			this.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iP(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ip()) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dS() + str;
			this.a.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iQ(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iq()) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dS() + Vars.Version;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000154C8 File Offset: 0x000136C8
		private void A(object A_1, LinkLabelLinkClickedEventArgs A_2)
		{
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iR());
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000154D8 File Offset: 0x000136D8
		private void A(object A_1, EventArgs A_2)
		{
			this.a.Enabled = false;
			this.c.Text = Lang.DOWN_STAT_LBL;
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadProgressChanged += this.A;
				webClient.DownloadFileCompleted += this.A;
				webClient.DownloadFileAsync(new Uri(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ir()), Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iS());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00015570 File Offset: 0x00013770
		private void a(object A_1, EventArgs A_2)
		{
			this.a.Enabled = false;
			this.c.Text = Lang.DOWNLOADING_LBL;
			try
			{
				WebClient webClient = new WebClient();
				webClient.DownloadProgressChanged += this.A;
				webClient.DownloadFileCompleted += this.A;
				webClient.DownloadFileAsync(new Uri(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@is()), Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iT());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00015608 File Offset: 0x00013808
		private void A(object A_1, DownloadProgressChangedEventArgs A_2)
		{
			this.A.Value = A_2.ProgressPercentage;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001561B File Offset: 0x0001381B
		private void A(object A_1, AsyncCompletedEventArgs A_2)
		{
			this.a.Enabled = true;
			this.c.Text = Lang.DOWN_OK_LBL;
			Process.Start(Vars.TempPath + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iT());
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001564E File Offset: 0x0001384E
		private void B(object A_1, EventArgs A_2)
		{
			base.Close();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00015658 File Offset: 0x00013858
		private void A(object A_1, DoWorkEventArgs A_2)
		{
			WebClient webClient = new WebClient();
			this.A = webClient.DownloadString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.it());
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0001567C File Offset: 0x0001387C
		private void A(object A_1, RunWorkerCompletedEventArgs A_2)
		{
			this.A.Text = this.A;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000156B0 File Offset: 0x000138B0
		private void A()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(U));
			this.A = new PictureBox();
			this.A = new Label();
			this.a = new Label();
			this.A = new LinkLabel();
			this.A = new RichTextBox();
			this.A = new Panel();
			this.B = new Label();
			this.a = new Panel();
			this.b = new Label();
			this.C = new Label();
			this.A = new Button();
			this.a = new PictureBox();
			this.B = new PictureBox();
			this.A = new ProgressBar();
			this.a = new Button();
			this.c = new Label();
			this.A = new BackgroundWorker();
			((ISupportInitialize)this.A).BeginInit();
			((ISupportInitialize)this.a).BeginInit();
			((ISupportInitialize)this.B).BeginInit();
			base.SuspendLayout();
			this.A.Image = (Image)componentResourceManager.GetObject(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iU());
			this.A.Location = new Point(12, 12);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iu();
			this.A.Size = new Size(50, 50);
			this.A.SizeMode = PictureBoxSizeMode.StretchImage;
			this.A.TabIndex = 54;
			this.A.TabStop = false;
			this.A.AutoSize = true;
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 12f, FontStyle.Bold);
			this.A.ImeMode = ImeMode.NoControl;
			this.A.Location = new Point(77, 12);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iV();
			this.A.Size = new Size(115, 21);
			this.A.TabIndex = 52;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iv();
			this.a.AutoSize = true;
			this.a.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 12f);
			this.a.ImeMode = ImeMode.NoControl;
			this.a.Location = new Point(77, 41);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iW();
			this.a.Size = new Size(97, 21);
			this.a.TabIndex = 51;
			this.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iw();
			this.A.AutoSize = true;
			this.A.Cursor = Cursors.Hand;
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 9.75f);
			this.A.ImeMode = ImeMode.NoControl;
			this.A.LinkBehavior = LinkBehavior.HoverUnderline;
			this.A.Location = new Point(472, 19);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iX();
			this.A.Size = new Size(100, 17);
			this.A.TabIndex = 48;
			this.A.TabStop = true;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ix();
			this.A.TextAlign = ContentAlignment.TopRight;
			this.A.LinkClicked += this.A;
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 9f);
			this.A.Location = new Point(12, 113);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iY();
			this.A.Size = new Size(571, 131);
			this.A.TabIndex = 55;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			this.A.BackColor = Color.DarkGray;
			this.A.Location = new Point(12, 105);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aP();
			this.A.Size = new Size(571, 1);
			this.A.TabIndex = 62;
			this.B.AutoSize = true;
			this.B.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 14.25f, FontStyle.Bold);
			this.B.ImeMode = ImeMode.NoControl;
			this.B.Location = new Point(49, 75);
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ap();
			this.B.Size = new Size(108, 25);
			this.B.TabIndex = 61;
			this.B.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iy();
			this.a.BackColor = Color.DarkGray;
			this.a.Location = new Point(12, 298);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iZ();
			this.a.Size = new Size(571, 1);
			this.a.TabIndex = 64;
			this.b.AutoSize = true;
			this.b.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 14.25f, FontStyle.Bold);
			this.b.ImeMode = ImeMode.NoControl;
			this.b.Location = new Point(49, 268);
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bf();
			this.b.Size = new Size(104, 25);
			this.b.TabIndex = 63;
			this.b.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iz();
			this.C.AutoSize = true;
			this.C.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 9f);
			this.C.ImeMode = ImeMode.NoControl;
			this.C.Location = new Point(159, 276);
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Br();
			this.C.Size = new Size(222, 15);
			this.C.TabIndex = 65;
			this.C.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JA();
			this.A.Location = new Point(484, 417);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ja();
			this.A.Size = new Size(99, 23);
			this.A.TabIndex = 66;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JB();
			this.A.UseVisualStyleBackColor = true;
			this.A.Click += this.B;
			this.a.Image = (Image)componentResourceManager.GetObject(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jb());
			this.a.Location = new Point(13, 72);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bA();
			this.a.Size = new Size(33, 31);
			this.a.SizeMode = PictureBoxSizeMode.StretchImage;
			this.a.TabIndex = 71;
			this.a.TabStop = false;
			this.B.Image = (Image)componentResourceManager.GetObject(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JC());
			this.B.Location = new Point(12, 265);
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CD();
			this.B.Size = new Size(33, 31);
			this.B.SizeMode = PictureBoxSizeMode.StretchImage;
			this.B.TabIndex = 72;
			this.B.TabStop = false;
			this.A.Location = new Point(27, 308);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jc();
			this.A.Size = new Size(545, 23);
			this.A.TabIndex = 73;
			this.a.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.a.ImageAlign = ContentAlignment.MiddleLeft;
			this.a.Location = new Point(187, 368);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JD();
			this.a.Size = new Size(214, 40);
			this.a.TabIndex = 74;
			this.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iz();
			this.a.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.a.UseVisualStyleBackColor = true;
			this.a.Click += this.a;
			this.c.AutoSize = true;
			this.c.Location = new Point(24, 337);
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jd();
			this.c.Size = new Size(41, 13);
			this.c.TabIndex = 76;
			this.c.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JE();
			this.A.DoWork += this.A;
			this.A.RunWorkerCompleted += this.A;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(600, 450);
			base.Controls.Add(this.c);
			base.Controls.Add(this.a);
			base.Controls.Add(this.A);
			base.Controls.Add(this.B);
			base.Controls.Add(this.a);
			base.Controls.Add(this.A);
			base.Controls.Add(this.C);
			base.Controls.Add(this.a);
			base.Controls.Add(this.b);
			base.Controls.Add(this.A);
			base.Controls.Add(this.B);
			base.Controls.Add(this.A);
			base.Controls.Add(this.A);
			base.Controls.Add(this.A);
			base.Controls.Add(this.a);
			base.Controls.Add(this.A);
			this.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Icon = (Icon)componentResourceManager.GetObject(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.F());
			base.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Je();
			this.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JF();
			((ISupportInitialize)this.A).EndInit();
			((ISupportInitialize)this.a).EndInit();
			((ISupportInitialize)this.B).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400027F RID: 639
		private static AMF A;

		// Token: 0x04000280 RID: 640
		private string A;

		// Token: 0x04000281 RID: 641
		private Version A;

		// Token: 0x04000283 RID: 643
		private PictureBox A;

		// Token: 0x04000284 RID: 644
		internal Label A;

		// Token: 0x04000285 RID: 645
		private Label a;

		// Token: 0x04000286 RID: 646
		private LinkLabel A;

		// Token: 0x04000287 RID: 647
		private RichTextBox A;

		// Token: 0x04000288 RID: 648
		private Panel A;

		// Token: 0x04000289 RID: 649
		private Label B;

		// Token: 0x0400028A RID: 650
		private Panel a;

		// Token: 0x0400028B RID: 651
		private Label b;

		// Token: 0x0400028C RID: 652
		private Label C;

		// Token: 0x0400028D RID: 653
		private Button A;

		// Token: 0x0400028E RID: 654
		private PictureBox a;

		// Token: 0x0400028F RID: 655
		private PictureBox B;

		// Token: 0x04000290 RID: 656
		private ProgressBar A;

		// Token: 0x04000291 RID: 657
		private Button a;

		// Token: 0x04000292 RID: 658
		private Label c;

		// Token: 0x04000293 RID: 659
		private BackgroundWorker A;
	}
}
