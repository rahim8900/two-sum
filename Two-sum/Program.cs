using System;
namespace Two_sum
{
    internal class Program
    {
        static void Main()
        {
            int target = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(',');
            int i, j;
            int r1 = 0;
            int r2 = 0;
            for (i = 0; i < input.Length; i++)
            {
                for (j = 0; j < input.Length; j++)
                {
                    if ((i != j) && ((int.Parse(input[i]) + int.Parse(input[j])) == target))
                    {
                        r1 = i;
                        r2 = j;
                    }
                }
            }
            Console.WriteLine($"[{r2}, {r1}]");
            Console.ReadKey();
        }
    }
}
