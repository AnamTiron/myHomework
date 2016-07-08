namespace Fundamentals2016.Part4
{
    public abstract class Poligon 
    {
        protected Poligon() { }

        protected Poligon(double l1) 
        {
            L1 = l1;
        }

        protected abstract PoligonEnum Type { get; }
        public double? L1 { get; set; }

        public virtual double CalculatePerimeter() {
            return L1 ?? 0;
        }

        public override string ToString()
        {
            switch (Type)
            {
                case PoligonEnum.Triangle:
                    return "Triangle";
                case PoligonEnum.Rectangle:
                    return "Rectangle";
                case PoligonEnum.RegularPentagon:
                    return "RegularPentagon";
                default:
                    return "Unknown";
            }
        }
    }
}
