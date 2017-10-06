    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace WorkHours
    {
        class Program
        {
            static void Main(string[] args)
            {
                // inputs
                int hoursNeeded = int.Parse(Console.ReadLine());
                int workersCount = int.Parse(Console.ReadLine());
                int workDays = int.Parse(Console.ReadLine());

                int hoursOfWorking = (workersCount * workDays) * 8;
                int hoursLeft = Math.Abs(hoursOfWorking - hoursNeeded);

                if (hoursOfWorking > hoursNeeded) Console.WriteLine("{0} hours left", hoursLeft);
                else
                {
                    Console.WriteLine("{0} overtime", hoursLeft);
                    Console.WriteLine("Penalties: {0}" , hoursLeft * workDays);
                }



            }
        }
    }
