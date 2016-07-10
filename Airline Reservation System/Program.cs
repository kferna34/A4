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
*Version:               0.0.0.3 = AIRLINE RESERVATION SYSTEM SWITCH    
*/
namespace Airline_Reservation_System
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void menu()
        {
            Console.WriteLine(" Airline Reservation System ");
            Console.WriteLine(" Please enter the number you want to do: ");
            Console.WriteLine(" 1 -  First Class");
            Console.WriteLine(" 2 -  Economy Class");
            Console.WriteLine(" 3 -  Exit Reservation System");
            int choice = 0;
            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" ==~~==~~ FIRST CLASS ~~==~~== ");
                        break;
                    case 2:
                        Console.WriteLine("==~~==~~ ECONOMY CLASS ~~==~~== ");
                        break;
                    case 3:
                        Console.WriteLine("==~~==~~ EXIT MENU ~~==~~== ");
                        break;
                    default:
                        Console.WriteLine("PLEASE ENTER THE RIGHT SELECTION");
                        break;
                }
            }

        }
    }
}
