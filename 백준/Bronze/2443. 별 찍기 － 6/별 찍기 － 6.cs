class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        for(int i = 1; i < num+1; i++)
        {
            for (int k = num - i; k < num-1; k++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < num*2 - (2*i-1);  j++)
            {
                Console.Write("*");
            }                
            
            Console.WriteLine();
        }
    }
}