using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulation.Shapes
{
    class Body
    {
        public List<Vector> edges = new List<Vector>();

        public Body(List<Point> vertices)
        {
            for (int i = 0; i < vertices.Count - 1; i++)
            {
                edges.Add(new Vector(vertices.ElementAt(i), vertices.ElementAt(i + 1)));
            }

            edges.Add(new Vector(vertices.ElementAt(vertices.Count - 1), vertices.ElementAt(0)));
        }
    }
}
