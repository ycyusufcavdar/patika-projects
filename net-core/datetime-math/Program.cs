// See https://aka.ms/new-console-template for more information
// NET CORE 6.0

Console.WriteLine(DateTime.Now); // günün tarihini getirir.
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);


Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın gününü string getirir
Console.WriteLine(DateTime.Now.DayOfYear); // İçinde bulunulan yılın kaçıncı gününde olduğunu getirir


Console.WriteLine(DateTime.Now.ToLongDateString());  // gün ay yıl ama yazıyla
Console.WriteLine(DateTime.Now.ToShortDateString()); // gün ay yıl ama sayıyla


Console.WriteLine(DateTime.Now.ToLongTimeString()); // saat dakika saniye
Console.WriteLine(DateTime.Now.ToShortTimeString()); // saat dakika


Console.WriteLine(DateTime.Now.AddDays(2)); // tarihe 2 gün ekledi
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));


Console.WriteLine("***** Datetime Format ******");
Console.WriteLine(DateTime.Now.ToString("dd")); // 24
Console.WriteLine(DateTime.Now.ToString("ddd")); // sat
Console.WriteLine(DateTime.Now.ToString("dddd")); // saturday

Console.WriteLine(DateTime.Now.ToString("MM")); //04
Console.WriteLine(DateTime.Now.ToString("MMM")); // apr
Console.WriteLine(DateTime.Now.ToString("MMMM")); // april


Console.WriteLine(DateTime.Now.ToString("yy")); //22
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022


Console.WriteLine("**** Math Kütüphanesi ****");
Console.WriteLine(Math.Abs(-25)); // 25
Console.WriteLine(Math.Sin(10)); // sinus hesabı
Console.WriteLine(Math.Cos(10)); // cosinus
Console.WriteLine(Math.Tan(10)); // tanjant


Console.WriteLine(Math.Ceiling(22.3)); // 22.3'den büyük en küçük tam sayıyı getirir
Console.WriteLine(Math.Round(22.3)); // hangi tarafa yakınsa onu getirir
Console.WriteLine(Math.Round(22.7)); 
Console.WriteLine(Math.Floor(22.7)); // 22.7'den küçük en büyük tam sayıyı getirir


Console.WriteLine(Math.Max(2,6)); // 6 getirir
Console.WriteLine(Math.Min(2,6)); // 2 getirir 
Console.WriteLine(Math.Pow(3,4)); // 3 üzeri 4'ü verir
Console.WriteLine(Math.Sqrt(9)); // karekök alır
Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki karşılığı
Console.WriteLine(Math.Exp(3)); // e üzeri 3ü getirir
Console.WriteLine(Math.Log10(10)); // 10 sayısının log10 tabanındaki karşılığı