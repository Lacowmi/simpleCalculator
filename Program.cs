using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static public void calculating()
        {
            Operations operations = new Operations();
            int a, b, result = 0;
            String operation;

            Console.Write("Введите первое число: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Введите корректное значение!\nВведите первое число: ");
            }
            Console.Write("Введите второе число: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Введите корректное значение!\nВведите второе число: ");
            }

            Console.Write("Выберете операцию(/, *, +, -): ");
            operation = Console.ReadLine();
            while (operation != "/" && operation != "*" && operation != "+" && operation != "-")
            {
                Console.Write("Введите корректную операцию: ");
                operation = Console.ReadLine();
            }
            switch (operation)
            {
                case "/":
                    result = operations.division(a, b);
                    break;
                case "*":
                    result = operations.multiplication(a, b);
                    break;
                case "+":
                    result = operations.addition(a, b);
                    break;
                case "-":
                    result = operations.substraction(a, b);
                    break;
            }
            Console.WriteLine("Результат: " + result + "\n Нажмите enter что бы выйти в меню.");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            int check;
            do
            {
                Console.WriteLine("Выберете действие:\n1.Посчитать\n2.Выход");
                check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        calculating();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Выберете действие из списка!");
                        break;
                }
            } while (check == 1);
        }
    }
}
