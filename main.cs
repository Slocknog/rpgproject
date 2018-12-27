using System;
using PlayerCharacter;
using Functions;
using LocationSpace;

namespace GameMain
{
    public class Game
    {

        static void Main()
        {
            MainMenu Game = new MainMenu();
            Game.Menu();
            return;
        }

    }
    public class MainMenu
    {
        Character CurrentPlayer = new Character();
        public void Menu()
        {
            Music MusicPlayer = new Music();
            LocationEngine Location = new LocationEngine();
            MusicPlayer.Track("0");
            while (true)
            {
            Menu:
                Console.WriteLine("Welcome to the main menu. Enter 'create' to create a character and begin the game. Enter 'play' to log in.\r\nSaving features are to be implemented.\r\n");
                while (true)
                {
                    string MenuSelection = Console.ReadLine();
                    if (MenuSelection == "create")
                    {
                        CurrentPlayer.Creation();
                        goto Menu;
                    }
                    else if (MenuSelection == "play")
                    {
                        if (CurrentPlayer.CharacterPass != "")
                        {
                            Console.Write("\r\nEnter your password: ");
                            string Password = Console.ReadLine();
                            bool Check = CurrentPlayer.Login(Password);
                            if (Check == true)
                            {
                                Console.WriteLine("\r\nAdd transition to location here.");
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please create a character first.\r\n");
                            break;

                        }
                       
                    }
                }
                while (true)
                {
                    Console.WriteLine("\r\nPress any key to continue.\r\n");
                    Console.ReadKey();
                    string TownSelection = "";
                    Console.WriteLine("\r\nYou are in Town.\r\n\r\nYou can 'explore' for encounters\r\nYou can use 'stats' to check your character\r\nOr you can 'sleep' to return to the main menu\r\n");
                    TownSelection = Console.ReadLine();
                    if (TownSelection == "sleep")
                    {
                        Console.WriteLine("");
                        break;
                    }
                    else if (TownSelection == "stats")
                    {
                        CurrentPlayer.CharacterStats();
                    }
                }







            }
        }
    }
}
