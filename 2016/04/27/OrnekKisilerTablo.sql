Create Table Kisiler(
	id Int Not Null Identity(1,1) Primary key,
	isim Varchar(20),
	soyisim Varchar(20)
);

Alter Table Add Ulke Varchar(20);

Update Kisiler Set isim = 'Kirigaya', soyisim = "Kazuto", ulke = 'Japonya' Where id = '1';
Update Kisiler Set isim = 'Lucifer', soyisim = "Morningstar", ulke = 'İngiltere'  Where id = '2';
Update Kisiler Set isim = 'Walter', soyisim = "O'Brian", ulke = 'Amerika'  Where id = '3';
Update Kisiler Set isim = 'Stan', soyisim = "Lee", ulke = 'Amerika'  Where id = '4';
Update Kisiler Set isim = 'Naruto', soyisim = "Uzumaki", ulke = 'Japonya'  Where id = '5';

Select * From Kisiler;
Select isim From kisiler;
Select isim, soyisim, ulke From kisiler;
Select isim, soyisim From kisiler Where id = 1;
Select * From kisiler Where isim = "Naruto" And soyisim = "Uzumaki";
Select * From kisiler Where id >= 2 And id <= 4;
Select * From kisiler Where ulke Like 'ame%';
Select * From kisiler Order By Asc;
Select * From kisiler Order By Desc;
Select * From kisiler Group By ulke;

Drop Table Kisiler;
