// See https://aka.ms/new-console-template for more information
Console.WriteLine("***** Soru 4 *****");
Console.WriteLine("Lütfen bir cümle giriniz.");
string x = Convert.ToString(Console.ReadLine());

string[] kelimeler = x.Split(' ');
string[] cumle = x.Split(' ');
string result= string.Join("", cumle);
Console.WriteLine("Kelime Sayısı: "+ kelimeler.Length);
Console.WriteLine("Harf Sayısı: "+ result.Length);

foreach (var item in kelimeler)
{
    Console.WriteLine(item);
}

