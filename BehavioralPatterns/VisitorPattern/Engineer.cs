using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Engineer : ISubscriber
    {
        public void Notify(Tuple<Shape, float> item)
        {
            if(item.Item2 <=0)
            {
                Console.WriteLine("Imposible area");
                return;
            }

            var shape = item.Item1;
            if(shape is Circle)
            {
                Circle circle = (Circle)shape;
                if (circle.Radius > 30.0f)
                {
                    Console.WriteLine($"Area of circle with radius {circle.Radius} is too big");
                    return;
                }
            }
            else if (shape is Square)
            {
                Square square = (Square)shape;
                if (square.Length > 20.0f)
                {
                    Console.WriteLine($"Area of square with length {square.Length} is too big");
                    return;
                }
            }

            Console.WriteLine("Seems right");
        }
    }
}
