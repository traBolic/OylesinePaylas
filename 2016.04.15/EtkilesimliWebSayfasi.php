<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>İletişim</title>
</head>
<body><?php
if($_POST){
	$icerik = "Adı: ".@$_POST['ad'].
			   ", Soyadı: ".@$_POST['soyad'].
			   ", E-Posta: ".@$_POST['email'].
			   ", Telefon: ".@$_POST['tel'].
			   ", Mesaj: ".@$_POST['mesaj'];
	$dosya = fopen($_SERVER['DOCUMENT_ROOT'] . "/bilgiler.txt","wb");
	if(fwrite($dosya,$icerik)){
		echo "<h2>Bilgileriniz başarılı bir şekilde kayıt edildi</h2>";
	}
	else{
		echo "<h2>Malesef bilgileriniz bize ulaşmadı. Lütfen Yeniden deneyin.</h2>";
	}
	fclose($dosya);
}
?> 
<form action="" method="post" name="form1" id="form1">
 <table width="330" border="1" cellspacing="0" cellpadding="0">
  <tbody>
   <tr>
    <td width="153"><label for="ad">Adı:</label></td>
    <td width="176"><input type="text" name="ad" id="ad"></td>
   </tr>
   <tr>
    <td><label for="soyad">Soyadı:</label></td>
    <td><input type="text" name="soyad" id="soyad"></td>
   </tr>
   <tr>
    <td><label for="email">E-Posta:</label></td>
    <td><input type="email" name="email" id="email"></td>
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
    <td height="50" colspan="2" align="center"><input type="submit" name="submit" id="submit" value="Submit"></td>
   </tr>
  </tbody>
 </table>
</form>
</body>
</html>
