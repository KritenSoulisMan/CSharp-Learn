using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.Days
{
    class Day_1
    {
        public Day_1()
        {
            // 1 Day

            // Переменные
            int aa = 10;
            double bb = 5.1;
            char cc = 'a';
            string dd = "Hello";
            bool booling = true;
            Console.WriteLine(aa + bb);
            Console.WriteLine(cc);
            Console.WriteLine(dd);
            Console.WriteLine(booling);

            // Ввод, вывод текста в консоль.
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "!");

            // Условия для выполнения некоторого кода.
            int num = 1;

            if (num > 0)
            {
                Console.WriteLine("Позитив");
            }
            else if (num < 0)
            {
                Console.WriteLine("Негатив");
            }
            else
            {
                Console.WriteLine("Ноль");
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine("Один");
                    break;
                case 2:
                    Console.WriteLine("Два");
                    break;
                default:
                    Console.WriteLine("Это явно другое число...");
                    break;
            }

            // Циклы
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("For loop: " + i);
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("While loop: " + j);
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine("Do-while loop: " + k);
                k++;
            }
            while (k < 5);






            /*
             * В структуре int есть следующие методы:
             * 
             * 1. int.Equals() — используется для проверки, равны ли два объекта int. Возвращает логическое значение.
             * 2. int.Parse() — используется для преобразования или анализа строки в int.
             * 3. int.MaxValue — возвращает максимальное возможное значение переменной int.
             * 4. int.MinValue — возвращает миниимальное возможное значение переменной int.
             * 
            */

            // Задание 1: Напишите программу, которая запрашивает у пользователя два числа, складывает их и выводит результат на экран. (Выполнено)

            Console.Write("1-е число: "); // Пользовательский ввод числа.
            int c = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.

            Console.Write("2-е число: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine(c + d); // Вывод суммы






            // Задание 2: Напишите программу, которая запрашивает у пользователя число и определяет, является ли оно четным или нечетным. (Выполнено)

            Console.Write("Напишите число: "); // Пользовательский ввод числа.
            int number = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.

            if (number % 2 == 0) // Если число чётное.
            {
                Console.WriteLine("Число четное.");
            }
            else // Если число не чётное.
            {
                Console.WriteLine("Число не четное.");
            }






            // Задание 3: Напишите программу, которая выводит таблицу умножения для чисел от 1 до 10. (Выполнено)

            for (int i = 1; i < 11; i++) // Задаём условия (int чему число равно; Минимум или максимум; Уменьшение или увеличение числа)
            {
                for (int abc = 1; abc <= 10; abc++)
                {
                    Console.WriteLine($"{i} * {abc} = {i * abc}");
                }
            }






            // Задание 4: Напишите программу, которая запрашивает у пользователя три числа и выводит наибольшее из них. (Выполнено)

            Console.Write("1-е число: "); // Пользовательский ввод числа.
            int e = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.

            Console.Write("2-е число: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("3-е число: ");
            int g = int.Parse(Console.ReadLine());

            if (e < f)
            {
                if (f < g)
                {
                    Console.WriteLine("Это число наибольшее: " + c);
                }
                else if (g < e)
                {
                    Console.WriteLine("Это число наибольшее: " + f);
                }
            }

            else if (f < e)
            {
                if (f < g)
                {
                    Console.WriteLine("Это число наибольшее: " + c);
                }
                else if (g < e)
                {
                    Console.WriteLine("Это число наибольшее: " + f);
                }
            }

            else if (e < g)
            {
                if (f < g)
                {
                    Console.WriteLine("Это число наибольшее: " + c);
                }
                else if (f < e)
                {
                    Console.WriteLine("Это число наибольшее: " + f);
                }
            }






            // Задание 5: Напишите программу, которая запрашивает у пользователя число N и считает сумму чисел от 1 до N.. (+- Выполнено)

            Console.Write("Напишите целое число (не меньше 1): "); // Пользовательский ввод числа.
            int n = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
