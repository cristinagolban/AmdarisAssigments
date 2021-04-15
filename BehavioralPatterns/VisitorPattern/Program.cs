using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IVisitable>
            {
                new Circle(10),
                new Circle(10),
                new Rectangle(2,12),
                new Square(12),
                new Circle(33),
                new Square(0),
                new Rectangle(3,4)
            };

           // IVisitor visitor = new BlackboardDrawerVisitor();
           //IVisitor visitor = new PaperDrawerVisitor(40);

            AreaCalculatorVisitor visitor = new AreaCalculatorVisitor();

           var engineer = new Engineer();
            visitor.AddSubscriber(engineer);

            try
            {
                shapes.ForEach(shape => shape.Accept(visitor));

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
