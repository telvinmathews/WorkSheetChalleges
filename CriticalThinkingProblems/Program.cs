using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoops loops = new ForLoops();
            //loops.RunFiveLoops();
            //loops.RunNineloopsBackwards();
            //loops.UserInputLoop();
            //loops.LoopString();
            //loops.PrintCharInString();
            //loops.ForEachPrintCharInString();
            //loops.PrintEverOtherCharInString();
            loops.PrintCharDivBy3InString();
            Console.ReadLine();
        }
    }
}
