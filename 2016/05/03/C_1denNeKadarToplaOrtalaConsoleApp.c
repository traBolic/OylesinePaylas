#include<stdio.h>

void main(){
	int n, topla=0, i;

	printf("Sayi gir: ");
	scanf_s("%d", &n);

	if (n > 0)
	{
		for (i = 1; i < n; i++){
			topla += i;
		}
		printf("\nOrtalama: %.1f\n\n", topla / ((double)i));
	}
}
