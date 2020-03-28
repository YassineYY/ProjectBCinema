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
                HomeScreen();
        }
    }
}
