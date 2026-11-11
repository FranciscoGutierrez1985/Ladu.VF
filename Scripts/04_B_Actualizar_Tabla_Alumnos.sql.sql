USE LADU_DB;
GO

-- 1. Nos aseguramos de que la tabla Alumnos tenga todas las columnas que pide C#
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Alumnos') AND name = 'Legajo')
    ALTER TABLE Alumnos ADD Legajo VARCHAR(50) NULL;

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Alumnos') AND name = 'Activo')
    ALTER TABLE Alumnos ADD Activo BIT NOT NULL DEFAULT 1;
GO

-- 2. Borramos los Stored Procedures viejos si existen para evitar conflictos
DROP PROCEDURE IF EXISTS sp_ObtenerAlumnos;
DROP PROCEDURE IF EXISTS sp_InsertarAlumno;
DROP PROCEDURE IF EXISTS sp_ActualizarAlumno;
DROP PROCEDURE IF EXISTS sp_EliminarAlumno;
GO

-- 3. Los volvemos a crear limpios y bien configurados
CREATE PROCEDURE sp_ObtenerAlumnos
AS
BEGIN
    SELECT IdAlumno, Nombre, Apellido, Dni, Email, Legajo, Activo 
    FROM Alumnos;
END
GO

CREATE PROCEDURE sp_InsertarAlumno
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Dni VARCHAR(20),
    @Email VARCHAR(150),
    @Legajo VARCHAR(50),
    @Activo BIT
AS
BEGIN
    INSERT INTO Alumnos (Nombre, Apellido, Dni, Email, Legajo, Activo)
    VALUES (@Nombre, @Apellido, @Dni, @Email, @Legajo, @Activo);
END
GO

CREATE PROCEDURE sp_ActualizarAlumno
    @IdAlumno INT,
    @Nombre VARCHAR(100),
    @Apellido VARCHAR(100),
    @Dni VARCHAR(20),
    @Email VARCHAR(150),
    @Legajo VARCHAR(50),
    @Activo BIT
AS
BEGIN
    UPDATE Alumnos 
    SET Nombre = @Nombre, 
        Apellido = @Apellido, 
        Dni = @Dni, 
        Email = @Email, 
        Legajo = @Legajo, 
        Activo = @Activo
    WHERE IdAlumno = @IdAlumno;
END
GO

CREATE PROCEDURE sp_EliminarAlumno
    @IdAlumno INT
AS
BEGIN
    DELETE FROM Alumnos WHERE IdAlumno = @IdAlumno;
END
GO