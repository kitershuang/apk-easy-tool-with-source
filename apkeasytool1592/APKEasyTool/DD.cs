using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x0200000F RID: 15
	public static class DD
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000B87E File Offset: 0x00009A7E
		public static string[] GetFilesDrop(this DragEventArgs args)
		{
			return ((string[])args.Data.GetData(DataFormats.FileDrop)) ?? DD.A;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000B8A0 File Offset: 0x00009AA0
		public static bool CheckDragOver(this DragEventArgs e, params string[] extensions)
		{
			DD.A a = new DD.A();
			a.A = e.GetFilesDrop();
			return extensions.Any(new Func<string, bool>(a.A)) || (Directory.Exists(a.A[0]) && File.Exists(a.A[0] + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dC()) && File.Exists(a.A[0] + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dc()));
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000B918 File Offset: 0x00009B18
		public static void CheckDragEnter(this DragEventArgs e, params string[] extensions)
		{
			DD.a a = new DD.a();
			a.A = e.GetFilesDrop();
			if (extensions.Any(new Func<string, bool>(a.A)) || (Directory.Exists(a.A[0]) && File.Exists(a.A[0] + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dC()) && File.Exists(a.A[0] + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dc())))
			{
				e.Effect = DragDropEffects.Copy;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000B99C File Offset: 0x00009B9C
		internal static void A(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.B.BackColor = Color.White;
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				string extension = Path.GetExtension(text);
				if (extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase))
				{
					A_0.pathOfApk.Text = text.ToString();
					A_0.a.Text = Path.GetFileNameWithoutExtension(A_0.pathOfApk.Text);
					A_0.B.Text = Path.GetFileNameWithoutExtension(A_0.pathOfApk.Text);
					if (!A_0.D.Checked && A_0.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !A_0.pathOfApk.Items.Contains(A_0.pathOfApk.Text))
					{
						A_0.pathOfApk.Items.Insert(0, A_0.pathOfApk.Text);
					}
					A_0.A.B(A_0.pathOfApk.Text);
					TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dD());
				}
				if (extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv(), StringComparison.CurrentCultureIgnoreCase))
				{
					A_0.pathOfApk.Text = text.ToString();
					A_0.a.Text = Path.GetFileNameWithoutExtension(A_0.pathOfApk.Text);
					A_0.B.Text = Path.GetFileNameWithoutExtension(A_0.pathOfApk.Text);
					if (!A_0.D.Checked && A_0.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !A_0.pathOfApk.Items.Contains(A_0.pathOfApk.Text))
					{
						A_0.pathOfApk.Items.Insert(0, A_0.pathOfApk.Text);
					}
					A_0.A.B(A_0.pathOfApk.Text);
					TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dd());
				}
				if (Directory.Exists(text))
				{
					if (File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dC()) && File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dc()))
					{
						if (!A_0.D.Checked && A_0.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !A_0.pathOfApk.Items.Contains(A_0.pathOfApk.Text) && File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dC()))
						{
							A_0.pathOfApk.Items.Insert(0, A_0.pathOfApk.Text);
						}
						A_0.A.B(text);
						TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dE());
						A_0.pathOfApk.Text = text.ToString();
						A_0.B.Text = Path.GetFileName(A_0.pathOfApk.Text);
					}
					else if (File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
					{
						if (!A_0.D.Checked && A_0.pathOfApk.Text != 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b() && !A_0.pathOfApk.Items.Contains(A_0.pathOfApk.Text) && File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
						{
							A_0.pathOfApk.Items.Insert(0, A_0.pathOfApk.Text);
						}
						A_0.A.B(A_0.pathOfApk.Text);
						TMain.A(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dF());
						A_0.pathOfApk.Text = text.ToString();
						A_0.B.Text = Path.GetFileName(A_0.pathOfApk.Text);
					}
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000BD64 File Offset: 0x00009F64
		internal static void a(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.A.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				string extension = Path.GetExtension(text);
				if (extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase) || extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv(), StringComparison.CurrentCultureIgnoreCase))
				{
					if (A_0.A.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
					{
						MessageBox.Show(Lang.APKTOOL_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						A_0.tMain.SelectedIndex = 4;
						return;
					}
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.df(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text), text);
				}
				if (extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase) || extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cv(), StringComparison.CurrentCultureIgnoreCase))
				{
					A_2.Effect = DragDropEffects.Copy;
				}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000BE70 File Offset: 0x0000A070
		internal static void B(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.a.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string text = ((string[])A_2.Data.GetData(DataFormats.FileDrop))[0];
				if (Directory.Exists(text))
				{
					if (A_0.A.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
					{
						MessageBox.Show(Lang.APKTOOL_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						A_0.tMain.SelectedIndex = 4;
						return;
					}
					if (File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dG()) && File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
					{
						CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dH(), text);
						return;
					}
					if (File.Exists(text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.de()))
					{
						CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dg(), text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dh(), text);
					}
				}
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000BF70 File Offset: 0x0000A170
		internal static void b(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.B.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			string[] array = DD.multifiles = (string[])A_2.Data.GetData(DataFormats.FileDrop);
			int num = 0;
			if (num >= array.Length)
			{
				return;
			}
			string text = array[num];
			if (DD.multifiles.Length > 1)
			{
				CMD.draganddropmass = true;
			}
			if (Path.GetExtension(text).Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase))
			{
				if (A_0.overApkChecked.Checked)
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da(), text, text);
					return;
				}
				CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.da(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dI(), text);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000C040 File Offset: 0x0000A240
		internal static void C(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.b.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				if (Path.GetExtension(text).Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dB(), text, text);
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		internal static void c(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.J.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				if (Path.GetExtension(text).Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.DY(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), text);
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000C154 File Offset: 0x0000A354
		internal static void D(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.C.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				if (Path.GetExtension(text).Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.db(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b(), text);
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		internal static void d(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.D.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				if (Path.GetExtension(text).Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.di(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text), text);
				}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000C27C File Offset: 0x0000A47C
		internal static void E(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.c.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string text = ((string[])A_2.Data.GetData(DataFormats.FileDrop))[0];
				Path.GetExtension(text);
				if (Directory.Exists(text))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dJ(), Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dj(), text);
				}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000C308 File Offset: 0x0000A508
		internal static void e(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.g.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				if (Path.GetExtension(text).Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cV(), StringComparison.CurrentCultureIgnoreCase))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dK(), text, 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b());
				}
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000C394 File Offset: 0x0000A594
		internal static void F(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.D.BackColor = Color.White;
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				string extension = Path.GetExtension(text);
				if (extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cy(), StringComparison.CurrentCultureIgnoreCase) || extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cZ(), StringComparison.CurrentCultureIgnoreCase) || extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cz(), StringComparison.CurrentCultureIgnoreCase))
				{
					A_0.H.Text = text;
					A_0.J.Text = Path.GetFileName(text);
				}
				if (Directory.Exists(text))
				{
					A_0.g.Text = text;
					A_0.i.Text = Path.GetFileName(text);
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000C464 File Offset: 0x0000A664
		internal static void f(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.i.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (!A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}
			foreach (string text in (string[])A_2.Data.GetData(DataFormats.FileDrop))
			{
				string extension = Path.GetExtension(text);
				if (extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cy(), StringComparison.CurrentCultureIgnoreCase) || extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cZ(), StringComparison.CurrentCultureIgnoreCase) || extension.Equals(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.cz(), StringComparison.CurrentCultureIgnoreCase))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dk(), text, Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text));
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000C520 File Offset: 0x0000A720
		internal static void G(this AMF A_0, object A_1, DragEventArgs A_2)
		{
			A_0.I.BackColor = Color.FromArgb(0, 225, 225, 225);
			if (A_2.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string text = ((string[])A_2.Data.GetData(DataFormats.FileDrop))[0];
				if (Directory.Exists(text))
				{
					CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dL(), text, Path.GetDirectoryName(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + Path.GetFileNameWithoutExtension(text) + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dl());
				}
			}
		}

		// Token: 0x04000168 RID: 360
		public static string[] multifiles;

		// Token: 0x04000169 RID: 361
		public static int multifilesint = 0;

		// Token: 0x0400016A RID: 362
		public static int multifilesint1 = 0;

		// Token: 0x0400016B RID: 363
		private static readonly string[] A = new string[0];

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		private sealed class A
		{
			// Token: 0x060000DC RID: 220 RVA: 0x0000C5BE File Offset: 0x0000A7BE
			internal bool A(string A_1)
			{
				return this.A[0].EndsWith(A_1, StringComparison.Ordinal);
			}

			// Token: 0x0400016C RID: 364
			public string[] A;
		}

		// Token: 0x02000011 RID: 17
		[CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000DE RID: 222 RVA: 0x0000C5CF File Offset: 0x0000A7CF
			internal bool A(string A_1)
			{
				return this.A[0].EndsWith(A_1, StringComparison.Ordinal);
			}

			// Token: 0x0400016D RID: 365
			public string[] A;
		}
	}
}
