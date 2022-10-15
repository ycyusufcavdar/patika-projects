// See https://aka.ms/new-console-template for more information
// Bu ders dosyası net core 6.0 ile oluşturulmuştur.

// try
// {
//     // Hata ihtimalı olan kod bloğu.
//     Console.WriteLine("Bir sayı giriniz");
//     int sayi = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
// }
// catch(System.Exception ex)
// {
//     // Hata olursa yapılacak işlem
//     Console.WriteLine("Hata: " + ex.Message.ToString());
// }
// finally
// {
//     // Hata olsun ya da olmasın, işlemin son aşaması. Ancak burası opsiyonel.
//     Console.WriteLine("İşlem tamamlandı");
// }


try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-2000000000000000");
}
catch (System.ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine(ex);
}
catch (System.FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
catch (System.OverflowException ex)
{
    Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem başarıyla tamamlanmıştır.");
}