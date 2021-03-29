using System;
using System.Threading;

namespace Assigment04
{
    public struct Masina
    {
        public string Type;
        public int Age;
        public int km;



    }



    class Program
    {
        static void Main(string[] args)
        {
            Masina a = new Masina { Type = "Dacia", Age = 2005, km = 10000 };
            Masina a2 = new Masina { Type = "Bmw", Age = 2020, km = 200 };

            Bicicleta p = new Bicicleta { Roti = 4, Age = 2019 };
            Bicicleta p2 = new Bicicleta { Roti = 2, Age = 2009 };
            Bicicleta p3 = new Bicicleta { Roti = 4, Age = 1999 };

            Tren t = new Tren { nr = 123, vagon = 2 };
            Tren t2 = new Tren { nr = 203, vagon = 13 };


            //boxing si unboxing
            int codd = t.nr;
            object o = codd;
            int s = (int)o;

            Console.WriteLine("unboxing :" + o);


            
            //Culoare e un atribut static deci il apelez cu numele clasei
              Console.WriteLine("Masina a : "+a.Type +" "+ a.Age);
              Console.WriteLine("Bicicleta p1 :  "+ p.Roti + " " + p.Age+" "+ Bicicleta.Culoare);
              Console.WriteLine("Bicicleta p2 :  " + p2.Roti + " " + p2.Age + " " + Bicicleta.Culoare);
            // ChangeColor la fel fiind statica trebuie apelata cu numele clasei si Color are o singura copie deci se schimba
            //pt toate bicicletele
               
              Bicicleta.ChangeColor();
           
              Console.WriteLine("Bicicleta p2 :  " + p.Roti + " " + p.Age + " " + Bicicleta.Culoare);
              Console.WriteLine("Bicicleta p2 :  " + p2.Roti + " " + p2.Age + " " + Bicicleta.Culoare);
              //Se schimba doar nr de roti de la obiectul pt care apelam
              p3.ChangeRoti();
              Console.WriteLine("Bicicleta p2 :  " + p2.Roti + " " + p2.Age + " " + Bicicleta.Culoare);
              Console.WriteLine("Bicicleta p3 :  " + p3.Roti + " " + p3.Age + " " + Bicicleta.Culoare);
          

            Console.WriteLine("Masina a: " + a.Type + " " + a.Age + " " + a.km);
            Console.WriteLine("Masina a2: " + a2.Type + " " + a2.Age + " " + a2.km);

            // pentru ca masina e STRUCT Creeaza un nou obiect cu datele din a2
            ChangeKm2(a2);
            Console.WriteLine("Masina a2 dupa modificari: " + a2.Type + " " + a2.Age + " " + a2.km);

            // Schimba km masinii a deoarece folosim ref
            ChangeKm(ref a);
            Console.WriteLine("Masina a dupa modificari: " + a.Type + " " + a.Age + " " + a.km);

            //aici trebuie sa initializam toate atributele pentru ca folosim out
            BuyNew(out a);
            Console.WriteLine("Masina a dupa modificari: " + a.Type + " " + a.Age + " " + a.km);

        }

        static void ChangeKm(ref Masina a)
        {
            a.km = a.km - 5000;
        }

        static void ChangeKm2(Masina a)
        {
            a.km = a.km + 22;
            //Acesta e noul obiect creat in aceasta functie 
            Console.WriteLine("Masina din functie : " + a.Type + " " + a.Age + " " + a.km);




            // nu am scris informatii despre constructorul static pentru ca l-am folosit in asigmentul urmator

            // Executia principala incepe aici
            Console.WriteLine("Tthread starts here.");

            // This method takes 4 seconds to finish.  
            Program.Pause();

            // This method doesn't take anytime at all.  
            Program.DoSomething();

            // Execution ends here  
            Console.WriteLine("Thread ends here.");
            Console.ReadKey();
        }

        static void BuyNew(out Masina a)
        {
            a.Type = "New";
            a.km = 0;
            a.Age = 2021;

        }


        public static void Pause()
        {
            Console.WriteLine("I did something!!");
            Thread.Sleep(1000);
            Console.WriteLine("Tired! Need a 3 sec nap.");
            Thread.Sleep(1000);
            Console.WriteLine("1....");
            Thread.Sleep(1000);
            Console.WriteLine("2....");
            Thread.Sleep(1000);
            Console.WriteLine("3....");
            Console.WriteLine("I'm not tired anymore.");
        }
        public static void DoSomething()
        {
            Console.WriteLine("I'm counting to 10");
            for (int i = 1; i <= 10; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine("Done!.");
        }


    }

    


}
