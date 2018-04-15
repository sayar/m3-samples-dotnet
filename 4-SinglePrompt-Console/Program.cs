using System;
using Microsoft.Bot.Builder.Adapters;
using Microsoft.Bot.Builder.Core.Extensions;

namespace M3Samples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PromptBot.");

            var adapter = new ConsoleAdapter();
            adapter.Use(new ConversationState<DemoState>(new MemoryStorage()));
            adapter.ProcessActivity(async (context) =>
            {
                var promptBot = new PromptBot();
                await promptBot.OnTurn(context);
            }).Wait();
        }
    }
}
