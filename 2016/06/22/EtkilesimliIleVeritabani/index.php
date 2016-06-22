<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>İletişim</title>
<style>
td {
	padding: 0 3px;
}
textarea {
	margin: 0px;
	width: 98.6%;
	height: 70px;
	resize: vertical;
}
input:not([type=radio]) {
	width: 98%;
}
</style>
</head>
<body>
<?php
if(@$_GET["islem"]!=""){
	// Aşağıdaki try catch kod bloğunda, blok arasına eklenen işlemleri işlemeyi dener. Önce $db değişkenine veritabanına bağlanmak için bir bağlantı açar. Çünkü veri tabanına veri girişi çıkışı yapabilmemiz için, açık bir bağlantıya ihtiyacımız olacak.
	try {
		// Bağlantı oluşturulurken, dbname değerine veritabanın adını veririz. host kısmına, veritabanı sunucusunun ip adresi veya internet adresi verilir. 2. ve 3. parametrelere de veritabanının kullanıcı adı ve şifresi girilir.
		$vt = new PDO("mysql:dbname=eodevlocal;host=localhost", "root", "" );
	} 
	// Bağlantı nesnesi, bağlantıyı başarılı olarak sağlayamazsa, hatayı yakalaması için catch fonksiyonu kullanır ve parametre altında gelecek olan dizideki mesajı ekrana echo ile yazdıdırır. 
	catch(PDOException $e) {
		echo $e->getMessage();
	}
	
	// Eğer sayfaya post gönderilmişse ve post edilen veriler arasında form girişleri tanımlı ise, işlemlere başlar
	if($_POST && $_GET["islem"]=="kayit" && isset($_POST['ad']) && isset($_POST['soyad']) && isset($_POST['eposta']) && isset($_POST['tel']) && isset($_POST['mesaj'])){
		
		// Açılmış olan veritabanı nesnesinin alt fonksiyonu olan prepare fonksiyonunu kullanarak, SQL sorgusunu çalıştırılması için hazırlar.
		$sorgu = $vt->prepare("INSERT INTO EtkilesimliIleVeritabani SET
								ad = :ad,
								soyad = :soyad,
								eposta = :eposta,
								tel = :tel,
								mesaj = :mesaj");
								
		// POST metodu ile gelen verileri, veritabanına kaydetmek için bir dizi içerisine atılır ve bunları sorgu nesnesine alt fonksiyonu olan execute'a parametre verdikten sonra $ekle değişkenine atanır.
		$ekle = $sorgu->execute(array(
			  "ad" => @$_POST['ad'],
			  "soyad" => @$_POST['soyad'],
			  "eposta" => @$_POST['eposta'],
			  "tel" => @$_POST['tel'],
			  "mesaj" => @$_POST['mesaj'],
		));
		
		// Eğer ekleme işlemi başarılı bir şekilde tamamlanırsa, $ekle değişkeninin değeri true olacağı için if fonksiyonu ile değer true ise başarılı, değilse başarısız mesajı gösterilir.
		if ( $ekle )
			echo "<br>Mesajınız bize ulaştı. Girdiğiniz bilgiler doğrultusunda sizinle en kısa sürede iletişime geçilecektir.<br><br><br>";
		else
			echo "Bir hata oluştu ve bilgiler kayıt edilemedi.";
	}
	elseif($_POST && $_GET["islem"]=="guncelle" && isset($_POST['ad']) && isset($_POST['soyad']) && isset($_POST['eposta']) && isset($_POST['tel']) && isset($_POST['mesaj'])){
		
		// Listelenen verilerin bulunduğu tabloda, her kayıt için bir radio button bulunur. Silinmesi için seçilen radio, düzenle butonuna basıldıktan sonra sil butonu aktifse, önce silim işlemleri yapılır. 
		if(@$_POST["sil"]==1){
			
			// Silme işleminde DELETE komutu kullanılır. Aynı SELECT işleminde olduğu gibi kullanılır sadece SELECT işleminde seçilecek tablolar belirtilmez.
			$sorgu = $vt->prepare("DELETE FROM EtkilesimliIleVeritabani WHERE kayit_id = :kayit_id");
			$sil = $sorgu->execute(array(
			   'kayit_id' => $_POST['kayit_id']
			));
			// Eğer silme işlemi başarılı ise ekrana başarılı mesajı verir.
			if($sil){
				echo '<br>Başarıyla silindi<br><br>';
			}
		}
		// Eğer sil butonu seçilmemişse, düzenleme işlemleri yapılır.
		else{
			
			// Güncelleme işlemi ise, ekleme işlemlerine benzer şekilde gerçekleşir lakin UPDATE işleminde, değişim yapılacak satırın PRIMARY KEY sütununa ait bir değer girilmesi gerekir. Nedeni ise, program hangi kayıtı düzenleyeceğini bilmeden düzeltemez. Bu yüzden bir seçici ister. Bu seçici de genelde PRIMARY KEY'dir.
			$sorgu = $vt->prepare("UPDATE EtkilesimliIleVeritabani SET
								ad = :ad,
								soyad = :soyad,
								eposta = :eposta,
								tel = :tel,
								mesaj = :mesaj
								WHERE kayit_id=:kayit_id");
								
			// POST metodu ile gelen verileri, veritabanına kaydetmek için bir dizi içerisine atılır ve bunları sorgu nesnesine alt fonksiyonu olan execute'a parametre verdikten sonra $ekle değişkenine atanır.
			$guncelle = $sorgu->execute(array(
				  "ad" => @$_POST['ad'],
				  "soyad" => @$_POST['soyad'],
				  "eposta" => @$_POST['eposta'],
				  "tel" => @$_POST['tel'],
				  "mesaj" => @$_POST['mesaj'],
				  "kayit_id" => @$_POST['kayit_id']
			));
			// Eğer güncelleme işlemi başarılı ise ekrana başarılı mesajı verir.
			if($guncelle)
				echo '<br>Başarıyla güncellendi<br><br>';
		}
	}
?>
<table width="100%" border="1" cellspacing="0" cellpadding="0">
	<thead>
		<tr height="40">
			<th scope="col">Ad</th>
			<th scope="col">Soyad</th>
			<th scope="col">E-Posta</th>
			<th scope="col">Telefon</th>
			<th scope="col">Mesaj</th>
			<th scope="col">Eklenme Tarihi</th>
			<th scope="col">Sil</th>
			<th scope="col">&nbsp;</th>
		</tr>
	</thead>
	<?php
	// Veritabanında kayıtlı verileri listelemek içinse, açık olan bağlantıyı kullanarak SELECT komutu ile veri tabanındaki verilere erişir, foreach döngüsü ile de veritabanından gelen her satır için döngü açar ve dönen kayıtlar için isteğe göre listeler. SELECT yapılırken * olan kısımda tablodaki sütunlar istenildiği durumda özel olarak belirtilebilir ve sütunları , virgül kullanara ayırabilirsiniz. Fakat veri çekerken tüm sütunları ele almak istiyorsanız * ifadesi koymak yeterli olacaktır. PDO::FETCH_ASSOC komutu, PDO nesnesinin bir özelliğidir. Veritabanından verileri çekerken, sütunları kendi indisine göre de ayırır. Fakat bizim için indise göre ayırmak çok da önemli değil çünkü indise göre değilde, daha rahat okuyabilmek için FETCH_ASSOC komutunu kullanarak sadece sütun adlarını çekiyor oluruz. 
	$sorgu = $vt->query("SELECT * FROM EtkilesimliIleVeritabani", PDO::FETCH_ASSOC);
	
	// Karar kullanarak $sorgu içerisinde çekilen verinin sayısına bakılır. Eğer sayı 0 dan büyük bir sayı ise, listeleme işlemlerine devam edilir.
	if ( $sorgu->rowCount() ){
		foreach( $sorgu as $kayit ){ ?>
	<form action="?islem=guncelle" method="post" name="form1" id="form1">
		<tbody>
			<tr>
				<td><input type="text" name="ad" value="<?php echo $kayit["ad"];?>"></td>
				<td><input type="text" name="soyad" value="<?php echo $kayit["soyad"];?>"></td>
				<td><input type="mail" name="eposta" value="<?php echo $kayit["eposta"];?>"></td>
				<td><input type="tel" name="tel" value="<?php echo $kayit["tel"];?>"></td>
				<td><textarea name="mesaj"><?php echo $kayit["mesaj"];?></textarea></td>
				<td><?php echo $kayit["tarih"];?></td>
				<td align="center"><input type="radio" name="sil" id="radio" value="1"></td>
				<td><input type="hidden" name="kayit_id" value="<?php echo $kayit["kayit_id"];?>">
					<input type="submit" name="button" id="button" value="Düzenle"></td>
			</tr>
		</tbody>
	</form>
	<?php
		}
	}
	// Eğer değilse, aşağıdaki metinde olduğu gibi veri bulunamadı mesajı çıkacaktır.
	else
		echo '<tr align="center" height="80"><td colspan="8">Listelenecek veri bulunamadı</td></tr>';
	?>
</table>
<?php
}
// Eğer sayfada GET edilen bir veri yoksa, sayfa içerisinde form objeleri görünür.
else{
?>
<form action="?islem=kayit" method="post" name="form1" id="form1">
	<table width="400" border="1" cellspacing="0" cellpadding="0">
		<tbody>
			<tr>
				<td width="100"><label for="ad">Adı:</label></td>
				<td width="294"><input type="text" name="ad" id="ad"></td>
			</tr>
			<tr>
				<td><label for="soyad">Soyadı:</label></td>
				<td><input type="text" name="soyad" id="soyad"></td>
			</tr>
			<tr>
				<td><label for="eposta">E-Posta:</label></td>
				<td><input type="mail" name="eposta" id="eposta"></td>
			</tr>
			<tr>
				<td><label for="tel">Telefon:</label></td>
				<td><input type="tel" name="tel" id="tel"></td>
			</tr>
			<tr>
				<td><label for="mesaj">Mesaj:</label></td>
				<td><textarea name="mesaj" cols="40" rows="6" id="mesaj"></textarea></td>
			</tr>
			<tr>
				<td height="50" colspan="2" align="center"><input type="submit" name="submit" id="submit" value="Gönder"></td>
			</tr>
		</tbody>
	</table>
</form>
<?php
} ?>
</body>
</html>
