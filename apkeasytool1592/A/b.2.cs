using System;
using System.Runtime.CompilerServices;

namespace A
{
	// Token: 0x02000038 RID: 56
	[CompilerGenerated]
	internal sealed class b
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0001799C File Offset: 0x00015B9C
		internal static uint A(string A_0)
		{
			uint num;
			if (A_0 != null)
			{
				num = 2166136261U;
				for (int i = 0; i < A_0.Length; i++)
				{
					num = ((uint)A_0[i] ^ num) * 16777619U;
				}
			}
			return num;
		}
	}
}
