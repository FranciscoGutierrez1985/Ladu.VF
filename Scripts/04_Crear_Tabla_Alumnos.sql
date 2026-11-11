-- 1. Tabla de Alumnos
CREATE TABLE Alumnos (
    IdAlumno INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Dni VARCHAR(20) NOT NULL UNIQUE,
    Email VARCHAR(100) NULL,
    Legajo VARCHAR(20) NULL,
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- 2. Stored Procedure: Obtener todos los alumnos
CREATE PROCEDURE sp_ObtenerAlumnos
AS
BEGIN
    SELECT IdAlumno, Nombre, Apellido, Dni, Email, Legajo, Activo
    FROM Alumnos;
END
GO

-- 3. Stored Procedure: Insertar alumno
CREATE PROCEDURE sp_InsertarAlumno
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Dni VARCHAR(20),
    @Email VARCHAR(100),
    @Legajo VARCHAR(20),
    @Activo BIT
AS
BEGIN
    INSERT INTO Alumnos (Nombre, Apellido, Dni, Email, Legajo, Activo)
    VALUES (@Nombre, @Apellido, @Dni, @Email, @Legajo, @Activo);
END
GO

-- 4. Stored Procedure: Actualizar alumno
CREATE PROCEDURE sp_ActualizarAlumno
    @IdAlumno INT,
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Dni VARCHAR(20),
    @Email VARCHAR(100),
    @Legajo VARCHAR(20),
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

-- 5. Stored Procedure: Eliminar alumno (baja física)
CREATE PROCEDURE sp_EliminarAlumno
    @IdAlumno INT
AS
BEGIN
    DELETE FROM Alumnos
    WHERE IdAlumno = @IdAlumno;
END
GO