using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{
    public class Task2
    {
        public static bool IsPalindrome(string text)
        {
            // Удаляем все символы, кроме букв
            string cleanedText = new string(text.Where(char.IsLetter).ToArray());

            // Приводим все символы к нижнему регистру
            cleanedText = cleanedText.ToLower();

            // Сравниваем текст с перевернутым текстом
            return cleanedText == new string(cleanedText.Reverse().ToArray());
        }

        public static int CountSentences(string text)
        {
            // Предположим, что каждая точка с пробелом после нее обозначает конец предложения
            return text.Split(new[] { ". " }, StringSplitOptions.None).Length;
        }

        public static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
