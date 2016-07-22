using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
*Assignment :           04 
*Author:                Krytia Fernandez
*Date Last Modified :   July 09, 2016
*Description :          Array and List Practice
*Version:               0.0.0.10 = all done
*/
namespace Assignment04
{
        class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); // random number object
            List<int> diceRolling = new List<int>(); // New List of Type int
            int[] list = new int[13];
            int MaximumTimes = 36000;

            // Build the list to store random numbers of dices
            for (int k = 0; k < MaximumTimes; k++)
            {
                int DieOne = rand.Next(1, 7);
                int DieTwo = rand.Next(1, 7);
                int sum = DieOne + DieTwo;
                list[sum]++;
                diceRolling.Add(sum);
            }
            Console.WriteLine("||::::::::::::::::::::::::||");
            Console.WriteLine("|| Rolls  |Number of Rolls||");
            Console.WriteLine("||+++****+++****+++****+++||");
            for (int k = 2; k < 13; k++)
            {
                Console.WriteLine("||{0,4}    |{1,10}     ||", k, list[k]);
                Console.WriteLine("||::::::::::::::::::::::::||");

            }

        }
    }
}

