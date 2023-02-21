using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    internal class IfStatement
    {
        // If, Switch, For, While Statement
      static void Main(string[] args)
        {
            Int32 value = 9;
            if (value < 10) // True
            {
                Console.WriteLine("Value is less than 10");
            }
            else 
            {
                Console.WriteLine("Value is greater than 10");
            }
        }
    }
}
