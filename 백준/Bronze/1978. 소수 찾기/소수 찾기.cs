class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[num];

        int count = 0;

        for (int i = 0; i< num; i++)
        {
            numbers[i] = int.Parse(input[i]);

            if (IsPrime(numbers[i]))
            {
                count++;
            }

        }

        Console.WriteLine(count);
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false; // 1 이하면 소수가 아님
        if (number == 2) return true; // 2는 소수

        // 2를 제외한 모든 짝수는 소수가 아님
        if (number % 2 == 0) return false;

        // 3부터 숫자의 제곱근까지 홀수만 검사
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0) return false; // 나누어 떨어지면 소수가 아님
        }

        return true; // 위 조건을 모두 통과하면 소수
    }
}