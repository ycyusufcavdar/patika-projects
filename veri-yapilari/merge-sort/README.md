# merge-sort
## [16,21,11,8,12,22] -> Merge Sort
### 1-) Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.
Aşamalar halinde ilerlemek gerekirse, arraydeki parçarlın ikiye bölünmek suretiyle ayrılıp sonrasında sıralanarak tekrardan birleşmesi gerekmektedir.
  [16,21,11,8,12,22]
  [16,21,11] [8,12,22]
  [16] [21,11] [8] [12,22]
  [16] [21] [11] [8] [12] [22]
Parçaların hepsi ayrıldı, şimdi sıralamak suretiyle birleştirmemiz gerekmekte.
  [16] [11,21] [8] [12,22]
  [11,16,21] [8,12,22]
  [8,11,12,16,22]
Sıralama işleminin sonucunda [8,11,12,16,22] sonucuna ulaştık.

### 2-) Big-O gösterimini yazınız.
O(nlogn) durumu her case için geçerlilik göstermektedir.

n->6 olduğuna göre;
O(6*log6) sonucuna ulaşırız.
