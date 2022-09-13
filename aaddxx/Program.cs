using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaddxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Shape[] shapes = new Shape[2];
                shapes[0] = new Circle(3, 5, "зеленый");
                shapes[1] = new Rectangle(6, 7, 6, 7, "красный");

                foreach (Shape shape in shapes)
                {
                    shape.draw();
                }
                Console.ReadKey();
            }

        }
    }
    
}
