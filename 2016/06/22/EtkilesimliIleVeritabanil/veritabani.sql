CREATE TABLE IF NOT EXISTS `etkilesimliileveritabani` (
  `islem_id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(25) NOT NULL,
  `soyad` varchar(25) NOT NULL,
  `eposta` varchar(255) NOT NULL,
  `tel` int(11) DEFAULT NULL,
  `mesaj` text NOT NULL,
  `tarih` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`islem_id`)
)
