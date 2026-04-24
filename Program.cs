using System;

namespace Perekupshik_Ion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine ("Cu cat ai cumparat telefonul?");
            int pretCumparare = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Dar cu cat lai vandut? ");
            int pretVanzare = Convert.ToInt32 (Console.ReadLine());

            int Profit = pretVanzare - pretCumparare ;

            Console.WriteLine(" Profitul tau este " + Profit + " Euro");
        }
    }
}