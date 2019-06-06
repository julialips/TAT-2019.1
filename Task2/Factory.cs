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
                return new XMLCreator();
            }
            else if (filename.Contains(".json"))
            {
                return new JSONCreator();
            }
            else
            {
                Console.WriteLine("Enter type of file('.xml' or '.json')");
                return null;
            }
        }
    }
}
