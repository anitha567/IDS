USE EmpresaUNI;
GO

-- ===================================================
-- LIMPIEZA 
-- ===================================================
DROP TABLE IF EXISTS Directivos;
DROP TABLE IF EXISTS Empleados;
DROP TABLE IF EXISTS Puestos;
DROP TABLE IF EXISTS CentrosTrabajo;
GO

-- ===================================================
-- CREACIÓN DE TABLAS
-- ===================================================
CREATE TABLE CentrosTrabajo (
    Num_Centro VARCHAR(10) PRIMARY KEY, 
    Nombre_Centro VARCHAR(100),
    Ciudad VARCHAR(100)
);

CREATE TABLE Puestos (
    Id_Puesto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_Puesto VARCHAR(100),
    Descripcion VARCHAR(255)
);

CREATE TABLE Empleados (
    Num_Empleado INT IDENTITY(1,1) PRIMARY KEY, 
    Nombre VARCHAR(50) NOT NULL,
    Apellido_Paterno VARCHAR(50) NOT NULL,
    Apellido_Materno VARCHAR(50) NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    RFC VARCHAR(13) NOT NULL, 
    Num_Centro VARCHAR(10), 
    Id_Puesto INT, 
    Es_Directivo BIT NOT NULL, 
    
    FOREIGN KEY (Num_Centro) REFERENCES CentrosTrabajo(Num_Centro),
    FOREIGN KEY (Id_Puesto) REFERENCES Puestos(Id_Puesto)
);

CREATE TABLE Directivos (
    Num_Empleado INT PRIMARY KEY, 
    Centro_Supervisa VARCHAR(10), 
    Prestacion_Combustible BIT NOT NULL, 
    
    FOREIGN KEY (Num_Empleado) REFERENCES Empleados(Num_Empleado),
    FOREIGN KEY (Centro_Supervisa) REFERENCES CentrosTrabajo(Num_Centro)
);
GO

-- ===================================================
-- INSERCIÓN DE DATOS 
-- ===================================================

-- Centros de Trabajo 
INSERT INTO CentrosTrabajo (Num_Centro, Nombre_Centro, Ciudad) VALUES 
('000201', 'Tiendas Ángel Flores Ropa', 'Culiacán'),
('000202', 'Tiendas Ángel Flores Muebles', 'Culiacán'),
('000203', 'Tiendas Ángel Flores Cajas', 'Culiacán'),
('049001', 'La Primavera Ropa', 'Culiacán'),
('049002', 'La Primavera Muebles', 'Culiacán'),
('049003', 'La Primavera Cajas', 'Culiacán');

INSERT INTO Puestos (Nombre_Puesto, Descripcion) VALUES 
('Vendedor', 'Vendedor'), 
('Gerente', 'Gerente'),
('Cajero', 'Cajero'),
('Supervisor', 'Supervisor de zona');

-- Empleados

INSERT INTO Empleados (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Num_Centro, Id_Puesto, Es_Directivo) 
VALUES ('Jesus', 'Vega', 'Castro', '1988-03-26', 'VECJ880326XXX', '000201', 1, 0);

INSERT INTO Empleados (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Num_Centro, Id_Puesto, Es_Directivo) 
VALUES ('Jose', 'Lopez', 'Perez', '1980-01-01', 'LOPJ800101XXX', '049003', 2, 1);

INSERT INTO Empleados (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Num_Centro, Id_Puesto, Es_Directivo) 
VALUES ('Maria', 'Gomez', 'Ruiz', '1995-07-15', 'GORM950715XXX', '000203', 3, 0);

INSERT INTO Empleados (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Num_Centro, Id_Puesto, Es_Directivo) 
VALUES ('Carlos', 'Silva', 'Mendez', '1975-11-20', 'SIMC751120XXX', '049001', 4, 1);

INSERT INTO Empleados (Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nacimiento, RFC, Num_Centro, Id_Puesto, Es_Directivo) 
VALUES ('Laura', 'Rios', 'Soto', '1999-02-10', 'RISL990210XXX', '000202', 1, 0);

-- Directivos 
INSERT INTO Directivos (Num_Empleado, Centro_Supervisa, Prestacion_Combustible) 
VALUES (2, '049003', 1); 

INSERT INTO Directivos (Num_Empleado, Centro_Supervisa, Prestacion_Combustible) 
VALUES (4, '049001', 1); 

-- ===================================================
-- Tablas
-- ===================================================

SELECT * FROM CentrosTrabajo;

SELECT * FROM Puestos;

SELECT * FROM Empleados;

SELECT * FROM Directivos;


-- ===================================================
-- REPORTE FINAL
-- ===================================================
SELECT 
    e.Num_Empleado AS [Numero de Empleado],
    e.Nombre + ' ' + e.Apellido_Paterno + ' ' + e.Apellido_Materno AS [Nombre + Apellido Paterno + Apellido Materno],
    CONVERT(VARCHAR, e.Fecha_Nacimiento, 103) AS [Fecha de Nacimiento], 
    e.RFC,
    c.Nombre_Centro AS [Nombre de Centro],
    p.Descripcion AS [Descripción del Puesto],
    CASE WHEN e.Es_Directivo = 1 THEN 'Si' ELSE 'No' END AS [¿Es Directivo?]
FROM Empleados e
JOIN CentrosTrabajo c ON e.Num_Centro = c.Num_Centro
JOIN Puestos p ON e.Id_Puesto = p.Id_Puesto;