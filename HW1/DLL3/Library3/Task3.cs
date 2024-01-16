using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Library3
{
    public class Task3

    {
        public static bool ValidateFullName(string fullName)
        {
            // Проверка, что ФИО содержит только буквы
            return Regex.IsMatch(fullName, "^[a-zA-Zа-яА-Я ]+$");
        }

        public static bool ValidateAge(string age)
        {
            // Проверка, что возраст содержит только цифры
            return Regex.IsMatch(age, "^[0-9]+$");
        }

        public static bool ValidatePhone(string phoneNumber)
        {
            // Проверка, что телефон соответствует заданному формату (пример: +1234567890)
            return Regex.IsMatch(phoneNumber, @"^\+\d{10}$");
        }

        public static bool ValidateEmail(string email)
        {
            // Проверка, что email соответствует заданному формату
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

    }
}
