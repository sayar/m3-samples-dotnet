using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Core.Extensions;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace M3Samples
{
    public class CounterBot : IBot
    {
        public async Task OnTurn(ITurnContext context)
        {
            CounterState conversationState = ConversationState<CounterState>.Get(context) ?? new CounterState();
            
            if (context.Activity.Type is ActivityTypes.Message)
            {
                conversationState.Counter++;
                await context.SendActivity($"Echo {context.Activity.Text}");
                await context.SendActivity($"You have been here {conversationState.Counter} times");
            }
        }
    }
}
