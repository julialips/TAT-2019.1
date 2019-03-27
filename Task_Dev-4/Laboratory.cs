namespace Task_Dev_4
{
    /// <summary>
    /// Class,which inherited from the abstract
    /// </summary>
    class Laboratory : IDandDescribe
    {
        /// <summary>
        /// Constructor of class
        /// </summary>
        public Laboratory() : base() { }

        /// <summary>
        /// The copy of constructor
        /// </summary>
        /// <param name="originalGUID"></param>
        /// <param name="originalDescription"></param>
        public Laboratory(int originalGUID, string originalDescription)
        {
            GUID= originalGUID;
            Description = originalDescription;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Laboratory laboratoryClone = new Laboratory(GUID, Description);
            return laboratoryClone;
        }

    }
}
