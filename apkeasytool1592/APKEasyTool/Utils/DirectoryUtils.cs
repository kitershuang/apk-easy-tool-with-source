using System;
using System.Windows.Forms;

namespace APKEasyTool.Utils
{
	// Token: 0x02000034 RID: 52
	public class DirectoryUtils
	{
		// Token: 0x0600023C RID: 572 RVA: 0x00016C9C File Offset: 0x00014E9C
		internal static void A(string A_0, Action<string> A_1)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = A_0;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				A_1(folderBrowserDialog.SelectedPath);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00016CCC File Offset: 0x00014ECC
		internal static void A(string A_0, string A_1, Action<string> A_2)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = A_1;
			openFileDialog.Title = A_0;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				A_2(openFileDialog.FileName);
			}
		}
	}
}
