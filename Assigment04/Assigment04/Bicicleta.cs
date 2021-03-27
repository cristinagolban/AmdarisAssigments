using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment04
{
    public class Bicicleta
    {
        public int Roti;
        public int Age;
        public static string Culoare = "rosie";
        public static string ChangeColor()
        {
            Culoare = "verde";
            return Culoare;
        }

        public int ChangeRoti()
        {
            Roti = 3;
            return Roti;
        }
    }
}
