using System;
namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" hur mycket tjänar den första anställda?");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("hur mycket tjänar den andra anställda?");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("hur mycket tjänar den tredje anställda?");
            int tal3 = int.Parse(Console.ReadLine());
            int summa = tal1 + tal2 + tal3;
            Console.WriteLine("första anställd" + summa + "andra anställd" + summa + "tredje anställd");
        }
    }
}


