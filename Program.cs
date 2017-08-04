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
            //string wednesday = "Wed";
            string theDay = "";
            DateTime today = DateTime.Today;


            //Console.WriteLine(jan1);

            //Console.WriteLine(jan1 == DateTime.Today);

            //Console.WriteLine(jan1.ToString("ddd"));

            do
            { nextDay.AddDays(1);
                //Console.WriteLine(nextDay.ToString());
                theDay = nextDay.ToString("ddd");
                Console.WriteLine(theDay);
            
                if (theDay == "Wed")
                {
                    Console.WriteLine("Today is Wednesday " + nextDay.ToString());
                }
                nextDay.AddDays(1);

            } while (nextDay < today);


            Console.ReadLine();
        }
    }
}
