using System.Runtime.Intrinsics;

namespace Packt.Shared
{
    public struct DisplacementVector
    {
        public int X;
     
        public int Y;

        // ctor to initialize the fields
        public DisplacementVector(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public static DisplacementVector operator + (
            DisplacementVector vector1,
            DisplacementVector vector2)

        {
            return new DisplacementVector(
                vector1.X + vector2.X,
                vector2.Y + vector2.Y);
        }

    }
}