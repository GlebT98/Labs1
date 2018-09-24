using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Prov (bool test)
        {
            if (!test)
            {
                Console.WriteLine("Неверный символ");
                Console.Write("Повторный ввод: ");
            }
        }

        static void Main(string[] args)
        {
            int h, w, r, sq;
            bool test;
            Console.WriteLine("Введите размеры фигур");
            Console.Write("Высота прямоугольника: ");
            test = (int.TryParse(Console.ReadLine(), out h));
            Prov (test);
            Console.Write("Ширина прямоугольника: ");
            test = (int.TryParse(Console.ReadLine(), out w));
            Prov(test);
            Console.Write("Сторона квадрата: ");
            test = (int.TryParse(Console.ReadLine(), out sq));
            Prov(test);
            Console.Write("Радиус круга: ");
            test = (int.TryParse(Console.ReadLine(), out r));
            Prov(test);
            Console.WriteLine();

            Rectangle rectangl = new Rectangle(w, h);
            Square square = new Square (sq);
            Circle circle = new Circle(r);

            rectangl.Print();
            square.Print();
            circle.Print();

            Console.ReadLine();
        }
    }
}