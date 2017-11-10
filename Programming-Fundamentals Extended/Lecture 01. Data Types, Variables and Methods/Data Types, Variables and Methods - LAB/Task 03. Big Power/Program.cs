using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_03.Big_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerNumberByItSelf = int.Parse(Console.ReadLine());
            BigInteger result = BigInteger.Pow(new BigInteger(powerNumberByItSelf), powerNumberByItSelf);        
            Console.WriteLine(result);
        }
    }
}
