using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Tugas Program Bilangan Desimal Ke Hexadesimal Visual C#");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Nama      : GILANG FAJAR RIJALUDIN");
        Console.WriteLine("Npm       : 1101201007");
        Console.WriteLine("Kelas     : Malam");
        Console.WriteLine("Dosen     : Asep Mabrur Aid,S.T,M.Kom");
        Console.WriteLine("Prodi     : Teknik Informatika");
        Console.WriteLine("MK        : Pemgraman Berorientasi Objek");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        string hexval = "20B0";
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " + decValue);
        }
    }
}
