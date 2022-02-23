using System;

namespace tipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion(Bilinçsiz dönüşüm)
            System.Console.WriteLine("Implicit Conversion");

            byte a =5;
            sbyte b= 30;
            short c= 10;

            int d= a+b+c;

            System.Console.WriteLine("d:" + d);

            long h = d;

            System.Console.WriteLine("h:" + h);

            string e="zikriye";
            char f = 'k';
            object g = e+f+d;

            System.Console.WriteLine("g:" + g);

            //Explicit Conversion (Bilinçli Dönüşüm)
            System.Console.WriteLine("Explicit Conversion");

            int x =4;
            byte y= (byte)x;

            System.Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;

            System.Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("v:" + v);

            // **** to string Methodu ****

            System.Console.WriteLine("To String Methodu");

            int xx = 6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy:" + yy);

            string zz = 12.5.ToString();
            System.Console.WriteLine("zz:" + zz);

            //System.convert

            System.Console.WriteLine("System.Covert Sınıfı");

            string s1 ="10", s2="20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1+sayi2;
            System.Console.WriteLine("Toplam:" + toplam);

            //Parse
            System.Console.WriteLine("Parse Methodu");

            ParseMethod();

        }

            public static void ParseMethod()
            {
                string metin1 = "10";
                string metin2 = "10,25";
                int rakam1;
                double double1;

                rakam1 = Int32.Parse(metin1);
                double1 = Double.Parse(metin2);

                System.Console.WriteLine("rakam1:" + rakam1);
                System.Console.WriteLine("double1:" + double1);
            }
    }
}
