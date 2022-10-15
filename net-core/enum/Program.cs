using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya Çıkmak İçin Havanın Biraz Daha Isınmasını Bekleyelim");
            else if(sıcaklık >= (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Dışarıya Çıkmak İçin Hava Çok Sıcak");
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.Sıcak)
                Console.WriteLine("Hadi Dışarı Çıkalım");

        }
    }
    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20, 
        Sıcak = 25,
        CokSıcak = 30
    }
}