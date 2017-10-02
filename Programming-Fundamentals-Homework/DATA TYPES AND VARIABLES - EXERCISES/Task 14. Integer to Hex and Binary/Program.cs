using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexString = Convert.ToString(decimalNumber, 16).ToUpper();
            string binaryString = Convert.ToString(decimalNumber, 2).ToUpper();
            Console.WriteLine($"{hexString}\n{binaryString}");
        }
    }
}
