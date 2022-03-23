using System;

namespace tip_dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz dönüşüm)
            Console.WriteLine("**** Implicit Conversion****");

            byte a = 5;
            sbyte b = 20;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "elida";
            char f = 'C';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            //explicit conversion(bilinçli dönüşümler)
            Console.WriteLine("**** explicit dönüşümler");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            //ToString Methodu
            Console.WriteLine("ToString Methado");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            //System.Convert
            Console.WriteLine("System.Convert methodu");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("toplam:" + Toplam);

            //Parse
            Console.WriteLine("parse");
            ParseMethod();

        }

        public static void ParseMethod() 
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);

            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double" + double1);
        }
    }
}
