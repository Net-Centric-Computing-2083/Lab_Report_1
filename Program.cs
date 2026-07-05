using System;

class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public double Marks { get; set; }

    public Student(int id, string name, double marks)
    {
        StudentId = id;
        StudentName = name;
        Marks = marks;
    }

    public void DisplayStudentInfo()
    {
        string result = Marks >= 40 ? "Pass" : "Fail";

        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Student ID   : " + StudentId);
        Console.WriteLine("Student Name : " + StudentName);
        Console.WriteLine("Marks        : " + Marks);
        Console.WriteLine("Result       : " + result);
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

        student.DisplayStudentInfo();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}