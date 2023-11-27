namespace CodeKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int answer = 0;
            int n = 5;
            long[] answer = new long[n];
            int x = 2;
            
            int temp = x;
            for (int i = 0; i < n; i++)
            {
                answer[i] = x;
                x += temp;
            }

            foreach (var a in answer)
            {
                Console.WriteLine(a);
            }

        }
    }
}