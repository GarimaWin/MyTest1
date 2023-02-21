using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    internal class ArrayClass
    {

        // Write your name, surname and location in an array.

        // A array is used to store a collection of series of same elements
        // [1,2,3,4] - no of elements are 4.
      static void  Main(string[] args)
        {
            //String[] str = new string[2];
            Int32[] value = new Int32[3];
            value[0] = 1;
            value[1] = 2;
            value[2] = 3;

            for(int i = 0; i < value.Length; i++)
            {
                Console.WriteLine("From Array index - " + i.ToString() + " value is " + value[i]);
            }

            Console.WriteLine(value[0]);
            Console.WriteLine(value[1]);
            Console.WriteLine(value[2]);

        }

    }
}
