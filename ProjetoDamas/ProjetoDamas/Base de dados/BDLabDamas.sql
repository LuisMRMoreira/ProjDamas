USE master
GO

CREATE DATABASE JogoDamas
GO

USE JogoDamas
GO

CREATE TABLE Jogador (
	jogador_id INTEGER IDENTITY(1,1) NOT NULL,
	jogador_nome VARCHAR(50) NOT NULL,
	jogador_password VARCHAR(20) NOT NULL,
	jogador_email VARCHAR(50) NOT NULL,
	jogador_pais VARCHAR(50) NOT NULL,
	jogadro_imagem VARCHAR(50) NOT NULL	
)



--CREATE TABLE Jogo (
--	jogo_jogador1,
--	jogo_jogador2,
--	jogo_data,
--	jogo_resultado,
--	jogo_tipo, --online ou local

--)

--CREATE TABLE Imagem (
--	imagem_id INTEGER IDENTITY(1,1) NOT NULL,
--	jogador_id INTEGER NOT NULL,
--	local_imagem VARCHAR(200) NOT NULL,
--	PRIMARY KEY (imagem_id),
--	FOREIGN KEY (jogador_id) REFERENCES Jogador(jogador_id)
--)