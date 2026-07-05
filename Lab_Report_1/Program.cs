using System;

namespace StudentManagementSystem
{
    class Student
    {
        // Properties
        public int StudentID { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        // Parameterized Constructor
        public Student(int studentID, string name, double marks)
        {
            StudentID = studentID;
            Name = name;
            Marks = marks;
        }

        // Method to check pass/fail
        public string CheckResult()
        {
            if (Marks >= 40)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }

        // Method to display student information
        public void DisplayStudentInfo()
        {
            Console.WriteLine("\n--- Student Information ---");
            Console.WriteLine("Student ID : " + StudentID);
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Marks      : " + Marks);
            Console.WriteLine("Result     : " + CheckResult());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int id;
            string name;
            double marks;

            // Taking input from user
            Console.Write("Enter Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Student Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());

            // Creating object using parameterized constructor
            Student student = new Student(id, name, marks);

            // Display student details
            student.DisplayStudentInfo();

            Console.ReadLine();
        }
    }
}