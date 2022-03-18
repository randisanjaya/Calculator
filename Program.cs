using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Pilih Menu Calculator: ");
            Console.WriteLine();
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();

            Console.Write("Input Nomor Menu [1..4]:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Inputkan Nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penjumlahan(a, b));
            }

            else if (n == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }

            else if (n == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }

            else if (n == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            else
            {
                Console.WriteLine("Maaf, Format Input tidak ditemukan");
            }

            Console.WriteLine();
            Console.WriteLine("Tekan apa saja untuk menutup");
            Console.ReadKey();
        }

        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
