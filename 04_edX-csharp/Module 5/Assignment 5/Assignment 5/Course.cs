namespace Assignment_5
{
    class Course
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationWeeks { get; set; }

        internal Student[] Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }

        internal Teacher[] Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        private Teacher[] teachers = new Teacher[3];
        private Student[] students = new Student[3];

    }
}