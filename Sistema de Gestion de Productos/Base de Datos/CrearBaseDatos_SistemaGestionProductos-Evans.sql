/*Evans Alberto */

/* 1. CREAR BASE DE DATOS */

IF NOT EXISTS (
    SELECT name
    FROM sys.databases
    WHERE name = 'SistemaGestionProductos'
)
BEGIN
    CREATE DATABASE SistemaGestionProductos;
END
GO

USE SistemaGestionProductos;
GO

/* 2. CREAR TABLA CATEGORIAS */

IF OBJECT_ID('dbo.Categorias', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Categorias
    (
        IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
        Nombre VARCHAR(100) NOT NULL,
        Descripcion VARCHAR(250) NOT NULL,

        CONSTRAINT UQ_Categorias_Nombre
        UNIQUE (Nombre)
    );
END
GO

/* 3. CREAR TABLA PRODUCTOS */

IF OBJECT_ID('dbo.Productos', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Productos
    (
        IdProducto INT IDENTITY(1,1) PRIMARY KEY,
        Nombre VARCHAR(100) NOT NULL,
        Precio DECIMAL(10,2) NOT NULL,
        Stock INT NOT NULL,
        FechaRegistro DATETIME NOT NULL
            DEFAULT GETDATE(),
        IdCategoria INT NOT NULL,

        CONSTRAINT CK_Productos_Precio
        CHECK (Precio > 0),

        CONSTRAINT CK_Productos_Stock
        CHECK (Stock >= 0),

        CONSTRAINT FK_Productos_Categorias
        FOREIGN KEY (IdCategoria)
        REFERENCES dbo.Categorias(IdCategoria)
    );
END
GO

/* 4. INSERTAR CATEGORIAS DE PRUEBA */

IF NOT EXISTS (SELECT 1 FROM dbo.Categorias)
BEGIN
    INSERT INTO dbo.Categorias (Nombre, Descripcion)
    VALUES
    ('Computacion', 'Equipos de computacion'),
    ('Accesorios', 'Accesorios para computadoras'),
    ('Impresion', 'Equipos y suministros de impresion'),
    ('Redes', 'Productos de conectividad y redes');
END
GO

/* 5. INSERTAR PRODUCTOS DE PRUEBA */

IF NOT EXISTS (SELECT 1 FROM dbo.Productos)
BEGIN
    INSERT INTO dbo.Productos
        (Nombre, Precio, Stock, IdCategoria)
    VALUES
    ('Teclado', 8500.00, 15, 2),
    ('Mouse', 5500.00, 20, 2),
    ('Monitor', 95000.00, 8, 1),
    ('Impresora', 125000.00, 5, 3),
    ('Cable de red', 2500.00, 30, 4),
    ('Memoria USB', 4500.00, 25, 2);
END
GO

/* 6. CONSULTAR CATEGORIAS */

SELECT *
FROM dbo.Categorias;
GO

/* 7. CONSULTAR PRODUCTOS */

SELECT
    P.IdProducto,
    P.Nombre,
    P.Precio,
    P.Stock,
    P.FechaRegistro,
    C.Nombre AS Categoria,
    (P.Precio * P.Stock) AS ValorInventario
FROM dbo.Productos P
INNER JOIN dbo.Categorias C
    ON P.IdCategoria = C.IdCategoria;
GO

/*
=========================================================
 FIN DEL SCRIPT
=========================================================
*/
