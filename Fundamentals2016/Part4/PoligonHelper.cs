namespace Fundamentals2016.Part4
{
    // sealed: don't allow inheritance
    public sealed class PoligonHelper
    {
        // generic methods:
        public static double GetPerimeter<T>(T poligon)
            where T: Poligon
        {
            return poligon.CalculatePerimeter();
        }


        public static double GetArea(RegularPentagon t)
        {
            return t.CalculateArea();
        }
    }
}
