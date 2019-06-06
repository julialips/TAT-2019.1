using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace valuta
{
    class XMLCreator : IWriter
    {
        public void Write(List<Currency> currency)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Currency>));
            TextWriter text = new StreamWriter(@"../../Currency.xml");
            xmlSerializer.Serialize(text, currency);
            text.Close();
        }
    }
}
