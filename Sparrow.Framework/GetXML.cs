using Sparrow.Framework.Interfaces;
using System.Xml;

namespace Sparrow.Framework
{
    public class GetXML : IGetXML
    {
        private XmlDocument doc;
        private XmlNodeList item;

        public XmlDocument document
        {
            get { return doc; }

            set { doc = value; }
        }

        public XmlNodeList elementList
        {
            get { return item; }

            set { item = value; }
        }

        public IGetXML Load(string xmlFile)
        {
            doc = new XmlDocument();
            doc.Load(xmlFile);
            return this;
        }

        public string GetValue(string tagName, string key)
        {
            string retorno = string.Empty;

            elementList = doc.GetElementsByTagName(tagName);

            for (int i = 0; i < elementList.Count; i++)
            {
                for (int x = 0; x < elementList[i].Attributes.Count; x++)
                {
                    if (elementList[i].Attributes[x].Value == key)
                    {
                        var valorRetorno = elementList[i].Attributes[x + 1].Value;
                        retorno = valorRetorno;
                        break;
                    }
                }
            }

            return retorno;
        }
    }
}
