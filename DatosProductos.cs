using System;
using System.Collections.Generic;

namespace Practica_LINQ_CI
{
    public static class DatosProductos
    {
        public static List<Producto> ObtenerProductos()
        {
            return new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop Pro", Descripcion = "Laptop profesional con pantalla amplia", Precio = 45000.00m, Stock = 7, Categoria = "Electrónica", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 2, Nombre = "Laptop Lenovo", Descripcion = "Laptop ligera para oficina y estudio", Precio = 38000.75m, Stock = 15, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 1, 10) },
            new Producto { Id = 3, Nombre = "Monitor Curvo", Descripcion = "Monitor con pantalla curva de alta resolución", Precio = 12500.00m, Stock = 5, Categoria = "Electrónica", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 4, Nombre = "Mouse Gamer", Descripcion = "Mouse con luces RGB y botones programables", Precio = 850.99m, Stock = 23, Categoria = "Electrónica", FechaCreacion = new DateTime(2024, 2, 15) },
            new Producto { Id = 5, Nombre = "Teclado Pro", Descripcion = "Teclado mecánico para escritura rápida", Precio = 2500.00m, Stock = 10, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 5, 3) },

            new Producto { Id = 6, Nombre = "Audífonos Pro", Descripcion = "Audífonos inalámbricos con sonido envolvente", Precio = 3200.50m, Stock = 4, Categoria = "Audio", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 7, Nombre = "Bocina Bluetooth", Descripcion = "Bocina portátil con batería recargable", Precio = 1800.00m, Stock = 11, Categoria = "Audio", FechaCreacion = new DateTime(2023, 7, 18) },
            new Producto { Id = 8, Nombre = "Micrófono USB", Descripcion = "Micrófono ideal para grabaciones y reuniones", Precio = 2950.80m, Stock = 3, Categoria = "Audio", FechaCreacion = new DateTime(2024, 1, 12) },
            new Producto { Id = 9, Nombre = "Parlante Mini", Descripcion = "Parlante compacto de uso diario", Precio = 475.60m, Stock = 19, Categoria = "Audio", FechaCreacion = new DateTime(2023, 3, 22) },
            new Producto { Id = 10, Nombre = "Radio Portátil", Descripcion = "Radio pequeña con buena recepción", Precio = 500.00m, Stock = 20, Categoria = "Audio", FechaCreacion = new DateTime(2021, 11, 5) },

