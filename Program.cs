/**************************************************************************************************************
/* Практическая работа №3                                                                                     *
/* Выполнила: Вохмянина А.Р., 2-ИСП                                                                           *
/* Задание:составить программу работы алгоритма усложненного ветвления с обработкой ошибок времени выполнения *
/**************************************************************************************************************/
using System;

namespace работа_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа_6.\n Здравствуйте!";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            int n, a, b, c;
            Console.WriteLine("Проверка трехзначного числа");
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < 100 || n > 999)
                {
                    Console.WriteLine("Ошибка! Число должно быть трехзначным.");
                }
                else
                {
                    //Выделяем цифры числа
                    a = n / 100;
                    b = (n / 10) % 10;
                    c = n % 10;
                    Console.WriteLine("Первая цифра: " + a);
                    Console.WriteLine("Вторая цифра: " + b);
                    Console.WriteLine("Третья цифра: " + c);

                    // Проверяем образование геометрической прогрессии
                    if (b * b == a * c)
                    {
                        Console.WriteLine("Цифры образуют геометрическую прогрессию: ");
                    }
                    else
                    {
                        Console.WriteLine("Цифры не образуют геометрическую прогрессию: ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так. Ошибка: " + e.Message);
            }
            Console.ReadKey();

        }
    }
}
