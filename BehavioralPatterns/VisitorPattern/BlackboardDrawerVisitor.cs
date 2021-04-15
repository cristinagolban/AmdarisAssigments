using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
        public void Visit(Shape shape)
        {

            string result = shape switch
            {
                Square s => $"Drawing square with length {s.Length} on blackboard",

                Circle c => $"Drawing circle with radius {c.Radius} on blackboard",

                Rectangle r => $"Drawing rectangle with radius {r.Length} on blackboard",

                _ => "Unknow shape"
            };

            Console.WriteLine(result);
            
            
        }
    }
}
