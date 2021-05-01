using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_OperatorOverloading
{
    class Vector2
    {
        private double X { get; set; }
        private double Y { get; set; }
        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Vector2()
        {
            X = 0;
            Y = 0;
        }
        public override string ToString()
        {
            return "("+X+", "+Y+")";
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vector2 operator *(Vector2 vector, double scale)
        {
            return new Vector2(vector.X *scale, vector.Y*scale);
        }
        public static Vector2 operator /(Vector2 vector, double scale)
        {
            return new Vector2(vector.X / scale, vector.Y / scale);
        }
        public static implicit operator Vector3(Vector2 vector)
        {
            return new Vector3(vector.X, vector.Y, 0);
        }
    }
}
