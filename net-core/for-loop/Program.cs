// See https://aka.ms/new-console-template for more information
// Net 6.0


// Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
// Console.WriteLine("Lütfen Bir Sayı Giriniz");
// int sayac = int.Parse(Console.ReadLine());
// for (int i = 0; i < sayac; i++)
// {
//     if(i%2 == 1)
//         Console.WriteLine(i);
// }


// // 1-1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
// int tekToplam = 0;
// int ciftToplam = 0;


// for (int i = 1; i <= 1000; i++)
// {
//     if(i%2 == 1)
//         tekToplam += i; // tekToplam = tekToplam+i;
//     else
//         ciftToplam += i;

// }
// Console.WriteLine("Tek Toplam = " + tekToplam);
// Console.WriteLine("Çift Toplam =" + ciftToplam);

// Break, Continue 

// for (int i = 0; i < 10; i++)
// {
//     if(i==4)
//         break;
//     Console.WriteLine(i);
// }
for (int i = 0; i < 10; i++)
{
    if(i==4)
        continue;
    Console.WriteLine(i);
}

// Sonsuz Döngülerden uzak durun.
