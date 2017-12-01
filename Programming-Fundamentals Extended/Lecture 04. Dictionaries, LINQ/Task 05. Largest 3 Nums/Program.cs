using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<double> numbers = new List<double>();
        var realNumbers = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(n => n).Take(3).ToArray();
        Console.WriteLine(String.Join(" ", realNumbers));
    }
}

