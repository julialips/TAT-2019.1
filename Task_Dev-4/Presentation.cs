namespace Task_Dev_4
{
    /// <summary>
    /// class contains URI and format of presentation
    /// </summary>
   class Presentation
   {
        public string URI { get; set; }
        public enum Format 
        {
            Unknown,
            PPT,
            PDF
        }
    }
}
