using System.Collections.Generic;

namespace valuta
{
    interface IWriter
    {
        /// <summary>
        /// Method writes list IN file.
        /// </summary>
        /// <param name="currency"></param>
        void Write(List<Currency> currency);
    }
}
