using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Core.Extensions;

namespace M3Samples
{
    public class DemoState : StoreItem
    {
        public String CurrentQuestion { get; set; }
    }
}
