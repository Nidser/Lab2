using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    class Line : Shape
    {

        public int xPoint1 { get; set; }
        public int yPoint1 { get; set; }
        public int xPoint2 { get; set; }
        public int yPoint2 { get; set; }
        public Line(int x, int y, int x1, int y1, string colour)
            : base(colour)
        {
            xPoint1 = x;
            yPoint1 = x1;
            xPoint2 = y;
            yPoint2 = y1;

        }
        public Line()
            : this(0, 0, 0, 0, "")
        {
        }

        public override String ToString()
        {
            return base.ToString() + " the coordinates of the line are \t("
            + xPoint1 + " " + yPoint1 + ") and  \t(" + xPoint2 + " " + yPoint2 + ")";
        }

        public override void Translate(Vertex v1)
        {
            //4.	Override the Translate() method to translate the line in 2D space.
            xPoint1 -= v1.X;
            yPoint1 -= v1.Y;
            xPoint2 -= v1.X;
            yPoint2 -= v1.Y;

        }



    }
}
