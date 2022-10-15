// See https://aka.ms/new-console-template for more information
// .NET 6.0


int time = DateTime.Now.Hour;
if(time >= 6 && time < 11)
    Console.WriteLine("GÜNAYDIN");
else if(time >= 11 && time <= 18)
    Console.WriteLine("İYİ GÜNLER");
else
    Console.WriteLine("İYİ GECELER");

string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";
sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 && time >= 11 ? "İyi Günler" : "İyi GECELER";
Console.WriteLine(sonuc);
