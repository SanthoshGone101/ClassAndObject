public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine("Student Information");
        Console.WriteLine("StudentID: {0}, Name:{1}, Address:{2}", StudentID, Name, Address);

    }
}

class Program
{
    static void Main(string[] args)
    {
        Student st = new Student();
        st.StudentID = 1;
        st.Name = "Santhosh";
        st.Address = "Hyderabad";

        st.ShowDetails();
        Console.ReadKey();
    }
}

