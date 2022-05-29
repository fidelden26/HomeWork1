using System;

namespace HomeWork1.Weekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // неделя

            Console.WriteLine("Weekday");
            Console.WriteLine("Enter a number");
            string userInpyt = Console.ReadLine();
            var a = 0;
            var userInput2 = int.TryParse(userInpyt, out a);

            SevenDays(a);

        }

        static void SevenDays(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Only up to 7");
                    break;

            }
        }
    }
}