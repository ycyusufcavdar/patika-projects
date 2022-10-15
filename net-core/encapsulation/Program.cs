using System;

namespace encapsulation
{


    class program
    {

        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci("Yusuf", "Çavdar", 181818, 11);
            ogrenci1.ogrencibilgigetir();

            ogrenci ogrenci2 = new ogrenci("Ahmet", "Mehmet", 191919, 1);
            ogrenci2.sinifdusur();
            ogrenci2.sinifdusur();
            ogrenci2.ogrencibilgigetir();
        }



    }

    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
        get => isim;
        set => isim = value; 
        }
        public string Soyisim 
        { get => soyisim; 
        set => soyisim = value; 
        }
        public int OgrenciNo 
        { get => ogrenciNo;
         set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set 
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf En Düşük 1 Olabilir");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            } 
        }

        public ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public ogrenci()
        {
        }

        public void ogrencibilgigetir()
        {
            Console.WriteLine("*****Öğrenci Bilgileri*****");
            Console.WriteLine("Öğrenci Adı:{0}", this.Isim );
            Console.WriteLine("Öğrenci Soyadı:{0}", this.Soyisim );
            Console.WriteLine("Öğrenci No:{0}", this.OgrenciNo );
            Console.WriteLine("Öğrenci Sınıfı:{0}", this.Sinif );
        }

        public void sinifatlat()
        {
            this.Sinif = this.Sinif + 1;

        }
        public void sinifdusur()
        {
            this.Sinif= this.Sinif - 1;

        }
    }

}