using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool.Forms
{
	// Token: 0x02000035 RID: 53
	public partial class Dev : Form
	{
		// Token: 0x0600023F RID: 575 RVA: 0x00016D02 File Offset: 0x00014F02
		public Dev(AMF Main)
		{
			Dev.A = Main;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00016D10 File Offset: 0x00014F10
		public Dev()
		{
			this.A();
			Dev.devMain = this;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00016D24 File Offset: 0x00014F24
		internal void A(string A_1)
		{
			MessageBox.Show(A_1);
			this.richTextBox1.AppendText(A_1);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00016D3C File Offset: 0x00014F3C
		private void A(object A_1, EventArgs A_2)
		{
			this.A.Text = Dev.A.tMain.ItemSize.Width.ToString();
			this.a.Text = Dev.A.tMain.ItemSize.Height.ToString();
			this.b.Text = Dev.A.A.ItemSize.Width.ToString();
			this.B.Text = Dev.A.A.ItemSize.Height.ToString();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000099D8 File Offset: 0x00007BD8
		private void a(object A_1, EventArgs A_2)
		{
			new U().Show();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000A2EF File Offset: 0x000084EF
		private void A(object A_1, KeyEventArgs A_2)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000A2EF File Offset: 0x000084EF
		private void B(object A_1, EventArgs A_2)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00016DF1 File Offset: 0x00014FF1
		private void b(object A_1, EventArgs A_2)
		{
			new KP().Show();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00016E1C File Offset: 0x0001501C
		private void A()
		{
			this.A = new Label();
			this.A = new NumericUpDown();
			this.a = new Label();
			this.B = new Label();
			this.a = new NumericUpDown();
			this.b = new Label();
			this.C = new Label();
			this.B = new NumericUpDown();
			this.b = new NumericUpDown();
			this.c = new Label();
			this.D = new Label();
			this.A = new Button();
			this.richTextBox1 = new RichTextBox();
			this.a = new Button();
			((ISupportInitialize)this.A).BeginInit();
			((ISupportInitialize)this.a).BeginInit();
			((ISupportInitialize)this.B).BeginInit();
			((ISupportInitialize)this.b).BeginInit();
			base.SuspendLayout();
			this.A.AutoSize = true;
			this.A.Location = new Point(26, 77);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bf();
			this.A.Size = new Size(53, 13);
			this.A.TabIndex = 0;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jb();
			this.A.Location = new Point(53, 92);
			NumericUpDown numericUpDown = this.A;
			int[] array = new int[4];
			array[0] = 10000;
			numericUpDown.Maximum = new decimal(array);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jC();
			this.A.Size = new Size(61, 22);
			this.A.TabIndex = 1;
			this.A.ValueChanged += this.B;
			this.A.KeyDown += this.A;
			this.a.AutoSize = true;
			this.a.Location = new Point(26, 23);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Br();
			this.a.Size = new Size(298, 13);
			this.a.TabIndex = 2;
			this.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jc();
			this.B.AutoSize = true;
			this.B.Location = new Point(26, 143);
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bL();
			this.B.Size = new Size(64, 13);
			this.B.TabIndex = 0;
			this.B.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jD();
			this.a.Location = new Point(167, 93);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jd();
			this.a.Size = new Size(61, 22);
			this.a.TabIndex = 1;
			this.b.AutoSize = true;
			this.b.Location = new Point(26, 96);
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ck();
			this.b.Size = new Size(21, 13);
			this.b.TabIndex = 0;
			this.b.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jE();
			this.C.AutoSize = true;
			this.C.Location = new Point(140, 96);
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bj();
			this.C.Size = new Size(18, 13);
			this.C.TabIndex = 0;
			this.C.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.je();
			this.B.Location = new Point(167, 163);
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jF();
			this.B.Size = new Size(61, 22);
			this.B.TabIndex = 5;
			this.b.Location = new Point(53, 162);
			NumericUpDown numericUpDown2 = this.b;
			int[] array2 = new int[4];
			array2[0] = 10000;
			numericUpDown2.Maximum = new decimal(array2);
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jf();
			this.b.Size = new Size(61, 22);
			this.b.TabIndex = 6;
			this.c.AutoSize = true;
			this.c.Location = new Point(140, 166);
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bo();
			this.c.Size = new Size(18, 13);
			this.c.TabIndex = 3;
			this.c.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.je();
			this.D.AutoSize = true;
			this.D.Location = new Point(26, 166);
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BI();
			this.D.Size = new Size(21, 13);
			this.D.TabIndex = 4;
			this.D.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jE();
			this.A.ImeMode = ImeMode.NoControl;
			this.A.Location = new Point(29, 200);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BP();
			this.A.Size = new Size(159, 23);
			this.A.TabIndex = 86;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jG();
			this.A.UseVisualStyleBackColor = true;
			this.A.Click += this.a;
			this.richTextBox1.Location = new Point(292, 77);
			this.richTextBox1.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.iY();
			this.richTextBox1.Size = new Size(168, 146);
			this.richTextBox1.TabIndex = 87;
			this.richTextBox1.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			this.a.ImeMode = ImeMode.NoControl;
			this.a.Location = new Point(29, 238);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jg();
			this.a.Size = new Size(159, 23);
			this.a.TabIndex = 88;
			this.a.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jH();
			this.a.UseVisualStyleBackColor = true;
			this.a.Click += this.b;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(506, 273);
			base.Controls.Add(this.a);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.A);
			base.Controls.Add(this.B);
			base.Controls.Add(this.b);
			base.Controls.Add(this.c);
			base.Controls.Add(this.D);
			base.Controls.Add(this.a);
			base.Controls.Add(this.a);
			base.Controls.Add(this.A);
			base.Controls.Add(this.B);
			base.Controls.Add(this.C);
			base.Controls.Add(this.b);
			base.Controls.Add(this.A);
			this.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jh();
			this.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jh();
			base.Load += this.A;
			((ISupportInitialize)this.A).EndInit();
			((ISupportInitialize)this.a).EndInit();
			((ISupportInitialize)this.B).EndInit();
			((ISupportInitialize)this.b).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002AD RID: 685
		private static AMF A;

		// Token: 0x040002AE RID: 686
		public static Dev devMain;

		// Token: 0x040002B0 RID: 688
		private Label A;

		// Token: 0x040002B1 RID: 689
		private NumericUpDown A;

		// Token: 0x040002B2 RID: 690
		private Label a;

		// Token: 0x040002B3 RID: 691
		private Label B;

		// Token: 0x040002B4 RID: 692
		private NumericUpDown a;

		// Token: 0x040002B5 RID: 693
		private Label b;

		// Token: 0x040002B6 RID: 694
		private Label C;

		// Token: 0x040002B7 RID: 695
		private NumericUpDown B;

		// Token: 0x040002B8 RID: 696
		private NumericUpDown b;

		// Token: 0x040002B9 RID: 697
		private Label c;

		// Token: 0x040002BA RID: 698
		private Label D;

		// Token: 0x040002BB RID: 699
		internal Button A;

		// Token: 0x040002BC RID: 700
		public RichTextBox richTextBox1;

		// Token: 0x040002BD RID: 701
		internal Button a;
	}
}
