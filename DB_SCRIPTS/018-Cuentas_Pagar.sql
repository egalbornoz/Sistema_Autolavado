USE AUTOLAVADO;

Create TABLE Cuentas_Pagar(
  IdCuenta_Pagar  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  IdProveedor INT NULL,
  IdCompra INT NULL,
  Saldo_Factura DECIMAL(14,2),
  Fecha_Registro DATETIME NULL,
  Fecha_Vencimiento DATETIME NULL,
  Estado BIT NULL
);
