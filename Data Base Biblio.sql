
-- Primero Ejecutar creacion de base de datos, luego ejecutar desde uso hasta el final.
Create database BilbiotecaProyecto;

Use BilbiotecaProyecto;

Create table Libro (
    ISBN char(13) primary key,
    Titulo nvarchar(255) not null,
    Autor nvarchar(255) not null,
    Editorial nvarchar(255),
    A�oPublicacion int,
    Genero nvarchar(100),
    NumeroCopia int default 1
);

Create table Usuario (
    IdUsuario int primary key identity(1,1),
    Nombre nvarchar(100) not null,
    Apellido nvarchar(100) not null,
    Email nvarchar(255) unique not null,
    Telefono nvarchar(15)
);


Create table Reserva (
    IdReserva int primary key identity(1,1), 
    IdUsuario int not null,
    ISBN char(13) not null,
    FechaReserva date not null,
    FechaRetorno date not null,

    CONSTRAINT FK_Reserva_Usuario FOREIGN KEY (IdUsuario)
        REFERENCES Usuario(IdUsuario) ON DELETE CASCADE, 
    CONSTRAINT FK_Reserva_Libro FOREIGN KEY (ISBN)
        REFERENCES Libro(ISBN) ON DELETE CASCADE
);



insert into Libro (ISBN, Titulo, Autor, Editorial, A�oPublicacion, Genero, NumeroCopia)
values 
('9781234567890', 'Cien a�os de soledad', 'Gabriel Garc�a M�rquez', 'Sudamericana', 1967, 'Realismo M�gico', 3),
('9789876543210', 'Don Quijote de la Mancha', 'Miguel de Cervantes', 'Francisco de Robles', 1605, 'Novela', 5),
('9788523456789', '1984', 'George Orwell', 'Secker & Warburg', 1949, 'Distop�a', 4);

insert into Usuario (Nombre, Apellido, Email, Telefono)
values 
('Juan', 'P�rez', 'juan.perez@gmail.com', '555-1234'),
('Mar�a', 'G�mez', 'maria.gomez@gmail.com', '555-5678'),
('Carlos', 'Fern�ndez', 'carlos.fernandez@gmail.com', '555-8765');

insert into Reserva (IdUsuario, ISBN, FechaReserva, FechaRetorno)
values 
(1, '9781234567890', '2024-10-15', '2024-11-15'),
(2, '9789876543210', '2024-10-16', '2024-11-16'),
(3, '9788523456789', '2024-10-17', '2024-11-17');


