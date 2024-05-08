USE AUTOLAVADO;

Create TABLE Cuentas(
  IdCuenta  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  IdBanco INT NULL,
  Numero_Cuenta VARCHAR(20) NULL,
  Saldo DECIMAL(14,2),
  Fecha_Registro DATETIME NULL,
  Estado BIT NULL
);



ALTER TABLE Cuentas
ADD  CONSTRAINT Cuentas_Bancos
FOREIGN KEY(IdBanco)
REFERENCES Bancos(IdBanco)