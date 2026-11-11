-- 1. Crear tabla de Materias
IF OBJECT_ID('Materias', 'U') IS NOT NULL
    DROP TABLE Materias;
GO

CREATE TABLE Materias (
    IdMateria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(100),
    Activo BIT DEFAULT 1
);
GO

-- 2. Insertar un par de materias de prueba
INSERT INTO Materias (Nombre, Descripcion, Activo) VALUES ('Matemática', 'Matemática I y II', 1);
INSERT INTO Materias (Nombre, Descripcion, Activo) VALUES ('Programación', 'Introducción a C# y SQL', 1);
GO

-- 3. Stored Procedure para Listar (todas, para aplicar la misma lógica de grilla)
CREATE PROCEDURE sp_Materias_Listar
AS
BEGIN
    SELECT IdMateria, Nombre, Descripcion, Activo
    FROM Materias;
END
GO

-- 4. Stored Procedure para Insertar
CREATE PROCEDURE sp_Materias_Insertar
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(100)
AS
BEGIN
    INSERT INTO Materias (Nombre, Descripcion, Activo)
    VALUES (@Nombre, @Descripcion, 1);
END
GO

-- 5. Stored Procedure para Modificar
CREATE PROCEDURE sp_Materias_Modificar
    @IdMateria INT,
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(100),
    @Activo BIT
AS
BEGIN
    UPDATE Materias
    SET Nombre = @Nombre,
        Descripcion = @Descripcion,
        Activo = @Activo
    WHERE IdMateria = @IdMateria;
END
GO

-- 6. Stored Procedure para Eliminar (Física)
CREATE PROCEDURE sp_Materias_Eliminar
    @IdMateria INT
AS
BEGIN
    DELETE FROM Materias
    WHERE IdMateria = @IdMateria;
END
GO