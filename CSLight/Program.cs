using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Привет, Мир!");
            // Console.ReadKey();

            //Отновные типы данных | int | float | char| string | bool
            //Целочисленные
            /* byte b; // от 0 до 255
             sbyte sb; // -128 до 127
             short s; // -32768 до 32768
             ushort us; // 0 до 65535
             int i;
             uint ui;
             long l = long.MaxValue;
             ulong ul;
             //Числа с плавающей точкой
             float f = 5.7f; //точность до 7 знаков после ,
             double d = 5.7; // точность до 15 знаков после ,
             //Симпольный тип
             char c = 'H';
             //Строковый тип
             string str = "Hi";
             //Логический тип
             bool bl;
             int age = 27;
             age = 23;
            */
            //Операторы
            /*float result;
              int x, y;
              x = 5;
              y = 2;
              result = Convert.ToSingle(x) / y;
              Console.WriteLine(result); */

            //Деление по модулю, % выводит остаток
            /* int timeInMinets = 130;
            int hour;
            int minute;
            hour = timeInMinets / 60;
            minute = timeInMinets % 60;
            Console.WriteLine("hour: " + hour);
            Console.WriteLine("minute: " + minute); */

            //Варианты записи
            /* int age = 18;
             age = age + 1;
             age++;
             age += 1;
             age -= 1;
             age *= 1;
             age /= 1; */

            //Логические операторы == != >= <= > <

            /*int age = 15;
            bool accesIsAllowed;
            accesIsAllowed = age >= 18;
            Console.WriteLine(accesIsAllowed);*/

            //Конкатенация (сложение строк)

            string greeting = "Привет";
            string name = "Олег";
            string message = greeting + " " + name;
            Console.WriteLine(message + ", рад тебя видеть!");
            int age = 18;
            Console.WriteLine("Привет, тебе завтра исполнится " + age + " лет!");
            Console.WriteLine("Привет, тебе завтра исполнится " + (age + 1) + " лет!");
            Console.WriteLine("Hello");
        }
    }
}
