using System;
using System.Collections.Generic;
using System.Text;

namespace VerletClasses
{
    public class Vector3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3D()
        {
            X = 0.0f;
            Y = 0.0f;
            Z = 0.0f;
        }//eom

        public Vector3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return string.Format("[{0}\t{1}\t{2}]", X, Y, Z);
        }

        #region Overload Operators
        public static Vector3D operator *(Vector3D v, float s)
        {
            return new Vector3D(v.X * s, v.Y * s, v.Z * s);
        }

        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        #endregion
    }//eoc
}//eon
