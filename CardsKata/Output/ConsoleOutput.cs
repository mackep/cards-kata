using System;
using System.Collections.Generic;
using CardsKata.Gameplay;
using CardsKata.Result;

namespace CardsKata.Output
{
    public class ConsoleOutput : IOutput
    {
        public void Report(IEnumerable<PlayerWithCards> players)
        {
            foreach(var player in players)
                WriteConsole(player.ToString(), ConsoleColor.White);
        }

        public void Report(IResult result)
        {
            WriteConsole(result.GetDescription(), ConsoleColor.Green);
        }

        private static void WriteConsole(string msg, ConsoleColor color)
        {
            var previousColor = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ForegroundColor = previousColor;
        }
    }
}