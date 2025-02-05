using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal1 = new Calculate();
            cal1.number1 = 5.3;
            cal1.number2 = 7.1;
            Console.WriteLine($"{cal1.ToString()}");
            Console.WriteLine($"Результат: {cal1.Calc():f1}");
            Console.WriteLine();
            Calculate cal2 = new Calculate(19,12);
            Console.WriteLine($"{cal2.ToString()}");
            Console.WriteLine($"Результат: {cal2.Calc():f1}");
            Console.WriteLine();
            Console.Write("Первое число: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            double number2 = double.Parse(Console.ReadLine());
            Calculate cal3 = new Calculate(number1,number2);
            Console.WriteLine($"Результат: {cal3.Calc():f1}");
            Console.ReadLine();
        }
    }
}
