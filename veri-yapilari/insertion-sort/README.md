# insertion-sort
## [22,27,16,2,18,6] -> Insertion Sort
### 1-) Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
Sıralama algoritmasının kontrol aşamaları dışında kalan ve sadece sıralamanın değiştiği durumlar için gösterim şu şekildedir;
[22,27,16,2,18,6]
[2,27,16,22,18,6]
[2,6,16,22,18,27]
[2,6,16,18,22,27]

### 2-) Big-O gösterimini yazınız.
Insertion sort algoritması için Big-O O(n^2)'dir ancak burada belirtilen n^2 baskınlığı sebebiyle belirtilmiştir. Gerçek sonuca ulaşabilmemiz için yapmamız gereken işlem, ((n^2+n)/2)'dir. Bu işlemi yapacak olursam ((6^2+6)/2)'den sonucumuz 21 çıkar.

### 3-) Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
Best Case senaryosu için O(n)'dir ve buradan sonuç 6 çıkar.
Average Case ve worst case senaryoları için O(n^2) olarak hesaplanmış olup sonuç 36'dır.

### 4-) Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.
Dizinin ortasına yakın bulunduğu için avarage case kapsamına girer.

### Ekstra-) [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.
Sıralama algoritmasının kontrol aşamaları dışında kalan ve sadece sıralamanın değiştiği durumlar için gösterim şu şekildedir;
[2,3,5,8,7,9,4,15,6]
[2,3,4,8,7,9,5,15,6]
[2,3,4,5,7,9,8,15,6]
[2,3,4,5,6,9,8,15,7]
