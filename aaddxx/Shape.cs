using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaddxx
{
    public abstract class Shape
    {
        public string color;
        public Shape(string color)
        {
            this.color = color;
        }
        public abstract void draw();

        public abstract bool Equals(Shape shape);
    }
}
