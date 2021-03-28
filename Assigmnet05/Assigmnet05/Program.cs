using System;

namespace Assigmnet05
{
    class Program
    {
        static void Main(string[] args)
        {
            Caine c1 = new Caine { Age= 5, Name= "Max", YearsOfAdoption=3 };
            Console.WriteLine(c1.YearsOfAdoption);
            
            Pisica p1 = new Pisica { Name = "Missi ", Pui = 3, Color1="maro",Color2="alb" };
            Pisica p2 = new Pisica { Name = "Pisi ", Pui = 2, Color1 = "alb", Color2 = "negru" };

            Console.WriteLine(c1.Age + " " + c1.Name +  " " + c1.Sound());
            Console.WriteLine(p1.Age + " " + p1.Name + " " + p1.Pui + " " + p1.Sound());
            if (p1.Pui != 0)
                p1.PuiColor(p1.Color1, p1.Color2);
            if (p2.Pui != 0)
                p2.PuiColor(p2.Color2);

        }


    }
}
