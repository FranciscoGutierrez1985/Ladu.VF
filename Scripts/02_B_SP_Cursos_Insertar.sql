USE [LADU_DB]
GO

CREATE PROCEDURE sp_Cursos_Insertar
    @Nombre VARCHAR(100),
    @Division VARCHAR(50),
    @Anio INT,
    @Activo BIT
AS
BEGIN
    INSERT INTO Cursos (Nombre, Division, Anio, Activo)
    VALUES (@Nombre, @Division, @Anio, @Activo);
END
GO