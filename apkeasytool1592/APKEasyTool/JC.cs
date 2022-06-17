using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x02000014 RID: 20
	public class JC
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0000F794 File Offset: 0x0000D994
		public bool checkIfJavaIsInstalled()
		{
			bool result = false;
			Process process = new Process();
			try
			{
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.FileName = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hE();
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.Arguments = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.he();
				process.OutputDataReceived += this.A;
				process.ErrorDataReceived += this.a;
				process.Start();
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
				process.WaitForExit();
				result = (process.ExitCode == 0);
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000F877 File Offset: 0x0000DA77
		[CompilerGenerated]
		private void A(object A_1, DataReceivedEventArgs A_2)
		{
			if (A_2.Data != null)
			{
				this.A.Add(A_2.Data);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000F877 File Offset: 0x0000DA77
		[CompilerGenerated]
		private void a(object A_1, DataReceivedEventArgs A_2)
		{
			if (A_2.Data != null)
			{
				this.A.Add(A_2.Data);
			}
		}

		// Token: 0x04000234 RID: 564
		private readonly List<string> A = new List<string>();
	}
}
