 class Program
 {
     static void Main(string[] args)
     {
         int num = int.Parse(Console.ReadLine());

         for(int i = 1; i < num+1; i++)
         {
             for(int j = i; j < num; j++)
             {
                 Console.Write(" ");
             }
             
             for(int k = 0; k < i * 2 - 1; k++)
             {
                 Console.Write("*");
             }
             Console.WriteLine();
         }
     }
 }