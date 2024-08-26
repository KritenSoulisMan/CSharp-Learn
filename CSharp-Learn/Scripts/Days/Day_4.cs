using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.Days
{
    class Day_4
    {
        public Day_4()
        {
            // Day 4
            // for - это цикл с обозначением счётчика, условия срабатывания и процесс цикла, а дальше функция для использования заданных перменных в цикле.
            // for (int i = 0; i < 10; i++) Console.WriteLine(i);

            // int i = 0;
            // while - цикл с 1 условием и телом цикла.
            // while (i < 10) Console.WriteLine(i); i++;

            // int i = 0;
            // do while - Цикл который вначале выполняется, а после сравнивает условие для последующего выполнения.
            // do {Console.WriteLine(i); i++;} while (i < 10)





            // Подготовка к практике:
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // Прерывание цикла.
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue; // Переход к следующему шагу.
                }
                Console.WriteLine(i);
            }

            // for (int i = 0; i < 101; i++) Console.WriteLine(i);

            Console.Write("Напишите число: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++) Console.WriteLine(i + " * " + a);

            // int a = 0;
            // while (a < 101) Console.WriteLine(a);
            // do {Console.WriteLine(i + " * " + a); i++;} while (i <= 10)





            // Практика:
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }

            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
