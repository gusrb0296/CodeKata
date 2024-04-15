using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int T;

        T = int.Parse(Console.ReadLine());

        string a = "hello";
        StringBuilder stringBuilder = new StringBuilder();
        int Sum;

        for(int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            Sum = int.Parse(input[0]) + int.Parse(input[1]);
            stringBuilder.Append(Sum + "\n");

        }

        Console.WriteLine(stringBuilder.ToString());

    }
}