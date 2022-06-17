using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace A
{
	// Token: 0x02000039 RID: 57
	[CompilerGenerated]
	internal static class C
	{
		// Token: 0x06000252 RID: 594 RVA: 0x000179D4 File Offset: 0x00015BD4
		private static string A(CultureInfo A_0)
		{
			if (A_0 == null)
			{
				return 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
			}
			return A_0.Name;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000179E8 File Offset: 0x00015BE8
		private static Assembly A(AssemblyName A_0)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Assembly[] assemblies = currentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, A_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(C.A(name.CultureInfo), C.A(A_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00017A58 File Offset: 0x00015C58
		private static void A(Stream A_0, Stream A_1)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = A_0.Read(array, 0, array.Length)) != 0)
			{
				A_1.Write(array, 0, count);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00017A8C File Offset: 0x00015C8C
		private static Stream A(string A_0)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (A_0.EndsWith(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jJ()))
			{
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(A_0))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						C.A(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						return memoryStream;
					}
				}
			}
			return executingAssembly.GetManifestResourceStream(A_0);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00017B10 File Offset: 0x00015D10
		private static Stream A(Dictionary<string, string> A_0, string A_1)
		{
			string text;
			if (A_0.TryGetValue(A_1, out text))
			{
				return C.A(text);
			}
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00017B30 File Offset: 0x00015D30
		private static byte[] A(Stream A_0)
		{
			byte[] array = new byte[A_0.Length];
			A_0.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00017B58 File Offset: 0x00015D58
		private static Assembly A(Dictionary<string, string> A_0, Dictionary<string, string> A_1, AssemblyName A_2)
		{
			string text = A_2.Name.ToLowerInvariant();
			if (A_2.CultureInfo != null && !string.IsNullOrEmpty(A_2.CultureInfo.Name))
			{
				text = A_2.CultureInfo.Name + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jj() + text;
			}
			byte[] rawAssembly;
			using (Stream stream = C.A(A_0, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = C.A(stream);
			}
			using (Stream stream2 = C.A(A_1, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = C.A(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00017C18 File Offset: 0x00015E18
		public static Assembly A(object A_0, ResolveEventArgs A_1)
		{
			object obj = C.A;
			lock (obj)
			{
				if (C.A.ContainsKey(A_1.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(A_1.Name);
			Assembly assembly = C.A(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = C.A(C.A, C.a, assemblyName);
			if (assembly == null)
			{
				object obj2 = C.A;
				lock (obj2)
				{
					C.A[A_1.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00017CFC File Offset: 0x00015EFC
		// Note: this type is marked as 'beforefieldinit'.
		static C()
		{
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jK(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jk());
			C.a.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jK(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jL());
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jl(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jM());
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jm(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jN());
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jn(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jO());
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jo(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jP());
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jp(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jQ());
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jq(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jR());
			C.A.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jr(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.jS());
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00017DE8 File Offset: 0x00015FE8
		public static void A()
		{
			if (Interlocked.Exchange(ref C.A, 1) == 1)
			{
				return;
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += C.A;
		}

		// Token: 0x040002C3 RID: 707
		private static object A = new object();

		// Token: 0x040002C4 RID: 708
		private static Dictionary<string, bool> A = new Dictionary<string, bool>();

		// Token: 0x040002C5 RID: 709
		private static Dictionary<string, string> A = new Dictionary<string, string>();

		// Token: 0x040002C6 RID: 710
		private static Dictionary<string, string> a = new Dictionary<string, string>();

		// Token: 0x040002C7 RID: 711
		private static int A;
	}
}
