using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Init(out int a, out int b)
        {
            Console.Write("Введите первое чиcло: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите второе чиcло: ");
            b = Int32.Parse(Console.ReadLine());
        }

        static void Bank (ref double sum, bool bonus = false)
        {
            double percent;
            if (sum < 100)
                percent = 0.05;
            else if (sum < 200)
                percent = 0.07;
            else
                percent = 0.1;
            Console.Write($"Процент по вкладу составит: {sum * percent}. ");
            sum += sum * percent;
            if (bonus == true)
            {
                Console.Write($"Бонус банка: 15. ");
                sum += 15;
            }
            Console.WriteLine($"Общая сумма: {sum}");
        }
        static void Main(string[] args)
        {
            //Задание 1
            /*
            int x, y;
            Init(out x, out y);
            if (x == y)
                Console.WriteLine($"Число {x} равно числу {y}");
            else if (x > y)
                Console.WriteLine($"Число {x} больше числа {y}");
            else
                Console.WriteLine($"Число {x} меньше числа {y}");
            */


            //Задание 2
            /*
            Console.Write("Введите чиcло: ");
            int z = Int32.Parse(Console.ReadLine());
            if (z > 5 && z < 10)
            {
                Console.WriteLine("Данное число находиться в промежутке от 5 до 10");
            }
            else
                Console.WriteLine("Данное число НЕ находиться в промежутке от 5 до 10");
            */


            //Задания 3, 4
            Console.Write("Какую сумму вы готовы положить в банк: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Bank(ref sum, true);
        }
    }
}
