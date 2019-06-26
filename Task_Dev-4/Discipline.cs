using System;
using System.Collections.Generic;

namespace Task_Dev_4
{
    /// <summary>
    /// Class, contains lection,seminars and laboratories
    /// </summary>
    class Discipline : IDandDescribe
    {
        List<Lection> lectionsList = new List<Lection>();
        List<Seminar> seminarsList = new List<Seminar>();
        List<Laboratory> laboratoriesList = new List<Laboratory>();
        Random random = new Random();

        /// <summary>
        /// method to override ToString
        /// </summary>
        /// <returns> discription </returns>
        public override string ToString()
        {
            return ("It's a discipline!");
        }

        /// <summary>
        /// Constructor of class
        /// </summary>
        public Discipline() : base()
        {
            for (int i = 0; i < random.Next(5, 20); i++)
            {
                lectionsList.Add(new Lection());
            }

            for (int i = 0; i < random.Next(3, 20); i++)
            {
                seminarsList.Add(new Seminar());
            }

            for (int i = 0; i < random.Next(2, 10); i++)
            {
                laboratoriesList.Add(new Laboratory());
            }  
        }
    }
}