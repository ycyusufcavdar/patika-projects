// See https://aka.ms/new-console-template for more information
// Bu proje dökümanı net 6.0 ile oluşturulmuştur.

// Atama ve işlemli Atama
Console.WriteLine("*****Atama ve İşlemli Atama*****");
int x = 3;
int y = 3;

y = y+2;
Console.WriteLine(y);

y+=2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);
x*=2;
Console.WriteLine(x);


// Mantıksal Operatörler 
// && ve, || veya, ! değil
Console.WriteLine("*****Mantıksal Operatörler*****");

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted){
    Console.WriteLine("Perfect");
}
if(isSuccess || isCompleted){
    Console.WriteLine("Great");
}
if(isSuccess && !isCompleted){
    Console.WriteLine("Fine");
}

// İlişkisel Operatörler
// <, >, <=, >=, ==, !=
Console.WriteLine("*****İlişkisel Operatörler*****");

int a =3;
int b =4;
bool sonuc = a<b;
Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);

// Aritmetik Operatörler
// /, *, -, +, %

Console.WriteLine("*****Aritmetik Operatörler*****");

int sayi1= 10;
int sayi2= 5;
int sonuc1 = sayi1/sayi2;
Console.WriteLine("Bölme işlemi sonucu: " +sonuc1);
sonuc1= sayi1*sayi2;
Console.WriteLine("Çarpma işlemi sonucu: " +sonuc1);
sonuc1 = sayi1-sayi2;
Console.WriteLine("Çıkarma işlemi sonucu:  "+sonuc1);
sonuc1 = sayi1+sayi2;
Console.WriteLine("Toplama işlemi sonucu: " +sonuc1);
sonuc1 = ++sayi1;
Console.WriteLine("Sayıyı 1 ile toplama işlemi:" +sonuc1);

// Mod alma işlemi
int sonuc2 = 24%5;
Console.WriteLine("Mod alma sonucu:  " +sonuc2);