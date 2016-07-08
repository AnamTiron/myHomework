namespace Fundamentals2016.Part2
{
    using System;
    using System.Text;

    public class Rectangle
    {

        // private member variables
        private double length;
        private double width;

        // properties
        public double Length {
            get {
                return length;
            }
            set {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        // parameterless constructor (implicit)
        public Rectangle() { }

        // constructor with parameter
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }


        // Methods:
        public void InitializeWithCustomValues()
        {
            length = 8;
            width = 4;
        }

        public void InitializeWithSpecificValues(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        // ToString() - a based methode from based class Object
        public override string ToString()
        {
            #region withStringConcat

            //string result = "Rectangle details: ";

            //result = result + "\n\t Length: " + this.length + "\n\t Width: " + this.width + "\n\t Area:" + this.GetArea();

            #endregion


            #region withStringBuilder

            StringBuilder result = new StringBuilder();
            result.AppendLine("Rectangle details: ");
            result.AppendLine("\tLength: " + this.Length)
                .AppendLine("\tWidth: " + this.Width)
                .AppendLine("\tArea: " + this.GetArea());

            #endregion


            return result.ToString();

        }
    }
}
