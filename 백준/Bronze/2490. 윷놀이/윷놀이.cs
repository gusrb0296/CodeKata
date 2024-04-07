class Program
{
    static void Main(string[] args)
    {
        string[] one = Console.ReadLine().Split();
        string[] two = Console.ReadLine().Split();
        string[] three = Console.ReadLine().Split();

        Calculate(one);
        Calculate(two);
        Calculate(three);
    }

    static void Calculate(string[] list)
    {
        int result = 0;
        int[] nums = new int[list.Length];
        for(int i = 0; i < list.Length; i++)
        {
            nums[i] = int.Parse(list[i]);
            result += nums[i];
        }

        PrintResult(result);
    }

    static void PrintResult(int result)
    {
        switch (result)
        {
            case 0: Console.WriteLine("D");
                break;
            case 1: Console.WriteLine("C");
                break;
            case 2: Console.WriteLine("B");
                break; 
            case 3: Console.WriteLine("A");
                break;
            case 4: Console.WriteLine("E");
                break;
        }
    }
}