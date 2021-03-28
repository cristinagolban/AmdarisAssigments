using System;
using System.Collections.Generic;
using System.Text;

namespace Assigmnet05
{
    class Animal
    {

        public int Age;

        public Animal()
        {
            Age = 1;
        }

        public virtual string Sound()
        {
            return "Animalul scoate un sunet";
        }
    }
}
