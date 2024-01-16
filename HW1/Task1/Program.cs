using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library2;
using Library3;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание номер 1:");
            double resultQuadrat = MyLibrary.MyLibrary.squareQuadrat(4, 4); // подключили DLL My Library через References 
            //здесь ошибка в том, что в DLL я namespase и название класса назвал одинаково, поэтому выглядит некрасиво ( MyLibrary.MyLibrary)
            Console.WriteLine($"Площадь квадрата: {resultQuadrat}");
            double resultReactangle = MyLibrary.MyLibrary.squareRectangle(4,4);
            Console.WriteLine($"Площадь прямоугольника: {resultReactangle}");
            double resultTriangle = MyLibrary.MyLibrary.squareTriangle(2, 4);
            Console.WriteLine($"Площадь треугольника: {resultTriangle}\n");

            Console.WriteLine("Задание номер 2:");

            string testPalindrome = "Мама";
            string testSentences = "Мама пошла в магазин.";

            // Подключение библиотеки и использование методов
            bool isPalindrome = Task2.IsPalindrome(testPalindrome);
            int sentenceCount = Task2.CountSentences(testSentences);
            string reversedString = Task2.ReverseString(testSentences);

            // Вывод результатов
            Console.WriteLine($"Слово '{testPalindrome}' палиндром? {isPalindrome}");
            Console.WriteLine($"Количество предложений в фразе: '{testSentences}': {sentenceCount}");
            Console.WriteLine($"Читаем предложение задом наперед: {reversedString}\n");

            Console.WriteLine("Задание номер 3:");

            //данные для проверки
            string fullName = "Никита Сычев";
            string age = "33";
            string phoneNumber = "+79995243333";
            string email = "nikitasychev@inbox.ru";

            //подключение библиотеки

            bool isFullNameTrue = Task3.ValidateFullName(fullName);
            bool isAgeTrue = Task3.ValidateAge(age);
            bool isPhoneTrue = Task3.ValidatePhone(phoneNumber);
            bool isEmailTrue = Task3.ValidateEmail(email);

            //вывод результатов
            Console.WriteLine($"ФИО {fullName} содержит только буквы? Ответ: {isFullNameTrue}");
            Console.WriteLine($"Возраст {age} содержит только цифры? Ответ: {isAgeTrue}");
            Console.WriteLine($"Телефон {phoneNumber} соответствует формату? Ответ: {isPhoneTrue}");
            Console.WriteLine($"Почта {email} соответствует заданному формату? Ответ: {isEmailTrue}");






            Console.ReadLine();
        }
    }
}
