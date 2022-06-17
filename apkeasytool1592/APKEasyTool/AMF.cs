using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};
using A;
using APKEasyTool.Forms;
using APKEasyTool.Utils;

namespace APKEasyTool
{
	// Token: 0x02000005 RID: 5
	public partial class AMF : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002484 File Offset: 0x00000684
		public AMF()
		{
			this.A();
			AMF.form = this;
			AMF._logform = Log._Main;
			this.A = new U(this);
			this.A = new TL(this);
			this.A = new TFW(this);
			this.A = new TSma(this);
			this.A = new TO(this);
			this.A = new TMain(this);
			this.A = new MF(this);
			this.A = new AIF(this);
			this.A = new KP(this);
			this.A = new CMD(this);
			this.A = new WW(this);
			this.A = new Lang(this);
			this.A = new Dev(this);
			this.A = new Log(this);
			this.d.Click += this.J;
			this.I.Click += AMF.a.A.A;
			this.B.DragLeave += this.j;
			this.B.DragEnter += AMF.a.A.A;
			this.B.DragOver += this.A;
			this.B.DragDrop += this.a;
			this.A.DragLeave += this.K;
			this.A.DragEnter += AMF.a.A.a;
			this.A.DragOver += this.B;
			this.A.DragDrop += this.b;
			this.A.Click += this.k;
			this.a.DragLeave += this.L;
			this.a.DragEnter += AMF.a.A.B;
			this.a.DragOver += this.C;
			this.a.DragDrop += this.c;
			this.a.Click += this.l;
			this.B.DragLeave += this.M;
			this.B.DragEnter += AMF.a.A.b;
			this.B.DragOver += this.D;
			this.B.DragDrop += this.d;
			this.B.Click += this.m;
			this.b.DragLeave += this.N;
			this.b.DragEnter += AMF.a.A.C;
			this.b.DragOver += this.E;
			this.b.DragDrop += this.e;
			this.b.Click += this.n;
			this.J.DragLeave += this.O;
			this.J.DragEnter += AMF.a.A.c;
			this.J.DragOver += this.F;
			this.J.DragDrop += this.f;
			this.J.Click += this.o;
			this.C.DragLeave += this.P;
			this.C.DragEnter += AMF.a.A.D;
			this.C.DragOver += this.G;
			this.C.DragDrop += this.g;
			this.C.Click += this.p;
			this.D.DragLeave += this.Q;
			this.D.DragEnter += AMF.a.A.d;
			this.D.DragOver += this.H;
			this.D.DragDrop += this.h;
			this.D.Click += this.q;
			this.c.DragLeave += this.R;
			this.c.DragEnter += AMF.a.A.E;
			this.c.DragOver += this.I;
			this.c.DragDrop += this.i;
			this.c.Click += this.r;
			this.g.DragLeave += this.S;
			this.g.DragEnter += AMF.a.A.e;
			this.g.DragOver += this.J;
			this.g.DragDrop += this.j;
			this.g.Click += this.s;
			this.k.Click += this.T;
			this.L.Click += this.t;
			this.l.Click += this.U;
			this.M.Click += this.u;
			this.pakLbl.Click += this.V;
			this.launchLbl.Click += this.v;
			this.E.Click += this.W;
			this.F.Click += AMF.a.A.a;
			this.h.Click += this.w;
			this.I.Click += this.X;
			this.i.Click += this.x;
			this.richTextBoxLogs.LinkClicked += AMF.a.A.A;
			this.D.DragLeave += this.Y;
			this.D.DragEnter += AMF.a.A.F;
			this.D.DragOver += this.K;
			this.D.DragDrop += this.k;
			this.N.Click += this.y;
			this.O.Click += this.Z;
			this.i.DragLeave += this.z;
			this.i.DragEnter += AMF.a.A.f;
			this.i.DragOver += this.L;
			this.i.DragDrop += this.l;
			this.i.Click += this.aA;
			this.m.Click += this.aa;
			this.n.Click += this.aB;
			this.I.DragLeave += this.ab;
			this.I.DragEnter += AMF.a.A.G;
			this.I.DragOver += this.M;
			this.I.DragDrop += this.m;
			this.I.Click += this.aC;
			this.pakLbl.MouseLeave += this.ac;
			this.pakLbl.MouseEnter += this.aD;
			this.pakLbl.MouseDown += this.A;
			this.launchLbl.MouseLeave += this.ad;
			this.launchLbl.MouseEnter += this.aE;
			this.launchLbl.MouseDown += this.a;
			this.h.Click += this.ae;
			this.H.Click += this.aF;
			this.P.Click += this.af;
			this.e.Click += this.aG;
			this.f.Click += this.ag;
			this.G.Click += this.aH;
			this.p.Click += this.ah;
			this.a.MouseLeave += this.aI;
			this.a.MouseEnter += this.ai;
			this.a.Click += AMF.a.A.B;
			this.x.Click += AMF.a.A.b;
			this.f.MouseLeave += this.aJ;
			this.f.MouseEnter += this.aj;
			this.X.Click += AMF.a.A.C;
			this.w.Click += AMF.a.A.c;
			this.q.Click += this.aK;
			this.Q.Click += AMF.a.A.D;
			this.V.Click += this.ak;
			this.u.Click += this.aL;
			this.U.Click += this.al;
			this.v.Click += this.aM;
			this.s.Click += this.am;
			this.S.Click += this.aN;
			this.r.Click += this.an;
			this.W.Click += this.aO;
			this.j.Click += this.ao;
			this.f.Click += AMF.a.A.d;
			this.A.Click += AMF.a.A.E;
			this.g.Click += AMF.a.A.e;
			ContextMenu contextMenu = new ContextMenu();
			MenuItem menuItem = new MenuItem();
			menuItem = new MenuItem(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.B());
			menuItem.Click += this.G;
			contextMenu.MenuItems.Add(menuItem);
			this.richTextBoxLogs.ContextMenu = contextMenu;
			if (AMF._logform != null)
			{
				AMF._logform.richTextBoxLogs.ContextMenu = contextMenu;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000031E2 File Offset: 0x000013E2
		private void A(object A_1, EventArgs A_2)
		{
			this.A.A();
			new JList(base.Handle);
			if (Environment.GetCommandLineArgs().Length > 2)
			{
				base.Opacity = 0.0;
				base.Visible = false;
				base.ShowInTaskbar = false;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003224 File Offset: 0x00001424
		private void A(object A_1, KeyEventArgs A_2)
		{
			if (A_2.KeyCode == Keys.F1)
			{
				this.tMain.SelectedIndex = 0;
			}
			if (A_2.KeyCode == Keys.F2)
			{
				this.tMain.SelectedIndex = 1;
			}
			if (A_2.KeyCode == Keys.F3)
			{
				this.tMain.SelectedIndex = 2;
			}
			if (A_2.KeyCode == Keys.F4)
			{
				this.tMain.SelectedIndex = 3;
			}
			if (A_2.KeyCode == Keys.F5)
			{
				this.tMain.SelectedIndex = 4;
			}
			if (A_2.KeyCode == Keys.F6)
			{
				this.tMain.SelectedIndex = 5;
			}
			if (A_2.KeyCode == Keys.Escape)
			{
				this.A.C();
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000032CA File Offset: 0x000014CA
		private void a(object A_1, EventArgs A_2)
		{
			if (this.isSelectedFromDD)
			{
				this.A.b(A_1, A_2);
			}
			this.isSelectedFromDD = false;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000032E8 File Offset: 0x000014E8
		private void B(object A_1, EventArgs A_2)
		{
			if (!this.D.Checked && this.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !this.a.Items.Contains(this.a.Text))
			{
				this.a.Items.Insert(0, this.a.Text);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003354 File Offset: 0x00001554
		private void b(object A_1, EventArgs A_2)
		{
			if (!this.D.Checked && this.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !this.B.Items.Contains(this.B.Text))
			{
				this.B.Items.Insert(0, this.B.Text);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000033BE File Offset: 0x000015BE
		private void C(object A_1, EventArgs A_2)
		{
			this.isSelectedFromDD = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000033C7 File Offset: 0x000015C7
		private void c(object A_1, EventArgs A_2)
		{
			this.A.B(A_1, A_2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000033D6 File Offset: 0x000015D6
		private void A(object A_1, FormClosedEventArgs A_2)
		{
			if (!this.dontSave)
			{
				this.A.d();
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000033EB File Offset: 0x000015EB
		private void D(object A_1, EventArgs A_2)
		{
			if (this.C.Checked)
			{
				this.G.Enabled = true;
				return;
			}
			this.G.Enabled = false;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003413 File Offset: 0x00001613
		private void d(object A_1, EventArgs A_2)
		{
			this.A.B(A_1, A_2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003424 File Offset: 0x00001624
		private void E(object A_1, EventArgs A_2)
		{
			if (this.langComboBox.SelectedIndex > 0)
			{
				Lang.LoadLocalization(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.g() + this.langComboBox.Text));
				this.LanguageLoaded = true;
				return;
			}
			if (this.LanguageLoaded)
			{
				Application.Restart();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003474 File Offset: 0x00001674
		private void e(object A_1, EventArgs A_2)
		{
			this.A.A(A_1, A_2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003483 File Offset: 0x00001683
		private void A(object A_1, KeyPressEventArgs A_2)
		{
			if (!char.IsControl(A_2.KeyChar) && !char.IsDigit(A_2.KeyChar))
			{
				A_2.Handled = true;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003483 File Offset: 0x00001683
		private void a(object A_1, KeyPressEventArgs A_2)
		{
			if (!char.IsControl(A_2.KeyChar) && !char.IsDigit(A_2.KeyChar))
			{
				A_2.Handled = true;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000034A6 File Offset: 0x000016A6
		private void F(object A_1, EventArgs A_2)
		{
			this.dontSave = true;
			this.A.b(A_1, A_2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000034BC File Offset: 0x000016BC
		private void f(object A_1, EventArgs A_2)
		{
			File.Delete(Vars.LogPath);
			this.richTextBoxLogs.Text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000034D8 File Offset: 0x000016D8
		private void G(object A_1, EventArgs A_2)
		{
			if (this.richTextBoxLogs.SelectedText == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				Clipboard.SetText(AMF._logform.richTextBoxLogs.SelectedText);
				return;
			}
			Clipboard.SetText(this.richTextBoxLogs.SelectedText);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003518 File Offset: 0x00001718
		private void g(object A_1, EventArgs A_2)
		{
			try
			{
				AMF._logform = Log._Main;
				if (AMF._logform != null)
				{
					AMF._logform.richTextBoxLogs.Text = this.richTextBoxLogs.Text;
					AMF._logform.richTextBoxLogs.SelectionStart = this.richTextBoxLogs.Text.Length;
					AMF._logform.richTextBoxLogs.ScrollToCaret();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003594 File Offset: 0x00001794
		private void A(object A_1, DoWorkEventArgs A_2)
		{
			this.A.A(A_1, A_2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000035A3 File Offset: 0x000017A3
		private void A(object A_1, RunWorkerCompletedEventArgs A_2)
		{
			this.A.A(A_1, A_2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000035B2 File Offset: 0x000017B2
		private void H(object A_1, EventArgs A_2)
		{
			new Dev().Show();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000035C0 File Offset: 0x000017C0
		private void h(object A_1, EventArgs A_2)
		{
			AMF._logform = Log._Main;
			if (AMF._logform != null)
			{
				AMF._logform.Top = base.Location.Y;
				AMF._logform.Left = base.Location.X + base.Width;
				AMF._logform.Height = base.Height;
				AMF._logform.BringToFront();
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003630 File Offset: 0x00001830
		public void LogOutput(string text, AMF.Type type = AMF.Type.None, Color? color = null, bool output = true)
		{
			switch (type)
			{
			case AMF.Type.None:
				if (output)
				{
					this.LogToRichTextBox(text, color);
				}
				this.A(text, null);
				return;
			case AMF.Type.Info:
				if (output)
				{
					this.LogToRichTextBox(text, color);
				}
				this.A(text, global::A.a.l());
				return;
			case AMF.Type.Error:
				if (output)
				{
					this.LogToRichTextBox(text, color);
				}
				this.A(text, global::A.a.h());
				return;
			case AMF.Type.Warning:
				if (output)
				{
					this.LogToRichTextBox(text, color);
				}
				this.A(text, global::A.a.q());
				return;
			default:
				return;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000036B4 File Offset: 0x000018B4
		public void LogOutput(string text)
		{
			this.LogToRichTextBox(text, null);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000036D1 File Offset: 0x000018D1
		private void I(object A_1, EventArgs A_2)
		{
			this.A.A();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000036DE File Offset: 0x000018DE
		private void i(object A_1, EventArgs A_2)
		{
			if (this.tMain.SelectedIndex == 2)
			{
				this.richTextBoxLogs.SelectionStart = this.richTextBoxLogs.Text.Length;
				this.richTextBoxLogs.ScrollToCaret();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003714 File Offset: 0x00001914
		public void LogToRichTextBox(string text, Color? color = null)
		{
			AMF.B b = new AMF.B();
			b.A = this;
			b.A = color;
			b.A = text;
			base.Invoke(new Action(b.A));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003750 File Offset: 0x00001950
		private void A(string A_1, Image A_2)
		{
			AMF.b b = new AMF.b();
			b.A = this;
			b.A = A_1;
			b.A = A_2;
			base.Invoke(new MethodInvoker(b.A));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000037AC File Offset: 0x000019AC
		private void A()
		{
			this.A = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AMF));
			this.c = new Label();
			this.tMain = new TabControl();
			this.B = new TabPage();
			this.K = new TextBox();
			this.k = new TextBox();
			this.d = new Label();
			this.E = new Label();
			this.label95 = new Label();
			this.G = new TextBox();
			this.J = new Button();
			this.C = new CheckBox();
			this.B = new ComboBox();
			this.a = new ComboBox();
			this.pathOfApk = new ComboBox();
			this.M = new Button();
			this.A = new Panel();
			this.I = new PictureBox();
			this.i = new PictureBox();
			this.sigVer = new Label();
			this.h = new Label();
			this.F = new Button();
			this.tarLbl = new Label();
			this.minLbl = new Label();
			this.vercLbl = new Label();
			this.verLbl = new Label();
			this.launchLbl = new Label();
			this.pakLbl = new Label();
			this.f = new Label();
			this.apkicon = new PictureBox();
			this.G = new Label();
			this.e = new Label();
			this.F = new Label();
			this.g = new Label();
			this.H = new Label();
			this.h = new PictureBox();
			this.l = new Button();
			this.c = new Button();
			this.D = new Button();
			this.C = new Label();
			this.b = new Label();
			this.d = new Button();
			this.A = new Button();
			this.a = new Button();
			this.C = new Button();
			this.b = new Button();
			this.k = new Button();
			this.E = new Button();
			this.L = new Button();
			this.B = new Button();
			this.D = new TabPage();
			this.c = new CheckBox();
			this.i = new TextBox();
			this.L = new Label();
			this.J = new TextBox();
			this.l = new Label();
			this.F = new Panel();
			this.k = new Label();
			this.e = new Panel();
			this.K = new Label();
			this.O = new Button();
			this.n = new Button();
			this.j = new Label();
			this.J = new Label();
			this.I = new TextBox();
			this.N = new Button();
			this.h = new TextBox();
			this.i = new Button();
			this.I = new Label();
			this.H = new TextBox();
			this.m = new Button();
			this.i = new Label();
			this.g = new TextBox();
			this.I = new Button();
			this.H = new Button();
			this.h = new Button();
			this.G = new PictureBox();
			this.f = new PictureBox();
			this.tabLog = new TabPage();
			this.richTextBoxLogs = new RichTextBox();
			this.o = new Button();
			this.E = new TabPage();
			this.aF = new Label();
			this.p = new Button();
			this.g = new Button();
			this.E = new CheckBox();
			this.f = new TextBox();
			this.o = new Label();
			this.G = new Button();
			this.F = new TextBox();
			this.O = new Label();
			this.f = new Button();
			this.e = new TextBox();
			this.n = new Label();
			this.E = new Panel();
			this.M = new Label();
			this.m = new Label();
			this.C = new TextBox();
			this.e = new Button();
			this.N = new Label();
			this.F = new PictureBox();
			this.P = new Button();
			this.A = new TabPage();
			this.A = new TabControl();
			this.d = new TabPage();
			this.x = new Button();
			this.m = new CheckBox();
			this.w = new Button();
			this.X = new Button();
			this.aG = new Label();
			this.T = new Button();
			this.k = new CheckBox();
			this.P = new Label();
			this.langComboBox = new ComboBox();
			this.R = new Label();
			this.U = new Label();
			this.H = new PictureBox();
			this.R = new Button();
			this.G = new Panel();
			this.u = new Label();
			this.d = new CheckBox();
			this.j = new TextBox();
			this.j = new Button();
			this.t = new Button();
			this.D = new CheckBox();
			this.f = new Panel();
			this.q = new Button();
			this.Q = new Button();
			this.g = new Panel();
			this.B = new Panel();
			this.B = new PictureBox();
			this.b = new PictureBox();
			this.t = new Label();
			this.aJ = new Label();
			this.v = new Button();
			this.b = new TextBox();
			this.T = new Label();
			this.U = new Button();
			this.A = new TextBox();
			this.a = new Panel();
			this.r = new Label();
			this.p = new Label();
			this.S = new Label();
			this.a = new TextBox();
			this.a = new CheckBox();
			this.B = new TextBox();
			this.A = new ComboBox();
			this.u = new Button();
			this.a = new NumericUpDown();
			this.V = new Button();
			this.Q = new Label();
			this.s = new Label();
			this.q = new Label();
			this.A = new NumericUpDown();
			this.A = new CheckBox();
			this.b = new TabPage();
			this.W = new Button();
			this.L = new TextBox();
			this.l = new CheckBox();
			this.L = new CheckBox();
			this.e = new CheckBox();
			this.F = new CheckBox();
			this.f = new CheckBox();
			this.K = new CheckBox();
			this.J = new CheckBox();
			this.j = new CheckBox();
			this.H = new Panel();
			this.h = new Panel();
			this.V = new Label();
			this.v = new Label();
			this.i = new CheckBox();
			this.h = new CheckBox();
			this.H = new CheckBox();
			this.I = new CheckBox();
			this.g = new CheckBox();
			this.G = new CheckBox();
			this.C = new PictureBox();
			this.a = new PictureBox();
			this.C = new TabPage();
			this.aH = new Label();
			this.b = new ComboBox();
			this.C = new ComboBox();
			this.c = new ComboBox();
			this.ah = new Label();
			this.aI = new Label();
			this.ai = new Label();
			this.M = new CheckBox();
			this.overApkChecked = new CheckBox();
			this.installApkChkBox = new CheckBox();
			this.signApkCheckBox = new CheckBox();
			this.b = new Panel();
			this.aj = new Label();
			this.B = new CheckBox();
			this.c = new TextBox();
			this.w = new Label();
			this.X = new Label();
			this.r = new Button();
			this.D = new TextBox();
			this.x = new Label();
			this.b = new CheckBox();
			this.Y = new Label();
			this.y = new Label();
			this.d = new TextBox();
			this.E = new TextBox();
			this.S = new Button();
			this.s = new Button();
			this.c = new PictureBox();
			this.c = new TabPage();
			this.zipAfterSignChkBox = new CheckBox();
			this.C = new Panel();
			this.D = new Label();
			this.zipVcheckBox = new CheckBox();
			this.zipFcheckBox = new CheckBox();
			this.zipZcheckBox = new CheckBox();
			this.zipPcheckBox = new CheckBox();
			this.D = new PictureBox();
			this.a = new TabPage();
			this.ag = new Label();
			this.af = new Label();
			this.aa = new Label();
			this.Z = new Label();
			this.z = new Label();
			this.aA = new Label();
			this.ae = new Label();
			this.aE = new Label();
			this.A = new LinkLabel();
			this.W = new Label();
			this.a = new LinkLabel();
			this.ad = new Label();
			this.aD = new Label();
			this.c = new Panel();
			this.D = new Panel();
			this.d = new Panel();
			this.ac = new Label();
			this.B = new Label();
			this.A = new Label();
			this.a = new Label();
			this.ab = new Label();
			this.aB = new Label();
			this.aC = new Label();
			this.g = new PictureBox();
			this.E = new PictureBox();
			this.e = new PictureBox();
			this.d = new PictureBox();
			this.A = new ToolTip(this.A);
			this.K = new Button();
			this.A = new BackgroundWorker();
			this.I = new Panel();
			this.A = new PictureBox();
			this.label11 = new Label();
			this.apkvLbl = new Label();
			this.A = new StatusStrip();
			this.a = new ToolStripStatusLabel();
			this.A = new ToolStripStatusLabel();
			this.tMain.SuspendLayout();
			this.B.SuspendLayout();
			this.A.SuspendLayout();
			((ISupportInitialize)this.I).BeginInit();
			((ISupportInitialize)this.i).BeginInit();
			((ISupportInitialize)this.apkicon).BeginInit();
			((ISupportInitialize)this.h).BeginInit();
			this.D.SuspendLayout();
			((ISupportInitialize)this.G).BeginInit();
			((ISupportInitialize)this.f).BeginInit();
			this.tabLog.SuspendLayout();
			this.E.SuspendLayout();
			((ISupportInitialize)this.F).BeginInit();
			this.A.SuspendLayout();
			this.A.SuspendLayout();
			this.d.SuspendLayout();
			((ISupportInitialize)this.H).BeginInit();
			((ISupportInitialize)this.B).BeginInit();
			((ISupportInitialize)this.b).BeginInit();
			((ISupportInitialize)this.a).BeginInit();
			((ISupportInitialize)this.A).BeginInit();
			this.b.SuspendLayout();
			((ISupportInitialize)this.C).BeginInit();
			((ISupportInitialize)this.a).BeginInit();
			this.C.SuspendLayout();
			((ISupportInitialize)this.c).BeginInit();
			this.c.SuspendLayout();
			((ISupportInitialize)this.D).BeginInit();
			this.a.SuspendLayout();
			((ISupportInitialize)this.g).BeginInit();
			((ISupportInitialize)this.E).BeginInit();
			((ISupportInitialize)this.e).BeginInit();
			((ISupportInitialize)this.d).BeginInit();
			((ISupportInitialize)this.A).BeginInit();
			this.A.SuspendLayout();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.H());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.H();
			this.tMain.Controls.Add(this.B);
			this.tMain.Controls.Add(this.D);
			this.tMain.Controls.Add(this.tabLog);
			this.tMain.Controls.Add(this.E);
			this.tMain.Controls.Add(this.A);
			this.tMain.Controls.Add(this.a);
			componentResourceManager.ApplyResources(this.tMain, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.h());
			this.tMain.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.h();
			this.tMain.SelectedIndex = 0;
			this.tMain.SizeMode = TabSizeMode.Fixed;
			this.tMain.SelectedIndexChanged += this.i;
			this.B.AllowDrop = true;
			this.B.BackColor = Color.White;
			this.B.Controls.Add(this.K);
			this.B.Controls.Add(this.k);
			this.B.Controls.Add(this.d);
			this.B.Controls.Add(this.E);
			this.B.Controls.Add(this.label95);
			this.B.Controls.Add(this.G);
			this.B.Controls.Add(this.J);
			this.B.Controls.Add(this.C);
			this.B.Controls.Add(this.B);
			this.B.Controls.Add(this.a);
			this.B.Controls.Add(this.pathOfApk);
			this.B.Controls.Add(this.M);
			this.B.Controls.Add(this.A);
			this.B.Controls.Add(this.l);
			this.B.Controls.Add(this.c);
			this.B.Controls.Add(this.D);
			this.B.Controls.Add(this.C);
			this.B.Controls.Add(this.b);
			this.B.Controls.Add(this.c);
			this.B.Controls.Add(this.d);
			this.B.Controls.Add(this.A);
			this.B.Controls.Add(this.a);
			this.B.Controls.Add(this.C);
			this.B.Controls.Add(this.b);
			this.B.Controls.Add(this.k);
			this.B.Controls.Add(this.E);
			this.B.Controls.Add(this.L);
			this.B.Controls.Add(this.B);
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.I());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.I();
			this.B.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.K, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.i());
			this.K.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.i();
			this.A.SetToolTip(this.K, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.J()));
			this.K.KeyPress += this.a;
			componentResourceManager.ApplyResources(this.k, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.j());
			this.k.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.j();
			this.A.SetToolTip(this.k, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.K()));
			this.k.KeyPress += this.A;
			componentResourceManager.ApplyResources(this.d, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.k());
			this.d.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.k();
			componentResourceManager.ApplyResources(this.E, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.L());
			this.E.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.L();
			componentResourceManager.ApplyResources(this.label95, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.l());
			this.label95.ForeColor = Color.DarkGray;
			this.label95.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.l();
			componentResourceManager.ApplyResources(this.G, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.M());
			this.G.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.M();
			this.A.SetToolTip(this.G, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.m()));
			this.J.AllowDrop = true;
			componentResourceManager.ApplyResources(this.J, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.N());
			this.J.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.N();
			this.A.SetToolTip(this.J, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.n()));
			this.J.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.O());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.O();
			this.C.UseVisualStyleBackColor = true;
			this.C.CheckedChanged += this.D;
			this.B.FormattingEnabled = true;
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.o());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.o();
			this.B.Validated += this.b;
			this.a.FormattingEnabled = true;
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.P());
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.P();
			this.a.Validated += this.B;
			this.pathOfApk.DropDownWidth = 500;
			componentResourceManager.ApplyResources(this.pathOfApk, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.p());
			this.pathOfApk.FormattingEnabled = true;
			this.pathOfApk.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.p();
			this.pathOfApk.DropDownClosed += this.C;
			this.pathOfApk.SelectedValueChanged += this.a;
			this.pathOfApk.Validated += this.c;
			componentResourceManager.ApplyResources(this.M, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Q());
			this.M.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Q();
			this.M.UseVisualStyleBackColor = true;
			this.A.BackColor = Color.WhiteSmoke;
			this.A.Controls.Add(this.I);
			this.A.Controls.Add(this.i);
			this.A.Controls.Add(this.sigVer);
			this.A.Controls.Add(this.h);
			this.A.Controls.Add(this.F);
			this.A.Controls.Add(this.tarLbl);
			this.A.Controls.Add(this.minLbl);
			this.A.Controls.Add(this.vercLbl);
			this.A.Controls.Add(this.verLbl);
			this.A.Controls.Add(this.launchLbl);
			this.A.Controls.Add(this.pakLbl);
			this.A.Controls.Add(this.f);
			this.A.Controls.Add(this.apkicon);
			this.A.Controls.Add(this.G);
			this.A.Controls.Add(this.e);
			this.A.Controls.Add(this.F);
			this.A.Controls.Add(this.g);
			this.A.Controls.Add(this.H);
			this.A.Controls.Add(this.h);
			this.A.ForeColor = SystemColors.ControlLight;
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.q());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.q();
			this.I.Cursor = Cursors.Hand;
			componentResourceManager.ApplyResources(this.I, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.R());
			this.I.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.R();
			this.I.TabStop = false;
			this.A.SetToolTip(this.I, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.r()));
			this.i.Cursor = Cursors.Hand;
			componentResourceManager.ApplyResources(this.i, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.S());
			this.i.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.S();
			this.i.TabStop = false;
			this.A.SetToolTip(this.i, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.s()));
			componentResourceManager.ApplyResources(this.sigVer, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.T());
			this.sigVer.BackColor = Color.WhiteSmoke;
			this.sigVer.ForeColor = Color.DimGray;
			this.sigVer.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.T();
			componentResourceManager.ApplyResources(this.h, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.t());
			this.h.BackColor = Color.WhiteSmoke;
			this.h.ForeColor = SystemColors.ControlText;
			this.h.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.t();
			componentResourceManager.ApplyResources(this.F, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.U());
			this.F.ForeColor = Color.Black;
			this.F.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.U();
			this.F.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.tarLbl, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.u());
			this.tarLbl.BackColor = Color.WhiteSmoke;
			this.tarLbl.ForeColor = Color.DimGray;
			this.tarLbl.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.u();
			componentResourceManager.ApplyResources(this.minLbl, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.V());
			this.minLbl.BackColor = Color.WhiteSmoke;
			this.minLbl.ForeColor = Color.DimGray;
			this.minLbl.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.V();
			componentResourceManager.ApplyResources(this.vercLbl, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.v());
			this.vercLbl.BackColor = Color.WhiteSmoke;
			this.vercLbl.ForeColor = Color.DimGray;
			this.vercLbl.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.v();
			componentResourceManager.ApplyResources(this.verLbl, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.W());
			this.verLbl.BackColor = Color.WhiteSmoke;
			this.verLbl.ForeColor = Color.DimGray;
			this.verLbl.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.W();
			componentResourceManager.ApplyResources(this.launchLbl, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.w());
			this.launchLbl.BackColor = Color.WhiteSmoke;
			this.launchLbl.Cursor = Cursors.Hand;
			this.launchLbl.ForeColor = Color.DimGray;
			this.launchLbl.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.w();
			componentResourceManager.ApplyResources(this.pakLbl, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.X());
			this.pakLbl.BackColor = Color.WhiteSmoke;
			this.pakLbl.Cursor = Cursors.Hand;
			this.pakLbl.ForeColor = Color.DimGray;
			this.pakLbl.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.X();
			this.A.SetToolTip(this.pakLbl, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.x()));
			componentResourceManager.ApplyResources(this.f, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Y());
			this.f.BackColor = Color.WhiteSmoke;
			this.f.ForeColor = SystemColors.ControlText;
			this.f.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Y();
			this.apkicon.BackColor = Color.Gainsboro;
			this.apkicon.BorderStyle = BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.apkicon, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.y());
			this.apkicon.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.y();
			this.apkicon.TabStop = false;
			componentResourceManager.ApplyResources(this.G, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Z());
			this.G.BackColor = Color.WhiteSmoke;
			this.G.ForeColor = SystemColors.ControlText;
			this.G.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Z();
			componentResourceManager.ApplyResources(this.e, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.z());
			this.e.BackColor = Color.WhiteSmoke;
			this.e.ForeColor = SystemColors.ControlText;
			this.e.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.z();
			componentResourceManager.ApplyResources(this.F, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aA());
			this.F.BackColor = Color.WhiteSmoke;
			this.F.ForeColor = SystemColors.ControlText;
			this.F.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aA();
			componentResourceManager.ApplyResources(this.g, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aa());
			this.g.BackColor = Color.WhiteSmoke;
			this.g.ForeColor = SystemColors.ControlText;
			this.g.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aa();
			componentResourceManager.ApplyResources(this.H, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aB());
			this.H.BackColor = Color.WhiteSmoke;
			this.H.ForeColor = SystemColors.ControlText;
			this.H.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aB();
			this.h.Cursor = Cursors.Hand;
			componentResourceManager.ApplyResources(this.h, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ab());
			this.h.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ab();
			this.h.TabStop = false;
			this.A.SetToolTip(this.h, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aC()));
			componentResourceManager.ApplyResources(this.l, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ac());
			this.l.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ac();
			this.l.UseVisualStyleBackColor = true;
			this.c.AllowDrop = true;
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aD());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aD();
			this.c.UseVisualStyleBackColor = true;
			this.D.AllowDrop = true;
			componentResourceManager.ApplyResources(this.D, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ad());
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ad();
			this.D.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aE());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aE();
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ae());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ae();
			componentResourceManager.ApplyResources(this.d, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aF());
			this.d.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aF();
			this.d.UseCompatibleTextRendering = true;
			this.d.UseVisualStyleBackColor = true;
			this.A.AllowDrop = true;
			this.A.BackgroundImage = global::A.a.G();
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.af());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.af();
			this.A.UseVisualStyleBackColor = true;
			this.a.AllowDrop = true;
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aG());
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aG();
			this.a.UseVisualStyleBackColor = true;
			this.C.AllowDrop = true;
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ag());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ag();
			this.A.SetToolTip(this.C, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aH()));
			this.C.UseVisualStyleBackColor = true;
			this.b.AllowDrop = true;
			this.b.BackgroundImage = global::A.a.r();
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ah());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ah();
			this.A.SetToolTip(this.b, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aI()));
			this.b.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.k, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ai());
			this.k.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ai();
			this.k.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.E, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aJ());
			this.E.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aJ();
			this.A.SetToolTip(this.E, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aj()));
			this.E.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.L, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aK());
			this.L.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aK();
			this.L.UseVisualStyleBackColor = true;
			this.B.AllowDrop = true;
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ak());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ak();
			this.B.UseVisualStyleBackColor = true;
			this.D.AllowDrop = true;
			this.D.BackColor = Color.White;
			this.D.Controls.Add(this.c);
			this.D.Controls.Add(this.i);
			this.D.Controls.Add(this.L);
			this.D.Controls.Add(this.J);
			this.D.Controls.Add(this.l);
			this.D.Controls.Add(this.F);
			this.D.Controls.Add(this.k);
			this.D.Controls.Add(this.e);
			this.D.Controls.Add(this.K);
			this.D.Controls.Add(this.O);
			this.D.Controls.Add(this.n);
			this.D.Controls.Add(this.j);
			this.D.Controls.Add(this.J);
			this.D.Controls.Add(this.I);
			this.D.Controls.Add(this.N);
			this.D.Controls.Add(this.h);
			this.D.Controls.Add(this.i);
			this.D.Controls.Add(this.I);
			this.D.Controls.Add(this.H);
			this.D.Controls.Add(this.m);
			this.D.Controls.Add(this.i);
			this.D.Controls.Add(this.g);
			this.D.Controls.Add(this.I);
			this.D.Controls.Add(this.H);
			this.D.Controls.Add(this.h);
			this.D.Controls.Add(this.G);
			this.D.Controls.Add(this.f);
			componentResourceManager.ApplyResources(this.D, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aL());
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aL();
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.al());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.al();
			this.c.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.i, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aM());
			this.i.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aM();
			componentResourceManager.ApplyResources(this.L, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.am());
			this.L.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.am();
			componentResourceManager.ApplyResources(this.J, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aN());
			this.J.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aN();
			componentResourceManager.ApplyResources(this.l, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.an());
			this.l.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.an();
			this.F.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.F, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aO());
			this.F.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aO();
			componentResourceManager.ApplyResources(this.k, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ao());
			this.k.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ao();
			this.e.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.e, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aP());
			this.e.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aP();
			componentResourceManager.ApplyResources(this.K, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ap());
			this.K.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ap();
			componentResourceManager.ApplyResources(this.O, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aQ());
			this.O.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aQ();
			this.O.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.n, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aq());
			this.n.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aq();
			this.n.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.j, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aR());
			this.j.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aR();
			componentResourceManager.ApplyResources(this.J, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ar());
			this.J.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ar();
			componentResourceManager.ApplyResources(this.I, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aS());
			this.I.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aS();
			componentResourceManager.ApplyResources(this.N, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@as());
			this.N.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@as();
			this.N.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.h, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aT());
			this.h.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aT();
			this.i.AllowDrop = true;
			componentResourceManager.ApplyResources(this.i, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.at());
			this.i.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.at();
			this.i.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.I, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aU());
			this.I.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aU();
			componentResourceManager.ApplyResources(this.H, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.au());
			this.H.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.au();
			componentResourceManager.ApplyResources(this.m, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aV());
			this.m.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aV();
			this.m.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.i, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.av());
			this.i.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.av();
			componentResourceManager.ApplyResources(this.g, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aW());
			this.g.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aW();
			this.I.AllowDrop = true;
			componentResourceManager.ApplyResources(this.I, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aw());
			this.I.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aw();
			this.I.UseVisualStyleBackColor = true;
			this.H.BackgroundImage = global::A.a.k();
			componentResourceManager.ApplyResources(this.H, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aX());
			this.H.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aX();
			this.H.UseVisualStyleBackColor = true;
			this.h.BackgroundImage = global::A.a.k();
			componentResourceManager.ApplyResources(this.h, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ax());
			this.h.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ax();
			this.h.UseVisualStyleBackColor = true;
			this.G.Image = global::A.a.I();
			componentResourceManager.ApplyResources(this.G, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aY());
			this.G.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aY();
			this.G.TabStop = false;
			this.f.Image = global::A.a.I();
			componentResourceManager.ApplyResources(this.f, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ay());
			this.f.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ay();
			this.f.TabStop = false;
			this.tabLog.Controls.Add(this.richTextBoxLogs);
			this.tabLog.Controls.Add(this.o);
			componentResourceManager.ApplyResources(this.tabLog, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aZ());
			this.tabLog.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.aZ();
			this.tabLog.UseVisualStyleBackColor = true;
			this.richTextBoxLogs.BackColor = Color.Black;
			componentResourceManager.ApplyResources(this.richTextBoxLogs, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.az());
			this.richTextBoxLogs.ForeColor = Color.White;
			this.richTextBoxLogs.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.az();
			this.richTextBoxLogs.ReadOnly = true;
			this.richTextBoxLogs.TextChanged += this.g;
			componentResourceManager.ApplyResources(this.o, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BA());
			this.o.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BA();
			this.o.UseVisualStyleBackColor = true;
			this.o.Click += this.f;
			this.E.Controls.Add(this.aF);
			this.E.Controls.Add(this.p);
			this.E.Controls.Add(this.g);
			this.E.Controls.Add(this.E);
			this.E.Controls.Add(this.f);
			this.E.Controls.Add(this.o);
			this.E.Controls.Add(this.G);
			this.E.Controls.Add(this.F);
			this.E.Controls.Add(this.O);
			this.E.Controls.Add(this.f);
			this.E.Controls.Add(this.e);
			this.E.Controls.Add(this.n);
			this.E.Controls.Add(this.E);
			this.E.Controls.Add(this.M);
			this.E.Controls.Add(this.m);
			this.E.Controls.Add(this.C);
			this.E.Controls.Add(this.e);
			this.E.Controls.Add(this.N);
			this.E.Controls.Add(this.F);
			this.E.Controls.Add(this.P);
			componentResourceManager.ApplyResources(this.E, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ba());
			this.E.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ba();
			this.E.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.aF, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BB());
			this.aF.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BB();
			componentResourceManager.ApplyResources(this.p, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bb());
			this.p.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bb();
			this.p.UseVisualStyleBackColor = true;
			this.g.AllowDrop = true;
			this.g.BackgroundImage = global::A.a.J();
			componentResourceManager.ApplyResources(this.g, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BC());
			this.g.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BC();
			this.g.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.E, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bc());
			this.E.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bc();
			this.E.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.f, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BD());
			this.f.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BD();
			componentResourceManager.ApplyResources(this.o, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bd());
			this.o.ForeColor = Color.Gray;
			this.o.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bd();
			componentResourceManager.ApplyResources(this.G, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BE());
			this.G.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BE();
			this.G.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.F, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Be());
			this.F.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Be();
			componentResourceManager.ApplyResources(this.O, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BF());
			this.O.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BF();
			componentResourceManager.ApplyResources(this.f, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bf());
			this.f.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bf();
			this.f.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.e, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BG());
			this.e.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BG();
			componentResourceManager.ApplyResources(this.n, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bg());
			this.n.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bg();
			this.E.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.E, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BH());
			this.E.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BH();
			componentResourceManager.ApplyResources(this.M, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bh());
			this.M.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bh();
			componentResourceManager.ApplyResources(this.m, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BI());
			this.m.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BI();
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bi());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bi();
			componentResourceManager.ApplyResources(this.e, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BJ());
			this.e.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BJ();
			this.e.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.N, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bj());
			this.N.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bj();
			this.F.Image = global::A.a.j();
			componentResourceManager.ApplyResources(this.F, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BK());
			this.F.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BK();
			this.F.TabStop = false;
			componentResourceManager.ApplyResources(this.P, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bk());
			this.P.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bk();
			this.P.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BL());
			this.A.Controls.Add(this.A);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BL();
			this.A.UseVisualStyleBackColor = true;
			this.A.Controls.Add(this.d);
			this.A.Controls.Add(this.b);
			this.A.Controls.Add(this.C);
			this.A.Controls.Add(this.c);
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bl());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bl();
			this.A.SelectedIndex = 0;
			this.A.SizeMode = TabSizeMode.Fixed;
			componentResourceManager.ApplyResources(this.d, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BM());
			this.d.Controls.Add(this.x);
			this.d.Controls.Add(this.m);
			this.d.Controls.Add(this.w);
			this.d.Controls.Add(this.X);
			this.d.Controls.Add(this.aG);
			this.d.Controls.Add(this.T);
			this.d.Controls.Add(this.k);
			this.d.Controls.Add(this.P);
			this.d.Controls.Add(this.langComboBox);
			this.d.Controls.Add(this.R);
			this.d.Controls.Add(this.U);
			this.d.Controls.Add(this.H);
			this.d.Controls.Add(this.R);
			this.d.Controls.Add(this.G);
			this.d.Controls.Add(this.u);
			this.d.Controls.Add(this.d);
			this.d.Controls.Add(this.j);
			this.d.Controls.Add(this.j);
			this.d.Controls.Add(this.t);
			this.d.Controls.Add(this.D);
			this.d.Controls.Add(this.f);
			this.d.Controls.Add(this.q);
			this.d.Controls.Add(this.Q);
			this.d.Controls.Add(this.g);
			this.d.Controls.Add(this.B);
			this.d.Controls.Add(this.B);
			this.d.Controls.Add(this.b);
			this.d.Controls.Add(this.t);
			this.d.Controls.Add(this.aJ);
			this.d.Controls.Add(this.v);
			this.d.Controls.Add(this.b);
			this.d.Controls.Add(this.T);
			this.d.Controls.Add(this.U);
			this.d.Controls.Add(this.A);
			this.d.Controls.Add(this.a);
			this.d.Controls.Add(this.r);
			this.d.Controls.Add(this.p);
			this.d.Controls.Add(this.S);
			this.d.Controls.Add(this.a);
			this.d.Controls.Add(this.a);
			this.d.Controls.Add(this.B);
			this.d.Controls.Add(this.A);
			this.d.Controls.Add(this.u);
			this.d.Controls.Add(this.a);
			this.d.Controls.Add(this.V);
			this.d.Controls.Add(this.Q);
			this.d.Controls.Add(this.s);
			this.d.Controls.Add(this.q);
			this.d.Controls.Add(this.A);
			this.d.Controls.Add(this.A);
			this.d.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BM();
			this.d.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.x, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bm());
			this.x.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bm();
			this.x.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.m, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BN());
			this.m.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BN();
			this.m.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.w, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bn());
			this.w.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bn();
			this.w.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.X, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BO());
			this.X.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BO();
			this.X.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.aG, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bo());
			this.aG.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bo();
			componentResourceManager.ApplyResources(this.T, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BP());
			this.T.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BP();
			this.T.UseVisualStyleBackColor = true;
			this.T.Click += this.H;
			componentResourceManager.ApplyResources(this.k, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bp());
			this.k.Checked = true;
			this.k.CheckState = CheckState.Checked;
			this.k.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bp();
			this.k.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.P, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BQ());
			this.P.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BQ();
			this.langComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			this.langComboBox.DropDownWidth = 200;
			this.langComboBox.FormattingEnabled = true;
			this.langComboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bq())
			});
			componentResourceManager.ApplyResources(this.langComboBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BR());
			this.langComboBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BR();
			this.langComboBox.SelectedValueChanged += this.E;
			componentResourceManager.ApplyResources(this.R, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Br());
			this.R.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Br();
			componentResourceManager.ApplyResources(this.U, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BS());
			this.U.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BS();
			this.H.Image = global::A.a.n();
			componentResourceManager.ApplyResources(this.H, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bs());
			this.H.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bs();
			this.H.TabStop = false;
			componentResourceManager.ApplyResources(this.R, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BT());
			this.R.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BT();
			this.R.UseVisualStyleBackColor = true;
			this.R.Click += this.F;
			this.G.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.G, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bt());
			this.G.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bt();
			componentResourceManager.ApplyResources(this.u, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BU());
			this.u.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BU();
			componentResourceManager.ApplyResources(this.d, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bu());
			this.d.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bu();
			this.d.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.j, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BV());
			this.j.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BV();
			componentResourceManager.ApplyResources(this.j, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bv());
			this.j.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bv();
			this.j.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.t, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BW());
			this.t.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BW();
			this.t.UseVisualStyleBackColor = true;
			this.t.Click += this.d;
			componentResourceManager.ApplyResources(this.D, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bw());
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bw();
			this.D.UseVisualStyleBackColor = true;
			this.f.BackColor = Color.Gainsboro;
			this.f.BackgroundImage = global::A.a.c();
			componentResourceManager.ApplyResources(this.f, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BX());
			this.f.Cursor = Cursors.Hand;
			this.f.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BX();
			componentResourceManager.ApplyResources(this.q, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bx());
			this.q.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bx();
			this.q.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Q, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BY());
			this.Q.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BY();
			this.Q.UseVisualStyleBackColor = true;
			this.g.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.g, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.By());
			this.g.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.By();
			this.B.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BZ());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.BZ();
			this.B.Image = global::A.a.k();
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bz());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Bz();
			this.B.TabStop = false;
			this.b.Image = global::A.a.b();
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bA());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bA();
			this.b.TabStop = false;
			componentResourceManager.ApplyResources(this.t, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ba());
			this.t.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ba();
			componentResourceManager.ApplyResources(this.aJ, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bB());
			this.aJ.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bB();
			componentResourceManager.ApplyResources(this.v, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bb());
			this.v.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bb();
			this.v.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bC());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bC();
			componentResourceManager.ApplyResources(this.T, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bc());
			this.T.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bc();
			componentResourceManager.ApplyResources(this.U, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bD());
			this.U.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bD();
			this.U.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bd());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bd();
			this.a.BackColor = Color.Gainsboro;
			this.a.BackgroundImage = global::A.a.k();
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bE());
			this.a.Cursor = Cursors.Hand;
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bE();
			componentResourceManager.ApplyResources(this.r, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.be());
			this.r.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.be();
			componentResourceManager.ApplyResources(this.p, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bF());
			this.p.ForeColor = Color.Gray;
			this.p.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bF();
			componentResourceManager.ApplyResources(this.S, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bf());
			this.S.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bf();
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bG());
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bG();
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bg());
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bg();
			this.A.SetToolTip(this.a, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bH()));
			this.a.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bh());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bh();
			this.A.DropDownStyle = ComboBoxStyle.DropDownList;
			this.A.DropDownWidth = 200;
			this.A.FormattingEnabled = true;
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bI());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bI();
			this.A.SetToolTip(this.A, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bi()));
			this.A.SelectedValueChanged += this.e;
			componentResourceManager.ApplyResources(this.u, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bJ());
			this.u.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bJ();
			this.u.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bj());
			NumericUpDown numericUpDown = this.a;
			int[] array = new int[4];
			array[0] = 9;
			numericUpDown.Maximum = new decimal(array);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bj();
			NumericUpDown numericUpDown2 = this.a;
			int[] array2 = new int[4];
			array2[0] = 9;
			numericUpDown2.Value = new decimal(array2);
			componentResourceManager.ApplyResources(this.V, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bK());
			this.V.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bK();
			this.V.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Q, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bk());
			this.Q.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bk();
			componentResourceManager.ApplyResources(this.s, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bL());
			this.s.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bL();
			componentResourceManager.ApplyResources(this.q, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bl());
			this.q.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bl();
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bM());
			NumericUpDown numericUpDown3 = this.A;
			int[] array3 = new int[4];
			array3[0] = 999999;
			numericUpDown3.Maximum = new decimal(array3);
			NumericUpDown numericUpDown4 = this.A;
			int[] array4 = new int[4];
			array4[0] = 64;
			numericUpDown4.Minimum = new decimal(array4);
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bM();
			this.A.SetToolTip(this.A, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bm()));
			NumericUpDown numericUpDown5 = this.A;
			int[] array5 = new int[4];
			array5[0] = 1024;
			numericUpDown5.Value = new decimal(array5);
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bN());
			this.A.Checked = true;
			this.A.CheckState = CheckState.Checked;
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bN();
			this.A.UseVisualStyleBackColor = true;
			this.b.BackColor = Color.White;
			this.b.Controls.Add(this.W);
			this.b.Controls.Add(this.L);
			this.b.Controls.Add(this.l);
			this.b.Controls.Add(this.L);
			this.b.Controls.Add(this.e);
			this.b.Controls.Add(this.F);
			this.b.Controls.Add(this.f);
			this.b.Controls.Add(this.K);
			this.b.Controls.Add(this.J);
			this.b.Controls.Add(this.j);
			this.b.Controls.Add(this.H);
			this.b.Controls.Add(this.h);
			this.b.Controls.Add(this.V);
			this.b.Controls.Add(this.v);
			this.b.Controls.Add(this.i);
			this.b.Controls.Add(this.h);
			this.b.Controls.Add(this.H);
			this.b.Controls.Add(this.I);
			this.b.Controls.Add(this.g);
			this.b.Controls.Add(this.G);
			this.b.Controls.Add(this.C);
			this.b.Controls.Add(this.a);
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bn());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bn();
			componentResourceManager.ApplyResources(this.W, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bO());
			this.W.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bO();
			this.W.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.L, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bo());
			this.L.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bo();
			componentResourceManager.ApplyResources(this.l, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bP());
			this.l.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bP();
			this.l.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.L, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bp());
			this.L.Checked = true;
			this.L.CheckState = CheckState.Checked;
			this.L.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bp();
			this.L.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.e, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bQ());
			this.e.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bQ();
			this.e.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.F, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bq());
			this.F.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bq();
			this.F.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.f, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bR());
			this.f.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bR();
			this.A.SetToolTip(this.f, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.br()));
			this.f.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.K, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bS());
			this.K.Checked = true;
			this.K.CheckState = CheckState.Checked;
			this.K.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bS();
			this.A.SetToolTip(this.K, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bs()));
			this.K.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.J, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bT());
			this.J.Checked = true;
			this.J.CheckState = CheckState.Checked;
			this.J.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bT();
			this.A.SetToolTip(this.J, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bt()));
			this.J.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.j, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bU());
			this.j.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bU();
			this.A.SetToolTip(this.j, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bu()));
			this.j.UseVisualStyleBackColor = true;
			this.H.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.H, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bV());
			this.H.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bV();
			this.h.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.h, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bv());
			this.h.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bv();
			componentResourceManager.ApplyResources(this.V, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bW());
			this.V.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bW();
			componentResourceManager.ApplyResources(this.v, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bw());
			this.v.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bw();
			componentResourceManager.ApplyResources(this.i, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bX());
			this.i.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bX();
			this.A.SetToolTip(this.i, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bx()));
			this.i.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.h, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bY());
			this.h.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bY();
			this.A.SetToolTip(this.h, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.by()));
			this.h.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.H, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bZ());
			this.H.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bZ();
			this.A.SetToolTip(this.H, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.bz()));
			this.H.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.I, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CA());
			this.I.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CA();
			this.A.SetToolTip(this.I, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ca()));
			this.I.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.g, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CB());
			this.g.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CB();
			this.A.SetToolTip(this.g, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cb()));
			this.g.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.G, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CC());
			this.G.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CC();
			this.A.SetToolTip(this.G, componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cc()));
			this.G.UseVisualStyleBackColor = true;
			this.C.Image = global::A.a.F();
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CD());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CD();
			this.C.TabStop = false;
			this.a.Image = global::A.a.g();
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cd());
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cd();
			this.a.TabStop = false;
			this.C.Controls.Add(this.aH);
			this.C.Controls.Add(this.b);
			this.C.Controls.Add(this.C);
			this.C.Controls.Add(this.c);
			this.C.Controls.Add(this.ah);
			this.C.Controls.Add(this.aI);
			this.C.Controls.Add(this.ai);
			this.C.Controls.Add(this.M);
			this.C.Controls.Add(this.overApkChecked);
			this.C.Controls.Add(this.installApkChkBox);
			this.C.Controls.Add(this.signApkCheckBox);
			this.C.Controls.Add(this.b);
			this.C.Controls.Add(this.aj);
			this.C.Controls.Add(this.B);
			this.C.Controls.Add(this.c);
			this.C.Controls.Add(this.w);
			this.C.Controls.Add(this.X);
			this.C.Controls.Add(this.r);
			this.C.Controls.Add(this.D);
			this.C.Controls.Add(this.x);
			this.C.Controls.Add(this.b);
			this.C.Controls.Add(this.Y);
			this.C.Controls.Add(this.y);
			this.C.Controls.Add(this.d);
			this.C.Controls.Add(this.E);
			this.C.Controls.Add(this.S);
			this.C.Controls.Add(this.s);
			this.C.Controls.Add(this.c);
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CE());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CE();
			this.C.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.aH, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ce());
			this.aH.ForeColor = SystemColors.ControlDarkDark;
			this.aH.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ce();
			this.b.DropDownStyle = ComboBoxStyle.DropDownList;
			this.b.FormattingEnabled = true;
			this.b.Items.AddRange(new object[]
			{
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CF()),
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cf()),
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CG())
			});
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cg());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cg();
			this.C.DropDownStyle = ComboBoxStyle.DropDownList;
			this.C.FormattingEnabled = true;
			this.C.Items.AddRange(new object[]
			{
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CH()),
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ch()),
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CI()),
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ci())
			});
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CJ());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CJ();
			this.c.DropDownStyle = ComboBoxStyle.DropDownList;
			this.c.FormattingEnabled = true;
			this.c.Items.AddRange(new object[]
			{
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cj()),
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CK()),
				componentResourceManager.GetString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ck())
			});
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CL());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CL();
			componentResourceManager.ApplyResources(this.ah, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cl());
			this.ah.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cl();
			componentResourceManager.ApplyResources(this.aI, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CM());
			this.aI.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CM();
			componentResourceManager.ApplyResources(this.ai, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cm());
			this.ai.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cm();
			componentResourceManager.ApplyResources(this.M, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CN());
			this.M.ForeColor = SystemColors.ControlText;
			this.M.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CN();
			this.M.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.overApkChecked, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cn());
			this.overApkChecked.ForeColor = SystemColors.ControlText;
			this.overApkChecked.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cn();
			this.overApkChecked.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.installApkChkBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CO());
			this.installApkChkBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CO();
			this.installApkChkBox.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.signApkCheckBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Co());
			this.signApkCheckBox.Checked = true;
			this.signApkCheckBox.CheckState = CheckState.Checked;
			this.signApkCheckBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Co();
			this.signApkCheckBox.UseVisualStyleBackColor = true;
			this.b.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CP());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CP();
			componentResourceManager.ApplyResources(this.aj, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cp());
			this.aj.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cp();
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CQ());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CQ();
			this.B.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cq());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cq();
			componentResourceManager.ApplyResources(this.w, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CR());
			this.w.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CR();
			componentResourceManager.ApplyResources(this.X, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cr());
			this.X.ForeColor = SystemColors.ActiveCaptionText;
			this.X.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cr();
			componentResourceManager.ApplyResources(this.r, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CS());
			this.r.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CS();
			this.r.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.D, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cs());
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cs();
			componentResourceManager.ApplyResources(this.x, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CT());
			this.x.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CT();
			componentResourceManager.ApplyResources(this.b, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ct());
			this.b.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ct();
			this.b.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Y, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CU());
			this.Y.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CU();
			componentResourceManager.ApplyResources(this.y, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cu());
			this.y.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cu();
			componentResourceManager.ApplyResources(this.d, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CV());
			this.d.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CV();
			componentResourceManager.ApplyResources(this.E, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cv());
			this.E.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cv();
			componentResourceManager.ApplyResources(this.S, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CW());
			this.S.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CW();
			this.S.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.s, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cw());
			this.s.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cw();
			this.s.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CX());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CX();
			this.c.TabStop = false;
			this.c.Controls.Add(this.zipAfterSignChkBox);
			this.c.Controls.Add(this.C);
			this.c.Controls.Add(this.D);
			this.c.Controls.Add(this.zipVcheckBox);
			this.c.Controls.Add(this.zipFcheckBox);
			this.c.Controls.Add(this.zipZcheckBox);
			this.c.Controls.Add(this.zipPcheckBox);
			this.c.Controls.Add(this.D);
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cx());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cx();
			this.c.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.zipAfterSignChkBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CY());
			this.zipAfterSignChkBox.Checked = true;
			this.zipAfterSignChkBox.CheckState = CheckState.Checked;
			this.zipAfterSignChkBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CY();
			this.zipAfterSignChkBox.UseVisualStyleBackColor = true;
			this.C.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.C, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cy());
			this.C.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cy();
			componentResourceManager.ApplyResources(this.D, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CZ());
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.CZ();
			componentResourceManager.ApplyResources(this.zipVcheckBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cz());
			this.zipVcheckBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Cz();
			this.zipVcheckBox.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.zipFcheckBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cA());
			this.zipFcheckBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cA();
			this.zipFcheckBox.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.zipZcheckBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ca());
			this.zipZcheckBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ca();
			this.zipZcheckBox.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.zipPcheckBox, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cB());
			this.zipPcheckBox.Checked = true;
			this.zipPcheckBox.CheckState = CheckState.Checked;
			this.zipPcheckBox.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cB();
			this.zipPcheckBox.UseVisualStyleBackColor = true;
			this.D.Image = global::A.a.S();
			componentResourceManager.ApplyResources(this.D, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cb());
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cb();
			this.D.TabStop = false;
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cC());
			this.a.Controls.Add(this.ag);
			this.a.Controls.Add(this.af);
			this.a.Controls.Add(this.aa);
			this.a.Controls.Add(this.Z);
			this.a.Controls.Add(this.z);
			this.a.Controls.Add(this.aA);
			this.a.Controls.Add(this.ae);
			this.a.Controls.Add(this.aE);
			this.a.Controls.Add(this.A);
			this.a.Controls.Add(this.W);
			this.a.Controls.Add(this.a);
			this.a.Controls.Add(this.ad);
			this.a.Controls.Add(this.aD);
			this.a.Controls.Add(this.c);
			this.a.Controls.Add(this.D);
			this.a.Controls.Add(this.d);
			this.a.Controls.Add(this.ac);
			this.a.Controls.Add(this.B);
			this.a.Controls.Add(this.A);
			this.a.Controls.Add(this.a);
			this.a.Controls.Add(this.ab);
			this.a.Controls.Add(this.aB);
			this.a.Controls.Add(this.aC);
			this.a.Controls.Add(this.g);
			this.a.Controls.Add(this.E);
			this.a.Controls.Add(this.e);
			this.a.Controls.Add(this.d);
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cC();
			this.a.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.ag, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cc());
			this.ag.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cc();
			componentResourceManager.ApplyResources(this.af, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cD());
			this.af.ForeColor = Color.Gray;
			this.af.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cD();
			componentResourceManager.ApplyResources(this.aa, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cd());
			this.aa.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cd();
			componentResourceManager.ApplyResources(this.Z, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cE());
			this.Z.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cE();
			componentResourceManager.ApplyResources(this.z, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ce());
			this.z.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ce();
			componentResourceManager.ApplyResources(this.aA, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cF());
			this.aA.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cF();
			componentResourceManager.ApplyResources(this.ae, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cf());
			this.ae.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cf();
			componentResourceManager.ApplyResources(this.aE, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cG());
			this.aE.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cG();
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cg());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cg();
			this.A.TabStop = true;
			componentResourceManager.ApplyResources(this.W, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cH());
			this.W.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cH();
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ch());
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ch();
			this.a.TabStop = true;
			componentResourceManager.ApplyResources(this.ad, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cI());
			this.ad.ForeColor = Color.SteelBlue;
			this.ad.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cI();
			componentResourceManager.ApplyResources(this.aD, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ci());
			this.aD.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ci();
			this.c.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.c, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cJ());
			this.c.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cJ();
			this.D.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.D, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cj());
			this.D.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cj();
			this.d.BackColor = Color.DarkGray;
			componentResourceManager.ApplyResources(this.d, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cK());
			this.d.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cK();
			componentResourceManager.ApplyResources(this.ac, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ck());
			this.ac.ForeColor = SystemColors.ActiveCaptionText;
			this.ac.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ck();
			componentResourceManager.ApplyResources(this.B, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cL());
			this.B.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cL();
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cl());
			this.A.ForeColor = Color.Gray;
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cl();
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cM());
			this.a.ForeColor = Color.Gray;
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cM();
			componentResourceManager.ApplyResources(this.ab, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cm());
			this.ab.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cm();
			componentResourceManager.ApplyResources(this.aB, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cN());
			this.aB.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cN();
			componentResourceManager.ApplyResources(this.aC, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cn());
			this.aC.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cn();
			this.g.Cursor = Cursors.Hand;
			componentResourceManager.ApplyResources(this.g, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cO());
			this.g.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cO();
			this.g.TabStop = false;
			componentResourceManager.ApplyResources(this.E, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.co());
			this.E.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.co();
			this.E.TabStop = false;
			componentResourceManager.ApplyResources(this.e, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cP());
			this.e.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cP();
			this.e.TabStop = false;
			this.d.Image = global::A.a.l();
			componentResourceManager.ApplyResources(this.d, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cp());
			this.d.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cp();
			this.d.TabStop = false;
			this.A.AutoPopDelay = 20000;
			this.A.InitialDelay = 700;
			this.A.ReshowDelay = 100;
			componentResourceManager.ApplyResources(this.K, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cQ());
			this.K.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cQ();
			this.K.UseVisualStyleBackColor = true;
			this.K.Click += this.I;
			this.A.WorkerSupportsCancellation = true;
			this.A.DoWork += this.A;
			this.A.RunWorkerCompleted += this.A;
			this.I.BackColor = Color.Black;
			componentResourceManager.ApplyResources(this.I, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cq());
			this.I.Cursor = Cursors.Hand;
			this.I.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cq();
			this.A.BackColor = Color.Black;
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cR());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cR();
			this.A.TabStop = false;
			this.label11.BackColor = Color.Black;
			componentResourceManager.ApplyResources(this.label11, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cr());
			this.label11.ForeColor = SystemColors.AppWorkspace;
			this.label11.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cr();
			this.apkvLbl.BackColor = Color.Black;
			componentResourceManager.ApplyResources(this.apkvLbl, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cS());
			this.apkvLbl.ForeColor = SystemColors.AppWorkspace;
			this.apkvLbl.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cS();
			this.A.Items.AddRange(new ToolStripItem[]
			{
				this.a,
				this.A
			});
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cs());
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cs();
			this.A.SizingGrip = false;
			this.a.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.a.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cT();
			componentResourceManager.ApplyResources(this.a, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cT());
			componentResourceManager.ApplyResources(this.A, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ct());
			this.A.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.A.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ct();
			this.A.Overflow = ToolStripItemOverflow.Never;
			this.A.Spring = true;
			componentResourceManager.ApplyResources(this, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cU());
			base.AutoScaleMode = AutoScaleMode.Dpi;
			base.Controls.Add(this.A);
			base.Controls.Add(this.K);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.I);
			base.Controls.Add(this.tMain);
			base.Controls.Add(this.apkvLbl);
			base.Controls.Add(this.A);
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.Name = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cu();
			base.FormClosed += this.A;
			base.Load += this.A;
			base.LocationChanged += this.h;
			base.KeyDown += this.A;
			this.tMain.ResumeLayout(false);
			this.B.ResumeLayout(false);
			this.B.PerformLayout();
			this.A.ResumeLayout(false);
			this.A.PerformLayout();
			((ISupportInitialize)this.I).EndInit();
			((ISupportInitialize)this.i).EndInit();
			((ISupportInitialize)this.apkicon).EndInit();
			((ISupportInitialize)this.h).EndInit();
			this.D.ResumeLayout(false);
			this.D.PerformLayout();
			((ISupportInitialize)this.G).EndInit();
			((ISupportInitialize)this.f).EndInit();
			this.tabLog.ResumeLayout(false);
			this.E.ResumeLayout(false);
			this.E.PerformLayout();
			((ISupportInitialize)this.F).EndInit();
			this.A.ResumeLayout(false);
			this.A.ResumeLayout(false);
			this.d.ResumeLayout(false);
			this.d.PerformLayout();
			((ISupportInitialize)this.H).EndInit();
			((ISupportInitialize)this.B).EndInit();
			((ISupportInitialize)this.b).EndInit();
			((ISupportInitialize)this.a).EndInit();
			((ISupportInitialize)this.A).EndInit();
			this.b.ResumeLayout(false);
			this.b.PerformLayout();
			((ISupportInitialize)this.C).EndInit();
			((ISupportInitialize)this.a).EndInit();
			this.C.ResumeLayout(false);
			this.C.PerformLayout();
			((ISupportInitialize)this.c).EndInit();
			this.c.ResumeLayout(false);
			this.c.PerformLayout();
			((ISupportInitialize)this.D).EndInit();
			this.a.ResumeLayout(false);
			this.a.PerformLayout();
			((ISupportInitialize)this.g).EndInit();
			((ISupportInitialize)this.E).EndInit();
			((ISupportInitialize)this.e).EndInit();
			((ISupportInitialize)this.d).EndInit();
			((ISupportInitialize)this.A).EndInit();
			this.A.ResumeLayout(false);
			this.A.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000908B File Offset: 0x0000728B
		[CompilerGenerated]
		private void J(object A_1, EventArgs A_2)
		{
			this.A.A(A_1, A_2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000909A File Offset: 0x0000729A
		[CompilerGenerated]
		private void j(object A_1, EventArgs A_2)
		{
			this.B.BackColor = Color.White;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000090AC File Offset: 0x000072AC
		[CompilerGenerated]
		private void A(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv()
			}))
			{
				this.B.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000090DC File Offset: 0x000072DC
		[CompilerGenerated]
		private void a(object A_1, DragEventArgs A_2)
		{
			this.A(A_1, A_2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000090E6 File Offset: 0x000072E6
		[CompilerGenerated]
		private void K(object A_1, EventArgs A_2)
		{
			this.A.BackColor = Color.Transparent;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000090F8 File Offset: 0x000072F8
		[CompilerGenerated]
		private void B(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv()
			}))
			{
				this.A.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00009128 File Offset: 0x00007328
		[CompilerGenerated]
		private void b(object A_1, DragEventArgs A_2)
		{
			this.a(A_1, A_2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00009132 File Offset: 0x00007332
		[CompilerGenerated]
		private void k(object A_1, EventArgs A_2)
		{
			this.A.D(A_1, A_2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00009141 File Offset: 0x00007341
		[CompilerGenerated]
		private void L(object A_1, EventArgs A_2)
		{
			this.a.BackColor = Color.Transparent;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00009153 File Offset: 0x00007353
		[CompilerGenerated]
		private void C(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b()
			}))
			{
				this.a.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000917B File Offset: 0x0000737B
		[CompilerGenerated]
		private void c(object A_1, DragEventArgs A_2)
		{
			this.B(A_1, A_2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00009185 File Offset: 0x00007385
		[CompilerGenerated]
		private void l(object A_1, EventArgs A_2)
		{
			this.A.d(A_1, A_2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00009194 File Offset: 0x00007394
		[CompilerGenerated]
		private void M(object A_1, EventArgs A_2)
		{
			this.B.BackColor = Color.Transparent;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000091A6 File Offset: 0x000073A6
		[CompilerGenerated]
		private void D(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
			}))
			{
				this.B.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000091CE File Offset: 0x000073CE
		[CompilerGenerated]
		private void d(object A_1, DragEventArgs A_2)
		{
			this.b(A_1, A_2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000091D8 File Offset: 0x000073D8
		[CompilerGenerated]
		private void m(object A_1, EventArgs A_2)
		{
			this.A.a();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000091E5 File Offset: 0x000073E5
		[CompilerGenerated]
		private void N(object A_1, EventArgs A_2)
		{
			this.b.BackColor = Color.Transparent;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000091F7 File Offset: 0x000073F7
		[CompilerGenerated]
		private void E(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
			}))
			{
				this.b.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000921F File Offset: 0x0000741F
		[CompilerGenerated]
		private void e(object A_1, DragEventArgs A_2)
		{
			this.C(A_1, A_2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00009229 File Offset: 0x00007429
		[CompilerGenerated]
		private void n(object A_1, EventArgs A_2)
		{
			this.A.B();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00009236 File Offset: 0x00007436
		[CompilerGenerated]
		private void O(object A_1, EventArgs A_2)
		{
			this.J.BackColor = Color.Transparent;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00009248 File Offset: 0x00007448
		[CompilerGenerated]
		private void F(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
			}))
			{
				this.J.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00009270 File Offset: 0x00007470
		[CompilerGenerated]
		private void f(object A_1, DragEventArgs A_2)
		{
			this.c(A_1, A_2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000927A File Offset: 0x0000747A
		[CompilerGenerated]
		private void o(object A_1, EventArgs A_2)
		{
			this.A.E(A_1, A_2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00009289 File Offset: 0x00007489
		[CompilerGenerated]
		private void P(object A_1, EventArgs A_2)
		{
			this.C.BackColor = Color.Transparent;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000929B File Offset: 0x0000749B
		[CompilerGenerated]
		private void G(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
			}))
			{
				this.C.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000092C3 File Offset: 0x000074C3
		[CompilerGenerated]
		private void g(object A_1, DragEventArgs A_2)
		{
			this.D(A_1, A_2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000092CD File Offset: 0x000074CD
		[CompilerGenerated]
		private void p(object A_1, EventArgs A_2)
		{
			this.A.b();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000092DA File Offset: 0x000074DA
		[CompilerGenerated]
		private void Q(object A_1, EventArgs A_2)
		{
			this.D.BackColor = Color.Transparent;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000092EC File Offset: 0x000074EC
		[CompilerGenerated]
		private void H(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
			}))
			{
				this.D.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000092C3 File Offset: 0x000074C3
		[CompilerGenerated]
		private void h(object A_1, DragEventArgs A_2)
		{
			this.D(A_1, A_2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00009314 File Offset: 0x00007514
		[CompilerGenerated]
		private void q(object A_1, EventArgs A_2)
		{
			this.A.e(A_1, A_2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00009323 File Offset: 0x00007523
		[CompilerGenerated]
		private void R(object A_1, EventArgs A_2)
		{
			this.c.BackColor = Color.Transparent;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00009335 File Offset: 0x00007535
		[CompilerGenerated]
		private void I(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
			}))
			{
				this.c.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000935D File Offset: 0x0000755D
		[CompilerGenerated]
		private void i(object A_1, DragEventArgs A_2)
		{
			this.E(A_1, A_2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00009367 File Offset: 0x00007567
		[CompilerGenerated]
		private void r(object A_1, EventArgs A_2)
		{
			this.A.F(A_1, A_2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00009376 File Offset: 0x00007576
		[CompilerGenerated]
		private void S(object A_1, EventArgs A_2)
		{
			this.g.BackColor = Color.Transparent;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00009388 File Offset: 0x00007588
		[CompilerGenerated]
		private void J(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
			}))
			{
				this.g.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000093B0 File Offset: 0x000075B0
		[CompilerGenerated]
		private void j(object A_1, DragEventArgs A_2)
		{
			this.e(A_1, A_2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000093BA File Offset: 0x000075BA
		[CompilerGenerated]
		private void s(object A_1, EventArgs A_2)
		{
			this.A.A(A_1, A_2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000093C9 File Offset: 0x000075C9
		[CompilerGenerated]
		private void T(object A_1, EventArgs A_2)
		{
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), this.B.Text);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000093E1 File Offset: 0x000075E1
		[CompilerGenerated]
		private void t(object A_1, EventArgs A_2)
		{
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), this.a.Text);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000093F9 File Offset: 0x000075F9
		[CompilerGenerated]
		private void U(object A_1, EventArgs A_2)
		{
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), this.A.Text);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00009411 File Offset: 0x00007611
		[CompilerGenerated]
		private void u(object A_1, EventArgs A_2)
		{
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), this.b.Text);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00009429 File Offset: 0x00007629
		[CompilerGenerated]
		private void V(object A_1, EventArgs A_2)
		{
			this.A.C(A_1, A_2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00009438 File Offset: 0x00007638
		[CompilerGenerated]
		private void v(object A_1, EventArgs A_2)
		{
			this.A.c(A_1, A_2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00009447 File Offset: 0x00007647
		[CompilerGenerated]
		private void W(object A_1, EventArgs A_2)
		{
			this.A.a(A_1, A_2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00009456 File Offset: 0x00007656
		[CompilerGenerated]
		private void w(object A_1, EventArgs A_2)
		{
			if (this.pakLbl.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw())
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cX() + this.pakLbl.Text);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000948A File Offset: 0x0000768A
		[CompilerGenerated]
		private void X(object A_1, EventArgs A_2)
		{
			if (this.pakLbl.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw())
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cx() + this.pakLbl.Text);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000094BE File Offset: 0x000076BE
		[CompilerGenerated]
		private void x(object A_1, EventArgs A_2)
		{
			if (this.pakLbl.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cw())
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cY() + this.pakLbl.Text);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000094F2 File Offset: 0x000076F2
		[CompilerGenerated]
		private void Y(object A_1, EventArgs A_2)
		{
			this.D.BackColor = Color.White;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00009504 File Offset: 0x00007704
		[CompilerGenerated]
		private void K(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cy(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cZ(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cz()
			}))
			{
				this.D.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000953C File Offset: 0x0000773C
		[CompilerGenerated]
		private void k(object A_1, DragEventArgs A_2)
		{
			this.F(A_1, A_2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00009546 File Offset: 0x00007746
		[CompilerGenerated]
		private void y(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_DEX_ODEX_DIAG, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DA(), new Action<string>(this.A));
			this.J.Text = Path.GetFileName(this.H.Text);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000957E File Offset: 0x0000777E
		[CompilerGenerated]
		private void A(string A_1)
		{
			this.H.Text = A_1;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000958C File Offset: 0x0000778C
		[CompilerGenerated]
		private void Z(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_DIS_DIR_DIAG, new Action<string>(this.a));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000095A4 File Offset: 0x000077A4
		[CompilerGenerated]
		private void a(string A_1)
		{
			this.I.Text = A_1;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000095B2 File Offset: 0x000077B2
		[CompilerGenerated]
		private void z(object A_1, EventArgs A_2)
		{
			this.i.BackColor = Color.Transparent;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000095C4 File Offset: 0x000077C4
		[CompilerGenerated]
		private void L(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cy(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cZ(),
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cz()
			}))
			{
				this.i.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000095FC File Offset: 0x000077FC
		[CompilerGenerated]
		private void l(object A_1, DragEventArgs A_2)
		{
			this.f(A_1, A_2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00009606 File Offset: 0x00007806
		[CompilerGenerated]
		private void aA(object A_1, EventArgs A_2)
		{
			this.A.A(A_1, A_2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00009615 File Offset: 0x00007815
		[CompilerGenerated]
		private void aa(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_DIS_FOLDER_DIAG, new Action<string>(this.B));
			this.i.Text = Path.GetFileName(this.g.Text);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00009648 File Offset: 0x00007848
		[CompilerGenerated]
		private void B(string A_1)
		{
			this.g.Text = A_1;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00009656 File Offset: 0x00007856
		[CompilerGenerated]
		private void aB(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_SMA_DIR_DIAG, new Action<string>(this.b));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000966E File Offset: 0x0000786E
		[CompilerGenerated]
		private void b(string A_1)
		{
			this.h.Text = A_1;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000967C File Offset: 0x0000787C
		[CompilerGenerated]
		private void ab(object A_1, EventArgs A_2)
		{
			this.I.BackColor = Color.Transparent;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000968E File Offset: 0x0000788E
		[CompilerGenerated]
		private void M(object A_1, DragEventArgs A_2)
		{
			if (A_2.CheckDragOver(new string[]
			{
				68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b()
			}))
			{
				this.I.BackColor = Color.PowderBlue;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000096B6 File Offset: 0x000078B6
		[CompilerGenerated]
		private void m(object A_1, DragEventArgs A_2)
		{
			this.G(A_1, A_2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000096C0 File Offset: 0x000078C0
		[CompilerGenerated]
		private void aC(object A_1, EventArgs A_2)
		{
			this.A.a(A_1, A_2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000096CF File Offset: 0x000078CF
		[CompilerGenerated]
		private void ac(object A_1, EventArgs A_2)
		{
			this.pakLbl.BackColor = Color.WhiteSmoke;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000096E1 File Offset: 0x000078E1
		[CompilerGenerated]
		private void aD(object A_1, EventArgs A_2)
		{
			this.pakLbl.BackColor = Color.LightSkyBlue;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000096F3 File Offset: 0x000078F3
		[CompilerGenerated]
		private void A(object A_1, MouseEventArgs A_2)
		{
			this.pakLbl.BackColor = Color.FromArgb(114, 177, 216);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00009711 File Offset: 0x00007911
		[CompilerGenerated]
		private void ad(object A_1, EventArgs A_2)
		{
			this.launchLbl.BackColor = Color.WhiteSmoke;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00009723 File Offset: 0x00007923
		[CompilerGenerated]
		private void aE(object A_1, EventArgs A_2)
		{
			this.launchLbl.BackColor = Color.LightSkyBlue;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00009735 File Offset: 0x00007935
		[CompilerGenerated]
		private void a(object A_1, MouseEventArgs A_2)
		{
			this.launchLbl.BackColor = Color.FromArgb(114, 177, 216);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00009753 File Offset: 0x00007953
		[CompilerGenerated]
		private void ae(object A_1, EventArgs A_2)
		{
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), this.I.Text);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000976B File Offset: 0x0000796B
		[CompilerGenerated]
		private void aF(object A_1, EventArgs A_2)
		{
			Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), this.h.Text);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00009783 File Offset: 0x00007983
		[CompilerGenerated]
		private void af(object A_1, EventArgs A_2)
		{
			this.A.b(A_1, A_2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009792 File Offset: 0x00007992
		[CompilerGenerated]
		private void aG(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_FW_DIAG, Lang.AND_FW_PACK_LBL + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Da(), new Action<string>(this.C));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000097B9 File Offset: 0x000079B9
		[CompilerGenerated]
		private void C(string A_1)
		{
			this.C.Text = A_1;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000097C7 File Offset: 0x000079C7
		[CompilerGenerated]
		private void ag(object A_1, EventArgs A_2)
		{
			this.A.a(A_1, A_2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000097D6 File Offset: 0x000079D6
		[CompilerGenerated]
		private void aH(object A_1, EventArgs A_2)
		{
			this.A.B(A_1, A_2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000097E5 File Offset: 0x000079E5
		[CompilerGenerated]
		private void ah(object A_1, EventArgs A_2)
		{
			this.A.C(A_1, A_2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000097F4 File Offset: 0x000079F4
		[CompilerGenerated]
		private void aI(object A_1, EventArgs A_2)
		{
			this.a.BackColor = Color.Gainsboro;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009806 File Offset: 0x00007A06
		[CompilerGenerated]
		private void ai(object A_1, EventArgs A_2)
		{
			this.a.BackColor = Color.LightSkyBlue;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009818 File Offset: 0x00007A18
		[CompilerGenerated]
		private void aJ(object A_1, EventArgs A_2)
		{
			this.f.BackColor = Color.Gainsboro;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000982A File Offset: 0x00007A2A
		[CompilerGenerated]
		private void aj(object A_1, EventArgs A_2)
		{
			this.f.BackColor = Color.LightSkyBlue;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000983C File Offset: 0x00007A3C
		[CompilerGenerated]
		private void aK(object A_1, EventArgs A_2)
		{
			this.A.a(A_1, A_2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000984B File Offset: 0x00007A4B
		[CompilerGenerated]
		private void ak(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_DEC_DIR_DIAG, new Action<string>(this.c));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009863 File Offset: 0x00007A63
		[CompilerGenerated]
		private void c(string A_1)
		{
			this.B.Text = A_1;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009871 File Offset: 0x00007A71
		[CompilerGenerated]
		private void aL(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_COM_DIR_DIAG, new Action<string>(this.D));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009889 File Offset: 0x00007A89
		[CompilerGenerated]
		private void D(string A_1)
		{
			this.a.Text = A_1;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009897 File Offset: 0x00007A97
		[CompilerGenerated]
		private void al(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_EXT_DIR_DIAG, new Action<string>(this.d));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000098AF File Offset: 0x00007AAF
		[CompilerGenerated]
		private void d(string A_1)
		{
			this.A.Text = A_1;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000098BD File Offset: 0x00007ABD
		[CompilerGenerated]
		private void aM(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_ZIP_DIR_DIAG, new Action<string>(this.E));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000098D5 File Offset: 0x00007AD5
		[CompilerGenerated]
		private void E(string A_1)
		{
			this.b.Text = A_1;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000098E3 File Offset: 0x00007AE3
		[CompilerGenerated]
		private void am(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_PK8_FILE_DIAG, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DB(), new Action<string>(this.e));
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00009900 File Offset: 0x00007B00
		[CompilerGenerated]
		private void e(string A_1)
		{
			this.E.Text = A_1;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000990E File Offset: 0x00007B0E
		[CompilerGenerated]
		private void aN(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_PEM_FILE_DIAG, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Db(), new Action<string>(this.F));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000992B File Offset: 0x00007B2B
		[CompilerGenerated]
		private void F(string A_1)
		{
			this.d.Text = A_1;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009939 File Offset: 0x00007B39
		[CompilerGenerated]
		private void an(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_KEY_FILE_DIAG, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DC(), new Action<string>(this.f));
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00009956 File Offset: 0x00007B56
		[CompilerGenerated]
		private void f(string A_1)
		{
			this.D.Text = A_1;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00009964 File Offset: 0x00007B64
		[CompilerGenerated]
		private void aO(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.SEL_AAPT_FILE_DIAG, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dc(), new Action<string>(this.G));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009981 File Offset: 0x00007B81
		[CompilerGenerated]
		private void G(string A_1)
		{
			this.L.Text = A_1;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000998F File Offset: 0x00007B8F
		[CompilerGenerated]
		private void ao(object A_1, EventArgs A_2)
		{
			DirectoryUtils.A(Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DD(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dd()), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DE(), new Action<string>(this.g));
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000099B6 File Offset: 0x00007BB6
		[CompilerGenerated]
		private void g(string A_1)
		{
			this.j.Text = A_1;
		}

		// Token: 0x0400000C RID: 12
		public static AMF form;

		// Token: 0x0400000D RID: 13
		public static Log _logform;

		// Token: 0x0400000E RID: 14
		internal U A;

		// Token: 0x0400000F RID: 15
		internal TL A;

		// Token: 0x04000010 RID: 16
		internal TSma A;

		// Token: 0x04000011 RID: 17
		internal TFW A;

		// Token: 0x04000012 RID: 18
		internal TO A;

		// Token: 0x04000013 RID: 19
		internal TMain A;

		// Token: 0x04000014 RID: 20
		internal MF A;

		// Token: 0x04000015 RID: 21
		internal AIF A;

		// Token: 0x04000016 RID: 22
		internal KP A;

		// Token: 0x04000017 RID: 23
		internal CMD A;

		// Token: 0x04000018 RID: 24
		internal WW A;

		// Token: 0x04000019 RID: 25
		internal Lang A;

		// Token: 0x0400001A RID: 26
		internal Dev A;

		// Token: 0x0400001B RID: 27
		internal Log A;

		// Token: 0x0400001C RID: 28
		public bool isLoaded;

		// Token: 0x0400001D RID: 29
		public bool isSelectedFromDD;

		// Token: 0x0400001E RID: 30
		public bool LanguageLoaded;

		// Token: 0x0400001F RID: 31
		public bool dontSave;

		// Token: 0x04000021 RID: 33
		private PictureBox A;

		// Token: 0x04000022 RID: 34
		private TabPage A;

		// Token: 0x04000023 RID: 35
		private TabPage a;

		// Token: 0x04000024 RID: 36
		private Label A;

		// Token: 0x04000025 RID: 37
		private Label a;

		// Token: 0x04000026 RID: 38
		private Label B;

		// Token: 0x04000027 RID: 39
		public TabControl tMain;

		// Token: 0x04000028 RID: 40
		public TabPage tabLog;

		// Token: 0x04000029 RID: 41
		public RichTextBox richTextBoxLogs;

		// Token: 0x0400002A RID: 42
		private Panel A;

		// Token: 0x0400002B RID: 43
		private Panel a;

		// Token: 0x0400002C RID: 44
		public CheckBox zipFcheckBox;

		// Token: 0x0400002D RID: 45
		public CheckBox zipZcheckBox;

		// Token: 0x0400002E RID: 46
		public CheckBox zipPcheckBox;

		// Token: 0x0400002F RID: 47
		public CheckBox zipVcheckBox;

		// Token: 0x04000030 RID: 48
		public PictureBox apkicon;

		// Token: 0x04000031 RID: 49
		public Label tarLbl;

		// Token: 0x04000032 RID: 50
		public Label minLbl;

		// Token: 0x04000033 RID: 51
		public Label vercLbl;

		// Token: 0x04000034 RID: 52
		public Label verLbl;

		// Token: 0x04000035 RID: 53
		public Label pakLbl;

		// Token: 0x04000036 RID: 54
		internal Button A;

		// Token: 0x04000037 RID: 55
		internal Button a;

		// Token: 0x04000038 RID: 56
		internal Button B;

		// Token: 0x04000039 RID: 57
		internal Button b;

		// Token: 0x0400003A RID: 58
		internal Button C;

		// Token: 0x0400003B RID: 59
		internal Button c;

		// Token: 0x0400003C RID: 60
		internal Button D;

		// Token: 0x0400003D RID: 61
		internal Button d;

		// Token: 0x0400003E RID: 62
		internal Button E;

		// Token: 0x0400003F RID: 63
		internal Label b;

		// Token: 0x04000040 RID: 64
		internal Label C;

		// Token: 0x04000041 RID: 65
		internal TextBox A;

		// Token: 0x04000042 RID: 66
		internal TextBox a;

		// Token: 0x04000043 RID: 67
		internal TextBox B;

		// Token: 0x04000044 RID: 68
		internal TextBox b;

		// Token: 0x04000045 RID: 69
		internal NumericUpDown A;

		// Token: 0x04000046 RID: 70
		internal CheckBox A;

		// Token: 0x04000047 RID: 71
		internal NumericUpDown a;

		// Token: 0x04000048 RID: 72
		internal CheckBox a;

		// Token: 0x04000049 RID: 73
		internal ComboBox A;

		// Token: 0x0400004A RID: 74
		internal ToolTip A;

		// Token: 0x0400004B RID: 75
		internal BackgroundWorker A;

		// Token: 0x0400004C RID: 76
		internal TabPage B;

		// Token: 0x0400004D RID: 77
		internal Button e;

		// Token: 0x0400004E RID: 78
		internal TextBox C;

		// Token: 0x0400004F RID: 79
		internal Button F;

		// Token: 0x04000050 RID: 80
		internal Label c;

		// Token: 0x04000051 RID: 81
		private TabPage b;

		// Token: 0x04000052 RID: 82
		private TabPage C;

		// Token: 0x04000053 RID: 83
		internal CheckBox B;

		// Token: 0x04000054 RID: 84
		internal TextBox c;

		// Token: 0x04000055 RID: 85
		internal TextBox D;

		// Token: 0x04000056 RID: 86
		internal CheckBox b;

		// Token: 0x04000057 RID: 87
		internal TextBox d;

		// Token: 0x04000058 RID: 88
		internal TextBox E;

		// Token: 0x04000059 RID: 89
		private TabPage c;

		// Token: 0x0400005A RID: 90
		private PictureBox a;

		// Token: 0x0400005B RID: 91
		private PictureBox B;

		// Token: 0x0400005C RID: 92
		private PictureBox b;

		// Token: 0x0400005D RID: 93
		private PictureBox C;

		// Token: 0x0400005E RID: 94
		private PictureBox c;

		// Token: 0x0400005F RID: 95
		private PictureBox D;

		// Token: 0x04000060 RID: 96
		private Label D;

		// Token: 0x04000061 RID: 97
		private Panel B;

		// Token: 0x04000062 RID: 98
		private Panel b;

		// Token: 0x04000063 RID: 99
		private Panel C;

		// Token: 0x04000064 RID: 100
		private PictureBox d;

		// Token: 0x04000065 RID: 101
		private Panel c;

		// Token: 0x04000066 RID: 102
		private Panel D;

		// Token: 0x04000067 RID: 103
		private Panel d;

		// Token: 0x04000068 RID: 104
		private PictureBox E;

		// Token: 0x04000069 RID: 105
		private PictureBox e;

		// Token: 0x0400006A RID: 106
		private Panel E;

		// Token: 0x0400006B RID: 107
		private PictureBox F;

		// Token: 0x0400006C RID: 108
		internal Button f;

		// Token: 0x0400006D RID: 109
		internal TextBox e;

		// Token: 0x0400006E RID: 110
		internal Button G;

		// Token: 0x0400006F RID: 111
		internal TextBox F;

		// Token: 0x04000070 RID: 112
		private Panel e;

		// Token: 0x04000071 RID: 113
		private PictureBox f;

		// Token: 0x04000072 RID: 114
		private Panel F;

		// Token: 0x04000073 RID: 115
		private PictureBox G;

		// Token: 0x04000074 RID: 116
		internal TextBox f;

		// Token: 0x04000075 RID: 117
		public CheckBox overApkChecked;

		// Token: 0x04000076 RID: 118
		public CheckBox installApkChkBox;

		// Token: 0x04000077 RID: 119
		public CheckBox signApkCheckBox;

		// Token: 0x04000078 RID: 120
		internal Button g;

		// Token: 0x04000079 RID: 121
		internal TextBox G;

		// Token: 0x0400007A RID: 122
		internal CheckBox C;

		// Token: 0x0400007B RID: 123
		internal TextBox g;

		// Token: 0x0400007C RID: 124
		internal TextBox H;

		// Token: 0x0400007D RID: 125
		internal TextBox h;

		// Token: 0x0400007E RID: 126
		internal TextBox I;

		// Token: 0x0400007F RID: 127
		private Button H;

		// Token: 0x04000080 RID: 128
		private Button h;

		// Token: 0x04000081 RID: 129
		internal TextBox i;

		// Token: 0x04000082 RID: 130
		internal TextBox J;

		// Token: 0x04000083 RID: 131
		internal CheckBox c;

		// Token: 0x04000084 RID: 132
		internal TabPage D;

		// Token: 0x04000085 RID: 133
		internal Button I;

		// Token: 0x04000086 RID: 134
		internal Button i;

		// Token: 0x04000087 RID: 135
		private Panel f;

		// Token: 0x04000088 RID: 136
		private PictureBox g;

		// Token: 0x04000089 RID: 137
		public ComboBox pathOfApk;

		// Token: 0x0400008A RID: 138
		internal CheckBox D;

		// Token: 0x0400008B RID: 139
		internal ComboBox a;

		// Token: 0x0400008C RID: 140
		public CheckBox zipAfterSignChkBox;

		// Token: 0x0400008D RID: 141
		internal ComboBox B;

		// Token: 0x0400008E RID: 142
		internal Button J;

		// Token: 0x0400008F RID: 143
		internal TabPage d;

		// Token: 0x04000090 RID: 144
		internal TabPage E;

		// Token: 0x04000091 RID: 145
		private Button j;

		// Token: 0x04000092 RID: 146
		internal CheckBox d;

		// Token: 0x04000093 RID: 147
		internal TextBox j;

		// Token: 0x04000094 RID: 148
		internal Button K;

		// Token: 0x04000095 RID: 149
		public Label sigVer;

		// Token: 0x04000096 RID: 150
		private PictureBox H;

		// Token: 0x04000097 RID: 151
		private Panel G;

		// Token: 0x04000098 RID: 152
		internal CheckBox E;

		// Token: 0x04000099 RID: 153
		public Label launchLbl;

		// Token: 0x0400009A RID: 154
		internal Label d;

		// Token: 0x0400009B RID: 155
		internal Label E;

		// Token: 0x0400009C RID: 156
		internal TextBox K;

		// Token: 0x0400009D RID: 157
		internal TextBox k;

		// Token: 0x0400009E RID: 158
		internal CheckBox e;

		// Token: 0x0400009F RID: 159
		internal CheckBox F;

		// Token: 0x040000A0 RID: 160
		internal CheckBox f;

		// Token: 0x040000A1 RID: 161
		public ComboBox langComboBox;

		// Token: 0x040000A2 RID: 162
		private Panel g;

		// Token: 0x040000A3 RID: 163
		public Label label95;

		// Token: 0x040000A4 RID: 164
		internal Button k;

		// Token: 0x040000A5 RID: 165
		internal Button L;

		// Token: 0x040000A6 RID: 166
		internal Button l;

		// Token: 0x040000A7 RID: 167
		internal Button M;

		// Token: 0x040000A8 RID: 168
		internal Label e;

		// Token: 0x040000A9 RID: 169
		internal Label F;

		// Token: 0x040000AA RID: 170
		internal Label f;

		// Token: 0x040000AB RID: 171
		internal Label G;

		// Token: 0x040000AC RID: 172
		internal Label g;

		// Token: 0x040000AD RID: 173
		internal Label H;

		// Token: 0x040000AE RID: 174
		internal Label h;

		// Token: 0x040000AF RID: 175
		internal Button m;

		// Token: 0x040000B0 RID: 176
		internal Label I;

		// Token: 0x040000B1 RID: 177
		internal Button N;

		// Token: 0x040000B2 RID: 178
		internal Label i;

		// Token: 0x040000B3 RID: 179
		internal Button n;

		// Token: 0x040000B4 RID: 180
		internal Label J;

		// Token: 0x040000B5 RID: 181
		internal Button O;

		// Token: 0x040000B6 RID: 182
		internal Label j;

		// Token: 0x040000B7 RID: 183
		internal Label K;

		// Token: 0x040000B8 RID: 184
		internal Label k;

		// Token: 0x040000B9 RID: 185
		internal Label L;

		// Token: 0x040000BA RID: 186
		internal Label l;

		// Token: 0x040000BB RID: 187
		internal Button o;

		// Token: 0x040000BC RID: 188
		internal Label M;

		// Token: 0x040000BD RID: 189
		internal Label m;

		// Token: 0x040000BE RID: 190
		internal Button P;

		// Token: 0x040000BF RID: 191
		internal Label N;

		// Token: 0x040000C0 RID: 192
		internal Label n;

		// Token: 0x040000C1 RID: 193
		internal Label O;

		// Token: 0x040000C2 RID: 194
		internal Label o;

		// Token: 0x040000C3 RID: 195
		internal Button p;

		// Token: 0x040000C4 RID: 196
		private Label P;

		// Token: 0x040000C5 RID: 197
		internal Label p;

		// Token: 0x040000C6 RID: 198
		internal Label Q;

		// Token: 0x040000C7 RID: 199
		internal Label q;

		// Token: 0x040000C8 RID: 200
		internal Button Q;

		// Token: 0x040000C9 RID: 201
		internal Label R;

		// Token: 0x040000CA RID: 202
		internal Label r;

		// Token: 0x040000CB RID: 203
		internal Label S;

		// Token: 0x040000CC RID: 204
		internal Label s;

		// Token: 0x040000CD RID: 205
		internal Label T;

		// Token: 0x040000CE RID: 206
		internal Label t;

		// Token: 0x040000CF RID: 207
		internal Button q;

		// Token: 0x040000D0 RID: 208
		internal Label U;

		// Token: 0x040000D1 RID: 209
		internal Button R;

		// Token: 0x040000D2 RID: 210
		internal Label u;

		// Token: 0x040000D3 RID: 211
		internal TabControl A;

		// Token: 0x040000D4 RID: 212
		internal CheckBox G;

		// Token: 0x040000D5 RID: 213
		internal CheckBox g;

		// Token: 0x040000D6 RID: 214
		internal CheckBox H;

		// Token: 0x040000D7 RID: 215
		internal CheckBox h;

		// Token: 0x040000D8 RID: 216
		internal CheckBox I;

		// Token: 0x040000D9 RID: 217
		internal Label V;

		// Token: 0x040000DA RID: 218
		internal CheckBox i;

		// Token: 0x040000DB RID: 219
		internal Label v;

		// Token: 0x040000DC RID: 220
		internal Panel H;

		// Token: 0x040000DD RID: 221
		internal Panel h;

		// Token: 0x040000DE RID: 222
		internal CheckBox J;

		// Token: 0x040000DF RID: 223
		internal CheckBox j;

		// Token: 0x040000E0 RID: 224
		internal CheckBox K;

		// Token: 0x040000E1 RID: 225
		private LinkLabel A;

		// Token: 0x040000E2 RID: 226
		private Label W;

		// Token: 0x040000E3 RID: 227
		internal Label w;

		// Token: 0x040000E4 RID: 228
		internal Label X;

		// Token: 0x040000E5 RID: 229
		internal Label x;

		// Token: 0x040000E6 RID: 230
		internal Label Y;

		// Token: 0x040000E7 RID: 231
		internal Label y;

		// Token: 0x040000E8 RID: 232
		internal Button r;

		// Token: 0x040000E9 RID: 233
		internal Button S;

		// Token: 0x040000EA RID: 234
		internal Button s;

		// Token: 0x040000EB RID: 235
		private Label Z;

		// Token: 0x040000EC RID: 236
		private Label z;

		// Token: 0x040000ED RID: 237
		private Label aA;

		// Token: 0x040000EE RID: 238
		private Label aa;

		// Token: 0x040000EF RID: 239
		internal Label aB;

		// Token: 0x040000F0 RID: 240
		internal Label ab;

		// Token: 0x040000F1 RID: 241
		internal Label aC;

		// Token: 0x040000F2 RID: 242
		internal Label ac;

		// Token: 0x040000F3 RID: 243
		internal Label aD;

		// Token: 0x040000F4 RID: 244
		internal LinkLabel a;

		// Token: 0x040000F5 RID: 245
		internal Label ad;

		// Token: 0x040000F6 RID: 246
		internal Label aE;

		// Token: 0x040000F7 RID: 247
		internal Label ae;

		// Token: 0x040000F8 RID: 248
		internal CheckBox k;

		// Token: 0x040000F9 RID: 249
		internal PictureBox h;

		// Token: 0x040000FA RID: 250
		internal PictureBox I;

		// Token: 0x040000FB RID: 251
		internal PictureBox i;

		// Token: 0x040000FC RID: 252
		internal Panel I;

		// Token: 0x040000FD RID: 253
		internal Button T;

		// Token: 0x040000FE RID: 254
		internal Label aF;

		// Token: 0x040000FF RID: 255
		internal Button t;

		// Token: 0x04000100 RID: 256
		internal Button U;

		// Token: 0x04000101 RID: 257
		internal Button u;

		// Token: 0x04000102 RID: 258
		internal Button V;

		// Token: 0x04000103 RID: 259
		internal Button v;

		// Token: 0x04000104 RID: 260
		public Label label11;

		// Token: 0x04000105 RID: 261
		public Label apkvLbl;

		// Token: 0x04000106 RID: 262
		internal CheckBox L;

		// Token: 0x04000107 RID: 263
		internal Button W;

		// Token: 0x04000108 RID: 264
		internal TextBox L;

		// Token: 0x04000109 RID: 265
		internal CheckBox l;

		// Token: 0x0400010A RID: 266
		internal Label af;

		// Token: 0x0400010B RID: 267
		private StatusStrip A;

		// Token: 0x0400010C RID: 268
		private ToolStripStatusLabel A;

		// Token: 0x0400010D RID: 269
		private ToolStripStatusLabel a;

		// Token: 0x0400010E RID: 270
		internal Button w;

		// Token: 0x0400010F RID: 271
		internal Button X;

		// Token: 0x04000110 RID: 272
		internal Label aG;

		// Token: 0x04000111 RID: 273
		internal Label ag;

		// Token: 0x04000112 RID: 274
		internal CheckBox M;

		// Token: 0x04000113 RID: 275
		internal ComboBox b;

		// Token: 0x04000114 RID: 276
		internal ComboBox C;

		// Token: 0x04000115 RID: 277
		internal ComboBox c;

		// Token: 0x04000116 RID: 278
		internal Label aH;

		// Token: 0x04000117 RID: 279
		internal Label ah;

		// Token: 0x04000118 RID: 280
		internal Label aI;

		// Token: 0x04000119 RID: 281
		internal Label ai;

		// Token: 0x0400011A RID: 282
		internal CheckBox m;

		// Token: 0x0400011B RID: 283
		internal Label aJ;

		// Token: 0x0400011C RID: 284
		internal Label aj;

		// Token: 0x0400011D RID: 285
		internal Button x;

		// Token: 0x02000006 RID: 6
		public enum Type
		{
			// Token: 0x0400011F RID: 287
			None,
			// Token: 0x04000120 RID: 288
			Info,
			// Token: 0x04000121 RID: 289
			Error,
			// Token: 0x04000122 RID: 290
			Warning
		}

		// Token: 0x02000007 RID: 7
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06000095 RID: 149 RVA: 0x000099D8 File Offset: 0x00007BD8
			internal void A(object A_1, EventArgs A_2)
			{
				new U().Show();
			}

			// Token: 0x06000096 RID: 150 RVA: 0x000099E4 File Offset: 0x00007BE4
			internal void A(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(),
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv()
				});
			}

			// Token: 0x06000097 RID: 151 RVA: 0x000099E4 File Offset: 0x00007BE4
			internal void a(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(),
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv()
				});
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00009A02 File Offset: 0x00007C02
			internal void B(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b()
				});
			}

			// Token: 0x06000099 RID: 153 RVA: 0x00009A18 File Offset: 0x00007C18
			internal void b(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
				});
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00009A18 File Offset: 0x00007C18
			internal void C(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
				});
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00009A18 File Offset: 0x00007C18
			internal void c(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
				});
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00009A18 File Offset: 0x00007C18
			internal void D(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
				});
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00009A18 File Offset: 0x00007C18
			internal void d(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
				});
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00009A18 File Offset: 0x00007C18
			internal void E(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
				});
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00009A18 File Offset: 0x00007C18
			internal void e(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV()
				});
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00009A2E File Offset: 0x00007C2E
			internal void a(object A_1, EventArgs A_2)
			{
				new AIF().Show();
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x00009A3A File Offset: 0x00007C3A
			internal void A(object A_1, LinkClickedEventArgs A_2)
			{
				Process.Start(A_2.LinkText);
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00009A48 File Offset: 0x00007C48
			internal void F(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cy(),
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cZ(),
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cz()
				});
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00009A48 File Offset: 0x00007C48
			internal void f(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cy(),
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cZ(),
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cz()
				});
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00009A02 File Offset: 0x00007C02
			internal void G(object A_1, DragEventArgs A_2)
			{
				A_2.CheckDragEnter(new string[]
				{
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b()
				});
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00009A6E File Offset: 0x00007C6E
			internal void B(object A_1, EventArgs A_2)
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ic()));
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x00009A85 File Offset: 0x00007C85
			internal void b(object A_1, EventArgs A_2)
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cW(), Vars.TempPath);
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x00009A97 File Offset: 0x00007C97
			internal void C(object A_1, EventArgs A_2)
			{
				CMD.ProcessStartWithArgs(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.js()), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jT() + Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jt()) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jU());
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00009AC1 File Offset: 0x00007CC1
			internal void c(object A_1, EventArgs A_2)
			{
				CMD.ProcessStartWithArgs(Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.js()), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ju() + Vars.RealPath(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jt()) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DS());
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00009AEB File Offset: 0x00007CEB
			internal void D(object A_1, EventArgs A_2)
			{
				Application.Restart();
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00009AF2 File Offset: 0x00007CF2
			internal void d(object A_1, EventArgs A_2)
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jV());
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00009AFF File Offset: 0x00007CFF
			internal void E(object A_1, EventArgs A_2)
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jv());
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00009B0C File Offset: 0x00007D0C
			internal void e(object A_1, EventArgs A_2)
			{
				Process.Start(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jW());
			}

			// Token: 0x04000123 RID: 291
			public static readonly AMF.a A = new AMF.a();

			// Token: 0x04000124 RID: 292
			public static EventHandler A;

			// Token: 0x04000125 RID: 293
			public static DragEventHandler A;

			// Token: 0x04000126 RID: 294
			public static DragEventHandler a;

			// Token: 0x04000127 RID: 295
			public static DragEventHandler B;

			// Token: 0x04000128 RID: 296
			public static DragEventHandler b;

			// Token: 0x04000129 RID: 297
			public static DragEventHandler C;

			// Token: 0x0400012A RID: 298
			public static DragEventHandler c;

			// Token: 0x0400012B RID: 299
			public static DragEventHandler D;

			// Token: 0x0400012C RID: 300
			public static DragEventHandler d;

			// Token: 0x0400012D RID: 301
			public static DragEventHandler E;

			// Token: 0x0400012E RID: 302
			public static DragEventHandler e;

			// Token: 0x0400012F RID: 303
			public static EventHandler a;

			// Token: 0x04000130 RID: 304
			public static LinkClickedEventHandler A;

			// Token: 0x04000131 RID: 305
			public static DragEventHandler F;

			// Token: 0x04000132 RID: 306
			public static DragEventHandler f;

			// Token: 0x04000133 RID: 307
			public static DragEventHandler G;

			// Token: 0x04000134 RID: 308
			public static EventHandler B;

			// Token: 0x04000135 RID: 309
			public static EventHandler b;

			// Token: 0x04000136 RID: 310
			public static EventHandler C;

			// Token: 0x04000137 RID: 311
			public static EventHandler c;

			// Token: 0x04000138 RID: 312
			public static EventHandler D;

			// Token: 0x04000139 RID: 313
			public static EventHandler d;

			// Token: 0x0400013A RID: 314
			public static EventHandler E;

			// Token: 0x0400013B RID: 315
			public static EventHandler e;
		}

		// Token: 0x02000008 RID: 8
		[CompilerGenerated]
		private sealed class B
		{
			// Token: 0x060000AE RID: 174 RVA: 0x00009B1C File Offset: 0x00007D1C
			internal void A()
			{
				this.A.richTextBoxLogs.SelectionColor = (this.A ?? Color.White);
				this.A.richTextBoxLogs.AppendText(this.A + Environment.NewLine);
			}

			// Token: 0x0400013C RID: 316
			public AMF A;

			// Token: 0x0400013D RID: 317
			public Color? A;

			// Token: 0x0400013E RID: 318
			public string A;
		}

		// Token: 0x02000009 RID: 9
		[CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060000B0 RID: 176 RVA: 0x00009B77 File Offset: 0x00007D77
			internal void A()
			{
				this.A.A.Text = this.A;
				this.A.a.Image = this.A;
			}

			// Token: 0x0400013F RID: 319
			public AMF A;

			// Token: 0x04000140 RID: 320
			public string A;

			// Token: 0x04000141 RID: 321
			public Image A;
		}
	}
}
