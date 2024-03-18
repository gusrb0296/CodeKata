class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        
        if(num >= 90)
        {
            Console.WriteLine("A");
        }
        else if (num >= 80)
        {
            Console.WriteLine("B");
        }
        else if(num >= 70)
        {
            Console.WriteLine("C");
        }
        else if(num >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}