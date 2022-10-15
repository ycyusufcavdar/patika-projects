// See https://aka.ms/new-console-template for more information
// Net CORE 6.0


// Rekürsif - Öz Yinelemeli fonskisyon 
// 3^4 = 3*3*3*3

int result = 1;
for (int i = 1; i < 5; i++)
{
    result = result*3;
}
Console.WriteLine(result);
Islemler instance = new();

Console.WriteLine(instance.Expo(3,4));


//Extension Metotlar

string ifade = "Yusuf Çavdar";
bool sonuc = ifade.checkSpaces();
Console.WriteLine(sonuc);
if(sonuc)
{
    Console.WriteLine(ifade.deleteSpaces());
    Console.WriteLine(ifade.makeUpperCase());
    Console.WriteLine(ifade.makeLowerCase());
    
}

int[] dizi= {3,5,6,1,2,7};
dizi.sortArray();
dizi.ekranaYazdir();


int sayi = 5;

Console.WriteLine(sayi.isEven());

Console.WriteLine(ifade.getFirstChar());










public class Islemler
{

    public int Expo(int sayi, int us)
    {
        if(us<2)
            return sayi;
        return Expo(sayi,us-1)*sayi;
    }
    //EXPO(3,4)
    //EXPO(3,3)*3
    //EXPO(3,2)*3*3
    //EXPO(3,1)*3*3*3
    // 3*3*3*3 = 3^4
}

public static class Extension
{
    public static bool checkSpaces(this string param)
    {
        return param.Contains(" ");

    }
    public static string deleteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("",dizi);
    }
    public static string makeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string makeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] sortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void ekranaYazdir(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }
    public static bool isEven(this int param)
    {
        return param%2 == 0;
    }

    public static string getFirstChar(this string param)
    {
        return param.Substring(0,1);
    }
}