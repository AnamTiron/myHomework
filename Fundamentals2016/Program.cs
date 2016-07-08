namespace Fundamentals2016
{
    using Part3;
    using Part5;
    using System;
    using MyNamespace;
    using Part2;

    // class declaration
    // The class keyword is used for declaring a class.
    public class Program
    {
        // the entry point for all C# programs. The Main method states what the class does when executed.
        static void Main(string[] args)
        {
            
            #region part1 - Very short presentation, Hello World, class structure

            Console.WriteLine("Part 1: \n");

            // my first program in C# 

            // WriteLine is a method of the Console class defined in the System namespace. This statement causes the message "Hello, World!" to be displayed on the screen.
            Console.WriteLine("Hello World ");

            // This makes the program wait for a key press and it prevents the screen from running and closing quickly when the program is launched from Visual Studio.
            Console.ReadKey();

            #endregion


            #region part2 - class, namespace, dynamic type, static methodes, convertions, constant, readonly, struct, generics, enums

            Console.WriteLine("\n\n\nPart 2: \n");


            #region simple class example

            // initialization methods:
            // 1:
            var rectangle1 = new Rectangle
            {
                Length = 10,
                Width = 6
            };

            // 2:
            var rectangle2 = new Rectangle(12, 8);

            // 3:
            var rectangle3 = new Rectangle();
            rectangle3.InitializeWithCustomValues();

            // 4:
            var rectangle4 = new Rectangle();
            rectangle4.InitializeWithSpecificValues(20, 15);

            // call methods:
            Console.WriteLine(rectangle1.GetArea());
            rectangle1.Display();
            Console.WriteLine(rectangle1.ToString());
            Console.ReadKey();

            Console.WriteLine(rectangle2.ToString());
            Console.ReadKey();

            Console.WriteLine(rectangle3.ToString());
            Console.ReadKey();

            Console.WriteLine(rectangle4.ToString());
            Console.ReadKey();

            // to do: GetPerimeter();

            #endregion


            #region namespace example

            Test3.MyMethode();

            #endregion


            #region satatic class, static methods, dynamic type example

            // dinamyc type: (with static class, static methode)
            Console.WriteLine();
            DynamicTypes.DynamicTypesExample();

            #endregion


            #region var, boxing and unboxing, conversion

            var val = 1;
            object obj = val; // boxing;
            int i = (int)obj; // unboxing;

            // cast double to int.
            double nr1 = 5673.74;
            int nr2 = (int) nr1;
            Console.WriteLine("nr = {0}, type = {1}", nr1, nr1.GetType());
            Console.WriteLine("nr = {0}, type = {1}", nr2, nr2.GetType());
            Console.ReadKey();

            #endregion


            #region const, readonly

            // working with constants:
            Console.WriteLine("\n");
            Console.WriteLine("Enter Radius: ");
            try
            {
                var radius = Convert.ToDouble(Console.ReadLine());
                var circle = new CircleExampleWithConstants(radius);
                circle.DisplayArea();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            #endregion

            // struct
            // generic types
            // enums
            // extension methods

            // to do: extension method pe int, ridicare la patrat

            #endregion


            #region part3 - inheritance, interface, IComparable, generic  methods, overloading, polymorphism


            #endregion


            #region part4 - using, read from file, write in file, exceptions, custom exception, threads, async await

            var file = new WorkWithFileExample("E:\\ZTH\\TextFile.txt");
            file.ReadContent();
            file.WriteContent();

            // custom exception:
            Console.WriteLine("\n");
            Console.WriteLine("Enter a number: ");


            var number = Convert.ToDouble(Console.ReadLine());
            if (number < 0)
            {
                //throw new NegativeNumberException();
                throw new NegativeNumberException("Negative number is not allowed!");
            }
            Console.ReadKey();

            // events:

            // threads, async, await:

            #endregion
        }
    }
}
