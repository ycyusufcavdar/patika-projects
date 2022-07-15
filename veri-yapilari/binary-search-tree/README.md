# binary-search-tree
## [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

Root'u 7 olarak seçtiğimiz koşulda;
1.  5, 7'den küçüktür ve sola yazılır.
2.  1, 7'den ve 5'ten küçüktür, o halde 5'in soluna yazılır.
3.  8, 7'den büyüktür ve sağa yazılır.
4.  3, 7'den ve 5'ten küçüktür ancak 1'den büyüktür, bu durumda 1'in sağına yazılır.
5.  6, 7'den küçüktür ancak 5'ten büyüktür, bu durumda 5'in sağına yazılır.
6.  0, 7'den, 5'ten ve 1'den küçüktür, bu durumda 1'in soluna yazılır.
7.  9, 7'den ve 8'den büyüktür, bu durumda 8'in sağına yazılır.
8.  4, 7'den ve 5'ten küçüktür ancak 3'ten büyüktür, bu durumda 3'ün sağına yazılır.
9.  2, 7'den, 5'ten ve 3'ten küçüktür, bu durumda 3'ün soluna yazılır.

Aşağıdaki görselde oluşturulan Tree gösterilmiştir. Bu görsel digrams.net aracılığı ile yapılmıştır.

![image](https://user-images.githubusercontent.com/89012489/177681494-83c533cb-289f-482f-b2ac-17b3fd2953f8.png)
