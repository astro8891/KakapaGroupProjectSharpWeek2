using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFlash
{
    class PlayMathFlash
    {
        Random rnd = new Random();
        ViewMathFlash view = new ViewMathFlash();
        List<MathFlash> _MathFlash = new List<MathFlash>();
        string Operator;
        string UserSays;
        int number1;
        int number2;
        int Answer;
        int Attempts;

        public void Run()
        {
            Operator = view.GetOperator();
            if (Operator != "+" && Operator != "-") { Operator = view.GetOperator(); }
            AddToList();
            GetAnswer();
            while (UserSays != "")
            {
                UserSays = view.UserPlay(Operator, number1, number2);
                while (UserSays != Answer.ToString())
                {
                    if (Attempts != 3) { UserSays = view.Incorrect(); Attempts++; }
                    else { Attempts = 0; goto NextProb; }
                }
                view.Correct();
            NextProb: ;
                AddToList();
                GetAnswer();
            }
        }
        public void AddToList()
        {
            number1 = RandomNum();
            number2 = RandomNum();
            _MathFlash.Add(new MathFlash(Operator, number1, number2, Answer));
        }
        public void GetAnswer()
        {
            switch (Operator)
            {
                case "+":
                    Answer = number1 + number2;
                    break;
                case "-":
                    Answer = number1 - number2;
                    break;
            }
        }
        public int RandomNum()
        {
            return rnd.Next(0, 9);
        }

    }
}
