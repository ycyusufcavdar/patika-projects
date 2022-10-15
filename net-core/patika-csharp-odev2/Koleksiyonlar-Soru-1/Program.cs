// NET CORE 6.0 
using System.Collections;
using System.Collections.Generic;
Console.WriteLine("*****SORU 1******");
// Try Catch Yapısı İle Metin Girişini Engelliyoruz.
try
{
    Console.WriteLine("Lütfen Sadece Sayı Giriniz");
    // İleride Kullanmak İçin Asal ve Asal Olmayan Listeleri Oluşturuyoruz.
    ArrayList Asal = new ArrayList();
    ArrayList noAsal = new ArrayList();
    // Asal Sayılar Toplamı ve Asal Olmayan Sayılar Toplamını Tanımlıyoruz.
    int asaltop = 0;
    int noAsaltop = 0;
    // Kullanıcıdan Veri Girişi Almak ve Asallığını Sorgulamak İçin For Döngüsü Kullanıyoruz, Sonrasında Asal Sayıları Asal Listesine, Asal Olmayan Sayıları noAsal Listesine Ekliyoruz.
    for (int i = 0; i < 20; i++)
    {
        int ctrl = 0;
        Console.WriteLine("{0}. Sayıyı Giriniz: ", i+1);
        int sayi = Convert.ToInt32(Console.ReadLine());

            for (int j = 2; j < sayi; j++)
            {
                if(sayi % j == 0)
                ctrl++;
            }
            if(ctrl == 0)
            {
                Asal.Add(sayi);
                asaltop += sayi;
            }
            else
            {
                noAsal.Add(sayi);
                noAsaltop += sayi;
            }
    }
    // Asal Sayıları Sortlayıp Önce Eleman Sayısını Sonra da Elemanlarını Yazdırıyoruz.
    Asal.Sort();
    Console.WriteLine("Asal Olan Eleman Sayısı: "+ Asal.Count);
    foreach (var item in Asal)
    {
        Console.Write(item + ",");
    }
    Console.WriteLine(" Asal Olan Sayıların Ortalaması: " + asaltop / Asal.Count);

    // Az Önce Yaptığımız İşlemi Asal Olmayan Sayılar İçin Uyguluyoruz.
    noAsal.Sort();
    Console.WriteLine("Asal Olmayan Eleman Sayısı: "+ noAsal.Count);
    foreach (var item in noAsal)
    {
        Console.Write(item + ",");
    }
    Console.WriteLine(" Asal Olmayan Sayıların Ortalaması: "+ noAsaltop/ noAsal.Count);

}
catch (System.Exception)
{
    return;
}