
using Santhosh;

namespace Santhosh
{

    public class Assembly1baseclass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string InternalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public";

        public void testAccess()
        {
            //Accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(InternalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);


        }
    }
    public class AssemblyOther
    {
        Assembly1baseclass ObjBase = new Assembly1baseclass();

        public void otherTest()
        {
            Console.WriteLine(ObjBase.privateVariable);
            Console.WriteLine(ObjBase.protectedVariable);
            Console.WriteLine(ObjBase.InternalVariable);
            Console.WriteLine(ObjBase.protectedInternalVariable);
            Console.WriteLine(ObjBase.publicVariable);
        }
    }

    public class AssemblyDerived : Assembly1baseclass
    {
        public void testDerived()
        {
            //not Accessible
            Console.WriteLine(privateVariable);

            // Accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(InternalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            //Assembly1baseclass OB = new Assembly1baseclass();
            //OB.testAccess();

            AssemblyDerived assembly = new AssemblyDerived();
            assembly.testDerived();

            Console.ReadKey();
        }

    }
}



