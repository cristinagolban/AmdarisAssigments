using System;

namespace VisitorPattern
{
    public class PaperDrawerVisitor : IVisitor
    {
        private int capacity = 30;

        public PaperDrawerVisitor(int capacity)
        {
            this.capacity = capacity;
        }

        public void Visit(Shape shape)
        {

            string result = shape switch
            {
                Square s => s switch
                {
                    _ when capacity - s.Length < 0 =>  throw new InvalidOperationException($"Current capacity {capacity} but tried to draw square of length {s.Length}") ,
                     _ => $"Drawing square with length {s.Length} on paper"

                },

                Circle c => c switch
                {
                    _ when capacity - 2*c.Radius < 0 => throw new InvalidOperationException($"Current capacity {capacity} but tried to draw circle of diameter {c.Radius}"),
                    _ => $"Drawing cirlce with length {c.Radius} on paper"

                },

                Rectangle r => r switch
                {
                    _ when capacity - r.Length < 0 => throw new InvalidOperationException($"Current capacity {capacity} but tried to draw circle of diameter {r.Length}"),
                    _ => $"Drawing rectangle with length {r.Length} on paper"

                },

                _ => "Unknow shape"
            };

            Console.WriteLine(result);

            float res = shape switch
            {
                Square s => capacity -= s.Length,

                Circle c => capacity -= 2 * c.Radius,

                Rectangle r => capacity -= r.Length,

                _ => 0
            };
          


           
        }

        private static void ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Max capacity reached");
            Console.ResetColor();
        }

      
    }
}
