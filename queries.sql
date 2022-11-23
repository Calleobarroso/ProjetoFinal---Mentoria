
CREATE TABLE user (
  id int(11) unsigned NOT NULL AUTO_INCREMENT,
  Nome varchar(50) NOT NULL,
  CPF int(11) NOT NULL,
  nascimento int(11) NOT NULL,
  endereço varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
);