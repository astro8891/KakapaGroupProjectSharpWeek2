using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFlash
{
    class ViewMathFlash
    {
         public void HelloUser()
        {
            Console.WriteLine("Hello user! Welcome to our Mathflash Game!");
            Console.WriteLine("This game has certain rules, they are as follows:");
            Console.WriteLine("You may choose to play with addition or subtraction.");
            Console.WriteLine("");
        }
        public string GetOperator()
        {
            Console.WriteLine(Environment.NewLine+"Please enter + or - depending on what you want to do:");
            return Console.ReadLine();
        }
        public string UserPlay(string op, int num1, int num2)
        {
            Console.WriteLine(Environment.NewLine+"Question:");
            Console.WriteLine("{0} {1} {2}", num1, op, num2);
            return Console.ReadLine();
        }
        public string Incorrect()
        {
            Console.WriteLine(Environment.NewLine+"Incorrect! Try again.");
            Console.WriteLine("It has to be a number between 0-9 or 'previous'");
            return Console.ReadLine();
        }
        public void Correct()
        {

            Console.WriteLine(Environment.NewLine+"Correct!!");
        }
        public void InputError()
        {
            Console.WriteLine(Environment.NewLine+"OOPS!! Something went wrong please re-enter selection.");
        }

        public void WriteFinalScore(int question, int score, int attempts)
        {
            Console.WriteLine("Your final score is {0} out of {1}", score, question);
            Console.WriteLine("With {0} attempts",attempts);
            Console.WriteLine();
            Console.WriteLine("==============Metrics==============");
            Console.WriteLine("Percentage: {0}", score/question*100);
            Console.WriteLine("HitRate: {0}", attempts/question);
        }
    }
}
