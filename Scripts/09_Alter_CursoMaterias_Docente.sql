USE LADU_DB;
GO

-- Asegurar la relación de la materia de un curso con el usuario (docente)
ALTER TABLE CursoMaterias
ADD CONSTRAINT FK_CursoMaterias_Usuarios 
FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario);
GO