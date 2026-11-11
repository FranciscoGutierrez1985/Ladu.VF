USE LADU_DB;
GO

-- Asignar una materia a un curso
CREATE OR ALTER PROCEDURE sp_AsignarMateriaACurso
    @IdCurso INT,
    @IdMateria INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM CursoMaterias WHERE IdCurso = @IdCurso AND IdMateria = @IdMateria)
    BEGIN
        INSERT INTO CursoMaterias (IdCurso, IdMateria)
        VALUES (@IdCurso, @IdMateria);
    END
END
GO

-- Quitar una materia de un curso
CREATE OR ALTER PROCEDURE sp_QuitarMateriaDeCurso
    @IdCurso INT,
    @IdMateria INT
AS
BEGIN
    DELETE FROM CursoMaterias 
    WHERE IdCurso = @IdCurso AND IdMateria = @IdMateria;
END
GO

-- Obtener las materias de un curso específico
CREATE OR ALTER PROCEDURE sp_ObtenerMateriasPorCurso
    @IdCurso INT
AS
BEGIN
    SELECT m.IdMateria, m.Nombre, m.Descripcion -- (o las columnas que tenga tu tabla Materias)
    FROM Materias m
    INNER JOIN CursoMaterias cm ON m.IdMateria = cm.IdMateria
    WHERE cm.IdCurso = @IdCurso;
END
GO