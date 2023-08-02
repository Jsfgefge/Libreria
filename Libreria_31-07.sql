create database Librearia
USE Librearia

CREATE TABLE Catalogo(
	id_libro INT IDENTITY(1,1) PRIMARY KEY,
	Titulo VARCHAR(32) NOT NULL, 
	Autor VARCHAR(30) NOT NULL, 
	Idioma VARCHAR(15),
	Disponible INT NOT NULL,
	DAÑADO VARCHAR(100)
);

CREATE TABLE Usuarios(
	id_usuario INT IDENTITY(1,1) PRIMARY KEY,
	Carnet VARCHAR(15) UNIQUE,
	Contraseña VARCHAR(30) NOT NULL,
	Nombre VARCHAR(15) NOT NULL, 
	Apellido VARCHAR(15) NOT NULL,
	Prestamo VARCHAR(2) NOT NULL, 
	Rango INT NOT NULL, 
	Solvencia VARCHAR(2) NOT NULL
)

CREATE TABLE Prestamos(
	Carnet INT,
	Id_libro INT UNIQUE,
)


CREATE TABLE Rango(
	Rango INT NOT NULL,
	Nombre_rango VARCHAR(15)
)


INSERT INTO Usuarios (Carnet, Contraseña, Nombre, Apellido, Prestamo, rango, Solvencia)
VALUES (2023001, 'pass1', 'angel', 'marroquin', 'No', '1', 'Si')
INSERT  Usuarios (Carnet, Contraseña, Nombre, Apellido, Prestamo, rango, Solvencia)
VALUES (2023002, 'pass1', 'biblio1', 'biblio1', 'No', '2', 'Si')
INSERT INTO Usuarios (Carnet, Contraseña, Nombre, Apellido, Prestamo, rango, Solvencia)
VALUES (2023003, 'pass1', 'profesor1', 'profesor1', 'No', '3', 'Si')
INSERT INTO Usuarios (Carnet, Contraseña, Nombre, Apellido, Prestamo, rango, Solvencia)
VALUES (2023004, 'pass1', 'alumno1', 'alumno1', 'No', '4', 'Si')
INSERT  Usuarios (Carnet, Contraseña, Nombre, Apellido, Prestamo, rango, Solvencia)
VALUES (2023005, 'pass1', 'biblio1', 'biblio1', 'No', '2', 'Si')
INSERT INTO Usuarios (Carnet, Contraseña, Nombre, Apellido, Prestamo, rango, Solvencia)
VALUES (2023006, 'pass1', 'alumno1', 'alumno1', 'Si', '4', 'No')
INSERT INTO Usuarios (Carnet, Contraseña, Nombre, Apellido, Prestamo, rango, Solvencia)
VALUES (2023007, 'pass1', 'alumno1', 'alumno1', 'No', '4', 'No')


INSERT INTO Catalogo (Titulo, Autor, Idioma, Disponible, DAÑADO)
VALUES ('libromagico', 'autor1', 'español', '0', 'doblado')

INSERT INTO Rango(Rango, Nombre_Rango )
VALUES (1, 'Administrador')
INSERT INTO Rango(Rango, Nombre_Rango )
VALUES (2, 'Bibliotecario')
INSERT INTO Rango(Rango, Nombre_Rango )
VALUES (3, 'Profesor')
INSERT INTO Rango(Rango, Nombre_Rango )
VALUES (4, 'Alumno')


