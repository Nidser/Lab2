using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1.	Implement a test class which will be used to test the above classes. 
            Shape s1 = new Circle(20, 30, 5, "Blue");
            Console.WriteLine(s1);

            Vertex v1 = new Vertex(5, 20);

            s1.Translate(v1);

            Console.WriteLine(s1);

            //2.	Create and populate a polymorphic collection of lines and circles. 
            //Call the ToString() polymorphic method for each shape in the collection. 
            //Translate each shapes by a vector amount and call ToString() again. 

            Shape s2 = new Line(20, 30, 50, 80, "Red");
            Console.WriteLine(s2);

            s2.Translate(v1);

            Console.WriteLine(s2);

            Console.ReadLine();


        }
    }
}
