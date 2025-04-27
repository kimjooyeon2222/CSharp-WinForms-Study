using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Clicker_Game
{
    internal class CXMLControl
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_5 = "LEVEL_5";
        public static string _LEVEL_50 = "LEVEL_50";

        public Dictionary<string, string> fXML_Reader(string strXMLPath)
        {
            string strRijndaelText = File.ReadAllText(strXMLPath);
            string strDECText = CRijndael.DecryptString(strRijndaelText, CRijndael._bkey);

            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            using (XmlReader rd = XmlReader.Create(new StringReader(strDECText)))
            {
                rd.MoveToContent();  // <--- 무조건 Element로 이동

                // SETTING 엘리먼트 안으로 들어감
                if (rd.IsStartElement("SETTING"))
                {
                    string strID = rd.GetAttribute("ID");
                    rd.Read(); // SETTING 안쪽으로 들어가기 (자식들 읽을 준비)

                    while (rd.Read())
                    {
                        if (rd.NodeType == XmlNodeType.Element)
                        {
                            string elementName = rd.Name;
                            string value = rd.ReadElementContentAsString();

                            if (!string.IsNullOrEmpty(elementName))
                            {
                                DXMLConfig[elementName] = value;
                            }
                        }
                    }
                }
            }

            return DXMLConfig;
        }


        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true
            };

            using (XmlWriter wr = XmlWriter.Create(sb, settings))
            {
                wr.WriteStartDocument();
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TICK, DXMLConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXMLConfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, DXMLConfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_5, DXMLConfig[_LEVEL_5]);
                wr.WriteElementString(_LEVEL_50, DXMLConfig[_LEVEL_50]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }

            string strRijndaelText = CRijndael.EncryptString(sb.ToString(), CRijndael._bkey);
            File.WriteAllText(strXMLPath, strRijndaelText);
        }
    }
}
