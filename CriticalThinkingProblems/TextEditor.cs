using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class TextEditor : Applications
    {
        public TextEditor()
        {
            ApplicationName = "Slack";
            ApplicationType = "Message Service";
            RequiredRam = 4.0;//In gigabytes
            RequiredStorage = 0.512;//In gigabytes
        }
    }
}
