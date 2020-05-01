using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class CalulatorMadness
    {
        public void  UsserInputAddTwoNumbers()
        {
            Console.WriteLine("Please enter first number:");
            int numberOne = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter Second number:");
            int numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;
            Console.WriteLine("The result is: " + result);
        }
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            //Console.WriteLine(result);
            return result;
        }
        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            //Console.WriteLine(result);
            return result;
        } 
        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            //Console.WriteLine(result);
            return result;
        }
        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            //Console.WriteLine(result);
            return result;
        }

        public void RunCalulations()
        {
            //UsserInputAddTwoNumbers();
            //int sumOfOne = AddTwoNumbers(8,40);
            //int sumOfTwo = AddTwoNumbers(200,50);
            //int resultOfSum = AddTwoNumbers(sumOfOne, sumOfTwo);
            //int subOne = SubtractTwoNumbers(1, 2);
            //int mutiOne = MultiplyTwoNumbers(5, 9);
            //int divideOne = DivideTwoNumbers(3, 3);
            int multiResult = MultiplyTwoNumbers(40, 35);
            Console.WriteLine("should be 1,400: ");
            Console.WriteLine(multiResult);
            int divideResult = DivideTwoNumbers(multiResult, 4);
            Console.WriteLine("should be 350: ");
            Console.WriteLine(divideResult);
            int mutiplyNegativeOne = MultiplyTwoNumbers(divideResult, -1);
            Console.WriteLine("should be -350: ");
            Console.WriteLine(mutiplyNegativeOne);
            int exponentResult = MultiplyTwoNumbers(2, 2);
            Console.WriteLine("should be 4: ");
            Console.WriteLine(exponentResult);
            int addResult = AddTwoNumbers(mutiplyNegativeOne, exponentResult);
            Console.WriteLine("should be -346: ");
            Console.WriteLine(addResult);
            int addSixAndFive = AddTwoNumbers(6, 5);
            Console.WriteLine("should be 11: ");
            Console.WriteLine(addSixAndFive);
            int subtractResult = AddTwoNumbers(addSixAndFive, addResult);
            Console.WriteLine("should be -335: ");
            Console.WriteLine(subtractResult);
        }
    }
}
