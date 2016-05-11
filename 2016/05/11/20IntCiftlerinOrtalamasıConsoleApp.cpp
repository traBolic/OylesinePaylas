#include<iostream>
using namespace std;

void main(){
	int sayi = NULL,
		i = 0,
		k = 0,
		topla = 0;

	do{
		cout << i + 1 << ". sayi: ";
		cin >> sayi;

		if (!cin)
		{
			cin.clear();
			cin.ignore(256, '\n');
		}
		else{
			if (sayi % 2 == 0)
			{
				topla += sayi;
				k++;
			}
			i++;
		}
	} while (sayi == NULL || i < 20);

	cout << "\n" << (topla / (double)k) << "\n\n";
}
//http://eodev.com/gorev/8605817
