using System;

namespace StudentManagementSystem
{
    // Student class
    class Student
    {
        // Properties
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        // Parameterized Constructor
        public Student(int studentId, string name, double marks)
        {
            StudentId = studentId;
            Name = name;
            Marks = marks;
        }

        // Method to display student information
        public void DisplayStudent()
        {
            Console.WriteLine("\n------ Student Details ------");
            Console.WriteLine($"Student ID : {StudentId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Marks      : {Marks}");

            // Operators and Decision Making
            string result = (Marks >= 40) ? "Passed" : "Failed";

            Console.WriteLine($"Result     : {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variables and Data Types
            int id;
            string name;
            double marks;

            Console.WriteLine("===== Student Management System =====");

            // User Input
            Console.Write("Enter Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Student Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());

            // Create object using parameterized constructor
            Student student = new Student(id, name, marks);

            // Display information
            student.DisplayStudent();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}