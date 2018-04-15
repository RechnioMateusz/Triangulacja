using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using Triangulation.Shapes;
using Triangulation.Display;

namespace Triangulation.Loop
{
    class InitializeLoop : MainLoop
    {
        ShapesDrawer shape_drawer = new ShapesDrawer();
        Body body;
        
        Vector v = new Vector(new Point(250, 250), new Point(500, 250));

        public InitializeLoop(uint width, uint height, string title, Color background_color) : base(width, height, title, background_color)
        {
        }

        protected override void Initialize()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(100, 100));
            points.Add(new Point(300, 100));
            points.Add(new Point(400, 200));
            points.Add(new Point(350, 400));
            points.Add(new Point(100, 400));
            body = new Body(points);
        }

        protected override void LoadContent()
        {
        }

        protected override void Update(double dt)
        {
        }

        protected override void Render(double leftover_time)
        {
            shape_drawer.DrawShape(body, window, Color.Cyan);
            //v.ConvertToUnitary();
            test();
        }

        protected void test()
        {
            shape_drawer.DrawVector(v, window, Color.Green);
            //for (int i = 0; i < body.edges.Count; i++)
            //{
                float vec_x = (body.edges[0].CalculateDotProduct(v) / (v.length * v.length)) * v.x;
                float vec_y = (body.edges[0].CalculateDotProduct(v) / (v.length * v.length)) * v.y;

                Vector new_vec = new Vector(vec_x, vec_y, body.edges[0].hitch_point);
                shape_drawer.DrawVector(new_vec, window, Color.Red);
            //}

            v.Rotate(0.1f);
        }
    }
}
