using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        long a, b;
        a = long.Parse(input[0]);
        b = long.Parse(input[1]);

        if (a > b)
        {
            (a, b) = (b, a);
        }

        StringBuilder builder = new StringBuilder();

        if (a == b || b - a == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(b - a - 1);
            for (long i = a + 1; i < b; i++)
            {
                builder.Append($"{i} ");
            }
            Console.Write(builder.ToString());
        }
    }
}