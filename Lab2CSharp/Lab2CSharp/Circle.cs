using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    class Circle : Shape
    {
        public int cx { get; set; }
        public int cy { get; set; }

        public double radius { get; set; }

        public Circle(int x, int y, double r,string colour)
           : base(colour)
        {
            this.cx = x;
            this.cy = y;
            radius = r;

        }

        public Circle()
            :this(0,0,0.0, "")
        {

        }

        public override string ToString()
        {
            return base.ToString() + "\nthis circle has an x co-ord of " + cx + " and a y co-ord of "+cy+ " with a radius of " + radius
                +"\n the area of the circle is " + area();
        }

        public double area()
        {
            double area = Math.PI * radius * radius;

            return area;
        }

        public override void Translate(Vertex v1)
        {
            //Override the Translate() method to translate the Circle in 2D space. 

            cx = v1.x;
            cy = v1.y;

        }

    }
}
