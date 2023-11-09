CREATE TABLE TipoTransaccion
(
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(50) NOT NULL
);

CREATE TABLE TipoCuenta
(
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(50) NOT NULL,
);

CREATE TABLE Empresa
(
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(100) NOT NULL,
Correo NVARCHAR(100) NOT NULL,
Contraseña NVARCHAR(250) NOT NULL,
FechaCreacion DATETIME DEFAULT GETDATE(),
FechaActualizacion DATETIME,
TipoCuentaId INT FOREIGN KEY REFERENCES TipoCuenta(Id) NOT NULL
);

CREATE TABLE PersonaNatural
(
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(100) NOT NULL,
Correo NVARCHAR(100) NOT NULL,
Contraseña NVARCHAR(250) NOT NULL,
FechaCreacion DATETIME DEFAULT GETDATE(),
FechaActualizacion DATETIME,
TipoCuentaId INT FOREIGN KEY REFERENCES TipoCuenta(id) NOT NULL
);

CREATE TABLE Transaccion
(
Id INT PRIMARY KEY IDENTITY(1,1),
Valor DECIMAL(18,2) NOT NULL,
FechaCreacion DATETIME DEFAULT GETDATE(),
TipoTransaccionId INT FOREIGN KEY REFERENCES TipoTransaccion(Id),
TipoCuentaId INT FOREIGN KEY REFERENCES TipoCuenta(Id),
PersonaNaturalId INT FOREIGN KEY REFERENCES PersonaNatural(Id),
EmpresaId INT FOREIGN KEY REFERENCES Empresa(Id)
);


INSERT INTO TipoCuenta(Nombre) VALUES ('Ahorrros'),('Corriente');

INSERT INTO TipoTransaccion(Nombre) VALUES('Consignacion'),('Retiro');

INSERT INTO Empresa(Nombre,Correo,Contraseña,TipoCuentaId)
VALUES('Autos Bogota','AUTOS@BOGOTA.COM','12345',2),('Claro Soluciones','CLARO@SOLUCIONES.COM','123',2);

INSERT INTO PersonaNatural(Nombre,Correo,Contraseña,TipoCuentaId)
VALUES('Adrian','ADRIAN@CORREO.COM','adrian123',1),('Jorge ','JORGE@CORREO.COM','jorge123',1);

INSERT INTO Transaccion(Valor,TipoTransaccionId,TipoCuentaId,EmpresaId)
VALUES(1500000.00,1,2,1);

INSERT INTO Transaccion(Valor,TipoTransaccionId,TipoCuentaId,PersonaNaturalId)
VALUES(500000.00,1,1,1);
