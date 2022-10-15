// See https://aka.ms/new-console-template for more information
// NET CORE 6.0


// Sort (Sıralama işlemi)

int[] sayiDizisi = {15,1,4,2,6,85,43,64};

Console.WriteLine("SIRASIZ DİZİ");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("SIRALI DİZİ");
Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}


// Clear 
Console.WriteLine("ARRAY CLEAR");
// Sayı dizisi elemanlarını kullanarak 2. indexten itibaren 2 elemanı sıfırlamak.
Array.Clear(sayiDizisi,2,2);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

// Reverse
Console.WriteLine("ARRAY REVERSE");

Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

// INDEXOF
Console.WriteLine("ARRAY INDEXOF");

Console.WriteLine(Array.IndexOf(sayiDizisi,43));

// RESIZE
Console.WriteLine("ARRAY RESIZE");

Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8] = 99;
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

int[] dizi = new int[15];
Console.WriteLine(dizi);