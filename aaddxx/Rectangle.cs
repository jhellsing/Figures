using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaddxx
{
    public class Rectangle : Shape
    {
        private int top;
        private int left;
        private int height;
        private int width;

        public Rectangle(int top, int left, int height, int width, string color) : base(color)
        {
            this.top = top;
            this.left = left;
            this.height = height;
            this.width = width;
        }
        public override void draw()
        {
            Console.WriteLine($"рисую прямоугольник со сторонами ({top},{left},{height},{width}) {color} цвета");
        }
        public override bool Equals(Shape shape)
        {
            if (this.GetType() == shape.GetType())
            {
                Rectangle rectangle = shape as Rectangle;

                if (this.color == shape.color && this.top == rectangle.top &&
                    this.left == rectangle.left && this.height == rectangle.height && this.width == rectangle.width)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
