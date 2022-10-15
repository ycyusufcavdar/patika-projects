// See https://aka.ms/new-console-template for more information

Console.WriteLine("*****Soru 5******");

Console.WriteLine("Lütfen n sayısını giriniz:");
int n = Int32.Parse(Console.ReadLine());

if(n<0)
{
    Console.WriteLine("Lütfen Geçerli Bir sayı giriniz.");
}
else
{
    string[] yazdiDizisi = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Lütfen {0}. kelimeyi giriniz", i+1);
        yazdiDizisi[i] = Convert.ToString(Console.ReadLine());
    }
    Array.Reverse(yazdiDizisi);
    foreach (var item in yazdiDizisi)
    {
        Console.WriteLine(item);
    }


}