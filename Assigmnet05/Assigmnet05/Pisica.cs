using System;
using System.Collections.Generic;
using System.Text;

namespace Assigmnet05
{
    class Pisica: Animal
    {
        public string Name;
        public int Pui;
        public string Color1;
        public string Color2;

        public override string Sound()
        {
            return "Miau!";
        }

        public void PuiColor(string c1)
        {
            Console.WriteLine("Pui de culoarea "+c1);
        }

        public void PuiColor(string c1, string c2)
        {
            Console.WriteLine("Pui de culoarea " + c1 + "si culoarea "+ c2);
        }


    }
}
