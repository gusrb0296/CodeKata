﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    internal class _05
    {
        public int solution(int num1, int num2)
        {
            int answer;

            answer = num1 == num2 ? 1 : -1;

            return answer;
        }
    }
}
