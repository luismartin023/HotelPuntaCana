CREATE DATABASE HotelPuntaCana;
GO
USE HotelPuntaCana;
GO
 
CREATE TABLE TipoHabitacion (
    IdTipoHabitacion INT           IDENTITY(1,1) PRIMARY KEY,
    Nombre           VARCHAR(50)   NOT NULL,
    PrecioPorNoche   DECIMAL(10,2) NOT NULL,
    Capacidad        INT           NOT NULL,
    Descripcion      VARCHAR(200)
);
 
CREATE TABLE Habitacion (
    IdHabitacion     INT  IDENTITY(1,1) PRIMARY KEY,
    NumeroHabitacion INT  NOT NULL,
    IdTipoHabitacion INT  NOT NULL,
    Estado           VARCHAR(20) NOT NULL CONSTRAINT DF_Habitacion_Estado DEFAULT 'Disponible',
    CONSTRAINT FK_Habitacion_TipoHabitacion
        FOREIGN KEY (IdTipoHabitacion) REFERENCES TipoHabitacion(IdTipoHabitacion)
);
 
CREATE TABLE Huesped (
    IdHuesped    INT          IDENTITY(1,1) PRIMARY KEY,
    Nombre       VARCHAR(50)  NOT NULL,
    Apellido     VARCHAR(50)  NOT NULL,
    Cedula       VARCHAR(20)  NULL,
    Telefono     VARCHAR(20)  NULL,
    Email        VARCHAR(100) NULL,
    Nacionalidad VARCHAR(50)  NULL,
    CONSTRAINT UQ_Huesped_Cedula UNIQUE (Cedula)
);
 
CREATE TABLE Reserva (
    IdReserva    INT  IDENTITY(1,1) PRIMARY KEY,
    IdHabitacion INT  NOT NULL,
    IdHuesped    INT  NOT NULL,
    FechaEntrada DATE NOT NULL,
    FechaSalida  DATE NOT NULL,
    Canal        VARCHAR(50)  NOT NULL,
    Estado       VARCHAR(20)  NOT NULL CONSTRAINT DF_Reserva_Estado DEFAULT 'Pendiente',
    CONSTRAINT FK_Reserva_Habitacion FOREIGN KEY (IdHabitacion) REFERENCES Habitacion(IdHabitacion),
    CONSTRAINT FK_Reserva_Huesped    FOREIGN KEY (IdHuesped)    REFERENCES Huesped(IdHuesped)
);
 
CREATE TABLE Pago (
    IdPago      INT           IDENTITY(1,1) PRIMARY KEY,
    IdReserva   INT           NOT NULL,
    FechaPago   DATE          NOT NULL,
    Monto       DECIMAL(10,2) NOT NULL,
    MetodoPago  VARCHAR(50)   NULL,
    CONSTRAINT FK_Pago_Reserva FOREIGN KEY (IdReserva) REFERENCES Reserva(IdReserva)
);
 
CREATE TABLE Usuario (
    IdUsuario INT          IDENTITY(1,1) PRIMARY KEY,
    Nombre    VARCHAR(50)  NOT NULL,
    Usuario   VARCHAR(30)  NOT NULL,
    Clave     VARCHAR(100) NOT NULL,
    Rol       VARCHAR(20)  NOT NULL CONSTRAINT DF_Usuario_Rol DEFAULT 'Recepcionista',
    Activo    BIT          NOT NULL CONSTRAINT DF_Usuario_Activo DEFAULT 1,
    CONSTRAINT UQ_Usuario_Usuario UNIQUE (Usuario)
);
GO
 

CREATE PROCEDURE sp_CrearReserva
    @IdHabitacion INT, @IdHuesped INT,
    @FechaEntrada DATE, @FechaSalida DATE, @Canal VARCHAR(50)
AS
BEGIN
    IF @FechaEntrada >= @FechaSalida
    BEGIN RAISERROR('La fecha de salida debe ser posterior a la de entrada.',16,1); RETURN; END
 
    IF EXISTS (
        SELECT 1 FROM Reserva
        WHERE IdHabitacion = @IdHabitacion AND Estado IN ('Pendiente','Confirmada')
        AND ((@FechaEntrada >= FechaEntrada AND @FechaEntrada < FechaSalida) OR
             (@FechaSalida  > FechaEntrada  AND @FechaSalida <= FechaSalida) OR
             (@FechaEntrada <= FechaEntrada AND @FechaSalida >= FechaSalida))
    )
    BEGIN RAISERROR('OVERBOOKING: La habitacion no esta disponible en esas fechas.',16,1); RETURN; END
 
    INSERT INTO Reserva(IdHabitacion,IdHuesped,FechaEntrada,FechaSalida,Canal,Estado)
    VALUES(@IdHabitacion,@IdHuesped,@FechaEntrada,@FechaSalida,@Canal,'Confirmada');
    SELECT 'Reserva creada con exito' AS Mensaje;
END
GO
 
CREATE PROCEDURE sp_Login
    @Usuario VARCHAR(30), @Clave VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdUsuario, Nombre, Usuario, Rol
    FROM   Usuario
    WHERE  Usuario=@Usuario AND Clave=@Clave AND Activo=1;
END
GO
 
-- Datos iniciales
INSERT INTO TipoHabitacion VALUES
('Simple',3000,1,'Habitacion sencilla'),
('Doble',5000,2,'Habitacion doble'),
('Suite',10000,4,'Habitacion de lujo con vista al mar');
 
INSERT INTO Habitacion VALUES
(101,1,'Disponible'),(102,2,'Disponible'),(201,3,'Disponible');
 
INSERT INTO Huesped VALUES
('Juan','Perez','001-1234567-8','8095550000','juan@gmail.com','Dominicano'),
('Maria','Lopez','001-9999999-9','8095551111','maria@gmail.com','Dominicana');
 
INSERT INTO Usuario(Nombre,Usuario,Clave,Rol) VALUES
('Administrador','admin','1234','Admin'),
('Recepcion','recep','1234','Recepcionista');
 
EXEC sp_CrearReserva 1,1,'2026-03-01','2026-03-05','Booking';
EXEC sp_CrearReserva 2,2,'2026-04-01','2026-04-03','Directo';
 
INSERT INTO Pago VALUES(1,'2026-02-25',12000,'Tarjeta'),(2,'2026-02-26',10000,'Efectivo');
GO