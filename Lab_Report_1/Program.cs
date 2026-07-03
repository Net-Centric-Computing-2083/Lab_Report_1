using System;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public Student(int id, string name, double marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public string GetResult()
    {
        return Marks >= 40 ? "Passed" : "Failed";
    }

    public void Display()
    {
        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("ID      : " + Id);
        Console.WriteLine("Name    : " + Name);
        Console.WriteLine("Marks   : " + Marks);
        Console.WriteLine("Result  : " + GetResult());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Student Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        Student student = new Student(id, name, marks);

        student.Display();

       
        Console.ReadKey();
    }
}