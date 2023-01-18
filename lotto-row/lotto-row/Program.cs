using System;

namespace lotto_row
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                for (int i = 0; i < 7; i++)
                {
                    Random rand = new Random();
                    int lottoNumber = rand.Next(0, 36);
                    Console.Write(lottoNumber + " ");
                }
            Console.WriteLine();
            }
        }
    }
}
