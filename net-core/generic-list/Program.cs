// See https://aka.ms/new-console-template for more information
// Net core 6.0

class Program
{
    static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        // T -> object türündedir.

        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();

        renkListesi.Add("kırmızı");
        renkListesi.Add("mavi");
        renkListesi.Add("turuncu");
        renkListesi.Add("sarı");
        renkListesi.Add("yeşil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);


        // Foreach ve list foreach ile elemanlara erişim
        foreach (var item in sayiListesi)
        {
            Console.WriteLine(item);
        }
        foreach (var item in renkListesi)
        {
            Console.WriteLine(item);
        }

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        // Listeden eleman çıkarma

        sayiListesi.Remove(4);
        renkListesi.Remove("yeşil");

        Console.WriteLine("Yeni Listeler");
        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        Console.WriteLine("RemoveAt Yeni Listeler");
        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        // Liste içerisinde arama

        if(sayiListesi.Contains(10))
                    Console.WriteLine("10 liste içerisinde bulundu");
        
        // Eleman ile index'e erişmek

        Console.WriteLine(renkListesi.BinarySearch("sarı")); 

        // Diziyi List'e çevirme
        string[] hayvanlar = {"kedi", "köpek", "kuş"};
        
        List<string> hayvanListesi = new List<string>(hayvanlar);

        // Listeyi nasıl temizleriz?

        hayvanListesi.Clear();

        // Liste içerisinde nesne tutmak
        List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

        Kullanıcılar kullanıcı1 = new Kullanıcılar();
        kullanıcı1.Isim= "Yusuf";
        kullanıcı1.Soyisim= "Çavdar";
        kullanıcı1.Yas= 22;
        
        Kullanıcılar kullanıcı2 = new Kullanıcılar();
        kullanıcı2.Isim= "Tarık";
        kullanıcı2.Soyisim= "Kum";
        kullanıcı2.Yas= 24;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);

        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
        yeniListe.Add(new Kullanıcılar(){
            Isim="Halil",
            Soyisim="Emmi",
            Yas=26
        });

        foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
        {
            Console.WriteLine("Kullanıcı Adı: "+ kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı: "+ kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yaşı: "+ kullanıcı.Yas);
        }

        yeniListe.Clear();
    }
}

public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}