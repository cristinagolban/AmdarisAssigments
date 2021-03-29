using System;
using System.Text;

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
            //face suma nr impare
            Console.WriteLine("suma nr impare este= "+SumOdd(numbers));
            //numara cate nr impare sunt
            Console.WriteLine("exista "+NrOdd(numbers)+" nr impare");

            string[,] animals = new string[,] { { "pisica", "femela" }, { "caine", "femela" }, {"iepure","mascul" },{"pisica","mascul" } };
            // afiseaza "Miau!" pentru fiecare pisica
            Cats(animals);
            //afiseaza cate femele si cati masculi sunt in arrayul animals
            FemealeAndMale(animals);


            string text = @"Aici  este un   text cu  mai     multe  spatii ";
            string numere = "1.2;3_4.5;6,1.22.4";
            string email = @"cristina_golban_99@gmail.com";
            string nume = @"golban belgea ";
            string prenume = @"Cristina Maria ";

            string cod1 = @"ro123";
            string cod2 = @"RO123";
            //verifica daca cod1 si cod2 au caractere identice
            Console.WriteLine(cod1.Equals(cod2));

            

            Console.WriteLine("The length of the text string is: " + text.Length);

            //nume o sa fie scris doar cu nr mari
            nume=nume.ToUpper();
            // concateneaza nume cu prenume
            var fullname = nume + prenume;
            Console.WriteLine(fullname);

            //verifica daca in cod1 se gaseste 123
            if (cod1.Contains("123"))
            {
                Console.WriteLine("The sequence '123' was found.");
            }

            //inlocuieste '_' cu "."
            email = email.Replace("_", ".");
            Console.WriteLine(email);

            //elimina "gmail"
            email = email.Remove(19, 5);
            Console.WriteLine(email);

            //adauga "yahoo"
            email = email.Insert(19, "yahoo");
            Console.WriteLine(email);


            //splituie cuvintele eliminanad toate spatiile
            string[] textwords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var i in textwords)
            {
                Console.WriteLine($"Words: {i}");
            }

            //splituie numerele eliminanad toate ' ', ',', '.', '_', ';'
            string[] nr = numere.Split(' ', ',', '.', '_', ';');
            foreach (var i in nr)
            {
                Console.WriteLine($"nr: {i}");
            }


            //scrie numerele din nr cu '-' intre ele
            Console.WriteLine(string.Join("-", nr));


            //creaza un stringbuilder care e initializat cu alabala si poate contine 100 de caractere
            StringBuilder sb = new StringBuilder("alabala", 100);
            Console.WriteLine(sb);
            sb.Append(" portocala");
            Console.WriteLine(sb);
            sb.Replace("a", "A");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length);







        }



    }


}

