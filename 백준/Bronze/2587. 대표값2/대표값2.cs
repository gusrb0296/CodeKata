class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = (int.Parse(Console.ReadLine()));
            sum+= numbers[i];
        }
        
        Array.Sort(numbers);
        
        Console.WriteLine(sum/5);
        Console.WriteLine(numbers[2]);            
    }
}