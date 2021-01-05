using System;

namespace RestaurantManager
{
    class Program
    {
        static void Main(string[] args)
        {
            bool oprChecker = true;

            MenuStart:
            Console.WriteLine("\n=======================================");

            if (!oprChecker)
            {
                Console.WriteLine("Xeta! Dogru emeliyyati secin !");
                oprChecker = true;
            }

            Console.WriteLine("1 Menu uzerinde emeliyyat aparmaq");
            Console.WriteLine("2 Sifarisler uzerinde emeliyyat aparmaq");
            Console.WriteLine("0 Sistemden cixmaq");

            string selectedOpr = Console.ReadLine();

            switch (selectedOpr)
            {
                case "1":
                    Console.WriteLine("Menu uzerinde emeliyyat apailir. . .");
                    break;
                case "2":
                    Console.WriteLine("Sifarisler uzerinde emeliyyat apailir. . .");
                    break;
                case "0":
                    return;
                default:
                    oprChecker = false;
                    break;
            }
            goto MenuStart;
        }
    }
}
