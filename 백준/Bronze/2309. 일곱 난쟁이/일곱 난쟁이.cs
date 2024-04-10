class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        List<int> numbers = new List<int>();
        for (int i = 0; i < 9; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
            sum+= numbers[i];
        }

        int differ = sum - 100;
        int exception1 = 0, exception2 = 0;

        numbers.Sort();

        for (int i = 0; i < numbers.Count-1; i++)
        {
            for(int j = i + 1; j < numbers.Count; j++) 
            {
                if (numbers[i] + numbers[j] == differ)
                {
                    exception1 = i;
                    exception2 = j;
                    break;
                }
            }
        }

        for (int i= 0; i < numbers.Count; i++)
        {
            if(i == exception1 || i == exception2)
            {
                continue;
            }
            Console.WriteLine(numbers[i]);
        }    
    }
}