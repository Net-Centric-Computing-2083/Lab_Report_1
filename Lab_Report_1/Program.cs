namespace StudentManagementSystem
{
    class studentResult
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public float Marks { get; set; }

        public studentResult(int id, string name, float marks)
        {
            Id = id;
            StudentName = name;
            Marks = marks;
        }

        public void DisplayStudentInfo()
        {
            string grade;
            if (Marks < 40)
                grade = "Fail";
            else
                grade = "Pass";

            Console.WriteLine("---====*****Student Information*****====---");
            Console.WriteLine($"ID:    {Id}");
            Console.WriteLine($"Name:  {StudentName}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Grade: {grade}");
        }
    }

    public class StudentProgram
    {
        static void Main()
        {
            int id;
            string name;
            float marks;

            Console.WriteLine("Welcome to the Student Management System");
            Console.WriteLine("This program allows you to enter student information and display it.");
            Console.WriteLine("Enter the student information:");
            Console.WriteLine("Student ID:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Student Marks:");
            marks= float.Parse(Console.ReadLine());

            studentResult s = new studentResult(id, name, marks);
            s.DisplayStudentInfo();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}