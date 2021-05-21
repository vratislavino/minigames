using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigames
{
    interface IMinigame
    {
        event Action MinigameEnded;

        int Points { get; }

        void Start();
    }
}
