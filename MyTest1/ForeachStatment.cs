using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    internal class ForeachStatment
    {
        //Foreach
        
        static void Main(string[] args)
        {
            // foreach(element in iterable-item)
            // {
            // }
            //P1
            char[] myAraay = { 'H', 'G', 'M', 'N' };
            foreach(char ch in myAraay)
            {
               Console.WriteLine(ch);
            }

            //p2
            Char[] gender = { 'm', 'f', 'm', 'f', 'f' };
            int male = 0, female = 0;
            foreach(char j in gender)
            {
                if(j == 'm')
                {
                    male++;
                }
                else if(j == 'f')
                {
                    female++;
                }
            }
            Console.WriteLine(" no of  male - " + male);
            Console.WriteLine("no of female - " + female);

            //p3 Sum the value of an array using foreach loop
            Int32[] value = { 1, 4, 6, 7 };

            //Class & Object





        }
    }
}
