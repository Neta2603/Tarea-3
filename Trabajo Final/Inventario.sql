CREATE DATABASE Inventario
GO

USE Inventario
GO

CREATE TABLE Productos (
    ProductoId int IDENTITY(1,1),
    NombreProducto varchar(50),
    Precio int,
    Cantidad int
)
GO

CREATE PROCEDURE AgregarProducto
@NombreProducto varchar(50),
@Precio int,
@Cantidad int
AS
BEGIN
INSERT INTO Productos (NombreProducto, Precio, Cantidad)
VALUES (@NombreProducto, @Precio, @Cantidad)
END
GO

CREATE PROCEDURE ObtenerProductos
AS
BEGIN
SELECT * FROM Productos
END
GO

CREATE PROCEDURE EliminarProducto
@ProductoId int
AS
BEGIN
DELETE FROM Productos WHERE ProductoId = @ProductoId
END
GO

CREATE PROCEDURE ModificarProducto
@ProductoId int,
@NombreProducto varchar(50),
@Precio int,
@Cantidad int
AS
BEGIN
UPDATE Productos
SET NombreProducto = @NombreProducto, Precio = @Precio, Cantidad = @Cantidad
WHERE ProductoId = @ProductoId
END
GO

CREATE PROCEDURE BuscarProductos
@NombreProducto varchar(50)
AS
BEGIN
SELECT * FROM Productos WHERE NombreProducto LIKE '%' + @NombreProducto + '%'
END
GO

Exec ObtenerProductos
GO


CREATE PROCEDURE ProductosMasVendidos
AS
BEGIN
    SELECT TOP 10 NombreProducto, (Precio * Cantidad) as TotalVentas
    FROM Productos 
    ORDER BY TotalVentas DESC
END
GO

Exec ProductosMasVendidos
GO

CREATE PROCEDURE ProductosMenosVendidos
AS
BEGIN
    SELECT TOP 10 NombreProducto, (Precio * Cantidad) as TotalVentas
    FROM Productos 
    ORDER BY TotalVentas ASC
END
GO

Exec ProductosMenosVendidos
GO