
USE AUTOLAVADO;
Create TABLE Instrumentos_Pagos(
    IdInstrumento_Pago INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
    Descripcion VARCHAR(150) NULL,
  	Estado BIT  NULL
	);