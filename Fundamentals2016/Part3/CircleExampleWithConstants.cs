namespace Fundamentals2016.Part3
{
    using System;

    public class CircleExampleWithConstants
    {
        // constant declaration 
        private const double pi = 3.14159;
        private readonly double pi2;
        double r;

        public CircleExampleWithConstants()
        {
            //this.pi = 3.14159;
            pi2 = 3.14159;
        }

        public CircleExampleWithConstants(double r)
        {
            this.r = r;
            //this.pi = 3.14159;
            pi2 = 3.14159;
        }

        public CircleExampleWithConstants(double r, double pi)
        {
            this.r = r;
            //this.pi = pi;
            pi2 = pi;
        }

        public void DisplayArea()
        {
            Console.WriteLine();
            var areaCircle = pi * Math.Pow(r, 2);
            var areaCircle2 = pi2 * Math.Pow(r, 2);
            Console.WriteLine("Radius: {0}, Area: {1}, Area: {2}", r, areaCircle, areaCircle2);
            Console.ReadLine();
        }
    }
}
