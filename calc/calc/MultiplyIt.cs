﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class MultiplyIt
    {
        private int answer { get; set; }

        public int Multiplication(ArrayList theNums)
        {
            int x = Convert.ToInt32(theNums[0]);
            int y = Convert.ToInt32(theNums[1]);
            int answer = x * y;
            return answer;
        }
    }
}
