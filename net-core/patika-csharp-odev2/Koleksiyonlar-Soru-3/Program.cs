// NET CORE 6.0

using System.Collections;

// Sesli Harfleri Tutabilmek İçin Bir ArrayList Oluşturuyoruz.
ArrayList sesliharfler = new ArrayList();
Console.WriteLine("Lütfen Bir Metin Girişi Yapınız: ");

// Girilen Harfleri ToCharArray ile harf harf ayırıyoruz.
char[] yazi = (Console.ReadLine()).ToCharArray();

// Bu Harflerin İçindeki Sesli Harfleri Bulmak için Bütün Harfleri Sesli Harfler İle Karşılaştırıp, Sesli Harf Bulunduğunda Bu Harfi Sesliharfler Listemize Ekliyoruz.
foreach (var item in yazi)
{
    if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü' || item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
    {
        sesliharfler.Add(item);
    }
}

// Sesli Harfler Listemizi Sortlayıp Elemanlarını Yazdırıyoruz.
sesliharfler.Sort();

foreach (var item in sesliharfler)
{
    Console.WriteLine(item);
}
