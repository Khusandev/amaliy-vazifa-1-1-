﻿//1.Doira yuzi va aylana uzunligini hisoblash
//Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va 
//aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
//Input: radius = 3
//Output: S = 28.2743338823081, L = 18.8495559215388
//--------------
//Input: radius = 4.23
//Output: S = 56.2122031914168, L = 26.5778738493697

namespace praktikum_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("radiusni kiriting (input):");
            string radius = Console.ReadLine();
            double rad = Convert.ToDouble(radius);

            double S = Math.PI * (rad * rad);
            double L = 2 * Math.PI * rad;

            Console.WriteLine($"Doira yuzasi(output):{S}");
            Console.WriteLine($"Aylana uzunligi (output):{L}");



        }
    }
}

//2.Valyuta konvertri
//Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini 
//e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
//Input: qiymat = 2, kurs = 12400 so’m
//Output: 24800 so’m
//----------------
//Input: qiymat = 7.6, kurs = 12400 so’m
//Output: 94240 so’m


namespace praktikum_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("valyuta kursi (input):");
            string kurs1 = Console.ReadLine();
            double kurs2 = Convert.ToDouble(kurs1);

            Console.Write("valyuta qiymati (input):");
            string qiymat1 = Console.ReadLine();
            double qiymat2 = Convert.ToDouble(qiymat1);

            double Summa = kurs2 * qiymat2;

            Console.WriteLine($"Sumdagi summa(output):{Summa}");




        }
    }
}

//3.Yoshni hisoblash
//Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda 
//ifodalang. Kabisa yilini hisobga olmang
//Input: x = 2004
//Output: 6935
//---------------- -
//Input: x = 1996
//Output: 9855

namespace praktikum_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tugilgan yilingizni kiriting (input):");
            string ty = Console.ReadLine();
            int x = Convert.ToInt32(ty);
            int yil = 2024;
            int kun = 365;
            int yosh = (yil - x) * kun;
            Console.WriteLine($"Kunlargadi yoshingiz(output):{yosh}");

        }
    }
}