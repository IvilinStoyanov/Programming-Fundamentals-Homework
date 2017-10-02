using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = Convert.ToBoolean(Console.ReadLine());
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
