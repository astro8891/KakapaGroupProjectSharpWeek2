using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFlash
{
    class PlayMathFlash
    {
        ViewMathFlash view = new ViewMathFlash();
        List<MathFlash> _MathFlash = new List<MathFlash>();
        string Operator;

        public void Run()
        {
            Operator = view.GetOperator();
            if (Operator != "+" && Operator != "-") { Operator = view.GetOperator(); }


        }
        public void AddToList()
        {
            //_MathFlash.Add(new MathFlash( ));
        }
    }
}
