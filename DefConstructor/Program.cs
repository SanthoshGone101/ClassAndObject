
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string College { get; set; }

    // default constructor
        public Student()
        {
            College = "Geethanjali";
        }
    // Paramaterized constructor
    public Student(int studentId, string name, string college)
    {
        StudentId = studentId;
        Name = name;
        College = college;
    }

    public Student(int StudentId, string Name)
    {
        this.StudentId = StudentId;
        this.Name= Name;
    }
}

    public class Program
    {
        public static void Main(string[] args)
        {
            Student st = new Student(1,"Santhosh");

            Console.WriteLine("StudentID:{0}, Name:{1}, College:{2}", st.StudentId, st.Name, st.College);
           Console.ReadKey();
        }
    }

