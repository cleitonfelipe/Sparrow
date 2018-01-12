using System.Xml;

namespace Sparrow.Framework.Interfaces
{
    public interface IGetXML
    {
        XmlDocument document { get; set; }

        XmlNodeList elementList { get; set; }

        IGetXML Load(string xmlFile);

        string GetValue(string tagName, string key);
    }
}
