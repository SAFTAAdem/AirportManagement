using System;

namespace AM.UI.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("===== TEST 1 =====");
            Chap2.Test1();

            System.Console.WriteLine("\n===== TEST 2 =====");
            Chap2.Test2();

            System.Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            System.Console.ReadKey();
        }
    }
}