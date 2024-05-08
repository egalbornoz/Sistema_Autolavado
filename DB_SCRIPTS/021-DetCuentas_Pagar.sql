USE AUTOLAVADO;

Create TABLE DetCuentas_Pagar(
  IdDetCuenta_Pagar  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  IdCuenta_Pagar  INT NULL,
  IdInstrumento_Pago INT NULL,
  IdForma_Pago INT NULL,
  IdBancoCuenta INT NULL,
  Concepto VARCHAR(50),
  Referencia VARCHAR(20) NULL,
  Monto_Pago DECIMAL(14,2),
  Fecha_Pago DATETIME NULL,
);


ALTER TABLE DetCuentas_Pagar 
ADD  CONSTRAINT DetCuentas_Pagar_Cuentas_Pagar
FOREIGN KEY(IdCuenta_Pagar)
REFERENCES Cuentas_Pagar(IdCuenta_Pagar);


ALTER TABLE DetCuentas_Pagar 
ADD  CONSTRAINT DetCuentas_Pagar_Instrumentos_Pagos
FOREIGN KEY(IdInstrumento_Pago)
REFERENCES Instrumentos_Pagos(IdInstrumento_Pago);

ALTER TABLE DetCuentas_Pagar 
ADD  CONSTRAINT DetCuentas_Pagar_Formas_Pagos
FOREIGN KEY(IdForma_Pago)
REFERENCES Formas_Pagos(IdForma_Pago);

