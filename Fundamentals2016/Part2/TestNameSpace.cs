//Putting it inside the namespaces makes the declarations local to that 
//    namespace for the file(in case you have multiple namespaces in the file) 
//    but if you only have one namespace per file then it doesn't 
//    make much of a difference whether they go outside or inside the namespace.

using System;
//using TNI1 = Fundamentals2016.TestNamespaceInsideUsingUsing;
//using TNI2 = Fundamentals2016.TestNamespaceInsideUsingUsing2;
using Fundamentals2016.TestNamespaceInsideUsingUsing;
using Fundamentals2016.TestNamespaceInsideUsingUsing2;

namespace Fundamentals2016.TestNamespaceInsideUsingUsing
{
    //using System;

    public class Test
    {
        public static DateTime DataNasterii { get; set; }

        public static void Print()
        {
            Console.WriteLine("Test1 class");
        }
    }
}

namespace Fundamentals2016.TestNamespaceInsideUsingUsing2
{
    //using System;

    public class Test
    {
        public DateTime DataNasterii { get; set; }

        public static void Print()
        {
            Console.WriteLine("Test2 class");
        }
    }
}

namespace MyNamespace
{
    //using System;

    public class Test3
    {
        public static void MyMethode()
        {
            //TNI1.Test.Print();
            //TNI2.Test.Print();

            Fundamentals2016.TestNamespaceInsideUsingUsing.Test.Print();
            Fundamentals2016.TestNamespaceInsideUsingUsing2.Test.Print();
            Console.ReadKey();
        }
    }
}