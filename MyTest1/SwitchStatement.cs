using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    internal class SwitchStatement
    {
        static void Main(String[] args)
        {
            Int32 value = 1;
            switch(value)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                case 4:
                    Console.WriteLine("Value is 4");
                    break;
                default:
                    Console.WriteLine("Value is not matching");
                    break;


            }
        }
    }
}
