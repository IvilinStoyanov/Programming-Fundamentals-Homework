using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>();
            int locomotivePower = int.Parse(Console.ReadLine());
            var data = Console.ReadLine();
            while (data != "All ofboard!")
            {
                int wagonsWeight = int.Parse(data);
                wagons.Add(wagonsWeight);
                int sumOfAllWagons = wagons.Sum();
                if (sumOfAllWagons > locomotivePower)
                {
                    int average = sumOfAllWagons / wagons.Count;
                    int closest = FindingClosestNumberToAverage(average, wagons);
                    if(wagons.Contains(closest))
                    {
                        wagons.Remove(closest);
                    }
                }
                data = Console.ReadLine();
            }
             wagons.Reverse();
            wagons.Add(locomotivePower);
            Console.WriteLine(string.Join(" ", wagons));          
        }
        public static int FindingClosestNumberToAverage(int average, List<int> wagons)
        {
            int closest = wagons.OrderBy(item => Math.Abs(average - item)).First();
            return closest;
        }
    }
}
