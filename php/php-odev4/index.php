<?php
    // Kare Alan Hesabı -> a*a, Kare Çevre Hesabı ->a*4 , Dikdörtgen Alan Hesabı -> a*h , Dikdörtgen Çevre Hesabı -> a*2+h*2 , Üçgen Çevre Hesabı -> x+a+h , Üçgen Alan Hesabı -> kare kök içinde  çevre/2 *(çevre/2-a)(çevre/2-h)(çevre/2-x) şeklinde bulunur.

     class Sekil{
        public $a, $h,$x; 

        public function __construct ($a, $h = null,$x = null)
        {
            // a - TABAN h - YÜKSEKLİK x - Hipotenüs 
            $this->a = $a;
            $this->h = $h;
            $this->x = $x;
        }
     }

     class kare extends Sekil
     {
        public function alan() 
        {
            return ($this->a * $this->a);
        }
        public function cevre()
        {
            return $this->a*4;
        }
     }

     class dDortgen extends Sekil
     {
        public function alan()
        {
            return $this->a*$this->h ;
        }
        public function cevre()
        {
            return ($this->a*2)+($this->h*2) ;
        }

     }
     class ucgen extends Sekil
     {
        public function cevre()
        {
            return ($this->a + $this->h + $this->x);
        }
        public function alan()
        {
            $cevre= $this->cevre();
            $p = $cevre/2;
            return sqrt($p * ($p - $this->a)* ($p - $this->h) * ($p - $this->x));
        }
     }


     $kare = new kare(5);
     $dDortgen = new dDortgen(15,9);
     $ucgen = new ucgen(8,9,10);


     echo "Kare Alanı ". $kare->alan(). "<br>";
     echo "Kare Çevresi ". $kare->cevre(). "<br>";
     echo "Dikdörtgen Alanı ". $dDortgen->alan(). "<br>";
     echo "Dikdörtgen Çevresi ". $dDortgen->cevre(). "<br>";
     echo "Üçgen Çevresi ". $ucgen->cevre(). "<br>";
     echo "Üçgen Alanı ". $ucgen->alan(). "<br>";

