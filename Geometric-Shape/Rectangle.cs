using System;

namespace ATV_GeometricShape.Retangulo
{
    internal class Retangulo : GeometricShape
    {
        public float Base;
        public float Height;

        public override float Area()
        {
            return Base * Height;
        }
        public override float Perimeter()
        {
            return (2 * Base) + (2 * Height);
        }

    }
}