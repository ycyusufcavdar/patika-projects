// See https://aka.ms/new-console-template for more information
// NET CORE 6.0


//while
// 1'den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazma programı. 
// Console.WriteLine("Lütfen bir sayı giriniz: ");
// int sayi = int.Parse(Console.ReadLine());
// int sayac = 1;
// int toplam = 0;
// while (sayac <= sayi)
// {
//     toplam += sayac;
//     sayac++;
// }
// Console.WriteLine(toplam/sayi);

// // a'dan z'ye kadar tüm harfleri console a yazdır.

// char character = 'a';
// while (character <= 'z')
// {
//     Console.Write(character);
//     character ++;
// }

Console.WriteLine("*****FOREACH*****");

string[] arabalar = {"bmw", "ford","toyota","nissan"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}