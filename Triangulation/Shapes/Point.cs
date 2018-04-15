﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulation.Shapes
{
    class Point
    {
        public float x, y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector ConvertToVector()
        {
            return new Vector(this.x, this.y, new Point(0, 0));
        }
    }
}