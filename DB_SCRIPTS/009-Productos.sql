USE AUTOLAVADO;

Create TABLE Productos(
  IdProducto  INT PRIMARY KEY IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  Descripcion VARCHAR(100) NULL,
  IdMarca    INT NULL,
  IdUnidad_Medida   INT NULL,
  IdSubFamilia  INT NULL,
  Precio_Unitario DECIMAL(14,2),
  Fecha_Creacion DATETIME NULL,
  Fecha_Modificacion DATETIME NULL,
  Estado BIT NULL
);


ALTER TABLE Productos 
ADD  CONSTRAINT Productos_Marcas
FOREIGN KEY(IdMarca)
REFERENCES Marcas(IdMarca);


ALTER TABLE Productos 
ADD  CONSTRAINT Productos_Unidad_Medidas
FOREIGN KEY(IdUnidad_Medida)
REFERENCES Unidad_Medidas(IdUnidad_Medida);


ALTER TABLE Productos 
ADD  CONSTRAINT Productos_Subfamilias
FOREIGN KEY(IdSubfamilia)
REFERENCES Subfamilias(IdSubfamilia);