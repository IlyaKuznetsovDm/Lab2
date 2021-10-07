using System;

namespace Лаб_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Высокий уровень - 8 вариант
                Console.WriteLine("Введите первый катет");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второй катет");
                double c;
                double b = double.Parse(Console.ReadLine());
                c = Math.Sqrt(Math.Pow(a, 2) * (Math.Pow(b, 2)));
                Console.WriteLine("Гипотенуза равна {0}", c);
                double S = (a * b / 2);
                Console.WriteLine("Площадь равна {0}", S);
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно перменную");
            }   
        }       
    }
}
