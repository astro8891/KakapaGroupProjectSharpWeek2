using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFlash
{
    class MathFlash
    {
        public string Operator { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Answer {get;set; }

        public MathFlash(string Operator, int Number1, int Number2, int Answer)
        {
            this.Operator = Operator;
            this.Number1 = Number1;
            this.Number2 = Number2;
            this.Answer = Answer;
        }

    }
}

