
USE AUTOLAVADO;
Create TABLE Proveedores(
    IdProveedor INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	IdTipo_Documento INT NULL,
	Numero_Documento VARCHAR(12),
    Nombre VARCHAR(80) NULL,
    Direccion_Fiscal VARCHAR(200) NULL,
	Telefono VARCHAR(15) NULL,
    Movil VARCHAR(15) NULL,
    Email VARCHAR(50) NULL,
	Fecha_Creacion DATETIME NULL,
	Fecha_Actualizacion DATETIME NULL,
  	Estado BIT  NULL
);

ALTER TABLE Proveedores 
ADD  CONSTRAINT Proveedores_Tipo_Documentos
FOREIGN KEY(IdTipo_Documento)
REFERENCES Tipo_Documentos(IdTipo_Documento);

