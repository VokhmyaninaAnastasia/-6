//**************************************************************************************************************
//* Практическая работа №6                                                                                     *
//* Выполнила: Вохмянина А.Р., 2-ИСП                                                                           *
//* Задание:составить программу работы алгоритма усложненного ветвления с обработкой ошибок времени выполнения *
//**************************************************************************************************************
using System;

namespace работа_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа 6.";
            Console.WriteLine("Здравствуй!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            int n, a, b, c;
            Console.Write("Проверка трехзначного числа: ");
            try
            {
                n = Int32.Parse(Console.ReadLine());
                switch (n >= 100 && n <= 999)
                {
                    case true:
                        //Выделяем цифры числа
                        a = n / 100;
                        b = (n / 10) % 10;
                        c = n % 10;
                        Console.WriteLine("Первая цифра: " + a);
                        Console.WriteLine("Вторая цифра: " + b);
                        Console.WriteLine("Третья цифра: " + c);

                        // Проверяем образование геометрической прогрессии
                        switch (b * b == a * c)
                        {
                            case true:
                                Console.WriteLine("Цифры образуют геометрическую прогрессию. ");
                                break;
                            case false:
                                Console.WriteLine("Цифры не образуют геометрическую прогрессию. ");
                                break;
                        }
                        break;
                    case false:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка! Число должно быть трехзначным.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            catch(FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка!" + fex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch(OverflowException oex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка!" + oex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что-то пошло не так. Ошибка: " + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();

        }
    }
}