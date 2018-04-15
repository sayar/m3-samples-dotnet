﻿using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace M3Samples
{
    public class HelloBot : IBot
    {
        public async Task OnTurn(ITurnContext context)
        {
            if (context.Activity.Type is ActivityTypes.Message)
            {
                await context.SendActivity($"Hello world.");
            }
        }
    }
}
