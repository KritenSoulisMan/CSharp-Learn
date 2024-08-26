using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.Days
{
    class Day_6
    {
        public Day_6()
        {
            // 6 Day - Массивы...

            // 1.Одномерные массивы
            Console.WriteLine("1.Одномерные массивы.");
            int[] numbers = new int[5]; // Объявление массива с 5 элементами
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // Альтернативный способ инициализации
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers);





            // 2.Перебор массива с использованием цикла for
            Console.WriteLine("2.Перебор массива с использованием цикла for.");
            int[] nn = { 1, 2, 3, 4, 5 }; // nn.Length - длина массива nn
            for (int i = 0; i < nn.Length; i++) Console.WriteLine(nn[i]); // Вывод каждого числа из массива nn.






            // 3.Многомерные массивы
            Console.WriteLine("3.Многомерные массивы.");
            // int[,] 
            int[,] matrix = new int[3, 3]; // Объявление двумерного массива 3x3
            matrix[0, 0] = 1; // Двумерный массив под номером 1 0х0
            matrix[0, 1] = 2; // Двумерный массив под номером 2 0х1
            matrix[0, 2] = 3; // Двумерный массив под номером 3 0х2 и т.д.
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            // Альтернативный способ инициализации
            int[,] otherMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine();






            // 4.Перебор многомерного массива
            Console.WriteLine("4.Перебор многомерного массива.");

            int[,] matrixs = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < matrixs.GetLength(0); i++)
            {
                for (int j = 0; j < matrixs.GetLength(1); j++)
                {
                    Console.WriteLine(matrixs[i, j]);
                }
            }






            // 5.Основные операции над массивами
            Console.WriteLine("5.Основные операции над массивами.");

            int[] ns = { 5, 2, 8, 1, 3 };

            // Копирование массива
            int[] copy = new int[ns.Length];
            Array.Copy(ns, copy, ns.Length);

            // Сортировка массива
            Array.Sort(ns);

            // Поиск элемента в массиве
            int index = Array.IndexOf(ns, 8);
            Console.WriteLine("Index of 8: " + index);






            Console.WriteLine("ЗАДАЧИ:");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
