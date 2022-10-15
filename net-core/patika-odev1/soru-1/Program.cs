// See https://aka.ms/new-console-template for more information

Console.WriteLine("*****SORU 1*****");

    Console.WriteLine("Lütfen kaç sayı gireceğinizi yazınız:");
    while(true)
    {
        int n = Convert.ToInt32(Console.ReadLine()); 
        if(n<= 0)
        {
            Console.WriteLine("Lütfen pozitif tam sayı giriniz: ");
            continue;
        }
        else
        {
            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                if(sayiDizisi[i]<=0)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                    Console.WriteLine("Hatalı girdiğiniz sayı " + sayiDizisi[i]);
                    break;
                }
                
            }
            int sayac =1;
            Console.WriteLine("Çift Sayılar:");
            foreach (var item in sayiDizisi)
            {
                if(item %2 == 0 && item >0)
                {
                    sayac++;
                    Console.WriteLine(item);
                }
            }
            break;
        }
    }