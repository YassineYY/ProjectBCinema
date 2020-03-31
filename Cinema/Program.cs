using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            void HomeScreen()
            {
                var HomeScreenText = "CINEMA HOMESCREEN\n1. Select Movies\n2. Profile (Unavailable)\n3. Reservation\n4. Information";
                Console.WriteLine(HomeScreenText);
                string c = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(c) == 1)
                    {
                        Console.WriteLine("**** MOVIE SELECTION ****");
                        // Here comes the Movie Select Function
                        Console.WriteLine("**** Press 0 to go back to the Homescreen ****");
                        string c2 = Console.ReadLine();
                        if (Convert.ToInt32(c2) == 0)
                        {
                            HomeScreen();
                        }
                    }
                    else if (Convert.ToInt32(c) == 2)
                    {
                        // Unavailable so It will go back to the Homescreen
                        HomeScreen();
                    }
                    else if (Convert.ToInt32(c) == 3)
                    {
                        Console.WriteLine("**** RESERVATION SCREEN ****");
                        // Reservation Function
                        Console.WriteLine("**** Press 0 to go back to the Homescreen ****");
                        string c2 = Console.ReadLine();
                        if (Convert.ToInt32(c2) == 0)
                        {
                            HomeScreen();
                        }
                    }
                    else if (Convert.ToInt32(c) == 4)
                    {
                        Console.WriteLine("**** INFORMATION ****");
                        Console.WriteLine("**** Developers: Ozeir, Derek, Alan, Yassine en Brandon");
                        // Nothing important for this yet
                        Console.WriteLine("**** Press 0 to go back to the Homescreen ****");
                        string c2 = Console.ReadLine();
                        if (Convert.ToInt32(c2) == 0)
                        {
                            HomeScreen();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Usage Try Again.");
                        HomeScreen();
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Usage Try Again.");
                    HomeScreen();
                }
            }
            static void CinemaSeats()
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("-----------------   Screen   --------------------");
                Console.WriteLine("*************************************************");
                Console.WriteLine();

                string[] SeatsFirstRow = { "1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10" };
                Console.WriteLine("[{0}]", string.Join("   ", SeatsFirstRow));
                Console.WriteLine();

                string[] SeatsSecondRow = { "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };
                Console.WriteLine("[{0}]", string.Join("   ", SeatsSecondRow));
                Console.WriteLine();

                string[] SeatsThrirdRow = { "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };
                Console.WriteLine("[{0}]", string.Join("   ", SeatsThrirdRow));
                Console.WriteLine();

                string[] SeatsFourthRow = { "31", "32", "33", "34", "35", "36", "37", "38", "39", "40" };
                Console.WriteLine("[{0}]", string.Join("   ", SeatsFourthRow));
                Console.WriteLine();

                string[] SeatsFifthRow = { "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" };
                Console.WriteLine("[{0}]", string.Join("   ", SeatsFifthRow));
                Console.WriteLine();

                Console.WriteLine("*************************************************");

                int[] Seats = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
                List<int> TakenSeats = new List<int>();
                string TakenSeats2 = System.IO.File.ReadAllText(@"C:\Users\derek\source\repos\Cinema_Seat_System\TakenSeats.txt");
                Console.WriteLine("Enter amount of seats ordered:");
                int TotalSeatsOrdered = 0;
                while (TotalSeatsOrdered == 0)
                {
                    try
                    {
                        TotalSeatsOrdered = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("That's not a number, try again");
                        Console.WriteLine("Enter amount of seats ordered:");
                    }
                }
                while (TotalSeatsOrdered > 0)
                {
                    Console.WriteLine("Enter the seat number you want: (" + TotalSeatsOrdered + " left)");
                    try
                    {
                        int UserSeat = Convert.ToInt32(Console.ReadLine());
                        if (UserSeat > 50)
                        {
                            Console.WriteLine("That seat doesnt exist, try again");
                            Console.WriteLine("Enter the seat number you want: (" + TotalSeatsOrdered + " left)");
                        }
                        else if (TakenSeats.Contains(UserSeat))
                        {
                            Console.WriteLine("Seat already taken, choose another seat please");
                        }
                        else
                        {
                            TakenSeats.Add(UserSeat);
                            TotalSeatsOrdered = TotalSeatsOrdered - 1;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That's not a number, try again");
                    }
                }

                Console.WriteLine("Seats are chosen");
                Console.WriteLine("Continue to pay...");
            }
            HomeScreen();
            CinemaSeats();
        }
    }
}
