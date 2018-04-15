using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulation.Shapes
{
    class Vector
    {
        public float x, y, length;
        public Point hitch_point;

        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
            CalculateLength();
        }

        public Vector(Point a, Point b)
        {
            this.x = b.x - a.x;
            this.y = b.y - a.y;
            this.hitch_point = a;
            CalculateLength();
        }

        public Vector(float x, float y, Point hitch_point)
        {
            this.x = x;
            this.y = y;
            this.hitch_point = hitch_point;
            CalculateLength();
        }

        public void CalculateLength()
        {
            this.length = (float)Math.Sqrt((this.x * this.x) + (this.y * this.y));
        }

        public void ConvertToUnitary()
        {
            this.x /= this.length;
            this.y /= this.length;
            CalculateLength();
        }

        public float CalculateDotProduct(Vector v)
        {
            return this.x * v.x + this.y * v.y;
        }

        public void Rotate(float angle)
        {
            angle = angle * (float)Math.PI / 180.0f;
            float temp_x = (float)(this.x * Math.Cos(angle) - this.y * Math.Sin(angle));
            float temp_y = (float)(this.x * Math.Sin(angle) + this.y * Math.Cos(angle));
            this.x = temp_x;
            this.y = temp_y;
        }
    }
}
