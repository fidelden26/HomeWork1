using System;

namespace HomeWork1.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Таблица умножения

            Console.WriteLine("Multiplication table");
            Console.WriteLine("enter a number");
            var userInput = Console.ReadLine();
            var number = 0;
            var number2 = int.TryParse(userInput, out number);

            Table(number);
        }
        static void Table(int number)
        {
            switch (number)
            {
                case < 11:

                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine($"{number}*{i} = {number * i}");
                    }

                    break;

                default:
                    Console.WriteLine("Only up to 10");
                    break;
            }
        }
    }
}