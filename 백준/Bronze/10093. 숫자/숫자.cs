class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        long[] nums = new long[2];
        for(int i = 0; i < input.Length; i++)
        {
            nums[i] = long.Parse(input[i]);
        }
        
        if (nums[0] > nums[1])
        {
            (nums[1], nums[0]) = (nums[0], nums[1]);
        }
        
        if(nums[0] == nums[1] || nums[1] - nums[0] == 1)
        {
            Console.Write("0");
        }
        else
        {
            Console.WriteLine(nums[1] - nums[0] -1);
        

            for(long i= nums[0]+1; i < nums[1]; i++)
            {
                Console.Write($"{i} ");
            }    
        }
    }
}