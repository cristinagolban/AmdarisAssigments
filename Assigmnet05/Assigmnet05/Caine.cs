using System;
using System.Collections.Generic;
using System.Text;

namespace Assigmnet05
{
    class Caine: Animal
    {
        public string Name;
        private int YearOfAdoption;
        public int YearsOfAdoption
        { 
            get { return YearOfAdoption; } 
            set { YearOfAdoption = value; } 
        }
        public override string Sound()
        {
            return "Hau Hau";
        }

    }
}
