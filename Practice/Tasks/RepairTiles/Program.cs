using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double landingN = double.Parse(Console.ReadLine());
            double tilesW = double.Parse(Console.ReadLine());
            double tilesL = double.Parse(Console.ReadLine());
            double benchW = double.Parse(Console.ReadLine());  
            double benchL = double.Parse(Console.ReadLine());  

          
            
                double T = 0.2;
                double landingArea = landingN * landingN;
                double tilesArea = tilesW * tilesL;
                double benchArea = benchL * benchW;

                double totalArea = landingArea - benchArea;

                double numberOfTiles = totalArea / tilesArea;
                double timesNeeded = numberOfTiles * T;


            Console.WriteLine("{0:f2}", numberOfTiles);
                Console.WriteLine("{0:f2}", timesNeeded);
            }
           
        }
    }

