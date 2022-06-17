using System;
using System.Net;
using System.Net.NetworkInformation;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x0200002F RID: 47
	public class Updates
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00016190 File Offset: 0x00014390
		public static string RemoteVersion()
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				try
				{
					string text = new WebClient().DownloadString(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Jf());
					if (!string.IsNullOrEmpty(text))
					{
						return text;
					}
				}
				catch (Exception)
				{
					return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@in();
				}
			}
			return null;
		}
	}
}
