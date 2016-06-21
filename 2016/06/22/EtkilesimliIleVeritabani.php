<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>İletişim</title>
</head>
<body><?php
// Eğer sayfaya post gönderilmişse ve post edilen veriler arasında form girişleri tanımlı ise, işlemlere başlar
if($_POST && isset($_POST['ad']) && isset($_POST['soyad']) && isset($_POST['eposta']) && isset($_POST['tel']) && isset($_POST['mesaj'])){
	
	// Aşağıdaki try catch kod bloğunda, blok arasına eklenen işlemleri işlemeyi dener. Önce $db değişkenine veritabanına bağlanmak için bir bağlantı açar. Çünkü veri tabanına veri girişi çıkışı yapabilmemiz için, açık bir bağlantıya ihtiyacımız olacak.
	try {
		$vt = new PDO("mysql:dbname=eodevlocal;host=localhost", "root", "" );
	} 
	// Bağlantı başarılı olarak sağlanmazsa, ekrana hatayı yakalaması için catch fonksiyonu kullanır ve parametre altında gelecek olan dizideki mesajı ekrana echo ile yazdıdırır. 
	catch(PDOException $e) {
		echo $e->getMessage();
	}
	
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
	if ( $ekle ){
		echo "Mesajınız bize ulaştı. Girdiğiniz bilgiler doğrultusunda sizinle en kısa sürede iletişime geçilecektir.";
	}
	else{
		echo "Bir hata oluştu ve bilgiler kayıt edilemedi.";
	}
	
}
// Eğer sayfada POST edilen bir veri yoksa, sayfa içerisinde form objeleri görünür.
else{
?>
<form action="" method="post" name="form1" id="form1">
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
</form><?php
}
?>
</body>
</html>
