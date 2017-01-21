namespace Assignment_5
{
    class UProgram
    {
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }

        internal Degree Degrees
        {
            get
            {
                return degrees;
            }

            set
            {
                degrees = value;
            }
        }

        private Degree degrees;
    }
}