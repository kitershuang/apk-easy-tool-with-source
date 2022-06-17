using System;
using System.Windows.Forms;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x0200002D RID: 45
	public class TSma
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x000150A8 File Offset: 0x000132A8
		public TSma(AMF Main)
		{
			TSma.A = Main;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000150B8 File Offset: 0x000132B8
		internal void A(object A_1, EventArgs A_2)
		{
			if (TSma.A.H.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.DEX_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (TSma.A.I.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.DIR_NOT_SET_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (TSma.A.J.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.PLZ_ENTER_DIS_NAME_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			TSma.A.g.Text = TSma.A.I.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TSma.A.J.Text;
			TSma.A.i.Text = TSma.A.J.Text;
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dk(), TSma.A.H.Text, TSma.A.I.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TSma.A.J.Text);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000151E8 File Offset: 0x000133E8
		internal void a(object A_1, EventArgs A_2)
		{
			if (TSma.A.g.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.DEX_NOT_SEL_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (TSma.A.h.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.DIR_NOT_SET_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (TSma.A.i.Text == 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b())
			{
				MessageBox.Show(Lang.PLZ_ENTER_SMA_NAME_MBOX, Lang.WIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			CMD.Command(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dL(), TSma.A.g.Text, TSma.A.h.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dy() + TSma.A.i.Text);
		}

		// Token: 0x0400027E RID: 638
		private static AMF A;
	}
}
