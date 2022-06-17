using System;
using System.IO;
using System.Xml.Serialization;

namespace APKEasyTool
{
	// Token: 0x0200001C RID: 28
	public class XMLSave
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00011F10 File Offset: 0x00010110
		public static void SaveData(object obj, string filename)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
			TextWriter textWriter = new StreamWriter(filename);
			xmlSerializer.Serialize(textWriter, obj);
			textWriter.Close();
		}
	}
}
