using System;

class Student
{
    // Properties
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

    // Method to display student details
    public void Display()
    {
        string result = (Marks >= 40) ? "Pass" : "Fail";

        Console.WriteLine("\n===== Student Information =====");
        Console.WriteLine($"Student ID: {Id}");
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Result: {result}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Marks: ");
        double marks = double.Parse(Console.ReadLine());

        // Object creation using parameterized constructor
        Student student = new Student(id, name, marks);

        student.Display();
    }
}