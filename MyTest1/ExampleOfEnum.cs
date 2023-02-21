using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    public class ExampleOfEnum
    {
        //Enumeration
        enum Days { 
            Sun,
            Mon,
            Tue,
            Wed  = 7,
            Thu,
            Fri,
            Sat
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Days.Wed);
            int day = (int)Days.Wed;
            Console.WriteLine("Value of wednesday _ " + day);

            var weekday = (Days)5;
            Console.WriteLine(weekday);

        }



    }
}
