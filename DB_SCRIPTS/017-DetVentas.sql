USE AUTOLAVADO;

Create TABLE DetVentas(
  IdDetVenta  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  IdVenta INT NULL,
  IdProducto INT NULL,
  IdServicio INT NULL,
  Cantidad DECIMAL(10,2),
  Precio_Unitario DECIMAL(14,2),
  Total DECIMAL(14,2),
  Fecha_Creacion DATETIME NULL,
  Fecha_Modificacion DATETIME NULL,
);

ALTER TABLE DetVentas 
ADD  CONSTRAINT DetVentas_Ventas
FOREIGN KEY(IdVenta)
REFERENCES Ventas(IdVenta);
