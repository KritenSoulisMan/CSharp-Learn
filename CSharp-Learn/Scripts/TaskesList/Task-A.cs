using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.TaskesList
{
    class Task_A
    {
        public void Tasks11()
        {
            // Задача 1: Напишите программу, которая запрашивает у пользователя два целых числа и выводит их сумму, разность, произведение и частное.
            Console.WriteLine("Задача 1: Напишите программу, которая запрашивает у пользователя два целых числа и выводит их сумму, разность, произведение и частное.");

            Console.WriteLine("Напишите 1-е число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Напишите 2-е число: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Напишите арифметический знак: ");
            string c = Console.ReadLine();
            switch (c)
            {
                case "-":
                    int dum = a - b;
                    Console.WriteLine(dum);
                    break;

                case "+":
                    int sum = a + b;
                    Console.WriteLine(sum);
                    break;

                case "*":
                    int umn = a * b;
                    Console.WriteLine(umn);
                    break;

                case "/":
                    int del = a / b;
                    Console.WriteLine(del);
                    break;
            }






            // Задача 2: Напишите программу, которая запрашивает у пользователя его возраст и выводит сообщение с указанием, является ли он совершеннолетним.
            Console.WriteLine("Задача 2: Напишите программу, которая запрашивает у пользователя его возраст и выводит сообщение с указанием, является ли он совершеннолетним.");

            Console.WriteLine("Напишите свой возраст: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0) Console.WriteLine("Неверный возраст!");
            else if (age < 18) if (age > 0) Console.WriteLine("Вы ещё не совершено-летний человек.");
                else Console.WriteLine("Вы совершено-летний!");






            // Задача 3: Напишите программу, которая запрашивает у пользователя число и определяет, является ли оно четным или нечетным.
            Console.WriteLine("Задача 3: Напишите программу, которая запрашивает у пользователя число и определяет, является ли оно четным или нечетным.");

            Console.WriteLine("Напишите число: ");
            int numc = int.Parse(Console.ReadLine());

            if (numc % 2 == 0) Console.WriteLine("Число четное!");
            else Console.WriteLine("Число нечетное!");






            // Задача 4: Напишите программу, которая определяет, является ли введенное пользователем число положительным, отрицательным или нулем.
            Console.WriteLine("Задача 4: Напишите программу, которая определяет, является ли введенное пользователем число положительным, отрицательным или нулем.");

            Console.WriteLine("Напишите число: ");
            int chislo = int.Parse(Console.ReadLine());

            if (chislo == 0) Console.WriteLine("Число является нулём.");
            if (chislo > 0) Console.WriteLine("Число положительное.");
            else Console.WriteLine("Число отрицательное.");






            // Задача 5: Напишите программу, которая выводит все числа от 1 до 100, которые делятся на 3.
            Console.WriteLine("Задача 5: Напишите программу, которая выводит все числа от 1 до 100, которые делятся на 3.");

            for (int i = 0; i <= 100; i++) if (i % 3 == 0) Console.WriteLine(i);






            // Задача 6: Напишите программу, которая запрашивает у пользователя 5 чисел и выводит их среднее значение.
            Console.WriteLine("Задача 6: Напишите программу, которая запрашивает у пользователя 5 чисел и выводит их среднее значение.");

            Console.WriteLine("Напишите каждое число отдельно, используйте для разделения Enter.");
            int ac = int.Parse(Console.ReadLine());
            int bc = int.Parse(Console.ReadLine());
            int cc = int.Parse(Console.ReadLine());
            int ec = int.Parse(Console.ReadLine());
            int fc = int.Parse(Console.ReadLine());

            int umnc = (ac + bc + cc + ec + fc) / 5;
            Console.WriteLine(umnc);






            // Задача 7: Напишите функцию, которая принимает строку и возвращает ее длину.
            Console.WriteLine("Задача 7: Напишите функцию, которая принимает строку и возвращает ее длину.");

            Console.WriteLine("Напишите предложение:");
            string words = Console.ReadLine();
            foreach (var f in words)
            {
                for (int i = 0; i <= words.Length; i++)
                {
                    Console.WriteLine(i);
                }
            }






            // Задача 8: Напишите программу, которая запрашивает у пользователя 10 чисел и сохраняет их в массиве.
            // Затем программа должна найти и вывести наибольшее и наименьшее число в массиве.

            // Задача 9: Напишите программу, которая создает двумерный массив 5x5 и заполняет его случайными числами.
            // Затем программа должна найти и вывести сумму всех элементов массива.

            // Задача 10: Напишите программу, которая запрашивает у пользователя количество студентов в классе, а затем запрашивает оценки каждого студента.
            // Программа должна вывести среднюю оценку класса.
            Console.WriteLine("Задача 10: Напишите программу, которая запрашивает у пользователя количество студентов в классе.\n" +
                "Затем запрашивает оценки каждого студента.\n" +
                "Программа должна вывести среднюю оценку класса.");

            var HumonGGCount = new List<string>(); // Записываем количество учеников.

            Console.WriteLine("Напишите количество учеников в классе");
            var Humons = Console.ReadLine();
            var arg1 = Humons.Split(' ');
            HumonGGCount.Add(Humons);

            for (int i = 1; i <= HumonGGCount.Count; i++)
            {
                Console.WriteLine("Напишите оценки (через пробел) ученика под номером " + i + ".");
                var str = Console.ReadLine();
                var arg2 = str.Split(' ');
            }

            // Задача 11: Напишите программу, которая создает двумерный массив и выводит его в виде таблицы.
            // Затем находит и выводит сумму элементов каждой строки и каждого столбца.
        }
    }
}
