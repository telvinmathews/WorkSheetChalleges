using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class ForLoops
    {
        public void RunFiveLoops()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void RunNineloopsBackwards()
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void UserInputLoop()
        {
            Console.WriteLine("How many times would you like to loop?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < userInput; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void LoopString()
        {
            string word = "Hello World";
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void PrintCharInString()
        {
            string word = "Hello World";
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
        public void PrintEverOtherCharInString()
        {
            string word = "Hello World";
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                  Console.WriteLine(word[i]);
                }
            }
        }
        public void PrintCharDivBy3InString()
        {
            string word = "Hello World";
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 3 == 0)
                {
                  Console.WriteLine(word[i]);
                }
            }
        }
        public void ForEachPrintCharInString()
        {
            string word = "Hello World";
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
