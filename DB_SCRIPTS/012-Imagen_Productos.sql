
USE AUTOLAVADO;
Create TABLE Imagen_Productos(
    IdProducto INT NULL,
	 Imagen Image  NULL,
  	Estado BIT  NULL
	);

ALTER TABLE Imagen_Productos
ADD  CONSTRAINT Imagen_Productos_Productos
FOREIGN KEY(IdProducto)
REFERENCES Productos(IdProducto);