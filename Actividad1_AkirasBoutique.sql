-- ============================================================================
-- ASIGNATURA: Administración de Bases de Datos
-- ACTIVIDAD 1: Mejorando una Base de Datos (Akira's Boutique)
-- DESCRIPCIÓN: Creación de tablas Sucursales y Empleados, definición de
-- llaves primarias, llaves foráneas y registros iniciales.
-- ============================================================================

USE [AkirasBoutiques];
GO

---

-- 1. CREACIÓN DE LA TABLA SUCURSALES

---

IF OBJECT_ID('dbo.Sucursales', 'U') IS NOT NULL
DROP TABLE dbo.Sucursales;
GO

CREATE TABLE [dbo].[Sucursales](
[id_sucursal] INT NOT NULL PRIMARY KEY,
[nombre_sucursal] VARCHAR(100) NOT NULL,
[encargado] VARCHAR(100) NOT NULL,
[direccion] VARCHAR(150) NOT NULL,
[telefono] VARCHAR(20) NOT NULL
);
GO

---

-- 2. INSERCIÓN DE DATOS EN LA TABLA SUCURSALES

---

INSERT INTO [dbo].[Sucursales] ([id_sucursal], [nombre_sucursal], [encargado], [direccion], [telefono])
VALUES
(1, 'Akira’s Boutique: Las Mercedes', 'Sonia Alejandra Fernández Moreno', 'Calle Roble #507 Fracc. Las Mercedes', '4447831225'),
(2, 'Akira’s Boutique: Obraje', 'Fernando Calderón Ayala', 'Calle Dr. Jesús Díaz de León #438 col. Obraje', '4493780921'),
(3, 'Akira’s Boutique: Galerías Mazatlán', 'Daniela Fernanda Díaz Ordaz', 'Av. de la Marina #6204, Marina, local 35', '6692932059'),
(4, 'Akira’s Boutique: Zapopan', 'Mario Alberto Jiménez Salcido', 'Av. Manuel J. Clouthier 525 col. Benito Juárez', '3337841230'),
(5, 'Akira’s Boutique: Melchor', 'Yesenia Guadalupe Campos Rojo', 'Av. Melchor Ocampo #2528 Zona Centro', '6143906721'),
(6, 'Akira’s Boutique: Constitución', 'Tamara Alejandra Bernal Ramos', 'Calle Constitución #106 Zona Centro', '6181962954'),
(7, 'Akira’s Boutique: Centro', 'Samuel Enrique Barrios Enciso', 'Av. Hidalgo #338 Zacatecas Centro', '4929301250');
GO

---

-- 3. CREACIÓN DE LA TABLA EMPLEADOS CON LLAVE FORÁNEA HACIA SUCURSALES

---

IF OBJECT_ID('dbo.Empleados', 'U') IS NOT NULL
DROP TABLE dbo.Empleados;
GO

CREATE TABLE [dbo].[Empleados](
[id_empleado] INT NOT NULL PRIMARY KEY,
[nombre] VARCHAR(100) NOT NULL,
[direccion] VARCHAR(150) NOT NULL,
[telefono] VARCHAR(20) NOT NULL,
[edad] INT NOT NULL,
[id_sucursal] INT NOT NULL,
[email] VARCHAR(100) NOT NULL,
[password] VARCHAR(50) NOT NULL,
CONSTRAINT [FK_Empleados_Sucursales] FOREIGN KEY ([id_sucursal]) REFERENCES [dbo].[Sucursales] ([id_sucursal])
);
GO

---

-- 4. INSERCIÓN DE EMPLEADOS DE EJEMPLO (DISTRIBUIDOS POR SUCURSAL)

---

INSERT INTO [dbo].[Empleados] ([id_empleado], [nombre], [direccion], [telefono], [edad], [id_sucursal], [email], [password])
VALUES
-- Sucursal 1: Las Mercedes
(1, 'Sonia Alejandra Fernández Moreno', 'Calle Roble #507', '4447831225', 34, 1, 'sonia.fernandez@akiras.com', 'Pass1234'),
(2, 'Carlos Eduardo Mendoza Ríos', 'Av. De los Pinos #102', '4448123456', 28, 1, 'carlos.mendoza@akiras.com', 'Pass5678'),
(3, 'Mariana Isabel López Silva', 'Calle Olivo #304', '4449876543', 25, 1, 'mariana.lopez@akiras.com', 'Pass9012'),
(4, 'Jorge Luis Torres Peña', 'Calle Sauce #88', '4441122334', 30, 1, 'jorge.torres@akiras.com', 'Pass3456'),
(5, 'Valeria Sofía Ramos Gómez', 'Av. Tecnológico #500', '4445566778', 22, 1, 'valeria.ramos@akiras.com', 'Pass7890'),

-- Sucursal 2: Obraje
(6, 'Fernando Calderón Ayala', 'Dr. Díaz de León #438', '4493780921', 38, 2, 'fernando.calderon@akiras.com', 'Pass1122'),
(7, 'Andrea Beatriz Castro Ruiz', 'Calle Galeana #210', '4491234567', 27, 2, 'andrea.castro@akiras.com', 'Pass3344'),
(8, 'Ricardo Manuel Ortiz Vega', 'Av. Convención #1002', '4499876543', 31, 2, 'ricardo.ortiz@akiras.com', 'Pass5566'),
(9, 'Gabriela Elena Morales Lara', 'Calle Morelos #45', '4498877665', 24, 2, 'gabriela.morales@akiras.com', 'Pass7788'),
(10, 'Héctor Hugo Delgado Parra', 'Calle Zaragoza #302', '4494433221', 29, 2, 'hector.delgado@akiras.com', 'Pass9900'),

-- Sucursal 3: Galerías Mazatlán
(11, 'Daniela Fernanda Díaz Ordaz', 'Av. Marina #6204', '6692932059', 32, 3, 'daniela.diaz@akiras.com', 'Pass1212'),
(12, 'Luis Alberto Sánchez Rivas', 'Calle Camarón #12', '6691122334', 26, 3, 'luis.sanchez@akiras.com', 'Pass3434'),
(13, 'Paola Cristina Rueda Santos', 'Av. Del Mar #800', '6695566778', 23, 3, 'paola.rueda@akiras.com', 'Pass5656'),
(14, 'Adrián Enrique Meza Flores', 'Calle Sabalo #405', '6699988776', 35, 3, 'adrian.meza@akiras.com', 'Pass7878'),
(15, 'Camila Isabela Núñez Cruz', 'Av. Insurgentes #220', '6694455667', 21, 3, 'camila.nunez@akiras.com', 'Pass9090'),

-- Sucursal 4: Zapopan
(16, 'Mario Alberto Jiménez Salcido', 'Av. Clouthier #525', '3337841230', 40, 4, 'mario.jimenez@akiras.com', 'Pass2121'),
(17, 'Lorena Elizabeth Prado Reyes', 'Av. Patria #1500', '3331234567', 29, 4, 'lorena.prado@akiras.com', 'Pass4343'),
(18, 'Roberto Carlos Vargas Luna', 'Calle Acueducto #80', '3339876543', 33, 4, 'roberto.vargas@akiras.com', 'Pass6565'),
(19, 'Fernanda María Aguilar Solís', 'Av. Hidalgo #350', '3336677889', 26, 4, 'fernanda.aguilar@akiras.com', 'Pass8787'),
(20, 'Diego Armando Castillo Rocha', 'Calle Vallarta #1200', '3332233445', 27, 4, 'diego.castillo@akiras.com', 'Pass0909'),

-- Sucursal 5: Melchor
(21, 'Yesenia Guadalupe Campos Rojo', 'Av. Melchor Ocampo #2528', '6143906721', 36, 5, 'yesenia.campos@akiras.com', 'Pass1357'),
(22, 'Alejandro Gabriel Marín Silva', 'Calle Aldama #402', '6141122334', 31, 5, 'alejandro.marin@akiras.com', 'Pass2468'),
(23, 'Patricia Noemí Herrera Baeza', 'Av. Universidad #100', '6145566778', 28, 5, 'patricia.herrera@akiras.com', 'Pass3579'),
(24, 'Raúl Esteban Guzmán Acosta', 'Calle Victoria #50', '6148899001', 30, 5, 'raul.guzman@akiras.com', 'Pass4680'),
(25, 'Montserrat Alondra Domínguez', 'Calle Juárez #310', '6143344556', 24, 5, 'montserrat.dominguez@akiras.com', 'Pass5791'),

-- Sucursal 6: Constitución
(26, 'Tamara Alejandra Bernal Ramos', 'Calle Constitución #106', '6181962954', 33, 6, 'tamara.bernal@akiras.com', 'Pass1111'),
(27, 'Oscar Daniel Mendoza Fierro', 'Av. 20 de Noviembre #500', '6181234567', 27, 6, 'oscar.mendoza@akiras.com', 'Pass2222'),
(28, 'Beatriz Adriana Leyva Cano', 'Calle Negrete #302', '6189876543', 29, 6, 'beatriz.leyva@akiras.com', 'Pass3333'),
(29, 'Manuel Agustín Paredes Soto', 'Av. Dolores del Río #810', '6184455667', 32, 6, 'manuel.paredes@akiras.com', 'Pass4444'),
(30, 'Sofía Margarita Beltrán Ríos', 'Calle Florida #150', '6187788990', 23, 6, 'sofia.beltran@akiras.com', 'Pass5555'),

-- Sucursal 7: Centro
(31, 'Samuel Enrique Barrios Enciso', 'Av. Hidalgo #338', '4929301250', 37, 7, 'samuel.barrios@akiras.com', 'Pass6666'),
(32, 'Diana Laura Estrada Orozco', 'Calle Tacuba #85', '4921122334', 26, 7, 'diana.estrada@akiras.com', 'Pass7777'),
(33, 'Francisco Javier Navarro Gil', 'Av. Juárez #210', '4925566778', 34, 7, 'francisco.navarro@akiras.com', 'Pass8888'),
(34, 'Karen Vanessa Ibarra Pacheco', 'Calle Guerrero #40', '4929900112', 25, 7, 'karen.ibarra@akiras.com', 'Pass9999'),
(35, 'Gonzalo Ignacio Villalobos C.', 'Av. Rayón #115', '4923344556', 28, 7, 'gonzalo.villalobos@akiras.com', 'Pass0000');
GO

---

-- 5. CONSULTAS DE COMPROBACIÓN (REQUERIDAS EN EL PASO 7)

---

-- Consulta A: Comprobar el catálogo de sucursales
SELECT id_sucursal, nombre_sucursal, encargado, telefono
FROM Sucursales;
GO

-- Consulta B: Comprobar el listado general de empleados
SELECT id_empleado, nombre, edad, email, id_sucursal
FROM Empleados;
GO

-- Consulta C: Comprobar la relación INNER JOIN entre Empleados y Sucursales
SELECT E.id_empleado, E.nombre AS Nombre_Empleado, E.edad, E.email, S.nombre_sucursal AS Sucursal, S.encargado AS Encargado_Sucursal
FROM Empleados E
INNER JOIN Sucursales S ON E.id_sucursal = S.id_sucursal
ORDER BY S.id_sucursal ASC, E.nombre ASC;
GO
