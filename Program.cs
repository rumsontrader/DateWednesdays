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
            Console.WriteLine(jan1);
            Console.WriteLine(jan1 == DateTime.Today);           
            Console.ReadLine();
        }
    }
}
