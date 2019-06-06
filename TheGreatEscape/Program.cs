/*
 * [Your Title]
 * Daniel Formas 06-03-2019
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;

namespace TheGreatEscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.StartGame();
            Scenario1.Round1();
            Console.ReadKey();
        }
    }
}