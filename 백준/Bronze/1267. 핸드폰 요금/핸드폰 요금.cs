internal class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        string[] time = Console.ReadLine().Split();
        
        int[] times = new int[count];

        for(int i = 0; i < count; i ++)
        {
            times[i] = int.Parse(time[i]);
        }

        int sumY = 0, sumM = 0;

        for(int i = 0; i < times.Length; i++)
        {
            sumY += (times[i] / 30 + 1) * 10;
        }
        
        for(int i = 0; i < times.Length; i++)
        {
            sumM += (times[i] / 60 + 1) * 15;
        }

        
        if(sumY < sumM)
        {
            Console.Write("Y ");
            Console.Write(sumY);
        }
        else if(sumY == sumM)
        {
            Console.Write("Y M ");
            Console.Write(sumY);
        }
        else
        {
            Console.Write("M ");
            Console.Write(sumM);
        }

    }
}