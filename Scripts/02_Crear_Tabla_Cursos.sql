-- Si ya existen de una ejecución anterior, los borramos para empezar limpios
IF OBJECT_ID('sp_Cursos_Listar', 'P') IS NOT NULL
    DROP PROCEDURE sp_Cursos_Listar;
GO

IF OBJECT_ID('Cursos', 'U') IS NOT NULL
    DROP TABLE Cursos;
GO

-- 1. Crear tabla de Cursos
CREATE TABLE Cursos (
    IdCurso INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Division VARCHAR(10) NOT NULL,
    Anio INT NOT NULL,
    Activo BIT DEFAULT 1
);
GO

-- 2. Insertar un curso de prueba
INSERT INTO Cursos (Nombre, Division, Anio, Activo) 
VALUES ('1er Año Informática', 'A', 2026, 1);
GO

-- 3. Crear Stored Procedure para listar
CREATE PROCEDURE sp_Cursos_Listar
AS
BEGIN
    SELECT IdCurso, Nombre, Division, Anio, Activo
    FROM Cursos
END
GO