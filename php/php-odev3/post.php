<?php
$sayi = $_POST["sayi"];
if($sayi == ""){
    echo "Lütfen bir değer giriniz. <br>";
    echo '<a href="index.php"> Geri Dön</a>';
}else{
    if($sayi % 3 == 0){
        echo "Sayı 3 ile tam bölünüyor.";
        echo '<a href="index.php"> Geri Dön</a>';
    }else{
        $yeniSayi = $sayi;
        while($yeniSayi % 3 !==0){
            $yeniSayi++;
        }
        echo "$sayi sayısı 3 ile tam bölünemiyor. Yeni sayı: $yeniSayi";
        echo '<a href="index.php"> Geri Dön</a>';
    }
    }

    ?>