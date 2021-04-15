using System;

namespace VisitorPattern
{
    public class AreaCalculatorVisitor : AbstractPublisher, IVisitor
    {
        public void Visit(Shape shape)
        {
            float area = shape switch
            {
                Square s => (float)s.Length * s.Length,
                Circle c => (float)(c.Radius * c.Radius * Math.PI),
                Rectangle r => (float)(r.Length * r.Width),
                _ => (float)0
            };



                this.Publish(Tuple.Create(shape, area));

            
            

        }
    }
}
