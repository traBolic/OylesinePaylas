#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main () {
    int n=10,
        dizi[n],
        k=10,
        b=105,
        sayi, a, i, j;

    // Her seferinde farklı bir rakam üretmesinde kullanılır.
    srand ( time(NULL) );


    // 10 adet rastgele sayı üretip, diziye atıyoruz
    for(i=0; i<n; i++) {
        sayi = (rand() % (b + 1 - k)) + k;
        dizi[i] = sayi;
    }


    // Sayıları, büyükten küçüğe sıralamadan önceki halini ekrana basıyoruz
    printf("Uretilen sayilar:\n");
    for(i=0; i<n; i++)
        printf("dizi[%d] -> %d\n", i, dizi[i]);


    // dizi içerisinde bulunan sayıları büyükten küçüğe sıralıyoruz
    for (i = 0; i < n; ++i)
        for (j = i + 1; j < n; ++j)
            if (dizi[i] < dizi[j]) {
                a = dizi[i];
                dizi[i] = dizi[j];
                dizi[j] = a;
            }


    printf("\n\nDizideki sayilarin buyukten kucuğe siralanmiş hali: \n");


    // Sıralanmış sayıları, ekrana basıyoruz
    for(i=0; i<n; i++)
        printf("dizi[%d] -> %d\n", i, dizi[i]);


    return 0;
}
