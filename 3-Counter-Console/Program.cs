using System;
using Microsoft.Bot.Builder.Adapters;
using Microsoft.Bot.Builder.Core.Extensions;

namespace M3Samples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CounterBot.");

            var adapter = new ConsoleAdapter();
            adapter.Use(new ConversationState<CounterState>(new MemoryStorage()));
            adapter.ProcessActivity(async (context) =>
            {
                var counterBot = new CounterBot();
                await counterBot.OnTurn(context);
            }).Wait();
        }
    }
}
