
USE AUTOLAVADO;
Create TABLE Subfamilias(
    IdSubfamilia INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	IdFamilia INT NULL,
    Descripcion VARCHAR(150) NULL,
  	Estado BIT  NULL
	);

	ALTER TABLE Subfamilias 
ADD  CONSTRAINT Subfamilias_Familias
FOREIGN KEY(IdFamilia)
REFERENCES Familias(IdFamilia);