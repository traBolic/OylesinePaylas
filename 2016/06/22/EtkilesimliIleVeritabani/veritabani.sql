CREATE TABLE IF NOT EXISTS `etkilesimliileveritabani` (
  `kayit_id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(25) NOT NULL,
  `soyad` varchar(25) NOT NULL,
  `eposta` varchar(255) NOT NULL,
  `tel` int(11) DEFAULT NOT NULL,
  `mesaj` text NOT NULL,
  `tarih` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`kayit_id`)
)
