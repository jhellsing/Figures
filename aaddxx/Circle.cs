using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaddxx
{
    public class Circle : Shape
    {
        private int xCenter;
        private int yCenter;
        public Circle(int xCenter, int yCenter, string color) : base(color)
        {
            this.xCenter = xCenter;
            this.yCenter = yCenter;

        }
        public override void draw()
        {
            Console.WriteLine($"рисую круг с центром в точках ({ xCenter}; { yCenter}) {color} цвета");
        }

        public override bool Equals(Shape shape)
        {
            if (this.GetType() == shape.GetType())
            {
                Circle circle = shape as Circle;
                if (this.color == shape.color && this.xCenter == circle.xCenter &&
                    this.yCenter == circle.yCenter)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
