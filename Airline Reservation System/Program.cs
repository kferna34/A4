using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*Assignment :           04 
*Author:                Krytia Fernandez
*Date Last Modified :   July 11, 2016
*Description :          Array and List Practice
*Version:               0.0.0.4 = fixed the display menu
*/
namespace Airline_Reservation_System
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine(" =========== Airline Reservation System ===========");
                Console.WriteLine(" |                                                |");
                Console.WriteLine(" |  1 -  First Class                              |");
                Console.WriteLine(" |  2 -  Economy Class                            |");
                Console.WriteLine(" |  3 -  Exit Reservation System                  |");
                Console.WriteLine(" |                                                |");
                Console.WriteLine(" ==================================================");
                Console.Write(" Your Choice -> ");
                choice = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("PLEASE ENTER A RIGHT SELECTION !!");
                        break;
                }//switch
            }//while
        }//3rd end
    }//2nd end
}//end