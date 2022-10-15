// NET CORE 6.0

using System.Collections;

// Girilen Sayıları Tutmak İçin Bir Arraylist Oluşturuyoruz.
ArrayList sayilar = new ArrayList();

// İleride Kullanacağımız Küçük Sayılar Toplamı ve Büyük Sayılar Toplamı Değişkenlerini Tanımlıyoruz.
int kstoplam = 0;
int bstoplam = 0;

// Kullanıcıdan 20 Adet Sayıyı For Döngüsü İle Alıyoruz.
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("{0}. Sayıyı Giriniz", i+1);
    int sayi = Convert.ToInt32(Console.ReadLine());
    sayilar.Add(sayi);
}

// Sayılara Sort(Sıralama) İşlemi Uyguluyoruz.
sayilar.Sort();

// Küçük Sayıları Tutabilmek İçin Bir ArrayList Oluşturuyoruz ve Önceden Sortladığımız Sayılar Listesinden Elemanları KS Listesine Ekliyoruz.
ArrayList ks = new ArrayList();
for (int i = 0; i < 3; i++)
{
    int x = Convert.ToInt32(sayilar[i]);
    ks.Add(x);
    kstoplam += Convert.ToInt32(sayilar[i]);
}

// Az Önce Küçük Sayılar İçin Yaptığımız İşlemi Büyük Sayılar İçin Yapıyoruz.
ArrayList bs = new ArrayList();
for (int i = 17; i < 20; i++)
{
    int y = Convert.ToInt32(sayilar[i]);
    bs.Add(y);
    bstoplam += Convert.ToInt32(sayilar[i]);
}

// Küçük Sayılarımızı foreach ile ekrana yazdırıyoruz.

Console.WriteLine("Küçük Sayılar: ");
foreach (var item in ks)
{
    Console.WriteLine(item);
}

// Büyük Sayılarımızı foreach ile ekrana yazdırıyoruz.
Console.WriteLine("Büyük Sayılar: ");
foreach (var item in bs)
{
    Console.WriteLine(item);
}
// Küçük Sayılar Ortalaması, Büyük Sayılar Ortalaması ve Toplam Ortalama Değerlerini Hesaplayıp Ekrana Yazdırıyoruz.
int ksort = (kstoplam/3);
int bsort = (bstoplam/3);
int toport = ksort + bsort;

Console.WriteLine("Küçük Sayıların Ortalaması: " + ksort);
Console.WriteLine("Büyük Sayıların Ortalaması: " + bsort);
Console.WriteLine("Ortalamaların Toplamı : "+ toport);