using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x02000031 RID: 49
	public partial class WW : Form
	{
		// Token: 0x0600020B RID: 523 RVA: 0x0001632A File Offset: 0x0001452A
		public WW(AMF Main)
		{
			WW.A = Main;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00016338 File Offset: 0x00014538
		public WW()
		{
			this.A();
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(WW.A.Location.X + 30, WW.A.Location.Y + 30);
			this.A.Text = WW.message;
			this.a.Text = Path.GetFileName(WW.file);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000163B4 File Offset: 0x000145B4
		private void A(object A_1, EventArgs A_2)
		{
			if (MessageBox.Show(Lang.CANCEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Process[] processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ie());
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
				processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iD());
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
				processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iE());
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
				processesByName = Process.GetProcessesByName(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.id());
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
				Application.Exit();
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00016462 File Offset: 0x00014662
		private void a(object A_1, EventArgs A_2)
		{
			this.A.Start();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00016470 File Offset: 0x00014670
		private void B(object A_1, EventArgs A_2)
		{
			try
			{
				if (WW.A.k.Checked)
				{
					JList.TaskBar(1);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000164CC File Offset: 0x000146CC
		private void A()
		{
			this.A = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WW));
			this.A = new Label();
			this.A = new Panel();
			this.A = new Button();
			this.A = new ProgressBar();
			this.a = new Label();
			this.A = new Timer(this.A);
			this.A.SuspendLayout();
			base.SuspendLayout();
			this.A.AutoSize = true;
			this.A.Location = new Point(20, 13);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jk();
			this.A.Size = new Size(38, 13);
			this.A.TabIndex = 0;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bf();
			this.A.BackColor = Color.FromArgb(240, 240, 240);
			this.A.Controls.Add(this.A);
			this.A.Dock = DockStyle.Bottom;
			this.A.Location = new Point(0, 95);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iZ();
			this.A.Size = new Size(439, 44);
			this.A.TabIndex = 1;
			this.A.Location = new Point(337, 9);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hN();
			this.A.Size = new Size(89, 25);
			this.A.TabIndex = 0;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hn();
			this.A.UseVisualStyleBackColor = true;
			this.A.Click += this.A;
			this.A.Location = new Point(23, 57);
			this.A.MarqueeAnimationSpeed = 20;
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jc();
			this.A.Size = new Size(397, 23);
			this.A.Style = ProgressBarStyle.Marquee;
			this.A.TabIndex = 2;
			this.a.AutoSize = true;
			this.a.Location = new Point(20, 33);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.JL();
			this.a.Size = new Size(38, 13);
			this.a.TabIndex = 4;
			this.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Br();
			this.A.Interval = 1000;
			this.A.Tick += this.B;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			this.BackColor = Color.White;
			base.ClientSize = new Size(439, 139);
			base.Controls.Add(this.a);
			base.Controls.Add(this.A);
			base.Controls.Add(this.A);
			base.Controls.Add(this.A);
			this.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Icon = (Icon)componentResourceManager.GetObject(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.F());
			base.MaximizeBox = false;
			base.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jl();
			this.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@do();
			base.Load += this.a;
			this.A.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002A0 RID: 672
		public static string message;

		// Token: 0x040002A1 RID: 673
		public static string file;

		// Token: 0x040002A2 RID: 674
		private static AMF A;

		// Token: 0x040002A4 RID: 676
		private Label A;

		// Token: 0x040002A5 RID: 677
		private Panel A;

		// Token: 0x040002A6 RID: 678
		private Button A;

		// Token: 0x040002A7 RID: 679
		private ProgressBar A;

		// Token: 0x040002A8 RID: 680
		private Label a;

		// Token: 0x040002A9 RID: 681
		private Timer A;
	}
}
