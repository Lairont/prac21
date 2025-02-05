using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time clock1 = new Time();
            clock1.hours = 1;
            clock1.minutes = 45;
            clock1.seconds = 14;
            Console.WriteLine($"{clock1.ToString()}");
            Console.WriteLine($"Общее количество минут: {clock1.Totalminutes()}\n" +
                $"Общее количество секунд: {clock1.Totalseconds()}");
            Console.WriteLine();
            Time clock2 = new Time(2,10,51);
            Console.WriteLine($"{clock2.ToString()}");
            Console.WriteLine($"Общее количество минут: {clock2.Totalminutes()}\n" +
                $"Общее количество секунд: {clock2.Totalseconds()}");
            Console.WriteLine();
            Console.Write("Количество часов: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Количество минут: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Количество секунд: ");
            int seconds = int.Parse(Console.ReadLine());
            Time clock3 = new Time(hours,minutes,seconds);
            Console.WriteLine($"Общее количество минут: {clock3.Totalminutes()}\n" +
                $"Общее количество секунд: {clock3.Totalseconds()}");
            Console.ReadLine();
        }
    }
}
