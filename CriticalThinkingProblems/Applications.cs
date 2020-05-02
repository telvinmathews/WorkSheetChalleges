using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Applications
    {
        //Member variable (Has a)
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRam;
        public double RequiredStorage;
        //Conductor (Spawn)
        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Message Service";
            RequiredRam = 4.0;//In gigabytes
            RequiredStorage = 0.512;//In gigabytes
        }
        //Member method (Can do)

    }
}
