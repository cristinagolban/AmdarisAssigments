using System;

namespace Assigment06
{
    class Program
    {

        static int SumOdd(int[] n)
        {
            int sum = 0;
            foreach (int i in n)
            {
                if (i % 2 != 0)
                    sum = sum + i;
            }
            return sum;
        }

        static int NrOdd(int[] n)
        {
            int c = 0;
            foreach (int i in n)
            {
                if (i % 2 != 0)
                    c++;
            }
            return c;
               
        }

        static void Cats(string[,] a)
        {
            int cont = a.Length;
            for ( int i=0;i<cont/2;i++)
            {
                if (a[i, 0] == "pisica")
                    Console.WriteLine("Miau!");
            }
        }


        static void FemealeAndMale(string [,] a)
        {
            int cont = a.Length;
            int fem = 0;
            int masc = 0;
            for (int i = 0; i < cont / 2; i++)
            {
                if (a[i, 1] == "femela")
                    fem++;
                else masc++;
                    
            }

            Console.WriteLine("Exista " + fem + " femele si " + masc + " masculi");
        }

        static void Main(string[] args)
        {
            int [] numbers = new int[10] {2,10,5,77,32,66,9,13,7,30 };
            Console.WriteLine("suma nr impare este= "+SumOdd(numbers));
            Console.WriteLine("exista "+NrOdd(numbers)+" nr impare");

            string[,] animals = new string[,] { { "pisica", "femela" }, { "caine", "femela" }, {"iepure","mascul" },{"pisica","mascul" } };

            Cats(animals);
            FemealeAndMale(animals);
        }



    }


}

