-- Creazione del database
CREATE DATABASE fantacalcio;

-- Selezione del database appena creato
USE fantacalcio;

-- Creazione della tabella "giocatori"
CREATE TABLE giocatori (
  id INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(50) NOT NULL,
  ruolo ENUM('P', 'D', 'C', 'A') NOT NULL,
  squadra VARCHAR(50) NOT NULL,
  valore DECIMAL(5,2) NOT NULL,
  fantavoto DECIMAL(4,2) DEFAULT NULL
);

-- Creazione della tabella "squadre"
CREATE TABLE squadre (
  id INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(50) NOT NULL
);

-- Creazione della tabella "allenatori"
CREATE TABLE allenatori (
  id INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(50) NOT NULL,
  squadra_id INT NOT NULL,
  FOREIGN KEY (squadra_id) REFERENCES squadre(id)
);

-- Creazione della tabella "rose"
CREATE TABLE rose (
  id INT PRIMARY KEY AUTO_INCREMENT,
  allenatore_id INT NOT NULL,
  giocatore_id INT NOT NULL,
  FOREIGN KEY (allenatore_id) REFERENCES allenatori(id),
  FOREIGN KEY (giocatore_id) REFERENCES giocatori(id)
);

-- Creazione della tabella "giornate"
CREATE TABLE giornate (
  id INT PRIMARY KEY AUTO_INCREMENT,
  numero INT NOT NULL,
  data DATE NOT NULL
);

-- Creazione della tabella "voti"
CREATE TABLE voti (
  id INT PRIMARY KEY AUTO_INCREMENT,
  giornata_id INT NOT NULL,
  giocatore_id INT NOT NULL,
  voto DECIMAL(4,2) NOT NULL,
  FOREIGN KEY (giornata_id) REFERENCES giornate(id),
  FOREIGN KEY (giocatore_id) REFERENCES giocatori(id)
);