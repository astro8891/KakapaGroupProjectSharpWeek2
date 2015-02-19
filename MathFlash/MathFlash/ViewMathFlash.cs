using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFlash
{
    class ViewMathFlash
    {
        public string GetOperator()
        {
            Console.WriteLine(Environment.NewLine+"Please enter + or - depending on what you want to do:");
            return Console.ReadLine();
        }
     

    }
}
