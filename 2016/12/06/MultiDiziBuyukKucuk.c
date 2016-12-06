#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int satir = 2,
        sutun = 10,
        dizi[satir][sutun],
        k = 10,
        b = 100,
        sayi, a, i, j, l;

    srand(time(NULL));

    for (i = 0; i < satir; i++)
        for (j = 0; j < sutun; j++) {
            dizi[i][j] = (rand() % (b + 1 - k)) + k;
            dizi[i][j] = (rand() % (b + 1 - k)) + k;
        }

    
    printf("Uretilen sayilar:\n");
    for (i = 0; i < satir; i++) {
        printf(" dizi[%d] = [", i);
        for (j = 0; j < sutun; j++) {
            printf("%d", dizi[i][j]);
            if ((j + 1) != sutun)
                printf(",");
        }
        printf("]\n");
    }

    
    for (i = 0; i < satir; i++) {
        if (i == 0) {
            for (j = 0; j < sutun; ++j)
                for (l = j + 1; l < sutun; ++l)
                    if (dizi[i][j] < dizi[i][l]) {
                        a = dizi[i][j];
                        dizi[i][j] = dizi[i][l];
                        dizi[i][l] = a;
                    }
        }
        else if (i == 1) {
            for (j = 0; j < sutun; ++j)
                for (l = j + 1; l < sutun; ++l)
                    if (dizi[i][j] > dizi[i][l]) {
                        a = dizi[i][j];
                        dizi[i][j] = dizi[i][l];
                        dizi[i][l] = a;
                    }
        }
    }

    
    printf("\n\nSiralandiktan sonra:\n");
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
