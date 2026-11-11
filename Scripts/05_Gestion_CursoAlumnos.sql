USE LADU_DB;
GO

-- Inscribir un alumno a un curso
CREATE OR ALTER PROCEDURE sp_InscribirAlumnoACurso
    @IdCurso INT,
    @IdAlumno INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM CursoAlumnos WHERE IdCurso = @IdCurso AND IdAlumno = @IdAlumno)
    BEGIN
        INSERT INTO CursoAlumnos (IdCurso, IdAlumno)
        VALUES (@IdCurso, @IdAlumno);
    END
END
GO

-- Dar de baja a un alumno de un curso
CREATE OR ALTER PROCEDURE sp_DesinscribirAlumnoDeCurso
    @IdCurso INT,
    @IdAlumno INT
AS
BEGIN
    DELETE FROM CursoAlumnos 
    WHERE IdCurso = @IdCurso AND IdAlumno = @IdAlumno;
END
GO

-- Obtener los alumnos inscriptos en un curso
CREATE OR ALTER PROCEDURE sp_ObtenerAlumnosPorCurso
    @IdCurso INT
AS
BEGIN
    SELECT a.IdAlumno, a.Nombre, a.Apellido, a.Dni, a.Email, a.Legajo, a.Activo
    FROM Alumnos a
    INNER JOIN CursoAlumnos ca ON a.IdAlumno = ca.IdAlumno
    WHERE ca.IdCurso = @IdCurso;
END
GO