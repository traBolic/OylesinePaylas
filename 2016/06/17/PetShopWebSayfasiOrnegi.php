<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Petshop</title>
</head>

<body>
<div class="banner"><img src="http://nairobihotel-link.com/wp-content/uploads/2015/08/pet-care.jpg" width="50%"></div>
<div class="icerik" style="width:50%;"><br><br><h1 style="color:#f00;">
<?php
// timezone tanımlaması, bazı sunucuların türkiye olarak tanımlanmamasından dolayı saatin farklı bir bölge ile gösterilmesine sebep olabilir. Türkiye zaman dilimine ayarlamak için aşağıdaki parametrelerin kullanılması sorunu giderecektir.
date_default_timezone_set('Europe/Istanbul');

$saat=22;
$selam="";
if($saat > 3){
	$selam= "Günaydın";
}
if($saat > 13){
	$selam= "Tünaydın";
}
if($saat > 16){
	$selam= "İyi akşamlar";
}
if($saat > 20 || $saat <=3){
	$selam= "İyi Geceler";
}
echo $selam;
?></h1>
<h3>Pug Özellikleri ve Bakımı</h3>
<p>Pug herkesin gözünde küçük ama büyükmüş gibi duran bir köpek olarak görünmektedir.Oldukca mutlu kendini hisseden ve sahibine çok sadık bir ırktır.Oyun oynamayı çok seven bir köpek cinsidir yaramazlıklarınla dikkatleri çeker.Sert cezalar bu tip ırkları küstürür ve dahada zorlar bu nedenle mümkün olduğunca sakince hareket edilmeli.Eğitimlerden çabuk sıkılabilecek bir köpek olan Puglar bazıları heyecanlı bazıları ise sönük bir karaktere sahip olabilmekteler.Pug bekçi köpekliğide yapabilir havlamayı çok fazla seven bir ırk değildir gerekli gördüğü takdirde havlar.Diğer hayvanlarla ve diğer köpeklerle çok iyi geçinmektedir.İlgiye çok muhtaçtırlar ve oldukcada kıskanç yapıları vardır sizi kıskanır.Pug 12-15 yıl arasında yaşayabilmektedir.</p>
</div>
</body>
</html>
