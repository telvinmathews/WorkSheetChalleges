using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class WhileLoops
    {
        public void LoopWhileTrue()
        {
            int count = 5;
            while (count < 25)
            {
                count++;
                Console.WriteLine(count);
            }
        }
        public void UserInputWhileLoop()
        {
            Console.WriteLine("Enter 42");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput != 42)
            {
                Console.WriteLine("please enter 42.");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thanks!!");
        }
    }
}
