USE AUTOLAVADO;

Create TABLE DetCuentas_Cobrar(
  IdDetCuenta_Cobrar  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  IdCuenta_Cobrar  INT NULL,
  IdInstrumento_Pago INT NULL,
  IdForma_Pago INT NULL,
  IdBancoCuenta INT NULL,
  Concepto VARCHAR(50),
  Referencia VARCHAR(20) NULL,
  Monto_Pago DECIMAL(14,2),
  Fecha_Pago DATETIME NULL,
);


ALTER TABLE DetCuentas_Cobrar 
ADD  CONSTRAINT DetCuentas_Cobrar_Cuentas_Cobrar
FOREIGN KEY(IdCuenta_Cobrar)
REFERENCES Cuentas_Cobrar(IdCuenta_Cobrar);


ALTER TABLE DetCuentas_Cobrar 
ADD  CONSTRAINT DetCuentas_Cobrar_Instrumentos_Pagos
FOREIGN KEY(IdInstrumento_Pago)
REFERENCES Instrumentos_Pagos(IdInstrumento_Pago);

ALTER TABLE DetCuentas_Cobrar 
ADD  CONSTRAINT DetCuentas_Cobrar_Formas_Pagos
FOREIGN KEY(IdForma_Pago)
REFERENCES Formas_Pagos(IdForma_Pago);

