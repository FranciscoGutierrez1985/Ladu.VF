USE LADU_DB;
GO

-- Insertar un usuario de prueba 
-- (Como en el código inicial de C# estamos leyendo los hashes binarios, 
-- para una prueba rápida de conectividad y estructura, insertamos valores de prueba en crudo)
INSERT INTO Usuarios (id_rol, legajo_dni, nombre, apellido, password_hash, password_salt, activo)
VALUES (3, '12345678', 'Carlos', 'Gómez', 0x01, 0x01, 1);
GO