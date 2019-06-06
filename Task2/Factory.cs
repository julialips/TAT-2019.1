using System;
using valuta;

namespace valuta
{
    class Factory
    {
        XMLCreator XML = new XMLCreator();
        JSONCreator JSON = new JSONCreator();

        public IWriter GetCreator(string filename)
        {
            if (filename.Contains(".xml"))
            {
                // IWebDriver webDriver = new ChromeDriver();
                return new XMLCreator();
               // XML.Write();
            }
            else if (filename.Contains(".json"))
            {
                return new JSONCreator();
                // JSON.Write();
            }
            else
            {
                Console.WriteLine("Enter type of file(.xml or .json)");
                return null;
            }
        }
    }
}
