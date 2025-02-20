public class Example
{
    private static int Temp;

    //static constructor
    static Example()
    {
        Temp = 20;
    }
    //private constructor
    private Example()
    {

    }
    // public constructor
    public Example(int temp)
    {
        Temp = Temp + temp;
    }



    public static int GetTemp()
    {
        return ++Temp;
    }
}

    public class Program
    {
        public static void Main(string[] args)
        {
        Example ex = new Example(10);
           Console.WriteLine("Temp:{0}",Example.GetTemp());
            
        }
    }


