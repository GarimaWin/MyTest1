using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    internal class ExampleOfRelationalOperator
    {

        //Relational Operator
        //1)- && both operands should  be true
        //2)- || Any of operands will be true, condition is true
        //3)- ! Not Operation

        static void Main(string[] args)
        {

            Int32 val1 = 10, val2 = 20;
            bool status = true;

            Console.WriteLine(true && true); 
            Console.WriteLine(true || true); 
            Console.WriteLine(true || false);
            Console.WriteLine(!false);
            Console.WriteLine(!true);



        }
    }
}