            new Producto { Id = 11, Nombre = "Disco SSD", Descripcion = "Unidad de almacenamiento rápido", Precio = 4200.00m, Stock = 13, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2023, 6, 8) },
            new Producto { Id = 12, Nombre = "Memoria USB", Descripcion = "Memoria portátil de 64GB", Precio = 350.75m, Stock = 30, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 13, Nombre = "Disco Externo", Descripcion = "Disco duro externo de gran capacidad", Precio = 5200.00m, Stock = 8, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2024, 4, 9) },
            new Producto { Id = 14, Nombre = "Tarjeta MicroSD", Descripcion = "Tarjeta de almacenamiento para celular", Precio = 450.90m, Stock = 17, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2023, 8, 14) },
            new Producto { Id = 15, Nombre = "SSD Pro", Descripcion = "Almacenamiento sólido de alto rendimiento", Precio = 6800.60m, Stock = 2, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2022, 10, 1) },

            new Producto { Id = 16, Nombre = "Lámpara LED", Descripcion = "Lámpara moderna para escritorio", Precio = 390.00m, Stock = 25, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 2, 6) },
            new Producto { Id = 17, Nombre = "Licuadora Oster", Descripcion = "Licuadora resistente para uso diario", Precio = 4300.00m, Stock = 9, Categoria = "Hogar", FechaCreacion = new DateTime(2024, 5, 11) },
            new Producto { Id = 18, Nombre = "Lonchera Térmica", Descripcion = "Lonchera práctica para conservar alimentos", Precio = 480.55m, Stock = 14, Categoria = "Hogar", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 19, Nombre = "Lavadora Mini", Descripcion = "Lavadora pequeña para espacios reducidos", Precio = 18500.00m, Stock = 6, Categoria = "Hogar", FechaCreacion = new DateTime(2023, 9, 25) },
            new Producto { Id = 20, Nombre = "Libro Cocina", Descripcion = "Recetas fáciles para preparar en casa", Precio = 350.00m, Stock = 29, Categoria = "Libros", FechaCreacion = new DateTime(2021, 4, 30) },

            new Producto { Id = 21, Nombre = "Libro Pro", Descripcion = "Libro avanzado para mejorar habilidades", Precio = 950.75m, Stock = 12, Categoria = "Libros", FechaCreacion = new DateTime(2023, 12, 1) },
            new Producto { Id = 22, Nombre = "Agenda Personal", Descripcion = "Agenda para organizar tareas diarias", Precio = 275.00m, Stock = 35, Categoria = "Papelería", FechaCreacion = new DateTime(2024, 1, 5) },
            new Producto { Id = 23, Nombre = "Cuaderno Grande", Descripcion = "Cuaderno de muchas páginas para apuntes", Precio = 125.99m, Stock = 50, Categoria = "Papelería", FechaCreacion = new DateTime(2023, 10, 10) },
            new Producto { Id = 24, Nombre = "Bolígrafo Azul", Descripcion = "Bolígrafo de tinta azul", Precio = 25.00m, Stock = 100, Categoria = "Papelería", FechaCreacion = new DateTime(2022, 9, 9) },
            new Producto { Id = 25, Nombre = "Resaltador Verde", Descripcion = "Resaltador para marcar textos importantes", Precio = 60.75m, Stock = 37, Categoria = "Papelería", FechaCreacion = new DateTime(2022, 12, 20) },

            new Producto { Id = 26, Nombre = "Camiseta Blanca", Descripcion = "Camiseta básica de algodón suave", Precio = 450.00m, Stock = 18, Categoria = "Ropa", FechaCreacion = new DateTime(2023, 6, 19) },
            new Producto { Id = 27, Nombre = "Jeans Azul", Descripcion = "Pantalón jean clásico para uso diario", Precio = 1450.50m, Stock = 7, Categoria = "Ropa", FechaCreacion = new DateTime(2024, 3, 17) },
            new Producto { Id = 28, Nombre = "Chaqueta Pro", Descripcion = "Chaqueta elegante con diseño moderno", Precio = 3500.00m, Stock = 5, Categoria = "Ropa", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 29, Nombre = "Zapatos Casuales", Descripcion = "Zapatos cómodos para caminar", Precio = 2800.90m, Stock = 11, Categoria = "Ropa", FechaCreacion = new DateTime(2023, 11, 12) },
            new Producto { Id = 30, Nombre = "Lentes Sol", Descripcion = "Lentes con protección para días soleados", Precio = 499.99m, Stock = 31, Categoria = "Ropa", FechaCreacion = new DateTime(2024, 6, 1) },

            new Producto { Id = 31, Nombre = "Celular Pro", Descripcion = "Celular moderno con pantalla grande", Precio = 52000.00m, Stock = 3, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 7, 7) },
            new Producto { Id = 32, Nombre = "Tablet Samsung", Descripcion = "Tablet con pantalla táctil de alta calidad", Precio = 23000.65m, Stock = 16, Categoria = "Electrónica", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 33, Nombre = "Cámara Digital", Descripcion = "Cámara para fotos y videos", Precio = 19500.00m, Stock = 2, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 2, 20) },
            new Producto { Id = 34, Nombre = "Router WiFi", Descripcion = "Router para mejorar conexión de internet", Precio = 2200.75m, Stock = 13, Categoria = "Electrónica", FechaCreacion = new DateTime(2024, 4, 22) },
            new Producto { Id = 35, Nombre = "Pantalla LED", Descripcion = "Televisor con pantalla LED inteligente", Precio = 31000.00m, Stock = 4, Categoria = "Electrónica", FechaCreacion = new DateTime(2021, 12, 15) },

            new Producto { Id = 36, Nombre = "Cable HDMI", Descripcion = "Cable para conectar dispositivos a pantalla", Precio = 225.00m, Stock = 40, Categoria = "General", FechaCreacion = new DateTime(2023, 1, 9) },
            new Producto { Id = 37, Nombre = "Cargador Pro", Descripcion = "Cargador rápido para dispositivos modernos", Precio = 950.95m, Stock = 17, Categoria = "General", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 38, Nombre = "Soporte Laptop", Descripcion = "Soporte ajustable para laptop", Precio = 650.00m, Stock = 5, Categoria = "General", FechaCreacion = new DateTime(2024, 2, 28) },
            new Producto { Id = 39, Nombre = "Funda Celular", Descripcion = "Funda protectora sencilla", Precio = 175.75m, Stock = 60, Categoria = "General", FechaCreacion = new DateTime(2023, 5, 15) },
            new Producto { Id = 40, Nombre = "Adaptador USB", Descripcion = "Adaptador pequeño para conectar accesorios", Precio = 325.00m, Stock = 43, Categoria = "General", FechaCreacion = new DateTime(2022, 8, 8) },

            new Producto { Id = 41, Nombre = "Silla Oficina", Descripcion = "Silla ergonómica para trabajar cómodo", Precio = 7200.00m, Stock = 7, Categoria = "Muebles", FechaCreacion = new DateTime(2023, 9, 1) },
            new Producto { Id = 42, Nombre = "Mesa Centro", Descripcion = "Mesa para sala con diseño simple", Precio = 3800.85m, Stock = 3, Categoria = "Muebles", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 43, Nombre = "Estante Pro", Descripcion = "Estante resistente con varios niveles", Precio = 5600.00m, Stock = 11, Categoria = "Muebles", FechaCreacion = new DateTime(2024, 7, 2) },
            new Producto { Id = 44, Nombre = "Escritorio Madera", Descripcion = "Escritorio amplio para computadora", Precio = 9900.99m, Stock = 5, Categoria = "Muebles", FechaCreacion = new DateTime(2023, 4, 18) },
            new Producto { Id = 45, Nombre = "Librero Blanco", Descripcion = "Librero de madera para organizar libros", Precio = 4800.00m, Stock = 2, Categoria = "Muebles", FechaCreacion = new DateTime(2022, 11, 23) },

            new Producto { Id = 46, Nombre = "Perfume Floral", Descripcion = "Perfume suave de aroma floral", Precio = 2500.00m, Stock = 19, Categoria = "Belleza", FechaCreacion = new DateTime(2023, 3, 3) },
            new Producto { Id = 47, Nombre = "Labial Pro", Descripcion = "Labial de larga duración y color intenso", Precio = 425.95m, Stock = 23, Categoria = "Belleza", FechaCreacion = new DateTime(2022, 12, 20) },
            new Producto { Id = 48, Nombre = "Crema Facial", Descripcion = "Crema hidratante para el cuidado del rostro", Precio = 780.00m, Stock = 29, Categoria = "Belleza", FechaCreacion = new DateTime(2024, 1, 30) },
            new Producto { Id = 49, Nombre = "Mascarilla Capilar", Descripcion = "Tratamiento nutritivo para cabello seco", Precio = 360.60m, Stock = 31, Categoria = "Belleza", FechaCreacion = new DateTime(2023, 6, 27) },
            new Producto { Id = 50, Nombre = "Limpiador Facial", Descripcion = "Limpiador suave para uso diario", Precio = 490.00m, Stock = 41, Categoria = "Belleza", FechaCreacion = new DateTime(2022, 12, 20) }
        };
        }
    }
}
