<?php





$planets = ["Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "", "", NULL];

function myFunc($array, $value)
{
    // Boş değerleri elemek için filtre uyguluyoruz. Bu filtre bize true değer döndüren değerleri verecek.
    $filtre = array_filter($array);
    // Rand bir diziden belli sayıda rastgele anahtar döndürmek için kullanılır. Eklediğimiz $value ile birlikte anahtar yerine değer göndermesini sağlıyoruz.
    $random = array_rand($filtre, $value);
    // Map ile callback işlemi uyguluyoruz. Burada itemlere filtre işlemi uyguluyoruz. Ve fonksiyonu geri çağırıyoruz.
    $result = array_map(function ($item) use ($filtre){
        return $filtre[$item];
    }, $random );
    return $result;
         
}
// pre etiketi elde ettiğimiz arraylarin alt alta gözükmesini sağlıyor.
echo '<pre>';
print_r(myFunc($planets,2));
print_r(myFunc($planets,3));
print_r(myFunc($planets,2));
print_r(myFunc($planets,4));
print_r(myFunc($planets,5));
