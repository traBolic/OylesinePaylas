#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int satir = 5,
        sutun = 3,
        dizi[satir][sutun],
        k = 5,
        b = 15,
        sayi, i, j;

    srand(time(NULL));


    for (i = 0; i < satir; i++)
        for (j = 0; j < sutun; j++) {
            if(j == 0) {
                dizi[i][j] = (rand() % (b + 1 - k)) + k;
            }
            else if(j == 1) {
                scanf("%d", &sayi);
                dizi[i][j] = sayi;
            }
            else if(j == 2) {
                dizi[i][j] = dizi[i][0] * dizi[i][1] + 10;
            }
        }

    
    printf("Sayilar:\n");
    for (i = 0; i < satir; i++) {
        printf(" dizi[%d] = [", i);
        for (j = 0; j < sutun; j++) {
            printf("%d", dizi[i][j]);
            if ((j + 1) != sutun)
                printf(",");
        }
        printf("]\n");
    }

    return 0;
}
