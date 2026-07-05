
/*Create a Student Management System that allows the user to enter a student's ID, Name, and Marks.
Store the information in a Student class using properties and initialize the object using a parameterized constructor.
Use appropriate variables, data types, and operators to determine whether the student has Passed or Failed, 
and display the complete student information on the console.*/
using System;

class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public Student(int id, string name, double marks)
    {
        StudentID = id;
        Name = name;
        Marks = marks;
    }
    public void Display()
    {
        string result;
        Console.WriteLine("\n-----Student Information-----");
        Console.WriteLine("ID:" + StudentID);
        Console.WriteLine("Name:" + Name);
        Console.WriteLine($"Marks: {Marks}");

        if (Marks >= 40)
        {
            result = $"{Name} has passed!";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(Name + " has failed!");
        }
    }
}
class Program
{
    static void Main()
    {
        //take user input 
        Console.WriteLine("Enter student ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter student marks:");
        double marks = double.Parse(Console.ReadLine());

        Student s1 = new Student(id, name, marks);
        s1.Display();

    }
}
