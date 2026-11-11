USE LADU_DB;
GO

-- 1. Tabla de Roles
CREATE TABLE Roles (
    id_rol INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL UNIQUE
);
GO

-- 2. Tabla de Usuarios (Docentes, Directivos, Preceptores)
CREATE TABLE Usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    id_rol INT NOT NULL,
    legajo_dni VARCHAR(20) NOT NULL UNIQUE,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    password_hash VARBINARY(MAX) NOT NULL,
    password_salt VARBINARY(MAX) NOT NULL,
    activo BIT DEFAULT 1 NOT NULL,
    FOREIGN KEY (id_rol) REFERENCES Roles(id_rol)
);
GO

-- 3. Insertar Roles Iniciales
INSERT INTO Roles (nombre) VALUES ('Directivo'), ('Preceptor'), ('Docente');
GO

-- 4. Stored Procedure para el Login
CREATE PROCEDURE sp_Usuarios_Login
    @LegajoDni VARCHAR(20)
AS
BEGIN
    SELECT 
        u.id_usuario,
        u.id_rol,
        u.legajo_dni,
        u.nombre,
        u.apellido,
        u.password_hash,
        u.password_salt,
        u.activo,
        r.nombre AS nombre_rol
    FROM Usuarios u
    INNER JOIN Roles r ON u.id_rol = r.id_rol
    WHERE u.legajo_dni = @LegajoDni AND u.activo = 1;
END
GO