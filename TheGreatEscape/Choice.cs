using System;

namespace TheGreatEscape
{
    public class Choice
    {
        public static void PChoice(int numChoice = 0, string input = "", string option1 = "", string option2 ="",string option3 ="",string option4 ="")
        {
            switch (numChoice)
            {
                case 2:
                    Console.WriteLine("Which will you choose? A or B?");
                    break;
                case 3:
                    Console.WriteLine("Which will you choose? A, B, or C?");
                    break;
                case 4:
                    Console.WriteLine("Which will you choose? A, B, C or D?");
                    break;
                default:
                    Console.WriteLine("You have no choice");
                    break;
            }

            input = Console.ReadLine();
            input = input.ToUpper();
            
            switch (input)
            {
                case "A":
                    Console.Clear();
                    Dialog.ChatOp("You have chosen " + option1 + "!", "green","");
                    break;
                case "B":
                    Console.Clear();
                    Dialog.ChatOp("You have chosen " + option2 + "!","green","");
                    break;
                case "C":
                    Console.Clear();
                    Dialog.ChatOp("You have chosen " + option3 + "!","green","");
                    break;
                case "D":
                    Console.Clear();
                    Dialog.ChatOp("You have chosen " + option4 + "!","green","");
                    break;
            }
        }

    }
}