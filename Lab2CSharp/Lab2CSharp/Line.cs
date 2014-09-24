using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    class Line : Shape
    {

        public int lx { get; set; }
        public int x1 { get; set; }
        public int ly { get; set; }
        public int y1 { get; set; }
        public Line(int x, int y, int x1, int y1, string colour)
            : base(colour)
        {
            this.lx = x;
            this.x1 = x1;
            this.ly = y;
            this.y1 = y1;

        }
        public Line()
            : this(0, 0, 0, 0, "")
        {
        }

        public override String ToString()
        {
            return base.ToString() + " the coordinates of the line is "
            + lx + " " + ly + " " + x1 + " " + y1;
        }

        public override void Translate(Vertex v1)
        {
            //4.	Override the Translate() method to translate the line in 2D space. 

        }



    }
}
