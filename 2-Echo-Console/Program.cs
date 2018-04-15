using System;
using Microsoft.Bot.Builder.Adapters;

namespace M3Samples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the EchoBot.");

            var adapter = new ConsoleAdapter();
            adapter.ProcessActivity(async (context) =>
            {
                var echoBot = new EchoBot();
                await echoBot.OnTurn(context);
            }).Wait();
        }
    }
}
