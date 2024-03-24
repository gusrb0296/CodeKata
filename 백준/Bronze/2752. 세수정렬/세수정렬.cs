using System;

class Program
{
    static void Main(string[] args)
    {
        string[] num = Console.ReadLine().Split();
        int[] number = new int[3];
        for(int i = 0; i < 3; i++)
        {
            number[i] = int.Parse(num[i]);
        }        
        Array.Sort(number);
        Console.Write("{0} {1} {2}", number[0], number[1], number[2]);
    }
}