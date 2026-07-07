using System;
class CollegeStudent
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public double ObtainedMarks { get; set; }

    // Parameterized constructor
    public CollegeStudent(int id, string name, double marks)
    {
        StudentId = id;
        StudentName = name;
        ObtainedMarks = marks;
    }

    // Method to evaluate status using the conditional operator
    public string CheckStatus()
    {
        return (ObtainedMarks >= 40) ? "PASSED" : "FAILED";
    }

    // Method to display the custom profile view
    public void PrintProfile()
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine("       STUDENT PROFILE          ");
        Console.WriteLine("==============================");
        Console.WriteLine($"ID Code    : {StudentId}");
        Console.WriteLine($"Full Name  : {StudentName}");
        Console.WriteLine($"Marks Rec. : {ObtainedMarks:F2}");
        Console.WriteLine($"Status     : {CheckStatus()}");
        Console.WriteLine("==============================");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Portal: Student Record Entry ---");

        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks Obtained: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        // Object instantiation using parameterized constructor
        CollegeStudent currentStudent = new CollegeStudent(id, name, marks);

        // Call display method
        currentStudent.PrintProfile();

        Console.WriteLine("\nPress any key to terminate process...");
        Console.ReadKey();
    }
}
