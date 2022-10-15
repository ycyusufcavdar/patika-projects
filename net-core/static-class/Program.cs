using System;

namespace Static_Class{

    class Program{

        static void Main(string[] args)
        {  
            Console.WriteLine("Çalışan Sayısı {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Yusuf", "Çavdar", "IT");
            Console.WriteLine("Çalışan Sayısı {0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Ahmet", "Mehmet", "IT");
            Calisan calisan2 = new Calisan("Ali", "Veli", "IT");
            Console.WriteLine("Çalışan Sayısı {0}",Calisan.CalisanSayisi);

            
            Console.WriteLine(Islemler.topla(15,25));
            Console.WriteLine(Islemler.cikar(55,15));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan()
        {
            calisanSayisi=0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim=soyisim;
            this.departman=departman;
            calisanSayisi ++;
        }
    }

    static class Islemler
    {
        public static long topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }


}