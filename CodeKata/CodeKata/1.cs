using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    // 1번 문제. 
    // 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 soltuion 함수를 완성해주세요.

    internal class _1
    {
        public int Solution(int num1, int num2)
        {
            int answer = 0;

            answer = num1 - num2;

            Console.WriteLine(answer);

            return answer;
        }
    }
}
