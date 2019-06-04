using System;

namespace TheGreatEscape
{
    public class Dialog
    {
        
        public static void ChatOp(string message, string color)
        {
            if (color== "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else if (color == "cyan")
            { Console.ForegroundColor = ConsoleColor.Cyan; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}