using System;
using System.Collections.Generic;
using System.Windows;

namespace Mod_9_Homework
{
    public partial class MainWindow : Window
    {
        List<Student> studentsCollection = new List<Student>();
        private int indexOfStudentNow = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.City = txtCity.Text;

            studentsCollection.Add(newStudent);

            //txtFirstName.Text = ""; or txtFirstName.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();

            MessageBox.Show(String.Format("Student {0} is created", newStudent.FirstName));
            indexOfStudentNow = -1;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            indexOfStudentNow--;
            // To be a wrap around
            if (indexOfStudentNow < 0)
                indexOfStudentNow = studentsCollection.Count - 1;

            txtFirstName.Text = studentsCollection[indexOfStudentNow].FirstName;
            txtLastName.Text = studentsCollection[indexOfStudentNow].LastName;
            txtCity.Text = studentsCollection[indexOfStudentNow].City;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            indexOfStudentNow++;
            // To be a wrap around
            if (indexOfStudentNow >= studentsCollection.Count)
                indexOfStudentNow = 0;

            txtFirstName.Text = studentsCollection[indexOfStudentNow].FirstName;
            txtLastName.Text = studentsCollection[indexOfStudentNow].LastName;
            txtCity.Text = studentsCollection[indexOfStudentNow].City;


        }
    }
}
