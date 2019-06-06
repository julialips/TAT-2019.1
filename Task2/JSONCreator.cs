using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using valuta;

namespace valuta
{
    class JSONCreator : IWriter
    {
        public void Write(List<Currency> currency)
        {

            using (StreamWriter file = File.CreateText(@"../../ExchangeRates.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, currency);
            }
        }
    }
}
