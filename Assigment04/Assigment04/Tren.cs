using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment04
{
    public class Tren
    {
        public int nr;
        public int vagon;

        //constructorul static ruleaza o singura data inainte de prima instnatiere
        static Tren()
        {
            Console.WriteLine("ctor static");

        }

        public Tren()
        {
            Console.WriteLine("ctor normal");
        }
    }
}
