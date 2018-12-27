using System;

namespace LocationSpace
{
    public class LocationEngine
    {
        public void GoToLocation(bool MenuDecision, string Location)
        {

            switch (Location)
            {
                case "town":
                    Console.Write("\r\nArriving at: Town\r\n");
                    Console.ReadLine();
                    Town();
                    break;

                default:
                    Console.Write("\nInvalid location\n\n");
                    break;
            }


        }
        public void Town()
        {
            Console.WriteLine("\r\nPress any key to continue.\r\n");
            Console.ReadKey();
            string TownSelection = "";
            Console.WriteLine("\r\nYou are in Town.\r\n\r\nYou can 'explore' for encounters\r\nYou can use 'stats' to check your character\r\nOr you can 'sleep' to return to the main menu\r\n");
            TownSelection = Console.ReadLine();
            if (TownSelection == "sleep")
            {
                Console.WriteLine("");
                return;
            }
            else if (TownSelection == "stats")
            {
                return;
                // CurrentPlayer.CharacterStats();
            }
        }
    }
}
