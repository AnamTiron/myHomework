using System;

namespace Fundamentals2016.Part4
{
    public class RegularPentagon : Poligon, IPoligon, IComparable<RegularPentagon>
    {
        protected override PoligonEnum Type
        {
            get
            {
                return PoligonEnum.RegularPentagon;
            }
        }

        public RegularPentagon(double l1)
            : base(l1)
        {
        }

        public override double CalculatePerimeter()
        {
            return base.CalculatePerimeter() * 5;
        }
        
        public double CalculateArea()
        {
            const double indice = 1.72048;

            return Math.Pow(this.L1 ?? 0, 2) * indice;
        }

        public int CompareTo(RegularPentagon obj)
        {
            return this.CalculateArea() == obj.CalculateArea() &&
                this.CalculatePerimeter() == obj.CalculatePerimeter() ? 1 : 0;
        }
    }
}
