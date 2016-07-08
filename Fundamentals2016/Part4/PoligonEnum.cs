using System.ComponentModel;

namespace Fundamentals2016.Part4
{
    public enum PoligonEnum
    {
        [Description("Triangle")]
        Triangle = 1,
        
        [Description("Rectangle")]
        Rectangle = 2,

        [Description("RegularPentagon")]
        RegularPentagon = 3
    }
}
