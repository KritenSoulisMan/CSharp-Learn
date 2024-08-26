using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.Days
{
    class Day_5
    {
        public Day_5()
        {
            // 5 Day
            // 
            // Сильно опаздываю по выкладыванию кода, но по прежнему в свободное время делаю всё что мог бы сделать за прошлые дни...
            // Если кто заглянет сюда, можете свои задачи кидать мне в телеграмм: seqjo
            // 
            // Вызов функции запускает её код.
            void PrintMessage()
            {
                Console.WriteLine("Hi");
            }

            PrintMessage();

            // Подготовка к практике:
            void PrintNumber()
            {
                int number = 9;
                Console.WriteLine(number);
            }

            PrintNumber();

            int AddNumber(int a, int b)
            {
                return a + b;
            }

            int result = AddNumber(1, 2);
            Console.WriteLine(result);

            int Add(int a, int b) { return a + b; }

            Console.WriteLine(Add(1, 15));

            double Added(double a, double b) { return a + b; }

            Console.WriteLine(Added(1.12, 1.817));

            void PrintNumbers(params int[] numbers)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            PrintNumbers(1, 2, 3, 4, 5, 6); // Передаём массив.

            void OuterFunction() // Вызов функции внутри которой есть функция, которая больше нигде не используется.
            {
                void InnerFunction()
                {
                    Console.WriteLine("Почему я ни где не используюсь?");
                }

                InnerFunction(); // Вызов вспомогательной функции.
            }

            OuterFunction(); // Вызов первой функции.

            void Multiply()
            {
                int func(int a, int b) { return a * b; }
                Console.WriteLine(func(1, 2));

                double funcion(double a, double b) { return a * b; }
                Console.WriteLine(funcion(1.12, 1.817));
            }

            Multiply();
        }
    }
}
