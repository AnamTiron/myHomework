namespace Fundamentals2016.Part3
{
    using Part2;
    using System;
    
    internal class DynamicTypes
    {
        // Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object. 
        // The static modifier can be used with classes, fields, methods, properties, operators, events, and constructors, but it cannot be used with indexers, destructors, or types other than classes.
        public static void DynamicTypesExample()
        {
            dynamic d = 5;
            Console.WriteLine("d = {0}, type = {1}", d, d.GetType());
            Console.ReadKey();

            d = new Rectangle(4, 3);
            Console.WriteLine("d = {0}, type = {1}", d, d.GetType());
            Console.ReadKey();

            d = 10.4;
            Console.WriteLine("d = {0}, type = {1}", d, d.GetType());
            Console.ReadKey();
        }
    }
}
