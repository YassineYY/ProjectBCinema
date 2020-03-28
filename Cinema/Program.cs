using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CINEMA HOMESCREEN\n1. Select Movies\n2. Profile (Unavailable)\n3. Reservation\n 4.Information");
            string c = Console.ReadLine();
            if (Convert.ToInt32(c) == 1) {
                Console.WriteLine("**** MOVIE SELECTION ****");
            }
            Console.Writeline("Test2")
        }
    }
}
