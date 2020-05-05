<?php
include 'sql_baglan.php';
session_start();
if(isset($_POST['username']) and isset($_POST['sifre']))
{
$username=$_POST['username'];
$sifre=$_POST['sifre'];
}
else
{
	echo "<center>Lutfen kullanici adi ya da sifreyi bos birakmayiniz..!" 
	header("Location:index.html");
}
 $sorgu=mysqli_query($baglanti,"Select kullaniciadi From admin WHERE kullaniciadi=$username And sifre=$sifre");
 if(mysql_num_rows($sorgu) > 0)
{
   $_SESSION["admin"] = "true";
    $_SESSION["user"] = $kadi;
    $_SESSION["pass"] = $sifre;
    header("Location:admin.html");
}
$sorgu2=mysqli_query($baglanti,"Select kullaniciadi From kullanici WHERE kullaniciadi=$username And sifre=$sifre");
if(mysql_num_rows($sorgu) > 0)
{
   $_SESSION["uye"] = "true";
    $_SESSION["user"] = $username;
    $_SESSION["pass"] = $sifre;
    header("Location:index.html");
}
else
{
	echo "<center>Kullanici Adi/Sifre Yanlis."
}
 mysqli_close($baglanti);
?>