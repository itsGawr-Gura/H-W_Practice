using System;
using System.Linq;
using System.Threading;

namespace H_W_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 Вывести типы данных
            Console.WriteLine("Задание 1 Вывести типы данных");
            Console.WriteLine("Тип - Максимальное значение - Минимальное значение");
            Console.WriteLine($"byte\t| {byte.MaxValue} | {byte.MinValue}");
            Console.WriteLine($"sbyte\t| {sbyte.MaxValue} | {sbyte.MinValue}");
            Console.WriteLine($"short\t| {short.MaxValue} | {short.MinValue}");
            Console.WriteLine($"ushort\t| {ushort.MaxValue} | {ushort.MinValue}");
            Console.WriteLine($"int\t| {int.MaxValue} | {int.MinValue}");
            Console.WriteLine($"uint\t| {uint.MaxValue} | {uint.MinValue}");
            Console.WriteLine($"long\t| {long.MaxValue} | {long.MinValue}");
            Console.WriteLine($"ulong\t| {ulong.MaxValue} | {ulong.MinValue}");
            Console.WriteLine($"float\t| {float.MaxValue} | {float.MinValue}");
            Console.WriteLine($"double\t| {double.MaxValue} | {double.MinValue}");
            Console.WriteLine($"decimal\t| {decimal.MaxValue} | {decimal.MinValue}");
            Console.WriteLine($"char\t| {char.MaxValue} | {char.MinValue}");
            Console.WriteLine($"string\t| N/A | N/A");
            Console.WriteLine($"bool\t| True | False");
            Console.WriteLine($"object\t| N/A | N/A");
            Console.WriteLine($"dynamic\t| N/A | N/A");
            // Задание 2 Вывод данных пользователя
            Console.WriteLine("Задание 2 Вывод данных пользователя");
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свой город");
            string town = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите PIN-код состоящий из цифр");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше имя - {name} | Ваш город - {town} | Ваш возраст - {age} лет | Ваш PIN-код - {code}");
            // Задание 3 Преобразуйте входную строку
            Console.WriteLine("Задание 3 Преобразуйте входную строку");
            Console.WriteLine("Введите свою строку");
            string str = Console.ReadLine();
            string invert = string.Empty;
            foreach (char c in str)
            {
                invert += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
            }
            Console.WriteLine(invert);
            // Задание 4 Найти кол-во вхождений подстроки в строку
            Console.WriteLine("Задание 4 Найти кол-во вхождений подстроки в строку");
            Console.WriteLine("Введите вашу строку");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вашу подстроку");
            string s2 = Console.ReadLine();
            Console.WriteLine($"Количество вхождений вашей подстроки = {s1.Split(new string[] { s2 }, StringSplitOptions.None).Count() - 1}");
            // Задание 5 Бухой отпуск
            Console.WriteLine("Задание 5 Бухой отпуск");
            Console.WriteLine("Цена бутылки Виски в рублях");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваша скидка в процентах = ");
            double salePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Цена отпуска в рублях");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double cashBack = normPrice * salePrice / 100;
            double cashBackBalance = 0;
            int i = 0;
            while (holidayPrice > cashBackBalance)
            {
                cashBackBalance += cashBack;
                i++;
            }
            Console.WriteLine($"Чтобы отправиться в отпуск вам нужно купить и выпить - {i} бутылок Виски");
            // Задание 6 Глюки Гарри Поттера после подготовки к отпуску
            Console.WriteLine("Задание 6 Глюки Гарри Поттера после подготовки к отпуску");
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Но могу показать");
            Thread.Sleep(4000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            // Задание 7 Штрих код типа EAN13
            Console.WriteLine("Штрих код EAN13");
            Console.WriteLine("Введите 12-ти значный код состоящий из цифр типа EAN13");
            string ean13  = Console.ReadLine();
            if (ean13.Length < 12 || ean13.Length > 12)
            {
                Console.WriteLine("Введите 12-ти значный код  типа EAN13, состоящий из цифр");
                ean13 = Console.ReadLine();
            }
            int summChet1 = Convert.ToInt32(ean13[1] + ean13[3] + ean13[5] + ean13[7] + ean13[9] + ean13[11]);
            int summNechet1 = Convert.ToInt32(ean13[0] + ean13[2] + ean13[4] + ean13[6] + ean13[8] + ean13[10] + ean13[12]);
            summChet1 = 3 * summChet1;
            int summ1 = summChet1 + summNechet1;
            decimal control;
            



           
            
          





            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
