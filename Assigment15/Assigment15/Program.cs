using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Assigment15
{
    class Program
    {

        static void Main(string[] args)
        {
           var t = 19 - DateTime.Now.Hour;

            String s = $"Today is {DateTime.Now.DayOfWeek} and it's already {DateTime.Now.Hour} o'clock so I have " +
                       $"{t} hours until dinner";
            Console.WriteLine(s);


            DateTime day = new DateTime(1999, 7, 18);
            TimeSpan left =new DateTime(DateTime.Now.Year, day.Month, day.Day) - DateTime.Now ;
            String BirthDay = $"I was born on {day.ToString("dd/MM/yyyy")} " +
                $"so I have {(int)left.TotalDays} days, {(int) left.TotalHours} hours and {(int)left.TotalSeconds} " +
                $"seconds more to wait " +
                $"until my birthday";
            Console.WriteLine(BirthDay);

            

            DateTimeOffset dateOffset1 = DateTimeOffset.Now;
            DateTimeOffset dateOffset2 = DateTimeOffset.UtcNow;
            TimeSpan difference = dateOffset1 - dateOffset2;
            Console.WriteLine("{0} - {1} = {2}",
                              dateOffset1, dateOffset2, difference);



            Console.WriteLine();
            Console.WriteLine("CULTUREINFO");

            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("en-GB");
            CultureInfo cultureInfo2 = CultureInfo.GetCultureInfo("ec-US");

            Console.WriteLine(10.ToString("C", cultureInfo));

            Console.WriteLine(10.ToString("C",cultureInfo2));



            using(FileStream fs = new FileStream("assig15.txt", FileMode.Open) )
            {
                var bytes = Encoding.ASCII.GetBytes(BirthDay);
                fs.Write(bytes);
            }


        }
    }
}
