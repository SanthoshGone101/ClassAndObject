using Santhosh;

namespace Akhila

{
    public class DerivedAssembly : Assembly1baseclass
    {

        public void OtherTestAssembly()
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

    public class OtherClass
    {
        Assembly1baseclass  derivedAssembly = new Assembly1baseclass();

        public void OtherAssemblyTest()
        {
            Console.WriteLine(derivedAssembly.privateVariable);

            Console.WriteLine(derivedAssembly.protectedVariable);
            Console.WriteLine(derivedAssembly.InternalVariable);
            Console.WriteLine(derivedAssembly.protectedInternalVariable);
            Console.WriteLine(derivedAssembly.publicVariable);
        }
    }
}

