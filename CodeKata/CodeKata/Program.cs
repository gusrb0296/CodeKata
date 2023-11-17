namespace CodeKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(3);
            solution(4);
        }


        // 1. 짝수와 홀수 문제
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