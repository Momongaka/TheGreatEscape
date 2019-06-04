using System;

namespace TheGreatEscape
{
    public class Game
    {
        private static string CharacterName { get; set; }

        public static void StartGame()
        {
            Dialog.ChatOp("The Great Escape!","cyan");
            Dialog.ChatOp("Try Not to Die too Much!","cyan");
            NameCharacter();
        }

        public static void NameCharacter()
        {
            Console.WriteLine("What would you like your Adventuring Name to be?");
            CharacterName = Console.ReadLine();
            
            Dialog.ChatOp("Your Character name is: " + CharacterName + "! Huzzahhh","green");
        }

    }
}