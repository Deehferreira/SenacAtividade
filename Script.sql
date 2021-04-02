CREATE DATABASE ProjCadastros;
USE ProjCadastros;
CREATE TABLE Usuario(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255),
    login VARCHAR(255),
    senha VARCHAR(255),
    dataNascimento Date);
    INSERT INTO Usuario (nome,login,senha,dataNascimento) VALUES ('Regina','Regi','1234','2004-04-08');
select * from Usuario;
CREATE TABLE Pacotes(
	id INT primary key auto_increment not null,
    nome VARCHAR(255) ,
    origem VARCHAR(200) ,
    destino VARCHAR(200) ,
    atrativos VARCHAR(200) ,
    saida DATE,
    retorno DATE,
    usuario INT,
    foreign key(usuario) references usuario(id));
select * from Pacotes;