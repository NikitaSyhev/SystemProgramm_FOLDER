using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MyMath // создали класс для подключения к проекту
    {
        public static bool IsLeap(int year) // перегруженная функция для проверки високосного года ( int ) 
        {        

            return (year % 4 == 0) && ((year % 100 != 0 )||(year % 400 == 0));
        }
        public static bool IsLeap(DateTime year) // перегруженная функция для проверки високосного года ( DateTime ) 
        {   
            return IsLeap(year.Year);
        }
        public static bool IsLeap(string year) // перегруженная функция для проверки високосного года ( year ) 
        {
            
            if ((year.Contains('.'))||(year.Contains('/')))
                return IsLeap(Convert.ToDateTime(year).Year);
            else
                return IsLeap(Convert.ToInt32(year));
        }
        public static decimal Summ(decimal a, decimal b, decimal c) // перегруженная функция для  расчета максимального значения( decimal ) 
        { return a + b + c; }
        public static decimal Summ(string x) // перегруженная функция для  расчета максимального значения( string ) 
        {
            decimal result = 0;
            string[] numbers = x.Split(';');
            foreach (string number in numbers) 
                { result += Convert.ToDecimal(number); }
            return result; 
        }
        // принцип тот же, только для расчета Max, Min
        public static decimal Max(decimal a, decimal b, decimal c) 
        {
            return new[] { a, b, c }.Max();
        }
        public static decimal Max(string x)
        {
            decimal[] a =x.Split(';').Select(y => decimal.Parse(y)).ToArray();
            return a.Max();
        }
        public static decimal Min(decimal a, decimal b, decimal c)
        {
            return new[] { a, b, c }.Min();
        }
        public static decimal Min(string x)
        {
            decimal[] a = x.Split(';').Select(y => decimal.Parse(y)).ToArray();
            return a.Min();
        }
    }
}
