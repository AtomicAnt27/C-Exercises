using System;

namespace ATV_GeometricShape.TriangleRectangle
{
    internal class TriangleRectangle : GeometricShape
    {
        public float Base;
        public float Height;
        private float Hypotenuse;

        public override float Area()
        {
            return (Base * Height) / 2;
        }
        public override float Perimeter()
        {
            return (Base + Height + Hypotenuse);
        }

    }
}