#include<iostream>
#include<string>
using namespace std;


int main() {

	int x, y, z, a, b, c;
	string ad;
	string soyad;

	cout << "Ilk sayiyi giriniz: " << endl;
	cin >> x;
	cout << "Ikinci sayiyi giriniz: " << endl;
	cin >> y;
	cout << "Ucuncu sayiyi giriniz: " << endl;
	cin >> z;
	cout << "Adinizi giriniz: " << endl;
	cin >> ad;
	cout << "Soyadinizi giriniz :" << endl;
	cin >> soyad;
	cout << "Numaranizi giriniz :" << endl;
	cin >> c;
	a = x + y;

	b = a*z;

	cout << "Adi :" << ad << endl;
	cout << "Soyadi: " << soyad << endl;
	cout << "Numarasi: " << c << endl;
	cout << "Cevap: " << b << endl;

	return 1;
}
