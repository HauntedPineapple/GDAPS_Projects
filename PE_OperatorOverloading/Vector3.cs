using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_OperatorOverloading
{
    class Vector3
    {
        private double x;
        private double y;
        private double z;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }
        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public static Vector3 operator *(Vector3 vector, double scale)
        {
            return new Vector3(vector.X * scale, vector.Y * scale, vector.Z * scale);
        }
        public static Vector3 operator /(Vector3 vector, double scale)
        {
            return new Vector3(vector.X / scale, vector.Y / scale, vector.Z / scale);
        }
        public static explicit operator Vector2(Vector3 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }
    }
}
