-- 1. Crear la tabla intermedia CursoUsuario
CREATE TABLE CursoUsuarios (
    IdCurso INT NOT NULL,
    IdUsuario INT NOT NULL,
    PRIMARY KEY (IdCurso, IdUsuario),
    FOREIGN KEY (IdCurso) REFERENCES Cursos(IdCurso),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id_Usuario)
);
GO

-- 2. Crear el Stored Procedure para buscar los cursos de un docente específico
CREATE PROCEDURE SP_ObtenerCursosPorDocente
    @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT c.IdCurso, c.Nombre
    FROM Cursos c
    INNER JOIN CursoUsuarios cu ON c.IdCurso = cu.IdCurso
    WHERE cu.IdUsuario = @IdUsuario;
END
GO