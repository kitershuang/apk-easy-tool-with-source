using System;
using System.Reflection;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace APKEasyTool
{
	// Token: 0x02000015 RID: 21
	public class JList
	{
		// Token: 0x06000187 RID: 391 RVA: 0x0000F892 File Offset: 0x0000DA92
		public JList(IntPtr windowHandle)
		{
			this.A = JumpList.CreateJumpListForIndividualWindow(TaskbarManager.Instance.ApplicationId, windowHandle);
			this.A.KnownCategoryToDisplay = 1;
			this.A();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000F8C2 File Offset: 0x0000DAC2
		public void AddToRecent(string destination)
		{
			JumpList.AddToRecent(destination);
			this.A.Refresh();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		private void A()
		{
			try
			{
				new JumpListCustomCategory(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hF());
				JumpListLink jumpListLink = new JumpListLink(Assembly.GetEntryAssembly().Location, Lang.OPEN_DEC_APK_DIR);
				jumpListLink.IconReference = new IconReference(Assembly.GetEntryAssembly().Location, 3);
				jumpListLink.Arguments = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hf();
				JumpListLink jumpListLink2 = new JumpListLink(Assembly.GetEntryAssembly().Location, Lang.OPEN_COM_APK_DIR);
				jumpListLink2.IconReference = new IconReference(Assembly.GetEntryAssembly().Location, 2);
				jumpListLink2.Arguments = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hG();
				JumpListLink jumpListLink3 = new JumpListLink(Assembly.GetEntryAssembly().Location, Lang.OPEN_EXT_APK_DIR);
				jumpListLink3.IconReference = new IconReference(Assembly.GetEntryAssembly().Location, 1);
				jumpListLink3.Arguments = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hg();
				JumpListLink jumpListLink4 = new JumpListLink(Assembly.GetEntryAssembly().Location, Lang.OPEN_ZIP_APK_DIR);
				jumpListLink4.IconReference = new IconReference(Assembly.GetEntryAssembly().Location, 1);
				jumpListLink4.Arguments = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hH();
				JumpListLink jumpListLink5 = new JumpListLink(Assembly.GetEntryAssembly().Location, Lang.OPEN_BAKSMALI_APK_DIR);
				jumpListLink5.IconReference = new IconReference(Assembly.GetEntryAssembly().Location, 4);
				jumpListLink5.Arguments = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hh();
				JumpListLink jumpListLink6 = new JumpListLink(Assembly.GetEntryAssembly().Location, Lang.OPEN_SMALI_APK_DIR);
				jumpListLink6.IconReference = new IconReference(Assembly.GetEntryAssembly().Location, 4);
				jumpListLink6.Arguments = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hI();
				this.A.AddUserTasks(new JumpListTask[]
				{
					jumpListLink
				});
				this.A.AddUserTasks(new JumpListTask[]
				{
					jumpListLink2
				});
				this.A.AddUserTasks(new JumpListTask[]
				{
					jumpListLink3
				});
				this.A.AddUserTasks(new JumpListTask[]
				{
					jumpListLink4
				});
				this.A.AddUserTasks(new JumpListTask[]
				{
					jumpListLink5
				});
				this.A.AddUserTasks(new JumpListTask[]
				{
					jumpListLink6
				});
				this.A.Refresh();
			}
			catch
			{
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000FAE8 File Offset: 0x0000DCE8
		public static void TaskBar(int state)
		{
			TaskbarManager.Instance.SetProgressState(state);
		}

		// Token: 0x04000235 RID: 565
		private JumpList A;
	}
}
