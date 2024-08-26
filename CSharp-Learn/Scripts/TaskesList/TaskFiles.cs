using System;
using System.IO; // Для работы с файлами.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.TaskesList
{
    class TaskFiles
    {
        // path - это путь.
        string path = "example.txt";

        public void FileReader()
        {
            // Запись текста в файл.
            File.WriteAllText(path, "Привет мир!");

            // Чтение контента из файла и вывод его в консоль.
            string content = File.ReadAllText(path);
            Console.WriteLine(content);



            // Можно с помощью массива вписывать несколько разом:
            string[] lines = { "Король шаманов", "Привет мир!", "Где файл?" };
            File.WriteAllLines(path, lines);

            // Вывод каждого элемента из файла.
            string[] ReadLines = File.ReadAllLines(path);
            foreach (string line in ReadLines)
            {
                Console.WriteLine(line);
            }



            // Автоматически запускается и также закрывается.
            using (StreamWriter writer = new StreamWriter(path))
            {
                // Запись по строчно: 
                writer.WriteLine("Привет");
                writer.WriteLine("мир");
            }
            Console.WriteLine(content);

            // Подробная версия в понятном виде:
            StreamWriter writer1 = new StreamWriter(path);
            try
            {
                writer1.WriteLine("Король");
                writer1.WriteLine("шаманов");
                Console.WriteLine(content);
            }
            finally
            {
                Console.WriteLine(content);
                // Освобождение ресурсов для других задач: 
                writer1.Dispose();
            }



            async Task WriteToFileAsync(string path)
            {
                await using (StreamWriter writer = new StreamWriter(path))
                {
                    await writer.WriteLineAsync("Привет");
                    await writer.WriteLineAsync("мир");
                    Console.WriteLine(content);
                }
            }
            /*
             * Конструкция using упрощает управление ресурсами, автоматически освобождая их после использования.
             * Асинхронное программирование с async/await позволяет выполнять длительные задачи в фоновом режиме, сохраняя отзывчивость программы.
             * Асинхронный using нужен, когда работаешь с ресурсами в асинхронном контексте и требуется асинхронное освобождение этих ресурсов.
            */
        }
    }
}
