using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Number_of_Fibonachi
{
    internal class Program
    {

        static int FRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FRecursive(n - 1) + FRecursive(n - 2);
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Выберите метод:\n1 - Рекурсия\n2 - Итерация:\n");
            Console.Write("Ur choice: ");
            int x = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (x)
                {
                    case 1:
                        Console.Write("Введите N: ");
                        int n = int.Parse(Console.ReadLine());

                        int startTicks = Environment.TickCount;
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write($"{FRecursive(i)}\n");
                        }

                        int endTicks = Environment.TickCount;
                        double elapsedTimeInSeconds = (endTicks - startTicks) / 1000.0;

                        Console.WriteLine($"Время выполнения: {elapsedTimeInSeconds:F2} сек");
                        break;
                }

                
            }
        }
    }
}



