using System;

namespace VerletClasses
{
    public class Vector2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2D()
        {
            X = 0.0f;
            Y = 0.0f;
        }//eom

        public Vector2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("[{0}\t{1}]", X, Y);
        }

        #region Overload Operators
        public static Vector2D operator *(Vector2D v, float s)
        {
            return new Vector2D(v.X * s, v.Y * s);
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X - b.X, a.Y - b.Y);
        }
        #endregion
    }//eoc
}//eon
