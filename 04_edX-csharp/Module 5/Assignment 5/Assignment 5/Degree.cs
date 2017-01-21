namespace Assignment_5
{
    internal class Degree
    {
        public string DegreeName { get; set; }
        public int CreditsRequired { get; set; }

        public Course Course1
        {
            get { return course; }
            set { course = value; }
        }

        private Course course;
    }
}