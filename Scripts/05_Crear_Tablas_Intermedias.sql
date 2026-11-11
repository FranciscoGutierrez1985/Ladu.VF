USE LADU_DB;
GO

-- 1. Tabla intermedia: Cursos y Materias
CREATE TABLE CursoMaterias (
    IdCurso INT NOT NULL,
    IdMateria INT NOT NULL,
    PRIMARY KEY (IdCurso, IdMateria),
    CONSTRAINT FK_CursoMaterias_Curso FOREIGN KEY (IdCurso) REFERENCES Cursos(IdCurso) ON DELETE CASCADE,
    CONSTRAINT FK_CursoMaterias_Materia FOREIGN KEY (IdMateria) REFERENCES Materias(IdMateria) ON DELETE CASCADE
);

-- 2. Tabla intermedia: Cursos y Alumnos (Inscripciones)
CREATE TABLE CursoAlumnos (
    IdCurso INT NOT NULL,
    IdAlumno INT NOT NULL,
    PRIMARY KEY (IdCurso, IdAlumno),
    CONSTRAINT FK_CursoAlumnos_Curso FOREIGN KEY (IdCurso) REFERENCES Cursos(IdCurso) ON DELETE CASCADE,
    CONSTRAINT FK_CursoAlumnos_Alumno FOREIGN KEY (IdAlumno) REFERENCES Alumnos(IdAlumno) ON DELETE CASCADE
);