﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int totalExamMinutes = examHour * 60 + examMinutes;
            int totalArriveMinutes = arriveHour * 60 + arriveMinutes;

            int difference = totalExamMinutes - totalArriveMinutes;

            int diffHours = 0;


            if (difference == 0 || difference > 0 && difference <= 30)
            {
                Console.WriteLine("On time");

                if (difference != 0)
                {
                    Console.WriteLine("{0} minutes before the start", difference);
                }

            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");

                while (difference > 59)
                {
                    diffHours++;
                    difference -= 60;
                }

                if (diffHours > 0)
                {
                    Console.WriteLine("{0}:{1:D2} hours before the start", diffHours, difference);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", difference);
                }

            }

            else
            {
                Console.WriteLine("Late");

                difference = Math.Abs(difference);

                while (difference > 59)
                {
                    diffHours++;
                    difference -= 60;
                }

                if (diffHours > 0)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", diffHours, difference);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", difference);
                }
            }
        }
    }
}