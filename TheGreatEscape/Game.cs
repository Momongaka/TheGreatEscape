using System;

namespace TheGreatEscape
{
    public abstract class Game
    {
        private static string CharacterName { get; set; }

        public static void StartGame()
        {
            
            Dialog.GameTitle();
            NameCharacter();
            Choice.PChoice();
        }

        public static void NameCharacter()
        {
            Console.WriteLine("What would you like your Adventuring Name to be?");
            CharacterName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(CharacterName)) CharacterName = "Bob";
            
            Dialog.ChatOp("Your Character name is: " + CharacterName + "! Huzzahhh","green");
        }

    }
}
