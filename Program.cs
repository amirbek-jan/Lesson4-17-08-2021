using System;

namespace Lesson4ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 2A
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = a + 1; i < b; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{sum}");

            // 2B
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}");
                    Console.Write(" ");
                }
            }
            
            // 3A
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
                for (int j = 1; j < 20; j++)
                {
                    if (i % 4 == 0)
                    {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.Write("\n");
            }
            
            // 3B
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    if (i % 9 == 0) {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
                if (i != 0) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            // 3C 
            int n = 5;
            int k = -1;
            for (int i = 0; i < n; i++){
                for (int j = 1; j < n - i; j++){
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < k; j++)
                {
                    if (i % 4 == 0 && j % 2 != 0)
                    {
                        Console.Write("*");
                    } else {
                        Console.Write(" ");
                    }
                }
                if (i != 0)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                k += 2;
            }
            
            // 3D
            int n = 9;
            int k = -1;
            int m = 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < Math.Abs(i - 4); j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }
                if (i == 4)
                {
                    m = -2;
                }
                if (i % 8 != 0)
                {
                    Console.Write("*");
                }
                k += m;
                Console.Write("\n");
            }
            

            // 4
            int p = int.Parse(Console.ReadLine());
            int price = 1000;
            int k = 0;
            while (price < 1100)
            {
                k++;
                price += (price * p) / 100;
            }
            Console.WriteLine($"{k} {price}");
        }
    }
}