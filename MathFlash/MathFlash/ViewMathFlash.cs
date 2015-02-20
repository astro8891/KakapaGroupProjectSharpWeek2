﻿using System;
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
            Console.WriteLine("");
            Console.WriteLine("Question:");
            Console.WriteLine("{0} {1} {2}", num1, op, num2);
            return Console.ReadLine();
        }
        public string Incorrect()
        {
            Console.WriteLine("");
            Console.WriteLine("Incorrect! Try again.");
            Console.WriteLine("It has to be a number between 0-9");
          
            return Console.ReadLine();
        }
        public void Correct()
        {
            Console.WriteLine("");
            Console.WriteLine("Correct!!");
        }

    }
}
