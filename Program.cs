using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWednesdays
{
    class Wenesdays
    {
        static void Main()
        {
                  
            DateTime jan1 = new DateTime(2017, 1, 1);
            DateTime nextDay = new DateTime(2017,1,2);
            string wednesday = "Wed";


            Console.WriteLine(jan1);

            Console.WriteLine(jan1 == DateTime.Today);

            Console.WriteLine(jan1.ToString("ddd"));

            do
            { nextDay++;
                if{
                    nextDay.ToString("ddd") = wednesday
                        Console.WriteLine("Today is Wednesday " + nextDay);
                }
                while nextDay < DateTime.Today();
            }


            Console.ReadLine();
        }
    }
}
