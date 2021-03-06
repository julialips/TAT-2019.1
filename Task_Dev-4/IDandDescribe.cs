﻿using System;

namespace Task_Dev_4
{
    /// <summary>
    /// Base abstruct class, contains description and ID for discipline
    /// </summary>
   public abstract class IDandDescribe
    {
        public int GUID { get; set; }
        public string Description { get; set; }
        Random random = new Random();

        /// <summary>
        /// Constructor of our class
        /// </summary>
        public IDandDescribe()
        {
            for (int i = 0; i < 20; i++)
            {
                GUID = i;
            }
            Description = WriteText(256);
        }

        /// <summary>
        /// Method, whitch write random text 
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public string WriteText(int limit)
        {
            string text ="abcdifjklmnprstyfhswqepz";
            char sometext = text[random.Next(0, text.Length - 1)];
            Console.WriteLine(sometext);
            return sometext.ToString();
        }
        /// <summary>
        /// method to override ,and return description 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Description : {Description}";
        }

        public override bool Equals(Object obj)
        {
            if (obj is IDandDescribe)
            {
                var discipline = (IDandDescribe)obj;
                return (GUID == discipline.GUID) ? true : false;
            }
            return false;
        }
    }
}
