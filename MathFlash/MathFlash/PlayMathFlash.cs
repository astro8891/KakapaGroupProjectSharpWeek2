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

        private int Score { get; set; }
        private int NumberOfQuestions { get; set; }
        private int Attempts { get; set; }

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
            RandomNum();
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
                    else { _attempts = 0; Score++; NumberOfQuestions++; goto NextProb; }
                }
                view.Correct();
            NextProb: ;
                RandomNum();
                GetAnswer();
                AddToList();
            }
            view.WriteFinalScore(NumberOfQuestions, Score, Attempts);
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
                case "previous":
                     _number1 = _MathFlash[_MathFlash.Count - 1].Number1;
                     _number2 = _MathFlash[_MathFlash.Count - 1].Number2;
                     _answer = _MathFlash[_MathFlash.Count - 1].Answer;
                    break;
                //case "next":
                    
                //    break;
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
        public bool CheckInput(string userinput)
        {

        }
        
    }
}
