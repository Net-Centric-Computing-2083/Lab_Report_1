 namespace Lab1
{
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
        public string Status()
        {
            return Marks >= 40 ? "Pass" : "Fail";
        }
        public void display()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nMarks: {Marks}\nStatus: {Status()}\n");
        }


    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Enter the number of students to be inserted:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter details for Student{i}:");

                Console.Write("ID     : ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name   : ");
                string name = Console.ReadLine();

                Console.Write("Marks  : ");
                double marks = double.Parse(Console.ReadLine());

                students.Add(new Student(id, name, marks));
            }

            Console.WriteLine("\nStudent Report: ");
            foreach (var student in students)
            {
                student.display();

            }
        }
    }
}
