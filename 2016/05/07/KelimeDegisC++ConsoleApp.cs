#include<stdio.h>
#include<stdlib.h>
#include<string.h>

int main()
{
	char cumle[99999],kelime[10], degis[10], str[10][10];
	int i = 0, j = 0, k = 0, w, p;
	printf("Cumleyi girin\n");
	gets(cumle);
	printf("\nHangi kelime degistirilecek: ");
	scanf("%s", kelime);
	printf("\nNe ile degistirilsin?: ", kelime);
	scanf("%s", degis);
	p = strlen(cumle);

	for (k = 0; k < p; k++)
	{
		if (cumle[k] != ' ')
		{
			str[i][j] = cumle[k];
			j++;
		}
		else
		{
			str[i][j] = NULL;
			j = 0; i++;
		}
	}

	str[i][j] = NULL;
	w = i;

	printf("\n\nSonuc: ");
	for (i = 0; i <= w; i++)
	{
		if (strcmp(str[i], kelime) == 0)
			strcpy(str[i], degis);

		printf("%s ", str[i]);
	}
	printf("\n\n");

	return 0;
}
//http://eodev.com/gorev/8570147
