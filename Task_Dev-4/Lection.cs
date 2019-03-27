using System.Collections.Generic;

namespace Task_Dev_4
{
    /// <summary>
    /// Class, that is a discipline,
    /// Maximum length of text lecture - 100000 characters, and presentation material, 
    ///including: URI-content(non-empty string), an indication of the presentation format
    /// </summary>
    class Lection : IDandDescribe
    {
        Presentation presentation;
        string textmaterials;
        public List<Seminar> ListOfSeminars { get; }
        public List<Laboratory> ListOfLaboratory { get; }

       /// <summary>
       /// Constructor of our class
       /// </summary>
        public Lection() : base()
        {
            textmaterials = WriteText(100000);
            presentation = new Presentation();
            presentation.URI = $"{WriteText(10)}.com";
            // presentation.format = new Format();
            // presentation.format = random.Next(0, 2);
            
            ListOfSeminars = new List<Seminar>();
            ListOfLaboratory = new List<Laboratory>();
           for (int i = 0; i < random.Next(1, 3); i++)
            {
                ListOfSeminars.Add(new Seminar());
            }
           for (int i = 0; i < random.Next(1, 6); i++)
            {
                ListOfLaboratory.Add(new Laboratory());
            }
        }

        public enum Format
        {
            Unknown,
            PPT,
            PDF
        }
        /// <summary>
        /// Override method
        /// </summary>
        /// <returns> discription of class lection </returns>
        public override string ToString()
        {
            return "It's a lecture!";
        }

      
    }
}
