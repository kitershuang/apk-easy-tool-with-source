using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x02000004 RID: 4
	public partial class AIF : Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020CC File Offset: 0x000002CC
		public AIF(AMF Main)
		{
			AIF.A = Main;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020DC File Offset: 0x000002DC
		public AIF()
		{
			this.A();
			this.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.A(), this.Text);
			this.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.a(), this.A.Text);
			this.A.Text = TMain.apkinfo;
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(AIF.A.Location.X + 30, AIF.A.Location.Y + 30);
			ContextMenu contextMenu = new ContextMenu();
			MenuItem menuItem = new MenuItem();
			menuItem = new MenuItem(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.B());
			menuItem.Click += this.A;
			contextMenu.MenuItems.Add(menuItem);
			this.A.ContextMenu = contextMenu;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021B9 File Offset: 0x000003B9
		private void A(object A_1, EventArgs A_2)
		{
			if (this.A.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				Clipboard.SetText(this.A.SelectedText);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021E4 File Offset: 0x000003E4
		private void a(object A_1, EventArgs A_2)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = (Lang.SAVE_FILE_FILTER = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.C());
				saveFileDialog.FilterIndex = 2;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, this.A.Text);
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000226C File Offset: 0x0000046C
		private void A()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AIF));
			this.A = new RichTextBox();
			this.A = new Button();
			base.SuspendLayout();
			this.A.BackColor = SystemColors.InfoText;
			this.A.Dock = DockStyle.Fill;
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.c(), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.A.ForeColor = SystemColors.Info;
			this.A.Location = new Point(0, 0);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.D();
			this.A.ReadOnly = true;
			this.A.Size = new Size(619, 490);
			this.A.TabIndex = 0;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			this.A.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.A.Font = new Font(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.d(), 8.25f);
			this.A.Location = new Point(451, 455);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.E();
			this.A.Size = new Size(126, 23);
			this.A.TabIndex = 1;
			this.A.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.e();
			this.A.UseVisualStyleBackColor = true;
			this.A.Click += this.a;
			base.AutoScaleDimensions = new SizeF(96f, 96f);
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.ClientSize = new Size(619, 490);
			base.Controls.Add(this.A);
			base.Controls.Add(this.A);
			base.Icon = (Icon)componentResourceManager.GetObject(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.F());
			base.MaximizeBox = false;
			base.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.f();
			this.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.G();
			base.ResumeLayout(false);
		}

		// Token: 0x04000008 RID: 8
		private static AMF A;

		// Token: 0x0400000A RID: 10
		private RichTextBox A;

		// Token: 0x0400000B RID: 11
		private Button A;
	}
}
