using System;

class Student
{
    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    // Parameterized constructor
    public Student(int id, string name, double marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    // Method to determine pass/fail using an operator
    public string GetResult()
    {
        return (Marks >= 40) ? "Passed" : "Failed";
    }

    // Method to display student information
    public void DisplayInfo()
    {
        Console.WriteLine("\n--- Student Information ---");
        Console.WriteLine("ID     : " + Id);
        Console.WriteLine("Name   : " + Name);
        Console.WriteLine("Marks  : " + Marks);
        Console.WriteLine("Result : " + GetResult());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Student Management System ===");

        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        // Object created using parameterized constructor
        Student student = new Student(id, name, marks);

        student.DisplayInfo();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}