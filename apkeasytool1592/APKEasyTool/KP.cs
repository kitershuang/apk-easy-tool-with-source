using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x02000016 RID: 22
	public partial class KP : Form
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000FAF5 File Offset: 0x0000DCF5
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000FAFD File Offset: 0x0000DCFD
		public string ReturnKeyPass { get; set; }

		// Token: 0x0600018D RID: 397 RVA: 0x0000FB06 File Offset: 0x0000DD06
		public KP(AMF Main)
		{
			KP.A = Main;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000FB14 File Offset: 0x0000DD14
		public KP()
		{
			this.A();
			this.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hi(), this.Text);
			this.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hJ(), this.A.Text);
			this.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hj(), this.A.Text);
			this.a.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hK(), this.a.Text);
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(KP.A.Location.X + 200, KP.A.Location.Y + 200);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000FBE5 File Offset: 0x0000DDE5
		private void A(object A_1, EventArgs A_2)
		{
			this.ReturnKeyPass = this.A.Text;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000FBFF File Offset: 0x0000DDFF
		private void a(object A_1, EventArgs A_2)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000FC28 File Offset: 0x0000DE28
		private void A()
		{
			this.A = new Label();
			this.A = new TextBox();
			this.A = new Button();
			this.a = new Button();
			base.SuspendLayout();
			this.A.AutoSize = true;
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			this.A.ImeMode = ImeMode.NoControl;
			this.A.Location = new Point(12, 9);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hk();
			this.A.Size = new Size(163, 13);
			this.A.TabIndex = 37;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hL();
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			this.A.Location = new Point(15, 36);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hl();
			this.A.PasswordChar = '*';
			this.A.Size = new Size(292, 22);
			this.A.TabIndex = 38;
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			this.A.ImeMode = ImeMode.NoControl;
			this.A.Location = new Point(228, 71);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hM();
			this.A.Size = new Size(79, 23);
			this.A.TabIndex = 39;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hm();
			this.A.UseVisualStyleBackColor = true;
			this.A.Click += this.A;
			this.a.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			this.a.ImeMode = ImeMode.NoControl;
			this.a.Location = new Point(143, 71);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hN();
			this.a.Size = new Size(79, 23);
			this.a.TabIndex = 40;
			this.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hn();
			this.a.UseVisualStyleBackColor = true;
			this.a.Click += this.a;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(319, 105);
			base.Controls.Add(this.a);
			base.Controls.Add(this.A);
			base.Controls.Add(this.A);
			base.Controls.Add(this.A);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hO();
			this.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ho();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000236 RID: 566
		private static AMF A;

		// Token: 0x04000237 RID: 567
		[CompilerGenerated]
		private string A;

		// Token: 0x04000239 RID: 569
		private TextBox A;

		// Token: 0x0400023A RID: 570
		internal Label A;

		// Token: 0x0400023B RID: 571
		internal Button A;

		// Token: 0x0400023C RID: 572
		internal Button a;
	}
}
