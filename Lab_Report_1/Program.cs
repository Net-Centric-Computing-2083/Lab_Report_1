using System;

namespace StudentManagementSystem
{
    // Student Class
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        // Parameterized Constructor
        public Student(int id, string name, double marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
        public void DisplayStudentInfo()
        {
            string result;


            if (Marks >= 40)
            {
                result = "Passed";
            }
            else
            {
                result = "Failed";
            }

            // Display Student Information
            Console.WriteLine("\n----- Student Information -----");
            Console.WriteLine($"Student ID   : {Id}");
            Console.WriteLine($"Student Name : {Name}");
            Console.WriteLine($"Marks        : {Marks}");
            Console.WriteLine($"Result       : {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double marks;

            // User Input
            Console.Write("Enter Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Student Marks: ");
            marks = Convert.ToDouble(Console.ReadLine());

            // Create Student Object using Parameterized Constructor
            Student student = new Student(id, name, marks);

            // Display Student Information
            student.DisplayStudentInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}