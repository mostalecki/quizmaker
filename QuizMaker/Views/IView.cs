﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    interface IView
    {
        string QuizTitle { get; set; }
        string Question { get; set; }
        string[] Answers { get; set; }
        bool[] IsCorrect { get; set; }
        uint Points { get; set; }
        uint TotalPoints { set; }


    }
}
