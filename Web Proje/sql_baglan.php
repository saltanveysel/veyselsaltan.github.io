<?php
   @$baglanti = mysqli_connect("localhost", "root", "","bilgi_yarismasi");
   if ( !$baglanti )
	exit( "Bağlantı sağlanamadı." );
   mysqli_select_db( $baglanti,"telefon_defteri" );
   mysqli_query($baglanti,"SET NAMES UTF8");
   

?>