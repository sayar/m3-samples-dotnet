using System;
using Microsoft.Bot.Builder.Adapters;

namespace M3Samples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the HelloBot.");

            var adapter = new ConsoleAdapter();
            adapter.ProcessActivity(async (context) =>
            {
                var helloBot = new HelloBot();
                await helloBot.OnTurn(context);
            }).Wait();
        }
    }
}
