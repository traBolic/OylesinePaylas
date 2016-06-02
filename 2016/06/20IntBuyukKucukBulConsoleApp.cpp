#include <iostream>

using namespace std;

int main(){
	int sayi,
		buyuk = -32767,
		kucuk = 32767;
	for (int i = 1; i <= 20; i++)
	{
		cout << i << ". sayiyi gir: ";
		cin >> sayi;

		if (sayi > buyuk)
			buyuk = sayi;
		if (sayi < kucuk)
			kucuk = sayi;
	}
	cout << "\nEn buyuk sayi: " << buyuk << "\nEn kucuk sayi: " << kucuk << "\n\n";
	return 0;
}
//http://eodev.com/gorev/8770200
