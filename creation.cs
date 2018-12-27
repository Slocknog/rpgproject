using System;

namespace Creation
{
    public class CharacterCreation
    {
        public static bool CharacterWelcome()
        {
            CreationMessages.CharacterWelcomeMessage();
            while (true)
            {
                string Choice = Console.ReadLine();

                if (Choice == "lore")
                {
                    CreationMessages.CharacterLore();
                }
                else if (Choice == "tutorial")
                {
                    CreationMessages.CharacterTutorial();
                }
                else if (Choice == "continue")
                {
                    return true;
                }
                else if (Choice == "back")
                {
                    return false;
                }
            }
        }

        public static string CharacterName()
        {
            CreationMessages.CharacterNameMessage();
            while (true)
            {
                string Choice = Console.ReadLine();

                if (Choice.Length <= 12 )
                {
                    if (Choice.Length >= 2)
                    {
                        return Choice;
                    }

                }

            }
        }
        public static string CharacterPass()
        {
            CreationMessages.CharacterPassMessage();

            while (true)
            {
                string Choice = Console.ReadLine();

                if (Choice.Length <= 20)
                {
                    if (Choice.Length >= 6)
                    {
                        return Choice;
                    }

                }

            }
        }
    }
    public class CreationMessages
    {
        public static void CharacterWelcomeMessage()
        {
            Console.WriteLine("\r\nWelcome to RPGPROJECT. You can input commands to gain information about the game world and mechanics,\r\nor continue with character creation.\r\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter 'lore' for information about the game world.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter 'tutorial' to go over the gameplay mechanics");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter 'continue' to go to character creation.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter 'back' to return to the main menu.\r\n");
            Console.ResetColor();
            Console.Write("Selection: ");

        }
        public static void CharacterLore()
        {
            Console.WriteLine("\r\nThere is no lore written yet.\r\nThis feature will be implemented in a future build.\r\n");
        }
        public static void CharacterTutorial()
        {
            Console.WriteLine("\r\nThe tutorial has not been made yet.\r\nThis feature will be implemented in a future build.\r\n");
        }
        public static void CharacterNameMessage()
        {
            // Add color to the entered text
            Console.Write("\r\nWhat is your name? This will also be used to identify your character's data.\r\nChoose a name between 2 and 12 characters.\r\n\r\nCharacter Name: ");
        }
        public static void CharacterPassMessage()
        {
            Console.Write("\r\n\r\nThe final step is to create a password for your character.\r\nThis grants you access to the character and is entered on game load.\r\nChoose a password between 5 and 20 characters.\r\n\r\nCharacter Password: ");
        }
    }
}
