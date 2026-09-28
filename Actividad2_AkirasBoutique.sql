-- ============================================================================
-- ASIGNATURA: Administración de Bases de Datos
-- ACTIVIDAD 2: Consultas de Datos en SQL Server (Akira's Boutique)
-- DESCRIPCIÓN: Extracción de información clave de la boutique mediante
-- Data Manipulation Language (DML) y funciones de agregación.
-- ============================================================================

USE [AkirasBoutiques];
GO

---

-- 1. SELECCIONAR EL PRODUCTO QUE MÁS VENTAS HA TENIDO (UNIDADES VENDIDAS)

---

SELECT TOP 1 P.id_producto, CAST(P.nombre AS VARCHAR(100)) AS Producto, SUM(D.cantidad) AS Total_Unidades_Vendidas
FROM detalle D
INNER JOIN producto P ON D.id_producto = P.id_producto
GROUP BY P.id_producto, CAST(P.nombre AS VARCHAR(100))
ORDER BY Total_Unidades_Vendidas DESC;
GO

---

-- 2. SELECCIONAR EL PRODUCTO CON MAYOR CANTIDAD EN STOCK

---

SELECT TOP 1 id_producto, CAST(nombre AS VARCHAR(100)) AS Producto, precio, stock
FROM producto
ORDER BY stock DESC;
GO

---

-- 3. ORDENAR COMPRAS DE LA MÁS ANTIGUA A LA MÁS RECIENTE

---

SELECT F.id_factura AS Num_Factura, F.fecha AS Fecha_Compra, CAST(C.nombre AS VARCHAR(100)) + ' ' + CAST(C.apellido AS VARCHAR(100)) AS Cliente, P.nombre AS Producto, D.cantidad AS Cantidad, D.precio AS Precio_Total_Renglon
FROM factura F
INNER JOIN cliente C ON F.id_cliente = C.id_cliente
INNER JOIN detalle D ON F.id_detalle = D.id_detalle
INNER JOIN producto P ON D.id_producto = P.id_producto
ORDER BY F.fecha ASC;
GO

---

-- 4. ORDENAR ALFABÉTICAMENTE LOS NOMBRES DE TODOS LOS CLIENTES (A-Z)

---

SELECT id_cliente, CAST(nombre AS VARCHAR(100)) AS Nombre, CAST(apellido AS VARCHAR(100)) AS Apellido, CAST(email AS VARCHAR(100)) AS Email
FROM cliente
ORDER BY Nombre ASC, Apellido ASC;
GO

---

-- 5. SELECCIONAR PRODUCTOS PERTENECIENTES A CADA CATEGORÍA

---

-- A) Categoría: Falda (id_categoria = 2)
SELECT P.id_producto, CAST(P.nombre AS VARCHAR(100)) AS Producto, P.precio, P.stock, CAST(C.nombre AS VARCHAR(100)) AS Categoria
FROM producto P
INNER JOIN categoria C ON P.id_categoria = C.id_categoria
WHERE C.id_categoria = 2;
GO

-- B) Categoría: Pantalón (id_categoria = 3)
SELECT P.id_producto, CAST(P.nombre AS VARCHAR(100)) AS Producto, P.precio, P.stock, CAST(C.nombre AS VARCHAR(100)) AS Categoria
FROM producto P
INNER JOIN categoria C ON P.id_categoria = C.id_categoria
WHERE C.id_categoria = 3;
GO

-- C) Categoría: Chamarra (id_categoria = 7)
SELECT P.id_producto, CAST(P.nombre AS VARCHAR(100)) AS Producto, P.precio, P.stock, CAST(C.nombre AS VARCHAR(100)) AS Categoria
FROM producto P
INNER JOIN categoria C ON P.id_categoria = C.id_categoria
WHERE C.id_categoria = 7;
GO

-- D) Categoría: Zapatos (id_categoria = 6)
SELECT P.id_producto, CAST(P.nombre AS VARCHAR(100)) AS Producto, P.precio, P.stock, CAST(C.nombre AS VARCHAR(100)) AS Categoria
FROM producto P
INNER JOIN categoria C ON P.id_categoria = C.id_categoria
WHERE C.id_categoria = 6;
GO

-- E) Categoría: Accesorios (id_categoria = 10)
SELECT P.id_producto, CAST(P.nombre AS VARCHAR(100)) AS Producto, P.precio, P.stock, CAST(C.nombre AS VARCHAR(100)) AS Categoria
FROM producto P
INNER JOIN categoria C ON P.id_categoria = C.id_categoria
WHERE C.id_categoria = 10;
GO

---

-- 6. SELECCIONAR LOS ENCARGADOS DE LAS SUCURSALES DE AKIRA'S BOUTIQUE

---

SELECT id_sucursal, CAST(nombre_sucursal AS VARCHAR(100)) AS Sucursal, CAST(encargado AS VARCHAR(100)) AS Encargado
FROM Sucursales;
GO

---

-- 7. SELECCIONAR EMPLEADOS QUE TRABAJAN EN LA SUCURSAL CONSTITUCIÓN

---

SELECT E.id_empleado, CAST(E.nombre AS VARCHAR(100)) AS Empleado, E.edad, CAST(E.direccion AS VARCHAR(150)) AS Direccion, CAST(E.telefono AS VARCHAR(20)) AS Telefono, CAST(E.email AS VARCHAR(100)) AS Email, CAST(S.nombre_sucursal AS VARCHAR(100)) AS Sucursal
FROM Empleados E
INNER JOIN Sucursales S ON E.id_sucursal = S.id_sucursal
WHERE CAST(S.nombre_sucursal AS VARCHAR(100)) LIKE '%Constituci%';
GO

---

-- 8. SELECCIONAR CLIENTES MAYORES DE 30 AÑOS

---

SELECT id_cliente, CAST(nombre AS VARCHAR(100)) AS Nombre, CAST(apellido AS VARCHAR(100)) AS Apellido, fec_nac AS Fecha_Nacimiento, DATEDIFF(YEAR, fec_nac, GETDATE()) AS Edad_Aproximada
FROM cliente
WHERE DATEDIFF(YEAR, fec_nac, GETDATE()) > 30
ORDER BY Edad_Aproximada DESC;
GO
