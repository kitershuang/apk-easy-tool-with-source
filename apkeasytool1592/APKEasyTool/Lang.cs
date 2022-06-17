using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using <PrivateImplementationDetails>{772A5486-42ED-4673-A769-A9ED7CAF4601};

namespace APKEasyTool
{
	// Token: 0x02000012 RID: 18
	public class Lang
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		public Lang(AMF Main)
		{
			Lang.A = Main;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
		public static string Localize(string key)
		{
			try
			{
				if (Lang._localizations[Lang._currentLocalization].ContainsKey(key))
				{
					return Lang._localizations[Lang._currentLocalization][key];
				}
				RichTextBox richTextBoxLogs = Lang.A.richTextBoxLogs;
				richTextBoxLogs.Text = richTextBoxLogs.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dM() + key + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dm();
			}
			catch (Exception ex)
			{
				RichTextBox richTextBoxLogs2 = Lang.A.richTextBoxLogs;
				richTextBoxLogs2.Text = string.Concat(new string[]
				{
					richTextBoxLogs2.Text,
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dN(),
					ex.Message,
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dn(),
					key,
					68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Dz()
				});
			}
			return key;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		public static string Localize(string key, string orig)
		{
			try
			{
				if (Lang._localizations[Lang._currentLocalization].ContainsKey(key))
				{
					return Lang._localizations[Lang._currentLocalization][key];
				}
			}
			catch (Exception)
			{
				return orig;
			}
			return orig;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000C70C File Offset: 0x0000A90C
		public static bool LoadLocalization(string pFile)
		{
			Lang._localizations.Clear();
			bool result;
			try
			{
				if (!File.Exists(pFile))
				{
					result = false;
				}
				else
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(pFile);
					XmlNodeList xmlNodeList = xmlDocument.SelectNodes(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dO());
					Lang._localizations.Add(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@do(), new Dictionary<string, string>());
					string text = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.b();
					try
					{
						if (xmlNodeList.Count > 0)
						{
							foreach (object obj in xmlNodeList)
							{
								XmlNode xmlNode = (XmlNode)obj;
								text = xmlNode.Attributes[68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dP()].Value;
								if (!Lang._localizations[Lang._currentLocalization].ContainsKey(text))
								{
									Lang._localizations[68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@do()].Add(text, xmlNode.Attributes[68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dp()].Value.Replace(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dQ(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dq()));
								}
								else
								{
									RichTextBox richTextBoxLogs = Lang.A.richTextBoxLogs;
									richTextBoxLogs.Text = richTextBoxLogs.Text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dM() + text + 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dR();
								}
							}
						}
					}
					catch (Exception ex)
					{
						RichTextBox richTextBoxLogs2 = Lang.A.richTextBoxLogs;
						richTextBoxLogs2.Text = string.Concat(new string[]
						{
							richTextBoxLogs2.Text,
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dr(),
							ex.Message,
							68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dS(),
							text
						});
					}
					Lang.LoadStr();
					Lang.LoadStrForm();
					result = true;
				}
			}
			catch (Exception)
			{
				Lang._localizations.Clear();
				result = false;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		public static void LoadStr()
		{
			Lang.APKTOOL_NOT_SEL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ds(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dT());
			Lang.APK_NOT_SEL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dt(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dU());
			Lang.SEL_FILES_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.du(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dV());
			Lang.INVALID_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dv(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dW());
			Lang.PAK_ID_COPY_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dw(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dX());
			Lang.LAUNCH_COPY_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dx(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dY());
			Lang.SEL_DEC_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dy(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dZ());
			Lang.NOT_A_DEC_2_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.dz(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EA());
			Lang.APK_DEC_NOT_SET_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ea(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EB());
			Lang.PLZ_NAME_DEC_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Eb(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EC());
			Lang.DEC_AGAIN_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ec(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ED());
			Lang.APK_DEX_NOT_SEL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ed(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EE());
			Lang.ENTER_NAME_COM_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ee(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EF());
			Lang.DEC_APK_FIRST_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ef(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EG());
			Lang.COM_APK_FIRST_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Eg(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EH());
			Lang.ADB_BUSY_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Eh(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EI());
			Lang.ZIPALIGN_FIRST_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ei(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EJ());
			Lang.EXT_APK_FIRST_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ej(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EK());
			Lang.CANCEL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ek(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EL());
			Lang.CANCEL_ESC = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.El(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EM());
			Lang.SEL_DEX_ODEX_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Em(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EN());
			Lang.SEL_DIS_DIR_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.En(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EO());
			Lang.DEX_NOT_SEL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Eo(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EP());
			Lang.DIR_NOT_SET_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ep(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EQ());
			Lang.PLZ_ENTER_DIS_NAME_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Eq(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ER());
			Lang.SEL_DIS_FOLDER_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Er(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ES());
			Lang.SEL_SMA_DIR_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Es(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ET());
			Lang.PLZ_ENTER_SMA_NAME_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Et(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EU());
			Lang.CLEAR_LOGS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Eu(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EV());
			Lang.CLEAR_LOGS_MBOX_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ev(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EW());
			Lang.LOG_DIR_MBOX_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ew(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EX());
			Lang.PLEASE_READ_FAQ = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ex(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EY());
			Lang.AND_FW_PACK_LBL = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ey(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.EZ());
			Lang.SEL_FW_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ez(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eA());
			Lang.FW_NOT_SEL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ea(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eB());
			Lang.SEL_FW_FOLDER_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eb(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eC());
			Lang.SEL_FW_STORED_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ec(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eD());
			Lang.SEL_DEC_DIR_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ed(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eE());
			Lang.SEL_COM_DIR_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ee(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eF());
			Lang.SEL_EXT_DIR_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ef(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eG());
			Lang.SEL_ZIP_DIR_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eg(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eH());
			Lang.SEL_PK8_FILE_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eh(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eI());
			Lang.SEL_PEM_FILE_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ei(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eJ());
			Lang.SEL_KEY_FILE_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ej(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eK());
			Lang.SEL_AAPT_FILE_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ek(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eL());
			Lang.SEL_ALL_DIR_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.el(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eM());
			Lang.HIS_CLEAR_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.em(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eN());
			Lang.RES_DIAG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.en(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eO());
			Lang.SAVE_FILE_FILTER = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eo(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eP());
			Lang.DOWNLOADING_LBL = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ep(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eQ());
			Lang.DOWN_OK_LBL = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eq(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eR());
			Lang.OPEN_DEC_APK_DIR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.er(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eS());
			Lang.OPEN_COM_APK_DIR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.es(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eT());
			Lang.OPEN_EXT_APK_DIR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.et(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eU());
			Lang.OPEN_ZIP_APK_DIR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eu(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eV());
			Lang.OPEN_BAKSMALI_APK_DIR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ev(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eW());
			Lang.OPEN_SMALI_APK_DIR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ew(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eX());
			Lang.DEC_APK_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ex(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eY());
			Lang.DEC_JAR_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ey(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.eZ());
			Lang.DEC_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ez(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FA());
			Lang.DEC_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fa(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FB());
			Lang.COM_APK_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fb(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FC());
			Lang.COM_JAR_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fc(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FD());
			Lang.COM_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fd(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FE());
			Lang.COM_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fe(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FF());
			Lang.KEY_NOT_SEL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ff(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FG());
			Lang.SIGN_APK_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fg(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FH());
			Lang.SIGN_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fh(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FI());
			Lang.SIGN_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fi(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FJ());
			Lang.INS_APK_FILE_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fj(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FK());
			Lang.INS_APK_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fk(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FL());
			Lang.INS_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fl(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FM());
			Lang.INS_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fm(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FN());
			Lang.CANT_ZIPALIGN_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fn(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FO());
			Lang.ZIPALIGN_APK_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fo(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FP());
			Lang.ZIPALIGN_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fp(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FQ());
			Lang.ZIPALIGN_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fq(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FR());
			Lang.VERI_APK_FILE_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fr(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FS());
			Lang.ZIPALIGN_OUTPUT_DIS_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fs(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FT());
			Lang.VERI_APK_FILE_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ft(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FU());
			Lang.VERI_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fu(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FV());
			Lang.VERI_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fv(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FW());
			Lang.FW_APK_FILE_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fw(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FX());
			Lang.FW_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fx(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FY());
			Lang.FW_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fy(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.FZ());
			Lang.FW_CLR_APK_FILE_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Fz(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fA());
			Lang.FW_CLR_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fa(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fB());
			Lang.FW_CLR_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fb(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fC());
			Lang.EXT_APK_FILE_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fc(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fD());
			Lang.EXT_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fd(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fE());
			Lang.EXT_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fe(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fF());
			Lang.ZIP_APK_FILE_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ff(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fG());
			Lang.ZIP_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fg(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fH());
			Lang.ZIP_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fh(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fI());
			Lang.BAKSMALI_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fi(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fJ());
			Lang.BAKSMALI_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fj(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fK());
			Lang.BAKSMALI_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fk(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fL());
			Lang.SMALI_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fl(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fM());
			Lang.SMALI_SUCCESS_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fm(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fN());
			Lang.SMALI_FAIL_MBOX = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fn(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fO());
			Lang.CANCELLED_LOG = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fo(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fP());
			Lang.ADB_APK_INSTALL_FAIL_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fp(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fQ());
			Lang.NO_SUCH_FILE_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fq(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fR());
			Lang.KEY_PASS_INCORRECT_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fr(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fS());
			Lang.RENAME_FILE_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fs(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fT());
			Lang.STRING_INDEX_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ft(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fU());
			Lang.XML_PARSE_ERR = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fu(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fV());
			Lang.RESOURCE_MISSING_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fv(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fW());
			Lang.INSTANCE_TITLE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fw(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fX());
			Lang.LOG_OUTPUT_BTN = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fx(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fY());
			Lang.JAVA_NOT_INSTALLED_NOTICE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fy(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fZ());
			Lang.READ_APK = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fz(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GA());
			Lang.DONE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ga(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GB());
			Lang.ERROR_READ_APK = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gb(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GC());
			Lang.CHK_FOR_UPDATE = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gc(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GD());
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		public static void LoadStrForm()
		{
			Lang.A.label11.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gd(), Lang.A.label11.Text);
			Lang.A.K.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fx(), Lang.A.K.Text);
			Lang.A.E.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GE(), Lang.A.E.Text);
			Lang.A.A.SetToolTip(Lang.A.E, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ge(), Lang.A.A.GetToolTip(Lang.A.E)));
			Lang.A.tMain.TabPages[0].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GF(), Lang.A.tMain.TabPages[0].Text);
			Lang.A.c.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gf(), Lang.A.c.Text);
			Lang.A.b.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GG(), Lang.A.b.Text);
			Lang.A.C.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gg(), Lang.A.C.Text);
			Lang.A.label95.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GH(), Lang.A.label95.Text);
			Lang.A.E.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gh(), Lang.A.E.Text);
			Lang.A.A.SetToolTip(Lang.A.k, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GI(), Lang.A.A.GetToolTip(Lang.A.k)));
			Lang.A.d.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gi());
			Lang.A.A.SetToolTip(Lang.A.K, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GI(), Lang.A.A.GetToolTip(Lang.A.K)));
			Lang.A.d.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GJ(), Lang.A.d.Text);
			Lang.A.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gj(), Lang.A.A.Text);
			Lang.A.a.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GK(), Lang.A.a.Text);
			Lang.A.B.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gk(), Lang.A.B.Text);
			Lang.A.b.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GL(), Lang.A.b.Text);
			Lang.A.D.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gl(), Lang.A.D.Text);
			Lang.A.c.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GM(), Lang.A.c.Text);
			Lang.A.C.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gm(), Lang.A.C.Text);
			Lang.A.J.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GN(), Lang.A.J.Text);
			Lang.A.k.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gn(), Lang.A.k.Text);
			Lang.A.L.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GO(), Lang.A.L.Text);
			Lang.A.l.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Go(), Lang.A.l.Text);
			Lang.A.M.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GP(), Lang.A.M.Text);
			Lang.A.C.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gp(), Lang.A.C.Text);
			Lang.A.A.SetToolTip(Lang.A.G, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GQ(), Lang.A.A.GetToolTip(Lang.A.G)));
			Lang.A.K.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gq(), Lang.A.K.Text);
			Lang.A.A.SetToolTip(Lang.A.K, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GR(), Lang.A.A.GetToolTip(Lang.A.K)));
			Lang.A.J.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gr(), Lang.A.J.Text);
			Lang.A.A.SetToolTip(Lang.A.J, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GS(), Lang.A.A.GetToolTip(Lang.A.J)));
			Lang.A.j.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gs(), Lang.A.j.Text);
			Lang.A.A.SetToolTip(Lang.A.j, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GT(), Lang.A.A.GetToolTip(Lang.A.j)));
			Lang.A.f.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gt(), Lang.A.f.Text);
			Lang.A.A.SetToolTip(Lang.A.f, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GU(), Lang.A.A.GetToolTip(Lang.A.f)));
			Lang.A.signApkCheckBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gu(), Lang.A.signApkCheckBox.Text);
			Lang.A.installApkChkBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GV(), Lang.A.installApkChkBox.Text);
			Lang.A.overApkChecked.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gv(), Lang.A.overApkChecked.Text);
			Lang.A.e.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GW(), Lang.A.e.Text);
			Lang.A.G.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gw(), Lang.A.G.Text);
			Lang.A.F.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GX(), Lang.A.F.Text);
			Lang.A.f.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gx(), Lang.A.f.Text);
			Lang.A.g.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GY(), Lang.A.g.Text);
			Lang.A.H.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gy(), Lang.A.H.Text);
			Lang.A.h.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GZ(), Lang.A.h.Text);
			Lang.A.A.SetToolTip(Lang.A.h, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gz(), Lang.A.A.GetToolTip(Lang.A.h)));
			Lang.A.A.SetToolTip(Lang.A.I, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gA(), Lang.A.A.GetToolTip(Lang.A.I)));
			Lang.A.A.SetToolTip(Lang.A.i, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ga(), Lang.A.A.GetToolTip(Lang.A.i)));
			Lang.A.F.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gB(), Lang.A.F.Text);
			Lang.A.tMain.TabPages[1].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gb(), Lang.A.tMain.TabPages[1].Text);
			Lang.A.K.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gC(), Lang.A.K.Text);
			Lang.A.i.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gc(), Lang.A.i.Text);
			Lang.A.j.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gD(), Lang.A.j.Text);
			Lang.A.l.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gd(), Lang.A.l.Text);
			Lang.A.c.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gE(), Lang.A.c.Text);
			Lang.A.k.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ge(), Lang.A.k.Text);
			Lang.A.I.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gF(), Lang.A.I.Text);
			Lang.A.J.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gf(), Lang.A.J.Text);
			Lang.A.L.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gG(), Lang.A.L.Text);
			Lang.A.i.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gg(), Lang.A.i.Text);
			Lang.A.I.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gH(), Lang.A.I.Text);
			Lang.A.N.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GJ(), Lang.A.N.Text);
			Lang.A.m.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GJ(), Lang.A.m.Text);
			Lang.A.O.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.O.Text);
			Lang.A.n.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.n.Text);
			Lang.A.tMain.TabPages[2].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.fx(), Lang.A.tMain.TabPages[2].Text);
			Lang.A.o.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gI(), Lang.A.o.Text);
			Lang.A.tMain.TabPages[3].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gi(), Lang.A.tMain.TabPages[3].Text);
			Lang.A.M.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gi(), Lang.A.M.Text);
			Lang.A.m.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gJ(), Lang.A.m.Text);
			Lang.A.n.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gj(), Lang.A.n.Text);
			Lang.A.E.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gK(), Lang.A.E.Text);
			Lang.A.O.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gk(), Lang.A.O.Text);
			Lang.A.o.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gL(), Lang.A.o.Text);
			Lang.A.N.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gl(), Lang.A.N.Text);
			Lang.A.aF.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gM(), Lang.A.aF.Text);
			Lang.A.e.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gm(), Lang.A.e.Text);
			Lang.A.g.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gN(), Lang.A.g.Text);
			Lang.A.P.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gn(), Lang.A.P.Text);
			Lang.A.p.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gO(), Lang.A.p.Text);
			Lang.A.f.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.f.Text);
			Lang.A.G.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.G.Text);
			Lang.A.tMain.TabPages[4].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.go(), Lang.A.tMain.TabPages[4].Text);
			Lang.A.A.TabPages[0].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gP(), Lang.A.A.TabPages[0].Text);
			Lang.A.aJ.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gP(), Lang.A.aJ.Text);
			Lang.A.A.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gp(), Lang.A.A.Text);
			Lang.A.a.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gQ(), Lang.A.a.Text);
			Lang.A.A.SetToolTip(Lang.A.a, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gq(), Lang.A.A.GetToolTip(Lang.A.a)));
			Lang.A.D.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gR(), Lang.A.D.Text);
			Lang.A.t.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gr(), Lang.A.t.Text);
			Lang.A.aG.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gS(), Lang.A.aG.Text);
			Lang.A.X.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gs(), Lang.A.X.Text);
			Lang.A.w.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gT(), Lang.A.w.Text);
			Lang.A.k.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gt(), Lang.A.k.Text);
			Lang.A.Q.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gU(), Lang.A.Q.Text);
			Lang.A.x.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gu(), Lang.A.x.Text);
			Lang.A.R.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gV(), Lang.A.R.Text);
			Lang.A.Q.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gd(), Lang.A.Q.Text);
			Lang.A.A.SetToolTip(Lang.A.A, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gv(), Lang.A.A.GetToolTip(Lang.A.A)));
			Lang.A.d.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gW(), Lang.A.d.Text);
			Lang.A.p.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gw(), Lang.A.p.Text);
			Lang.A.q.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gX(), Lang.A.q.Text);
			Lang.A.m.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gx(), Lang.A.m.Text);
			Lang.A.A.SetToolTip(Lang.A.A, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gY(), Lang.A.A.GetToolTip(Lang.A.A)));
			Lang.A.t.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gy(), Lang.A.t.Text);
			Lang.A.S.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gZ(), Lang.A.S.Text);
			Lang.A.s.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gz(), Lang.A.s.Text);
			Lang.A.r.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HA(), Lang.A.r.Text);
			Lang.A.T.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ha(), Lang.A.T.Text);
			Lang.A.q.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HB(), Lang.A.q.Text);
			Lang.A.V.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.V.Text);
			Lang.A.u.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.u.Text);
			Lang.A.U.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.U.Text);
			Lang.A.v.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.v.Text);
			Lang.A.u.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hb(), Lang.A.u.Text);
			Lang.A.R.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HC(), Lang.A.R.Text);
			Lang.A.U.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hc(), Lang.A.U.Text);
			Lang.A.v.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gj(), Lang.A.v.Text);
			Lang.A.H.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HD(), Lang.A.H.Text);
			Lang.A.A.SetToolTip(Lang.A.H, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hd(), Lang.A.A.GetToolTip(Lang.A.H)));
			Lang.A.I.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HE(), Lang.A.I.Text);
			Lang.A.A.SetToolTip(Lang.A.I, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.He(), Lang.A.A.GetToolTip(Lang.A.I)));
			Lang.A.h.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HF(), Lang.A.h.Text);
			Lang.A.A.SetToolTip(Lang.A.h, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hf(), Lang.A.A.GetToolTip(Lang.A.h)));
			Lang.A.e.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HG(), Lang.A.e.Text);
			Lang.A.G.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hg());
			Lang.A.A.SetToolTip(Lang.A.G, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HH(), Lang.A.A.GetToolTip(Lang.A.G)));
			Lang.A.g.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hh(), Lang.A.g.Text);
			Lang.A.A.SetToolTip(Lang.A.g, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HI(), Lang.A.A.GetToolTip(Lang.A.g)));
			Lang.A.K.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gq(), Lang.A.K.Text);
			Lang.A.A.SetToolTip(Lang.A.K, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GR(), Lang.A.A.GetToolTip(Lang.A.K)));
			Lang.A.e.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HG(), Lang.A.e.Text);
			Lang.A.L.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hi(), Lang.A.L.Text);
			Lang.A.V.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GK(), Lang.A.V.Text);
			Lang.A.i.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HJ(), Lang.A.i.Text);
			Lang.A.A.SetToolTip(Lang.A.i, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hj(), Lang.A.A.GetToolTip(Lang.A.i)));
			Lang.A.j.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gs(), Lang.A.j.Text);
			Lang.A.A.SetToolTip(Lang.A.j, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GT(), Lang.A.A.GetToolTip(Lang.A.j)));
			Lang.A.F.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HK(), Lang.A.F.Text);
			Lang.A.J.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gr(), Lang.A.J.Text);
			Lang.A.A.SetToolTip(Lang.A.J, Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.GS(), Lang.A.A.GetToolTip(Lang.A.J)));
			Lang.A.f.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hk(), Lang.A.f.Text);
			Lang.A.l.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HL(), Lang.A.l.Text);
			Lang.A.W.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.W.Text);
			Lang.A.aj.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hl(), Lang.A.aj.Text);
			Lang.A.A.TabPages[2].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hl(), Lang.A.A.TabPages[2].Text);
			Lang.A.signApkCheckBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Gu(), Lang.A.signApkCheckBox.Text);
			Lang.A.installApkChkBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HM(), Lang.A.installApkChkBox.Text);
			Lang.A.overApkChecked.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hm(), Lang.A.overApkChecked.Text);
			Lang.A.b.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HN(), Lang.A.b.Text);
			Lang.A.w.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hn(), Lang.A.w.Text);
			Lang.A.B.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HO(), Lang.A.B.Text);
			Lang.A.X.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ho(), Lang.A.X.Text);
			Lang.A.y.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HP(), Lang.A.y.Text);
			Lang.A.Y.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hp(), Lang.A.Y.Text);
			Lang.A.r.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.r.Text);
			Lang.A.s.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.s.Text);
			Lang.A.S.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.gh(), Lang.A.S.Text);
			Lang.A.aH.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HQ(), Lang.A.aH.Text);
			string item = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hq(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HR());
			string item2 = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hr(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HS());
			string item3 = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hs(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HT());
			string item4 = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Ht(), 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HU());
			int selectedIndex = Lang.A.c.SelectedIndex;
			Lang.A.c.Items.Clear();
			Lang.A.c.Items.Add(item);
			Lang.A.c.Items.Add(item3);
			Lang.A.c.Items.Add(item2);
			Lang.A.c.SelectedIndex = selectedIndex;
			int selectedIndex2 = Lang.A.b.SelectedIndex;
			Lang.A.b.Items.Clear();
			Lang.A.b.Items.Add(item);
			Lang.A.b.Items.Add(item3);
			Lang.A.b.Items.Add(item2);
			Lang.A.b.SelectedIndex = selectedIndex2;
			int selectedIndex3 = Lang.A.C.SelectedIndex;
			Lang.A.C.Items.Clear();
			Lang.A.C.Items.Add(item);
			Lang.A.C.Items.Add(item3);
			Lang.A.C.Items.Add(item2);
			Lang.A.C.Items.Add(item4);
			Lang.A.C.SelectedIndex = selectedIndex3;
			Lang.A.ai.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hu(), Lang.A.ai.Text);
			Lang.A.aI.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HV(), Lang.A.aI.Text);
			Lang.A.ah.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hv(), Lang.A.ah.Text);
			Lang.A.zipPcheckBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HW(), Lang.A.zipPcheckBox.Text);
			Lang.A.zipVcheckBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hw(), Lang.A.zipVcheckBox.Text);
			Lang.A.zipAfterSignChkBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HX(), Lang.A.zipAfterSignChkBox.Text);
			Lang.A.zipFcheckBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hx(), Lang.A.zipFcheckBox.Text);
			Lang.A.zipZcheckBox.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HY(), Lang.A.zipZcheckBox.Text);
			Lang.A.tMain.TabPages[5].Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hy(), Lang.A.tMain.TabPages[5].Text);
			Lang.A.aB.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hy(), Lang.A.aB.Text);
			Lang.A.ae.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.HZ(), Lang.A.ae.Text);
			Lang.A.aE.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.Hz(), Lang.A.aE.Text);
			Lang.A.ad.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hA(), Lang.A.ad.Text);
			Lang.A.a.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.ha(), Lang.A.a.Text);
			Lang.A.ab.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hB(), Lang.A.ab.Text);
			Lang.A.aC.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hb(), Lang.A.aC.Text);
			Lang.A.aD.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hC(), Lang.A.aD.Text);
			Lang.A.ac.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hc(), Lang.A.ac.Text);
			Lang.A.ag.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hD(), Lang.A.ag.Text);
			Lang.A.af.Text = Lang.Localize(68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.hd(), Lang.A.af.Text);
		}

		// Token: 0x0400016E RID: 366
		private static AMF A;

		// Token: 0x0400016F RID: 367
		public static string WIN_TITLE = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@do();

		// Token: 0x04000170 RID: 368
		public static string APKTOOL_NOT_SEL_MBOX;

		// Token: 0x04000171 RID: 369
		public static string APK_NOT_SEL_MBOX;

		// Token: 0x04000172 RID: 370
		public static string SEL_FILES_DIAG;

		// Token: 0x04000173 RID: 371
		public static string INVALID_NOTICE;

		// Token: 0x04000174 RID: 372
		public static string PAK_ID_COPY_NOTICE;

		// Token: 0x04000175 RID: 373
		public static string LAUNCH_COPY_NOTICE;

		// Token: 0x04000176 RID: 374
		public static string SEL_DEC_DIAG;

		// Token: 0x04000177 RID: 375
		public static string NOT_A_DEC_2_NOTICE;

		// Token: 0x04000178 RID: 376
		public static string APK_DEC_NOT_SET_MBOX;

		// Token: 0x04000179 RID: 377
		public static string PLZ_NAME_DEC_MBOX;

		// Token: 0x0400017A RID: 378
		public static string DEC_AGAIN_MBOX;

		// Token: 0x0400017B RID: 379
		public static string APK_DEX_NOT_SEL_MBOX;

		// Token: 0x0400017C RID: 380
		public static string ENTER_NAME_COM_MBOX;

		// Token: 0x0400017D RID: 381
		public static string DEC_APK_FIRST_MBOX;

		// Token: 0x0400017E RID: 382
		public static string COM_APK_FIRST_MBOX;

		// Token: 0x0400017F RID: 383
		public static string ADB_BUSY_MBOX;

		// Token: 0x04000180 RID: 384
		public static string ZIPALIGN_FIRST_MBOX;

		// Token: 0x04000181 RID: 385
		public static string EXT_APK_FIRST_MBOX;

		// Token: 0x04000182 RID: 386
		public static string CANCEL_MBOX;

		// Token: 0x04000183 RID: 387
		public static string CANCEL_ESC;

		// Token: 0x04000184 RID: 388
		public static string SEL_DEX_ODEX_DIAG;

		// Token: 0x04000185 RID: 389
		public static string SEL_DIS_DIR_DIAG;

		// Token: 0x04000186 RID: 390
		public static string DEX_NOT_SEL_MBOX;

		// Token: 0x04000187 RID: 391
		public static string DIR_NOT_SET_MBOX;

		// Token: 0x04000188 RID: 392
		public static string PLZ_ENTER_DIS_NAME_MBOX;

		// Token: 0x04000189 RID: 393
		public static string SEL_DIS_FOLDER_DIAG;

		// Token: 0x0400018A RID: 394
		public static string SEL_SMA_DIR_DIAG;

		// Token: 0x0400018B RID: 395
		public static string PLZ_ENTER_SMA_NAME_MBOX;

		// Token: 0x0400018C RID: 396
		public static string CLEAR_LOGS_MBOX;

		// Token: 0x0400018D RID: 397
		public static string CLEAR_LOGS_MBOX_ERR;

		// Token: 0x0400018E RID: 398
		public static string LOG_DIR_MBOX_ERR;

		// Token: 0x0400018F RID: 399
		public static string PLEASE_READ_FAQ;

		// Token: 0x04000190 RID: 400
		public static string AND_FW_PACK_LBL;

		// Token: 0x04000191 RID: 401
		public static string SEL_FW_DIAG;

		// Token: 0x04000192 RID: 402
		public static string FW_NOT_SEL_MBOX;

		// Token: 0x04000193 RID: 403
		public static string SEL_FW_FOLDER_DIAG;

		// Token: 0x04000194 RID: 404
		public static string SEL_FW_STORED_DIAG;

		// Token: 0x04000195 RID: 405
		public static string SEL_DEC_DIR_DIAG;

		// Token: 0x04000196 RID: 406
		public static string SEL_COM_DIR_DIAG;

		// Token: 0x04000197 RID: 407
		public static string SEL_EXT_DIR_DIAG;

		// Token: 0x04000198 RID: 408
		public static string SEL_ZIP_DIR_DIAG;

		// Token: 0x04000199 RID: 409
		public static string SEL_PK8_FILE_DIAG;

		// Token: 0x0400019A RID: 410
		public static string SEL_PEM_FILE_DIAG;

		// Token: 0x0400019B RID: 411
		public static string SEL_AAPT_FILE_DIAG;

		// Token: 0x0400019C RID: 412
		public static string SEL_KEY_FILE_DIAG;

		// Token: 0x0400019D RID: 413
		public static string SEL_ALL_DIR_DIAG;

		// Token: 0x0400019E RID: 414
		public static string HIS_CLEAR_MBOX;

		// Token: 0x0400019F RID: 415
		public static string RES_DIAG;

		// Token: 0x040001A0 RID: 416
		public static string SAVE_FILE_FILTER;

		// Token: 0x040001A1 RID: 417
		public static string DOWN_STAT_LBL;

		// Token: 0x040001A2 RID: 418
		public static string DOWNLOADING_LBL;

		// Token: 0x040001A3 RID: 419
		public static string DOWN_OK_LBL;

		// Token: 0x040001A4 RID: 420
		public static string OPEN_DEC_APK_DIR;

		// Token: 0x040001A5 RID: 421
		public static string OPEN_COM_APK_DIR;

		// Token: 0x040001A6 RID: 422
		public static string OPEN_EXT_APK_DIR;

		// Token: 0x040001A7 RID: 423
		public static string OPEN_ZIP_APK_DIR;

		// Token: 0x040001A8 RID: 424
		public static string OPEN_BAKSMALI_APK_DIR;

		// Token: 0x040001A9 RID: 425
		public static string OPEN_SMALI_APK_DIR;

		// Token: 0x040001AA RID: 426
		public static string DEC_APK_FILE_NOTICE;

		// Token: 0x040001AB RID: 427
		public static string DEC_JAR_FILE_NOTICE;

		// Token: 0x040001AC RID: 428
		public static string DEC_SUCCESS_MBOX;

		// Token: 0x040001AD RID: 429
		public static string DEC_FAIL_MBOX;

		// Token: 0x040001AE RID: 430
		public static string COM_APK_FILE_NOTICE;

		// Token: 0x040001AF RID: 431
		public static string COM_JAR_FILE_NOTICE;

		// Token: 0x040001B0 RID: 432
		public static string COM_SUCCESS_MBOX;

		// Token: 0x040001B1 RID: 433
		public static string COM_FAIL_MBOX;

		// Token: 0x040001B2 RID: 434
		public static string KEY_NOT_SEL_MBOX;

		// Token: 0x040001B3 RID: 435
		public static string SIGN_APK_FILE_NOTICE;

		// Token: 0x040001B4 RID: 436
		public static string SIGN_SUCCESS_MBOX;

		// Token: 0x040001B5 RID: 437
		public static string SIGN_FAIL_MBOX;

		// Token: 0x040001B6 RID: 438
		public static string INS_APK_FILE_LOG;

		// Token: 0x040001B7 RID: 439
		public static string INS_APK_FILE_NOTICE;

		// Token: 0x040001B8 RID: 440
		public static string INS_SUCCESS_MBOX;

		// Token: 0x040001B9 RID: 441
		public static string INS_FAIL_MBOX;

		// Token: 0x040001BA RID: 442
		public static string CANT_ZIPALIGN_MBOX;

		// Token: 0x040001BB RID: 443
		public static string ZIPALIGN_APK_FILE_NOTICE;

		// Token: 0x040001BC RID: 444
		public static string ZIPALIGN_SUCCESS_MBOX;

		// Token: 0x040001BD RID: 445
		public static string ZIPALIGN_FAIL_MBOX;

		// Token: 0x040001BE RID: 446
		public static string VERI_APK_FILE_LOG;

		// Token: 0x040001BF RID: 447
		public static string ZIPALIGN_OUTPUT_DIS_LOG;

		// Token: 0x040001C0 RID: 448
		public static string VERI_APK_FILE_NOTICE;

		// Token: 0x040001C1 RID: 449
		public static string VERI_SUCCESS_MBOX;

		// Token: 0x040001C2 RID: 450
		public static string VERI_FAIL_MBOX;

		// Token: 0x040001C3 RID: 451
		public static string FW_APK_FILE_LOG;

		// Token: 0x040001C4 RID: 452
		public static string FW_SUCCESS_MBOX;

		// Token: 0x040001C5 RID: 453
		public static string FW_FAIL_MBOX;

		// Token: 0x040001C6 RID: 454
		public static string FW_CLR_APK_FILE_LOG;

		// Token: 0x040001C7 RID: 455
		public static string FW_CLR_SUCCESS_MBOX;

		// Token: 0x040001C8 RID: 456
		public static string FW_CLR_FAIL_MBOX;

		// Token: 0x040001C9 RID: 457
		public static string EXT_APK_FILE_LOG;

		// Token: 0x040001CA RID: 458
		public static string EXT_SUCCESS_MBOX;

		// Token: 0x040001CB RID: 459
		public static string EXT_FAIL_MBOX;

		// Token: 0x040001CC RID: 460
		public static string ZIP_APK_FILE_LOG;

		// Token: 0x040001CD RID: 461
		public static string ZIP_SUCCESS_MBOX;

		// Token: 0x040001CE RID: 462
		public static string ZIP_FAIL_MBOX;

		// Token: 0x040001CF RID: 463
		public static string BAKSMALI_LOG;

		// Token: 0x040001D0 RID: 464
		public static string BAKSMALI_SUCCESS_MBOX;

		// Token: 0x040001D1 RID: 465
		public static string BAKSMALI_FAIL_MBOX;

		// Token: 0x040001D2 RID: 466
		public static string SMALI_LOG;

		// Token: 0x040001D3 RID: 467
		public static string SMALI_SUCCESS_MBOX;

		// Token: 0x040001D4 RID: 468
		public static string SMALI_FAIL_MBOX;

		// Token: 0x040001D5 RID: 469
		public static string CANCELLED_LOG;

		// Token: 0x040001D6 RID: 470
		public static string ADB_APK_INSTALL_FAIL_ERR;

		// Token: 0x040001D7 RID: 471
		public static string NO_SUCH_FILE_ERR;

		// Token: 0x040001D8 RID: 472
		public static string KEY_PASS_INCORRECT_ERR;

		// Token: 0x040001D9 RID: 473
		public static string RENAME_FILE_ERR;

		// Token: 0x040001DA RID: 474
		public static string STRING_INDEX_ERR;

		// Token: 0x040001DB RID: 475
		public static string XML_PARSE_ERR;

		// Token: 0x040001DC RID: 476
		public static string RESOURCE_MISSING_NOTICE;

		// Token: 0x040001DD RID: 477
		public static string INSTANCE_TITLE;

		// Token: 0x040001DE RID: 478
		public static string LOG_OUTPUT_BTN;

		// Token: 0x040001DF RID: 479
		public static string JAVA_NOT_INSTALLED_NOTICE;

		// Token: 0x040001E0 RID: 480
		public static string READ_APK;

		// Token: 0x040001E1 RID: 481
		public static string DONE;

		// Token: 0x040001E2 RID: 482
		public static string ERROR_READ_APK;

		// Token: 0x040001E3 RID: 483
		public static string CHK_FOR_UPDATE;

		// Token: 0x040001E4 RID: 484
		public static Dictionary<string, Dictionary<string, string>> _localizations = new Dictionary<string, Dictionary<string, string>>();

		// Token: 0x040001E5 RID: 485
		public static string _currentLocalization = 68C3D6DC-EBE1-4CDA-823B-2E9F977A4AA7.@do();
	}
}
