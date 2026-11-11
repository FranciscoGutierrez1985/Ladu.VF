USE [LADU_DB]
GO

CREATE PROCEDURE sp_Cursos_Actualizar
    @IdCurso INT,
    @Nombre VARCHAR(50),
    @Division VARCHAR(10),
    @Anio INT,
    @Activo BIT
AS
BEGIN
    UPDATE Cursos
    SET Nombre = @Nombre,
        Division = @Division,
        Anio = @Anio,
        Activo = @Activo
    WHERE IdCurso = @IdCurso;
END
GO