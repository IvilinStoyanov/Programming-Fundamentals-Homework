using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInHex = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine("{0}", numberInHex);



        }
    }
}
