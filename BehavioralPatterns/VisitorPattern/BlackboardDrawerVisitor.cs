using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
        public void Visit(Shape shape)
        {
            if (shape is Square)
            {
                Square square = (Square)shape;

                Console.WriteLine($"Drawing square with length {square.Length} on blackboard");
            }
            else if (shape is Circle)
            {
                Circle circle = (Circle)shape;

                Console.WriteLine($"Drawing circle with radius {circle.Radius} on blackboard");
            }
            else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;

                Console.WriteLine($"Drawing rectangle with radius {rectangle.Length} on blackboard");
            }
        }
    }
}
