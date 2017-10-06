using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            //variables

            //loads
            var bus = 200;
            var truck = 175;
            var train = 120;
            // vehicles counting
            var busCount = 0;
            var truckCount = 0;
            var trainCount = 0;
            // load to every vehicles
            var loadBus = 0;
            var loadTruck = 0;
            var loadTrain = 0;

            var loadBusF = 0;
            var loadTruckF = 0;
            var loadTrainF = 0;



            for (int i = 0; i < number; i++)
            {
                int load = int.Parse(Console.ReadLine());
                if (load <= 3)
                {
                    busCount += load;
                    loadBus = load * bus;
                    loadBusF += loadBus;               
                }
                if (load >= 4 && load <= 11)
                {
                    truckCount += load;
                     loadTruck = load * truck;
                    loadTruckF += loadTruck;
                }
                if (load >= 12)
                {
                    trainCount += load;
                    loadTrain = load * train;
                    loadTrainF += loadTrain;
                }          
            }
            double all = busCount + truckCount + trainCount;
            double avergeByTon = (loadBusF + loadTruckF + loadTrainF) / all;

            Console.WriteLine("{0:f2}", avergeByTon);
            Console.WriteLine("{0:f2}%" , busCount /all * 100);
            Console.WriteLine("{0:f2}%", truckCount / all * 100);
            Console.WriteLine("{0:f2}%", trainCount / all * 100);
          
        }
    }
}
