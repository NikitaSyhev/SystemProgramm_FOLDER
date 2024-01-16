using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace HW_Threads_FileStream
{
    internal class Program
    {

        private static readonly object lockObject = new object(); // объект блокировки потоков
        private static bool generationComplete = false; // переменная для отслеживания генерации числе в одном потоке, false = генерация не завершена, true - завершена

        static void Main(string[] args)
        {
            // Создаем потоки
            Thread generatorThread = new Thread(GenerateNumbers); // в поток пробрасываем методы
            Thread sumThread = new Thread(CalculateSum);
            Thread productThread = new Thread(CalculateProduct);

            // Запускаем потоки
            generatorThread.Start();
            sumThread.Start();
            productThread.Start();

            // Ждем завершения всех потоков
            generatorThread.Join(); // Join() обеспечивает ожидание завершения всех потоков перед тем, как программа продолжит выполнение кода далее. 
            sumThread.Join();
            productThread.Join();

            Console.WriteLine("Генерация, суммирование и умножение завершены.");
        }
        static void GenerateNumbers() // метод для генерации случайных чисел
        {
            // Генерация и сохранение пар чисел в файл
            lock (lockObject)
            {
                using (StreamWriter writer = new StreamWriter("numbers.txt")) // записали случайные числа в файл
                {
                    Random random = new Random();

                    for (int i = 0; i < 10; i++)
                    {
                        int num1 = random.Next(1, 100);
                        int num2 = random.Next(1, 100);
                        writer.WriteLine($"{num1},{num2}"); //запись в файл
                    }

                    generationComplete = true;
                }
            }
        }
        static void CalculateSum() //метод для подсчета суммы случайных чисел и записи их в файл
        {
            // Ожидание завершения генерации
            while (!generationComplete) // пока цикл не станет true, цикл выполняется, цикл нужен для ожидания завершения генерации чисел
            {
                Thread.Sleep(100);
            }

            // Подсчет суммы каждой пары и запись в файл
            lock (lockObject)
            {
                using (StreamWriter writer = new StreamWriter("sums.txt")) //запись
                using (StreamReader reader = new StreamReader("numbers.txt")) //чтение
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // считывание построчно
                    {
                        string[] numbers = line.Split(','); // разбивка на массив строк
                        int num1 = int.Parse(numbers[0]); // преобразовали считанные данные в инты
                        int num2 = int.Parse(numbers[1]);
                        int sum = num1 + num2; //получили результат
                        writer.WriteLine($"Сумма: {sum}"); //записали в файл
                    }
                }
            }
        }
        static void CalculateProduct() // метод для подсчета произведения пары чисел и запись их в файл
        {
            // Ожидание завершения генерации
            while (!generationComplete)
            {
                Thread.Sleep(100);
            }

            // Подсчет произведения каждой пары и запись в файл
            lock (lockObject)
            {
                using (StreamWriter writer = new StreamWriter("products.txt"))
                using (StreamReader reader = new StreamReader("numbers.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] numbers = line.Split(',');
                        int num1 = int.Parse(numbers[0]);
                        int num2 = int.Parse(numbers[1]);
                        int product = num1 * num2;
                        writer.WriteLine($"Произведение: {product}");
                    }
                }
            }
            Console.ReadLine();
        }
    }

    }
    

