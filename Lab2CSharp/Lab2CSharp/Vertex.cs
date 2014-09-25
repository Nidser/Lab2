using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    class Vertex
    {

        private int x;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if(X > 0)
                {
                    x = X;
                }
                else
                {
                    throw new ArgumentException("value must be a positive number");
                }
                
            }
        }
        private int y;

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (Y > 0)
                {
                    y = Y;
                }
                else
                {
                    throw new ArgumentException("value must be a positive number");
                }
            }
        }


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
