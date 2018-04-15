using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Core.Extensions;
using Microsoft.Bot.Schema;
using System;
using System.Threading.Tasks;

namespace M3Samples
{
    public class PromptBot : IBot
    {
        public async Task OnTurn(ITurnContext context)
        {
            DemoState state = ConversationState<DemoState>.Get(context) ?? new DemoState();
            
            if (context.Activity.Type is ActivityTypes.Message)
            {
                if (String.IsNullOrEmpty(state.CurrentQuestion))
                {
                    state.CurrentQuestion = "name";
                    await context.SendActivity("What is your name ?");
                }
                else if (state.CurrentQuestion.Equals("name"))
                {
                    state.CurrentQuestion = null;
                    await context.SendActivity($"Welcome, {context.Activity.Text}");
                }
            }
        }
    }
}
