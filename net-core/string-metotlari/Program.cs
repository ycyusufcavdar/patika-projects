// See https://aka.ms/new-console-template for more information
// NET CORE 6.0


string degisken = "Dersimiz Csharp, Hosgeldiniz.";
string degisken2 = "Csharp";

//LENGTH;

Console.WriteLine(degisken.Length);

// ToUpper, ToLower;

Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());


// Concat

Console.WriteLine(string.Concat("Merhaba! ",degisken));

// Compare, CompareTo

Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
Console.WriteLine(string.Compare(degisken,degisken2,true)); // 0,1,-1  true denirse büyük küçük harf duyarsız olur.
Console.WriteLine(string.Compare(degisken,degisken2,false));

// Contains

Console.WriteLine(degisken.Contains(degisken2)); // Degisken'in içerisinde degisken2 varsa true döner.
Console.WriteLine(degisken.EndsWith("Hosgeldiniz.")); // Degisken hosgeldiniz ile bitiyorsa true döner.
Console.WriteLine(degisken.StartsWith("Merhaba")); // Degisken merhaba ile başlıyorsa true döner.

// Indexof

Console.WriteLine(degisken.IndexOf("Cs")); // Aratılan kelimeyi bulduğunda ilk harfin indexini döner, bulamazsa -1 döner.
Console.WriteLine(degisken.IndexOf("Yusuf"));

// LastIndexof
Console.WriteLine(degisken.LastIndexOf("i")); // Aratılan harfi son bulduğu indexi döner.

// Insert

Console.WriteLine(degisken.Insert(0,"Merhaba! ")); // İlk parametrede hangi indexten başlaması gerektiğini, ikinci parametrede neyi insertlemesi gerektiğini belirtiyoruz.

// PadLeft, PadRight

Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken2 + degisken.PadRight(50));
Console.WriteLine(degisken2 + degisken.PadRight(50,'-'));

// Remove

Console.WriteLine(degisken.Remove(10)); // 10.indexten başlar ve sonuna kadar siler. (10. indexten öncesini getirir)
Console.WriteLine(degisken.Remove(5,3)); // 5. indexten başlar ve 3 karakter siler.
Console.WriteLine(degisken.Remove(0,1)); // 0.indexten başlar ve 1 karakter siler.

// Replace

Console.WriteLine(degisken.Replace("Csharp","C#"));
Console.WriteLine(degisken.Replace(" ", "+"));

// Split

Console.WriteLine(degisken.Split(' ')[1]);

// Substring

Console.WriteLine(degisken.Substring(4)); // 4.indexten başlar cümle sonuna kadar getirir.
Console.WriteLine(degisken.Substring(4,6)); // 4.indexten başlar 6 karakter getirir.