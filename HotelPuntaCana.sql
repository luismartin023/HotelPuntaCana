CREATE DATABASE HotelPuntaCana;
GO

USE HotelPuntaCana;
GO

-- 1. TABLAS
CREATE TABLE TipoHabitacion
(
    IdTipoHabitacion INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    PrecioPorNoche DECIMAL(10,2) NOT NULL,
    Capacidad INT NOT NULL,
    Descripcion VARCHAR(200)
);

CREATE TABLE Habitacion
(
    IdHabitacion INT IDENTITY(1,1) PRIMARY KEY,
    NumeroHabitacion INT NOT NULL,
    IdTipoHabitacion INT NOT NULL,
    Estado VARCHAR(20) DEFAULT 'Disponible',
    CONSTRAINT FK_Habitacion_TipoHabitacion FOREIGN KEY (IdTipoHabitacion) REFERENCES TipoHabitacion(IdTipoHabitacion)
);

CREATE TABLE Huesped
(
    IdHuesped INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Cedula VARCHAR(20) UNIQUE,
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    Nacionalidad VARCHAR(50)
);

CREATE TABLE Reserva
(
    IdReserva INT IDENTITY(1,1) PRIMARY KEY,
    IdHabitacion INT NOT NULL,
    IdHuesped INT NOT NULL,
    FechaEntrada DATE NOT NULL,
    FechaSalida DATE NOT NULL,
    Canal VARCHAR(50) NOT NULL, -- Ej: Booking, Expedia, Directo
    Estado VARCHAR(20) DEFAULT 'Pendiente', -- Pendiente, Confirmada, Cancelada
    CONSTRAINT FK_Reserva_Habitacion FOREIGN KEY (IdHabitacion) REFERENCES Habitacion(IdHabitacion),
    CONSTRAINT FK_Reserva_Huesped FOREIGN KEY (IdHuesped) REFERENCES Huesped(IdHuesped)
);

CREATE TABLE Pago
(
    IdPago INT IDENTITY(1,1) PRIMARY KEY,
    IdReserva INT NOT NULL,
    FechaPago DATE NOT NULL,
    Monto DECIMAL(10,2) NOT NULL,
    MetodoPago VARCHAR(50),
    CONSTRAINT FK_Pago_Reserva FOREIGN KEY (IdReserva) REFERENCES Reserva(IdReserva)
);
GO

-- 2. PROCEDIMIENTO ALMACENADO PARA EVITAR OVERBOOKING
-- (Esta es el arma secreta para que en C# no pases trabajo)
CREATE PROCEDURE sp_CrearReserva
    @IdHabitacion INT,
    @IdHuesped INT,
    @FechaEntrada DATE,
    @FechaSalida DATE,
    @Canal VARCHAR(50)
AS
BEGIN
    -- Validar que la fecha de salida sea mayor a la de entrada
    IF @FechaEntrada >= @FechaSalida
    BEGIN
        RAISERROR('La fecha de salida debe ser posterior a la fecha de entrada.', 16, 1);
        RETURN;
    END

    -- Validar Overbooking: Si existe alguna reserva confirmada o pendiente que se cruce en esas fechas
    IF EXISTS (
        SELECT 1 FROM Reserva 
        WHERE IdHabitacion = @IdHabitacion 
        AND Estado IN ('Pendiente', 'Confirmada')
        AND (
            (@FechaEntrada >= FechaEntrada AND @FechaEntrada < FechaSalida) OR
            (@FechaSalida > FechaEntrada AND @FechaSalida <= FechaSalida) OR
            (@FechaEntrada <= FechaEntrada AND @FechaSalida >= FechaSalida)
        )
    )
    BEGIN
        RAISERROR('OVERBOOKING: La habitación no está disponible en este rango de fechas.', 16, 1);
        RETURN;
    END

    -- Si pasa las validaciones, se inserta la reserva
    INSERT INTO Reserva (IdHabitacion, IdHuesped, FechaEntrada, FechaSalida, Canal, Estado)
    VALUES (@IdHabitacion, @IdHuesped, @FechaEntrada, @FechaSalida, @Canal, 'Confirmada');
    
    SELECT 'Reserva creada con éxito' AS Mensaje;
END;
GO

-- 3. DATOS DE PRUEBA (Para que Anfer tenga qué mostrar)
INSERT INTO TipoHabitacion VALUES 
('Simple', 3000, 1, 'Habitación sencilla'),
('Doble', 5000, 2, 'Habitación doble'),
('Suite', 10000, 4, 'Habitación de lujo con vista al mar');

INSERT INTO Habitacion VALUES 
(101, 1, 'Disponible'),
(102, 2, 'Disponible'),
(201, 3, 'Disponible');

INSERT INTO Huesped VALUES 
('Juan', 'Perez', '001-1234567-8', '8095550000', 'juan@gmail.com', 'Dominicano'),
('Maria', 'Lopez', '001-9999999-9', '8095551111', 'maria@gmail.com', 'Dominicana');

-- Insertamos reservas con el Stored Procedure (mucho más profesional)
EXEC sp_CrearReserva 1, 1, '2026-03-01', '2026-03-05', 'Booking';
EXEC sp_CrearReserva 2, 2, '2026-04-01', '2026-04-03', 'Directo';

INSERT INTO Pago VALUES 
(1, '2026-02-25', 12000, 'Tarjeta'),
(2, '2026-02-26', 10000, 'Efectivo');
GO

-- 4. REPORTES EXACTOS QUE PIDIÓ EL PROFESOR
-- Ocupación por mes
SELECT 
    MONTH(FechaEntrada) AS Mes, 
    COUNT(*) AS TotalReservas 
FROM Reserva 
WHERE Estado IN ('Confirmada', 'Pendiente')
GROUP BY MONTH(FechaEntrada);

-- Ingresos por canal (Ahora conectando Pago con Reserva)
SELECT 
    R.Canal, 
    SUM(P.Monto) AS TotalIngresos 
FROM Pago P
INNER JOIN Reserva R ON P.IdReserva = R.IdReserva
GROUP BY R.Canal;


SELECT * FROM TipoHabitacion;