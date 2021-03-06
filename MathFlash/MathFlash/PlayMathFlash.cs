﻿using System;
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
        public int Score { get; set; }
        public int AttemptsTotal { get; set; }

        string _operator;
        string _userSays;
        int _number1;
        int _number2;
        int _answer;
        int _attempts;

        public void Run()
        {
            view.HelloUser();
            _operator = view.GetOperator();
            if (_operator != "+" && _operator != "-") { _operator = view.GetOperator(); }
            RandomNum();
            AddToList();
            GetAnswer();
            while (_userSays != "")
            {
                _userSays = view.UserPlay(_operator, _number1, _number2);
                while (_userSays != _answer.ToString())
                {
                    AttemptsTotal++;
                    if (_attempts != 3) 
                    { 
                        _userSays = view.Incorrect(); 
                        _attempts++; 
                        AttemptsTotal++; 
                    }
                    else 
                    {
                        _attempts = 0; 
                        goto NextProb;
                    }
                }
                Score++;
                view.Correct();
                NextProb: ;
                RandomNum();
                GetAnswer();
                AddToList();
            }
            view.WriteFinalScore(Score, AttemptsTotal);
        }
        public void AddToList()
        {
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
                default:
                    view.InputError();
                    _operator = view.GetOperator();
                    GetAnswer();
                    break;
            }
        }
        public void RandomNum()
        {
            _number1 = rnd.Next(0, 9);
            _number2 = rnd.Next(0, 9);
        }
    }
}
