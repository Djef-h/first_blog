
using System;

class Program
{
    static void Main()
    {
        PrintReceipt();
    }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            System.Console.WriteLine("Cash Receipt");
            System.Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            System.Console.WriteLine("Charged to____________________");
            System.Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("\u00A9 IT KARIERA");
        }
}