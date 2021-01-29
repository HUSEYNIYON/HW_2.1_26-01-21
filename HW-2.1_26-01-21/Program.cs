using System;

namespace HW_2._1_26_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter changeCurr = new Converter(11.3001, 13.6854, 0.1474);
            Console.WriteLine("Введите сумму: ");
            var isNumber = int.TryParse(Console.ReadLine(), out var SUM);
            if (isNumber)
            {
                if(SUM>0)
                {
                    Console.WriteLine($"\tКурсы валют на сегодня: \n\t1 USD = {11.3001} TJS\n\t1 EUR = {13.6854} TJS \n\t1 RUB = {0.1474} TJS");
                    Console.WriteLine("\nПожалуйста, выберите тип конвертации:");
                    Console.WriteLine("Для конвертации TJS в USD нажмите - 1");
                    Console.WriteLine("Для конвертация TJS в EUR нажмите - 2");
                    Console.WriteLine("Для конвертация TJS в RUB нажмите - 3");
                    Console.WriteLine("Для конвертация USD в TJS нажмите - 4");
                    Console.WriteLine("Для конвертация EUR в TJS нажмите - 5");
                    Console.WriteLine("Для конвертация RUB в TJS нажмите - 6");
                    Console.WriteLine("\nВаш выбор: ");
                    int Choice = int.Parse(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            Console.WriteLine($"{SUM} TJS = {changeCurr.tjsToUsd(SUM)} USD");
                            break;
                        case 2:
                            Console.WriteLine($"{SUM} TJS = {changeCurr.tjsToEur(SUM)} EUR");
                            break;
                        case 3:
                            Console.WriteLine($"{SUM} TJS = {changeCurr.tjsToRub(SUM)} RUB");
                            break;
                        case 4:
                            Console.WriteLine($"{SUM} USD = {changeCurr.usdToTjs(SUM)} TJS");
                            break;
                        case 5:
                            Console.WriteLine($"{SUM} EUR ={changeCurr.eurToTjs(SUM)} TJS");
                            break;
                        case 6:
                            Console.WriteLine($"{SUM} RUB = {changeCurr.rubToTjs(SUM)} TJS");
                            break;
                        default:
                            Console.WriteLine("Неправильная команда. Пожалуйста, попробуйте еще раз");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Сумма меньше нулья");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Сумма дольжен быть цифры!");
            }
           
            Console.ReadKey();
        }
    }
}
