using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    public class ExampleOfOperators
    {

        //Arithmetic Operators
        //1)  +  - Add two values
        //2) -  -Substarct the second Operand from the first (5-3  = 2)
        //3) * - Multiples both operands
        //4)- / -  Devides the numerator by de-numerator
        //5)- % Modulus operator and a remainder of the offer an integer division
        //6)- ++ - increment
        //7)- -- - decrement




        static void Main(string[] args)
        {

            Int32 val1 = 10, val2 = 20;
            bool status = true;

            Console.WriteLine(val1 + val2); // addition
            Console.WriteLine(val2 - val1); // Substarction
            Console.WriteLine(val2 * val1); // Multiply
            Console.WriteLine(val2/val1); // devide
            Console.WriteLine(--val2); // decrement 
            Console.WriteLine(++val2); // increment
            Console.WriteLine(--val2); // decrement 
            Console.WriteLine(val2 % val1); // modulus 


            Console.WriteLine(status);
        }


    }
}
