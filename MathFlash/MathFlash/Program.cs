﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFlash
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayMathFlash play = new PlayMathFlash();
            play.Run();
            Console.WriteLine("Hit [Enter] to exit");
            Console.ReadLine();

        }
    }
}
