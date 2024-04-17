class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        for(int i = 0; i < num; i++)
        {
            for(int j = num-1; j > i; j--)
            {
                Console.Write(" ");
            }
            for(int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}