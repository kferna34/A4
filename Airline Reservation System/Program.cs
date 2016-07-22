using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Assignment :           04 
* Author:                Krytia Fernandez
* Date Last Modified :   July 18, 2016
* Description :          Array and List Practice
* Version:               0.0.0.10 == FINAL
 */
namespace Airline_Reservation_System
{
    class Program
    {
        private static bool[] seats;
        public static int TotalAssignedFirstClass;
        public static int TotalAssignedEconomyClass;

        static void Main(string[] args)
        {
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            Random rand = new Random();// generates random
            seats = new bool[11];
            //To keep a separate list of seats taken        
            List<int> seatsBooked = new List<int>();
            int InputSelection = 0;//menu selection

            do
            {
                bool SelectionMenu = true; // displays the menu
                while (SelectionMenu)

                {
                    Console.WriteLine(" =========== Airline Reservation System ===========");
                    Console.WriteLine(" |                                                |");
                    Console.WriteLine(" |  1 -  First Class                              |");
                    Console.WriteLine(" |  2 -  Economy Class                            |");
                    Console.WriteLine(" |  3 -  Exit Reservation System                  |");
                    Console.WriteLine(" |                                                |");
                    Console.WriteLine(" ==================================================");
                    Console.Write(" Your Choice ->  ", InputSelection);
                    InputSelection = Int32.Parse(Console.ReadLine());
                    Console.Clear();// clears the selection  to show a clear console again 
                    switch (InputSelection)
                    {
                        case 1:

                            if (TotalAssignedFirstClass == 5 && TotalAssignedEconomyClass < 5)
                            {
                                Console.WriteLine("Sorry, First class is full. Do you want to get a ticket for economy class? Y-N");
                                string choice = Console.ReadLine();
                                if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))//looks at the choice then compares it 
                                {
                                    BookEconomyClass();// refers to the bookEconomyClass method
                                }
                                else
                                {
                                    ChoiceNo();// refers to the Chocie no method
                                }
                            }
                            else
                            {
                                BookFirstClass();
                                Console.ReadKey();
                            }
                            if (TotalAssignedEconomyClass == 5 && TotalAssignedFirstClass == 5)
                            {
                                Console.ReadKey();
                                Console.WriteLine("Sorry! The plane is full. The next plane will be leaving in 3 hours");

                            }
                            break;

                        case 2:
                            if (TotalAssignedEconomyClass == 5 && TotalAssignedFirstClass < 5)
                            {
                                Console.WriteLine("Sorry, Economy Class is full. Do you want to get a ticket for first class? Y-N");
                                string choice = Console.ReadLine();
                                if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
                                {
                                    BookFirstClass();
                                }
                                else
                                {
                                    ChoiceNo();
                                }
                            }
                            else
                            {

                                BookEconomyClass();
                                Console.ReadKey();
                            }
                            if (TotalAssignedEconomyClass == 5 && TotalAssignedFirstClass == 5)
                            {
                                Console.ReadKey();
                                Console.WriteLine("Sorry! The plane is full. The next plane will be leaving in 3 hours");
                                break;
                            }
                            break;

                        case 3:

                            Console.WriteLine("==~~==~~ SEE YOU  AGAIN SOON!! ~~==~~== ");
                            SelectionMenu = false;
                            break;
                        default:
                            Console.WriteLine(" INVALID SELECTION !!");
                            break;
                    }
                }
            } while (InputSelection != 3);
        }

        public static void BookFirstClass()
        {

            bool SeatRepeated = false;
            Random rand = new Random();
            int index = 0;

            //keep generating the seat number until a FREE seat is assigned
            while (!SeatRepeated)
            {
                SeatRepeated = true;
                index = rand.Next(1, 6);
                if (seats[index] == true)
                    SeatRepeated = false;
            }
            seats[index] = true;
            TotalAssignedFirstClass++;
            Console.WriteLine("Assigned seat {0:N0}", index);
            Console.WriteLine("Please press ENTER to show the selection");
        }

        public static void BookEconomyClass()
        {

            bool seatRepeat = false;
            Random rand = new Random();
            int index = 0;

            //keep generating the seat number until a FREE seat is assigned
            while (!seatRepeat)
            {
                seatRepeat = true;// avoids repeating number or seats in this matter
                index = rand.Next(6, 11);
                if (seats[index] == true)
                    seatRepeat = false;
            }
            seats[index] = true;
            TotalAssignedEconomyClass++;
            Console.WriteLine("Assigned seat {0:N0}", index);
            Console.WriteLine("Please press ENTER to show the selection");
        }
        public static void ChoiceNo()
        {
            Console.WriteLine(" The Next plane leaves in 3 hours");

        }
    }
}