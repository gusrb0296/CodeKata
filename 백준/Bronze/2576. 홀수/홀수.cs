internal class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        int sum = 0;
        int min = int.MaxValue;

        for (int i = 0; i < 7; i++)
        {
            nums.Add(int.Parse(Console.ReadLine()));
            if (nums[i] % 2 != 0)
            {
                sum += nums[i];

                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
        }

        if (sum != 0)
        {
            Console.WriteLine(sum);
            Console.WriteLine(min);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}