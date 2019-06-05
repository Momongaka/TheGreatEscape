using System;

namespace TheGreatEscape
{
    public class Dialog
    {
        public static void GameTitle()
        {
            Console.Title = "The Great Escape";
            Console.SetWindowSize(100,35);
            string Start = @"
          _____ _             ____                _     _____                          
         |_   _| |__   ___   / ___|_ __ ___  __ _| |_  | ____|___  ___ __ _ _ __   ___ 
           | | | '_ \ / _ \ | |  _| '__/ _ \/ _` | __| |  _| / __|/ __/ _` | '_ \ / _ \
           | | | | | |  __/ | |_| | | |  __| (_| | |_  | |___\__ | (_| (_| | |_) |  __/
           |_| |_| |_|\___|  \____|_|  \___|\__,_|\__| |_____|___/\___\__,_| .__/ \___|
                                                                           |_|         
";
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}",Start));
            ChatOp(Start,"cyan","center");
            Console.ResetColor();
            //Console.WriteLine("Press enter to start");
            //Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Press enter to start"));
            ChatOp("Press Enter To star",align:"center");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ChatOp(string message, string color="", string align="")
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

            if (align == "center")
            {
                int screenWidth = Console.WindowWidth;
                int stringWidth = message.Length;
                int spaces = (screenWidth / 2) + (stringWidth / 2);
                Console.WriteLine(message.PadLeft(spaces));
            }
            else
            {
                Console.WriteLine(message);
            }
            
            Console.ResetColor();
        }
    }
}