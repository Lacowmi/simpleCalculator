using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            int a, b, result = 0;
            String operation;

            Console.Write("Введите первое число: ");
            while(!int.TryParse(Console.ReadLine(),out a))
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
            while(operation != "/" && operation != "*" && operation != "+" && operation != "-")
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
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
