class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[3];

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            
            for(int i = 0; i < num.Length; i ++)
            {
                num[i] = int.Parse(input[i]);
            }

            if (num[0] == 0 && num[1] == 0 && num[2] == 0)
            {
                return;
            }
            
            Array.Sort(num);

            if (num[0]* num[0] + num[1] * num[1] == num[2] * num[2])
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }
    }
}