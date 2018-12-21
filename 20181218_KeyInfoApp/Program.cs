using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181218_KeyInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            top:
            // Konsolda tuşlanacak veriyi saklayabilmek için ConsoleKeyInfo tipinde bir değişken tanımlanır.
            ConsoleKeyInfo cki = Console.ReadKey();
            // Basılan tuşun esc olup olmadığı kontrolü yapılır.
            if (cki.Key == ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
            // Basılan tuş f2 olup olmadığını kontrol ediyor
            else if (cki.Key== ConsoleKey.F2)
            {
                goto top;
            }
        }
    }
}
