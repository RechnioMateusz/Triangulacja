using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangulation.Loop;
using SFML.Graphics;

namespace Triangulation
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeLoop loop = new InitializeLoop(500, 500, "Triangulation", Color.Black);
            loop.RUN();
        }
    }
}