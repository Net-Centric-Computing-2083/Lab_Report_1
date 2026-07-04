using System;

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

    // Display Student Information
    public void Display()
    {
        Console.WriteLine("\n------ Student Details ------");
        Console.WriteLine("Student ID : " + StudentID);
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Marks      : " + Marks);

        string result = (Marks >= 40) ? "Passed" : "Failed";

        Console.WriteLine("Result     : " + result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        Student student = new Student(id, name, marks);

        student.Display();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}