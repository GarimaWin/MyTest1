using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    internal class ExampleOfLogicalOperator
    {


        //Logical Operator
        //1)- == - Checks two operands are equal or not
        //2)- != - Checks two operands are not equal.
        //3)- > - greater than
        //4)_ < - the value of left operands is less than the value of right operand. if yes condition will be true.
        //5)- >=
        //6)- <=


        static void Main(string[] args)
        {

            Int32 val1 = 10, val2 = 20;
            bool status = true;

            Console.WriteLine(val1 == val2); // ==
            Console.WriteLine(val1 != val2); // !=
            Console.WriteLine(val1 > val2); // greator than
            Console.WriteLine(val1 < val2); // < less than
            Console.WriteLine(val1 >= val2); // greator than or equal
            Console.WriteLine(val1 <= val2); // < less than or equal


        }

    }
}
