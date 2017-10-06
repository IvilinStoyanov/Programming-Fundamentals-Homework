using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            Console.WriteLine(TypeNumberInReversedOrder(numbers));
        }

        static string TypeNumberInReversedOrder(string number)
        {
            char[] reversedNumber = number.ToCharArray();
            string reversed = "";
            for (int i = reversedNumber.Length - 1; i >= 0; i--)
            {
                reversed += reversedNumber[i];
            }
            return reversed;
        }      
    }
}
