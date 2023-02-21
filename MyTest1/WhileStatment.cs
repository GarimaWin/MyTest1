using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest1
{
    internal class WhileStatment
    {
        static void Main(string[] args)
        {
            Int32 value = 3, i = 9;
            while (i > value)
            {
                Console.WriteLine(i);
                i = i - 1;
            }
        }
    }
}
