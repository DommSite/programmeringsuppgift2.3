using System;
using System.Diagnostics.Metrics;

namespace övning2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du köra din hyrda bil?");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hade du tänkt att köra? (i km)");
            float köravstånd = float.Parse(Console.ReadLine());

            float kostnad = (float)dagar * 500 + köravstånd * 1 - 200;

            Console.WriteLine("Din totala kostnad kommer vara " + kostnad + "kr.");


            Console.ReadKey();
        }
    }
}