using System;

namespace degisken
{
    class Program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("");

            byte b = 5;     // 1 byte yer kaplar
            sbyte c = 5;    // 1 byte yer kaplar

            short s = 5;    //2 byte yer kaplar
            ushort us = 5;  //2 byte yer kaplar

            Int16 i16 = 2;  //2 byte yer kaplar
            int i = 2;      //4 byte yer kaplar
            Int32 i32 = 2;  //4 byte yer kaplar
            Int64 i64 = 2;  //8 byte yer kaplar

            uint ui = 2;    //4 byte yer kaplar
            long l = 4;     //8 byte yer kaplar
            ulong ul = 4;   //8 byte yer kaplar

            //REAL SAYILAR İÇİN

            float f = 5;    //4 byte yer kaplar
            double d = 5;   //8 byte yer kaplar
            decimal de =5;  //8 byte yer kaplar


            char ch = '2';  //2 byte yer kaplar
            string str = "Zikriye"; //Sınırsız

            bool b1=true;
            bool b2=false;

            DateTime dt = DateTime.Now; //O ANIN TARİH VE SAAT KARŞILIĞINI VERİR
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            // STRİNG İFADELER

            string str1 = string.Empty; // BOŞ BİR DEĞER İFADESİ
            str1 = "Cüneyt Şener"; //HAYIR DEDIM BIR DEGISKEN ATAMAK İSTEDİM
            string ad = "Cüneyt";
            string soyad ="Şener";
            string tamIsım = ad + "" + soyad; // burada da birşeştirme yaptık

            //İNTEGER İFADELER

            int intdeger1 = 5;
            int intdeger2 = 3;
            int intdeger3 = intdeger1 + intdeger2;

            //Boolean İfadeler

            bool bool1 = 10<2; // BU TRUE GELECEKTİ KÜÇÜK OLSA FALSE GELECEKTİ

            //Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();// ÇEVİRME İŞLEMLERİ İÇİN KULLANIYLIYOR

            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20); // İNTEGER İFADEYİ STRİNG İFADEYE CEVİRİP TOPLUYOR
            Console.WriteLine(int21);// ÇIKTISI 40 OLUR

            int int22 = int20 + int.Parse(str20); //Çıktısı 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime);

            //saat
            string hovr = datetime.Now.ToString("HH.mm");
            Console.WriteLine(hour);






        }

    }

}
