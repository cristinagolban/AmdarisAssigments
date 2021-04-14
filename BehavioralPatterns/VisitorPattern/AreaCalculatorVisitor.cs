using System;

namespace VisitorPattern
{
    public class AreaCalculatorVisitor : AbstractPublisher, IVisitor
    {
        public void Visit(Shape shape)
        {
            
            if (shape is Square)
            {
                Square square = (Square)shape;
                var area= (float)square.Length * square.Length;

                this.Publish(Tuple.Create(shape, area));
            }
            else if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                var area = (float)(circle.Radius * circle.Radius * Math.PI);

                this.Publish(Tuple.Create(shape, area));

            }
            else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                var area = (float)(rectangle.Length * rectangle.Width);

                this.Publish(Tuple.Create(shape, area));

            }
            

        }
    }
}
