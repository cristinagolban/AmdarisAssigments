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


            var (shape, area) = item;

            if (area <= 0)
            {
                Console.WriteLine("Imposible area");
            }


            string result = shape switch
            {
                Square s => s switch
                {
                    _ when s.Length > 20.0f => $"Area of square with length {s.Length} is too big",
                    _ => "Seemns right"
                },

                Circle c => c switch
                {
                    _ when c.Radius > 30.0f => $"Area of cirucs with length {c.Radius} is too big",
                    _ => "Seemns right"

                },

                _ => "Seemns right"


            };

        Console.WriteLine(result);

        }
    }
}
