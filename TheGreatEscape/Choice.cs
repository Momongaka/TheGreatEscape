using System;

namespace TheGreatEscape
{
    public class Choice
    {
        public static void PChoice()
        {
            string input = "";
            Console.WriteLine("Which will you choose? A or B?");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Console.Clear();
                Dialog.ChatOp("You have chosen path A!", "green","");
            }
            else
            {
                Console.Clear();
                Dialog.ChatOp("You have chosen path B!","green","");
            }
        }
    }
}