USE master
GO

CREATE DATABASE PortalVinhos
GO

USE PortalVinhos
GO

CREATE TABLE Jogador (
	jogador_id INTEGER IDENTITY(1,1) NOT NULL,
	jogador_nome,
	jogador_password,
	jogador_email,
	jogador_pais,
	
)



CREATE TABLE Jogo (
	jogo_jogador1,
	jogo_jogador2,
	jogo_data,
	jogo_resultado,
	jogo_tipo, --online ou local

)

CREATE TABLE Imagem (
	imagem_id INTEGER IDENTITY(1,1) NOT NULL,
	jogador_id INTEGER NOT NULL,
	local_imagem VARCHAR(200) NOT NULL,
	PRIMARY KEY (imagem_id),
	FOREIGN KEY (jogador_id) REFERENCES Jogador(jogador_id)
)