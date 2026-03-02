-- Habilitar el uso de claves foráneas
PRAGMA foreign_keys = ON;

-- Crear tablas
CREATE TABLE IF NOT EXISTS libro (
    id_libro INTEGER PRIMARY KEY,
    titulo TEXT NOT NULL,
    fecha TEXT NOT NULL,
    isbn TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS autor (
    id_autor INTEGER PRIMARY KEY,
    nombre TEXT NOT NULL,
    apellido TEXT NOT NULL,
    correo TEXT NULL UNIQUE
);

CREATE Table IF NOT EXISTS libro_autor (
    libro_id INTEGER NOT NULL,
    autor_id INTEGER NOT NULL,
    FOREIGN KEY (libro_id) REFERENCES libro (id_libro),
    FOREIGN KEY (autor_id) REFERENCES autor (id_autor),
    -- Clave primaria compuesta -> asegura que un autor no se relacione dos veces en el mismo libro.
    PRIMARY KEY (libro_id, autor_id)
);

-- Insertar libros
INSERT INTO
    libro (titulo, fecha, isbn)
VALUES (
        'Un mundo feliz',
        '1932',
        'abc-001'
    ),
    (
        'El diario de Ana Frank',
        '1947',
        'abc-002'
    ),
    (
        'El mundo de Sofía',
        '1991',
        'abc-003'
    ),
    (
        'Las puertas de las percepción',
        '1954',
        'abc-004'
    );

-- Insertar autores
INSERT INTO
    autor (nombre, apellido)
VALUES ('Aldous', 'Huxley'),
    ('Ana', 'Frank'),
    ('Jostein', 'Jostein Gaarder');

INSERT INTO
    libro_autor (libro_id, autor_id)
VALUES (1, 1),
    (2, 2),
    (3, 3),
    (4, 1);

-- Consulta con tablas relacionadas
SELECT nombre, apellido, titulo
FROM
    libro_autor
    INNER JOIN autor ON libro_autor.autor_id = autor.id_autor
    INNER JOIN libro ON libro_autor.libro_id = libro.id_libro;