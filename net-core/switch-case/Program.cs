﻿// See https://aka.ms/new-console-template for more information

int month = DateTime.Now.Month;

// Expression
switch (month)
{
    case 1:
        Console.WriteLine("Ocak Ayındasınız");
        break;
    case 2:
        Console.WriteLine("Şubat Ayındasınız");
        break;
    case 3:
        Console.WriteLine("Mart Ayındasınız");
        break;
    case 4:
        Console.WriteLine("Nisan Ayındasınız");
        break;
    case 8:
        Console.WriteLine("Ağustos Ayındasınız");
        break;

    default:
        Console.WriteLine("Yanlış veri girişi!");
    break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Ayındasınız");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Bahar Ayındasınız");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz Ayındasınız");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar Ayındasınz");
        break;
    default:
    break;
}