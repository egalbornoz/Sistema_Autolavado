USE AUTOLAVADO;

Create TABLE Cuentas_Cobrar(
  IdCuenta_Cobrar  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  IdCliente INT NULL,
  IdVenta INT NULL,
  Saldo_Factura DECIMAL(14,2),
  Fecha_Registro DATETIME NULL,
  Fecha_Vencimiento DATETIME NULL,
  Estado BIT NULL
);
