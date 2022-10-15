// See https://aka.ms/new-console-template for more information
// NET CORE 6.0

using System.Collections.Generic;

Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

kullanicilar.Add(10,"Yusuf Çavdar");
kullanicilar.Add(12, "Tarık Kum");
kullanicilar.Add(18,"Deniz Arda");
kullanicilar.Add(20, "Özcan Coşar");

// Dizinin Elemanlarına Erişim

Console.WriteLine("***** Elemanlara Erişim *****");
Console.WriteLine(kullanicilar[12]);

foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}

// Count
Console.WriteLine("***** COUNT *****");
Console.WriteLine(kullanicilar.Count);

// Contains 
Console.WriteLine("***** CONTAINS *****");
Console.WriteLine(kullanicilar.ContainsKey(12));
Console.WriteLine(kullanicilar.ContainsValue("Ferdi Gül"));

// REMOVE
Console.WriteLine("***** REMOVE *****");
kullanicilar.Remove(18);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item.Value);
}

// Keys
Console.WriteLine("***** KEYS *****");
foreach (var item in kullanicilar.Keys)
{
    Console.WriteLine(item);
}
// Values
Console.WriteLine("***** VALUES *****");
foreach (var item in kullanicilar.Values)
{
    Console.WriteLine(item);
}