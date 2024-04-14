class Program
{
    static void Main(string[] args)
    {
        int[] cards = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int[,] numberPairs = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split();
            numberPairs[i, 0] = int.Parse(parts[0]);
            numberPairs[i, 1] = int.Parse(parts[1]);
            
            if(numberPairs[i, 0] > numberPairs[i, 1])
            {
                (numberPairs[i, 0], numberPairs[i, 1]) = (numberPairs[i, 1], numberPairs[i, 0]);
            }
            
            Array.Reverse(cards, numberPairs[i, 0]-1, numberPairs[i, 1] - numberPairs[i, 0] + 1);
        }

        foreach(int i in cards)
        {
            Console.Write($"{i} ");
        }

    }
}