using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первую переменную уравнения (а): ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Неверный символ");
                    Console.Write("Повторный ввод: ");
                }
                Console.Write("Введите вторую переменную уравнения (b): ");
                int b;
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Неверный символ");
                    Console.Write("Повторный ввод: ");
                }
                Console.Write("Введите третью переменную уравнения (c): ");
                int c;
                while (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Неверный символ");
                    Console.Write("Повторный ввод: ");
                }
                double result;
                double result2;
                int diskr;
                diskr = b * b - 4 * a * c;
                if (diskr < 0)
                {
                    Console.WriteLine("Дискриминант отрицательный, уравнение не имеет действительных решений");
                    Console.WriteLine("");
                }
                else
                {
                    if (diskr == 0)
                    {
                        result = (-(b) + Math.Sqrt(diskr)) / (2 * a);
                        Console.WriteLine("Решение уравнения: "+ result);
                        Console.WriteLine("");
                    }
                    else
                    {
                        result = (-(b) + Math.Sqrt(diskr)) / (2 * a);
                        Console.WriteLine("Первое решение: " + result);
                        result2 = (-(b) - Math.Sqrt(diskr)) / (2 * a);
                        Console.WriteLine("Второе решение: " + result2);
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}

