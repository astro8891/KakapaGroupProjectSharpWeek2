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
    }
}
