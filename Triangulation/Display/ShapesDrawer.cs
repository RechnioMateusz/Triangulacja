using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using Triangulation.Shapes;

namespace Triangulation.Display
{
    class ShapesDrawer
    {
        public void DrawVector(Vector v, RenderWindow window, Color color)
        {
            VertexArray ver_arr = new VertexArray(PrimitiveType.Lines);

            Vertex hitch_point = new Vertex(new Vector2f(v.hitch_point.x, v.hitch_point.y));
            Vertex phrase = new Vertex(new Vector2f(v.hitch_point.x + v.x, v.hitch_point.y + v.y));

            hitch_point.Color = color;
            phrase.Color = color;

            ver_arr.Append(hitch_point);
            ver_arr.Append(phrase);

            window.Draw(ver_arr);
        }

        public void DrawShape(Body body, RenderWindow window, Color color)
        {
            for (int i = 0; i < body.edges.Count; i++)
            {
                DrawVector(body.edges.ElementAt(i), window, color);
            }
        }
    }
}
