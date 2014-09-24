using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    class Vertex
    {

        public int x { get; set; }
        public int y { get; set; }
        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //default constructor
        public Vertex()
            : this(0, 0)
        {

        }

    }
}
