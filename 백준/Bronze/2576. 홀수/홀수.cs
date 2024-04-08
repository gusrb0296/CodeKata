class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        int sum = 0;

        for (int i = 0; i < 7; i++)
        {
            nums.Add(int.Parse(Console.ReadLine()));
        }

        List<int> oddNumbers = new List<int>();

        foreach (int num in nums)
        {
            if (num % 2 != 0)
            {
                oddNumbers.Add(num);
            }
        }

        sum = oddNumbers.Sum();
        oddNumbers.Sort();

        if (sum != 0)
        {
            Console.WriteLine(sum);
            Console.WriteLine(oddNumbers[0]);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}