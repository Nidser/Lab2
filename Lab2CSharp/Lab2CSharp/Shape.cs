using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{

    abstract class Shape 
    {

        public enum Colour { Red, Green, Blue}
        public String Col { get; set; }
        public Shape(String Colour)
        {
            this.Col = Colour;
        }

        public Shape()
            : this("")
        { }

        public override String ToString()
        {
            return "\nThe colour of the shape is " + this.Col;
        }

        //one to allow a shape to be translated in 2D space (Translate(..)). 
        //The amount to be translated should be passed as a parameter to the translate method 
        //(as a reference to a Vertex object i.e. the amount the object is to be translated with respect to the X and Y axes). 

        abstract public void Translate(Vertex v1);
       
    }
}
