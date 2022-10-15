// See https://aka.ms/new-console-template for more information
// NET CORE 6.0

string sayi = "999";

bool sonuc = int.TryParse(sayi, out  int outSayi);

if(sonuc)
{
    Console.WriteLine("Başarılı");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Başarısız");
}

Metotlar instance = new Metotlar();
instance.Topla(4,5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);

// METOT AŞIRI YÜKLEME - OVERLOADİNG
int ifade = 999;
instance.ekranaYazdir(Convert.ToString(ifade));
instance.ekranaYazdir(ifade);

instance.ekranaYazdir("Yusuf ", "Çavdar");

// Metot imzası 
// Metotadı + parametre sayısı + parametre tipi


class Metotlar
{
    public void Topla(int a , int b, out int toplam)
    {
        toplam = a+b;
    }

    public void ekranaYazdir(string veri )
    {
        Console.WriteLine(veri);
    }

    public void ekranaYazdir(int veri )
    {
        Console.WriteLine(veri);
    }

    public void ekranaYazdir(string veri1 , string veri2 )
    {
        Console.WriteLine(veri1 + veri2);
    }

}