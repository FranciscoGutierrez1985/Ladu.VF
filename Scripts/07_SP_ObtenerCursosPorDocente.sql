CREATE OR ALTER PROCEDURE SP_ObtenerCursosPorDocente
    @id_usuario INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Buscamos los cursos distintos donde este docente dicta alguna materia
    SELECT DISTINCT c.IdCurso, c.Nombre
    FROM Cursos c
    INNER JOIN CursoMaterias cm ON c.IdCurso = cm.idCurso
    WHERE cm.idUsuario = @id_usuario;
END
GO