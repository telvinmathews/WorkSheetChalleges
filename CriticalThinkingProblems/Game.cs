using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Game : Applications
    {
        public double RequiredEffectiveMemory;

        public Game()
        {
            ApplicationName = "Pokemon";
            ApplicationType = "Entertainment";
            RequiredRam = 4.0;//In gigabytes
            RequiredStorage = 2.0;//In gigabytes
            RequiredEffectiveMemory = 8.0;
        }
    }
}
