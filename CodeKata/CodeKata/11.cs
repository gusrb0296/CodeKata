using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    internal class _11  
    {
        static public string solution(int num)
        {
            string answer = "";

            if (num % 2 == 0)
            {
                answer = "Even";
            }
            else
                answer = "Odd";

            Console.WriteLine(answer);

            return answer;
        }
    }
}
