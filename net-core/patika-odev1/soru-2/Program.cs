// See https://aka.ms/new-console-template for more information


Console.WriteLine("*****SORU 2******");

Console.WriteLine("Lütfen n Sayısını Giriniz:");
int n = Int32.Parse(Console.ReadLine());

Console.WriteLine("Lütfen m Sayısını Giriniz:");
int m = Int32.Parse(Console.ReadLine());

if(n<0 || m<0)
{
    Console.WriteLine("Lütfen geçerli sayılar giriniz.");    
}
else
{
    int[] sayiDizisi = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
        sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
        if(sayiDizisi[i]<0)
        {
            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            break;
        }
    }
    int sayac = 1;
    Console.WriteLine("Eşit veya tam bölünenler");
    foreach (var item in sayiDizisi)
    {
        if(item%m == 0 && item>0)
        {
            sayac++;
            Console.WriteLine(item);
        }
    }
}

    

    
        
