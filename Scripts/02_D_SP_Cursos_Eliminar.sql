CREATE PROCEDURE sp_Cursos_Eliminar
    @IdCurso INT
AS
BEGIN
    DELETE FROM Cursos
    WHERE IdCurso = @IdCurso;
END
GO