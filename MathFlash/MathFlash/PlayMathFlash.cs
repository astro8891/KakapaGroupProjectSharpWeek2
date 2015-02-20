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

        string _operator;
        string _userSays;
        int _number1;
        int _number2;
        int _answer;
        int _attempts;

        public void Run()
        {
            _operator = view.GetOperator();
            if (_operator != "+" && _operator != "-") { _operator = view.GetOperator(); }
            AddToList();
            GetAnswer();
            while (_userSays != "")
            {
                _userSays = view.UserPlay(_operator, _number1, _number2);

                if ()
                {
                    
                }

                while (_userSays != _answer.ToString())
                {
                    if (_attempts != 3) { _userSays = view.Incorrect(); _attempts++; }
                    else { _attempts = 0; goto NextProb; }
                }
                view.Correct();
            NextProb: ;
                AddToList();
                GetAnswer();
            }
        }
        public void AddToList()
        {
            _number1 = RandomNum();
            _number2 = RandomNum();
            _MathFlash.Add(new MathFlash(_operator, _number1, _number2, _answer));
        }
        public void GetAnswer()
        {
            switch (_operator)
            {
                case "+":
                    _answer = _number1 + _number2;
                    break;
                case "-":
                    _answer = _number1 - _number2;
                    break;
            }
        }
        public int RandomNum()
        {
            return rnd.Next(0, 9);
        }

        public bool CheckInput(string userinput)
        {

        }
         
     
    }
}
