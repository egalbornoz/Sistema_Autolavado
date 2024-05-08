USE AUTOLAVADO;

Create TABLE Ventas(
  IdVenta  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  IdCliente INT NULL,
  Nro_Factura INT NULL,
  Nro_Control   INT NULL,
  Subtotal DECIMAL(14,2),
  Monto_Factura DECIMAL(14,2),
  Monto_Impuesto DECIMAL(14,2),
  Monto_Exento DECIMAL(14,2),
  Fecha_Creacion DATETIME NULL,
  Fecha_Modificacion DATETIME NULL,
  Estado BIT NULL
);
