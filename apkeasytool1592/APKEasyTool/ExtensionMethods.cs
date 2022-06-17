using System;
using System.IO;
using System.Runtime.InteropServices;

namespace APKEasyTool
{
	// Token: 0x02000002 RID: 2
	public static class ExtensionMethods
	{
		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "FlashWindowEx")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool A(ref ExtensionMethods.A);

		// Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
		public static bool FlashNotification(this AMF form)
		{
			bool result;
			try
			{
				IntPtr handle = form.Handle;
				ExtensionMethods.A structure = default(ExtensionMethods.A);
				structure.A = Convert.ToUInt32(Marshal.SizeOf<ExtensionMethods.A>(structure));
				structure.A = handle;
				structure.a = 15U;
				structure.B = uint.MaxValue;
				structure.b = 1000U;
				result = ExtensionMethods.A(ref structure);
			}
			catch (FileNotFoundException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private const uint A = 3U;

		// Token: 0x04000002 RID: 2
		private const uint a = 12U;

		// Token: 0x02000003 RID: 3
		private struct A
		{
			// Token: 0x04000003 RID: 3
			public uint A;

			// Token: 0x04000004 RID: 4
			public IntPtr A;

			// Token: 0x04000005 RID: 5
			public uint a;

			// Token: 0x04000006 RID: 6
			public uint B;

			// Token: 0x04000007 RID: 7
			public uint b;
		}
	}
}
