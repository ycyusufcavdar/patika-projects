// See https://aka.ms/new-console-template for more information
// Net Core 6.0
using System.Collections;


ArrayList liste = new ArrayList();

// liste.Add("Yusuf");
// liste.Add(2);
// liste.Add(true);
// liste.Add('A');

// //Array içerisindeki verilere erişme

// Console.WriteLine(liste[1]);

// foreach (var item in liste)
// {
//     Console.WriteLine(item);
// }

// Addrange

Console.WriteLine("***** ADD RANGE *****");
//string[] renkler = {"kırmızı", "sarı", "yeşil"};
List<int> sayilar = new List<int>(){1,8,3,7,92,5};

//liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var item in liste)
{
    Console.WriteLine(item);
}

// Sort

Console.WriteLine("***** Sort *****");
liste.Sort();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

// Binary Search - Kullanım için önce sort işlemi uygulanıp, ardından search işlemi gerçekleştirilmeli!

Console.WriteLine("***** Binary Search *****");
Console.WriteLine(liste.BinarySearch(8));

// Reverse

Console.WriteLine("***** Reverse ******");
liste.Reverse();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

// Clear

Console.WriteLine("***** Clear *****");
liste.Clear();

foreach (var item in liste)
{
    Console.WriteLine(item);
}