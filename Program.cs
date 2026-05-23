using Practica_LINQ_CI;
using System.Linq;

List<Producto> productos = DatosProductos.ObtenerProductos();

static void ImprimirProducto(Producto producto)
{
    Console.WriteLine($"Id: {producto.Id}");
    Console.WriteLine($"Nombre: {producto.Nombre}");
    Console.WriteLine($"Nombre: {producto.Descripcion}");
    Console.WriteLine($"Categoría: {producto.Categoria}");
    Console.WriteLine($"Precio: RD${producto.Precio}");
    Console.WriteLine($"Stock: {producto.Stock}");
    Console.WriteLine($"Nombre: {producto.FechaCreacion}");
    Console.WriteLine("---------------------------");
}

#region 1. Obtener todos los productos de la lista.
var todosProductos = from producto in productos
                     select producto;

//Console.WriteLine("Listado de productos.\n");

//foreach (var producto in productos)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 2. Obtener los nombres de todos los productos.

var nombresProductos = from producto in productos
                      select producto.Nombre;

//Console.WriteLine("\nNombres de los productos.\n");

//foreach (var nombre in nombresProductos)
//{
//    Console.WriteLine(nombre);
//}
#endregion

#region 3. Obtener los productos cuyo precio sea mayor a 500.

var preciosMayores500 = from producto in productos
                        where producto.Precio > 500
                        select producto;

//Console.WriteLine("\nProductos con precio mayor a 500.\n");

//foreach (var producto in preciosMayores500)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 4. Obtener los productos con stock menor a 10.

var stockMenoDiez = from producto in productos
                    where producto.Stock < 10
                    select producto;

//Console.WriteLine("\nProductos con stock menor a 10.\n");

//foreach (var producto in stockMenoDiez)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 5. Obtener los productos de la categoría "Electrónica".

var categoriaElectronica = from producto in productos
                           where producto.Categoria == "Electrónica"
                           select producto;

//Console.WriteLine("\nProductos de la catgoría de Tecnología.\n");

//foreach (var producto in categoriaElectronica)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 6. Obtener los productos cuyo nombre comience con la letra 'L'.

var productosConL = from producto in productos
                    where producto.Nombre.ToUpper().StartsWith("L")
                    select producto;

//Console.WriteLine("\nProductos que empiezan con la letra L.\n");

//foreach (var producto in productosConL)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 7. Obtener los productos cuyo precio esté entre 100 y 500.

var preciosEntre100Y300 = from producto in productos
                    where producto.Precio >= 100 && producto.Precio <=500
                    select producto;

//Console.WriteLine("\nProductos con precio entre 100 y 500.\n");

//foreach (var producto in preciosEntre100Y300)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 8. Obtener los productos ordenados por precio ascendente.

var ordenamientoPorPrecioAsc = from producto in productos
                          orderby producto.Precio ascending
                          select producto;

//Console.WriteLine("\nProductos ordenados por precios de manera ascendente.\n");

//foreach (var producto in ordenamientoPorPrecioAsc)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 9. Obtener los productos ordenados por precio descendente.
var ordenamientoPorPrecioDesc = from producto in productos
                            orderby producto.Precio descending
                            select producto;

//Console.WriteLine("\nProductos ordenados por precios de manera descendente.\n");

//foreach (var producto in ordenamientoPorPrecioDesc)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 10. Obtener los productos ordenados por nombre en orden alfabético.

var nombresOrdenAlfabetico = from producto in productos
                          orderby producto.Nombre ascending
                          select producto;

//Console.WriteLine("\nProductos ordenados por nombre en orden alfabético.\n");

//foreach (var producto in nombresOrdenAlfabetico)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 11. Obtener los productos ordenados por stock de mayor a menor.
var productosOrdenadosStock = from producto in productos
                          orderby producto.Stock descending
                          select producto;

//Console.WriteLine("\nProductos ordenados por stock de mayor a menor.\n");

//foreach (var producto in productosOrdenadosStock)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 12. Obtener los primeros 5 productos más caros
var primerosProductosCaros = (from producto in productos
                          orderby producto.Precio descending
                          select producto).Take(5);

//Console.WriteLine("\nPrimeros 5 productos más caros.\n");

//foreach (var producto in primerosProductosCaros)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 13. Obtener los 10 productos con menor stock.
var productosMenorStock = (from producto in productos
                          orderby producto.Stock ascending
                          select producto).Take(10);

//Console.WriteLine("\nProductos con menor stock.\n");

//foreach (var producto in productosMenorStock)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 14. Obtener la cantidad total de productos en la lista.
var listaProductos = from producto in productos
                          select producto;

//Console.WriteLine("\nCantidad total de productos en la lista.\n");

//int cantidadTotalProductos = listaProductos.Count();

//Console.WriteLine($"La cantidad total de productos es de: {cantidadTotalProductos}");

#endregion

#region 15. Obtener la suma de todos los precios de los productos.
var sumaPrecios = (from producto in productos
                          select producto.Precio).Sum();

//Console.WriteLine("\nSuma de todos los precios de los productos\n");
//Console.WriteLine($"La cantidad total de los precios es de: RD${sumaPrecios}");

#endregion

#region 16. Obtener el precio promedio de los productos.
var promedioPrecios = (from producto in productos
                   select producto.Precio).Average();

//Console.WriteLine("\nPrecio promedio de los productos\n");
//Console.WriteLine($"El promerio de los precios es de: RD${promedioPrecios:F2}");
#endregion

#region 17. Obtener el producto más caro.
var productoCaro = (from producto in productos
                          orderby producto.Precio descending
                          select producto).Take(1);

//Console.WriteLine("\nProducto más caro.\n");

//foreach (var producto in productoCaro)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 18. Obtener el producto más barato.
var productoBarato = (from producto in productos
                    orderby producto.Precio ascending
                    select producto).Take(1);

//Console.WriteLine("\nProducto más barato.\n");

//foreach (var producto in productoBarato)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 19. Verificar si hay algún producto con precio mayor a 1000.

var productosMayorA1000 = from producto in productos
                          where producto.Precio > 1000
                          select producto;

bool existeProductoMayorA1000 = productosMayorA1000.Any();

//Console.WriteLine($"¿Hay algún producto con precio mayor a 1000? {existeProductoMayorA1000}");

//if (existeProductoMayorA1000)
//{
//    Console.WriteLine("\nProductos con precio mayor a 1000:\n");

//    foreach (var producto in productosMayorA1000)
//    {
//        ImprimirProducto(producto);
//    }
//}
//else
//{
//    Console.WriteLine("No hay productos con precio mayor a 1000.");
//}

#endregion

#region 20. Verificar si todos los productos tienen stock mayor a 5.

var todosTienenStockMayorA5 = (from producto in productos
                               select producto).All(producto => producto.Stock > 5);

//Console.WriteLine($"¿Todos los productos tienen stock mayor a 5? {todosTienenStockMayorA5}");

#endregion

#region 21. Contar cuántos productos hay en la categoría "Audio".
var contarCategoriaAudio = from producto in productos
                          where producto.Categoria == "Audio"
                          select producto;

//Console.WriteLine($"Cantidad de productos de la catgoría Audio: {contarCategoriaAudio.Count()}");

#endregion

#region 22. Agrupar los productos por categoría.
var agruparProductos = from producto in productos
                       group producto by producto.Categoria into grupo
                       select grupo;

//Console.WriteLine("Productos agrupados por categoría:\n");

//foreach (var grupo in agruparProductos)
//{
//    Console.WriteLine($"Categoría: {grupo.Key}");
//    Console.WriteLine("---------------------------");

//    foreach (var producto in grupo)
//    {
//        Console.WriteLine($"Id: {producto.Id}");
//        Console.WriteLine($"Nombre: {producto.Nombre}");
//        Console.WriteLine($"Precio: RD${producto.Precio}");
//        Console.WriteLine($"Stock: {producto.Stock}");
//        Console.WriteLine();
//    }

//    Console.WriteLine("===========================");
//}

#endregion

#region 23. Obtener la categoría con más productos.
var categoriaMayor = (from producto in productos
                      group producto by producto.Categoria into grupo
                      orderby grupo.Count() descending
                      select new
                      {
                          Categoria = grupo.Key,
                          Cantidad = grupo.Count()
                      }).First();
//Console.WriteLine("\n23. Obtener la categoría con más productos.\n");
//Console.WriteLine("Categoría con más productos:\n");
//Console.WriteLine($"Categoría: {categoriaMayor.Categoria}");
//Console.WriteLine($"Cantidad de productos: {categoriaMayor.Cantidad}");

#endregion

#region  24. Obtener el stock total de todos los productos.
var stockTotal = (from producto in productos
                          select producto.Stock).Sum();

//Console.WriteLine("\n24. Obtener el stock total de todos los productos.\n");
//Console.WriteLine($"Suma del stock de todos los productos: {stockTotal}");
#endregion

#region 25. Obtener el producto con el nombre más largo.
var nombreMasLargo = (from producto in productos
                          orderby producto.Nombre.Length descending
                          select producto).First();

//Console.WriteLine("\n25. Obtener el producto con el nombre más largo.\n");
//ImprimirProducto(nombreMasLargo);
//Console.WriteLine($"Cantidad de caracteres en el nombre: {nombreMasLargo.Nombre.Length}");

#endregion

#region 26. Obtener el producto con la descripción más corta.
var descripcionMasCorta = (from producto in productos
                      orderby producto.Descripcion.Length ascending
                      select producto).First();

//Console.WriteLine("\n26. Obtener el producto con la descripción más corta.\n");
//ImprimirProducto(descripcionMasCorta);
//Console.WriteLine($"Cantidad de caracteres en la descripción: {descripcionMasCorta.Descripcion.Length}");

#endregion

#region 27. Filtrar los productos cuya descripción contenga la palabra "pantalla".
var filtrarDescripcion = (from producto in productos
                          where producto.Descripcion.Contains("pantalla")
                           select producto);

//Console.WriteLine("\n27. Filtrar los productos cuya descripción contenga la palabra \"pantalla\".\n");

//foreach (var producto in filtrarDescripcion)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".
var promedioCategoriaAlmacenamiento = (from producto in productos
                                      where producto.Categoria == "Almacenamiento"
                                       select producto.Stock).Average();

//Console.WriteLine("\n28. Obtener el promedio de stock de los productos de la categoría \"Almacenamiento.\"\n");
//Console.WriteLine($"Promedio de stock de los productos de la categoria Almacenamiento: {promedioCategoriaAlmacenamiento}");
#endregion

#region 29. Obtener los productos creados en una fecha específica (20/12/2022).

var fechaEspecifica = new DateTime(2022, 12, 20);

var productosFechaEspecifica = from producto in productos
                               where producto.FechaCreacion.Date == fechaEspecifica.Date
                               select producto;

//Console.WriteLine("\n29. Obtener los productos creados en una fecha específica (20/12/2022)\n");
//Console.WriteLine("Productos creados en la fecha 20/12/2022:\n");

//foreach (var producto in productosFechaEspecifica)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 30. Obtener los productos cuya ID sea par.
var idPar = from producto in productos
            where producto.Id % 2 == 0
            select producto;

//Console.WriteLine("\n30. Obtener los productos cuya ID sea par.\n");

//foreach (var producto in idPar)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 31. Obtener los productos cuya ID sea impar.
var idImpar = from producto in productos
            where producto.Id % 2 != 0
            select producto;

//Console.WriteLine("\n31. Obtener los productos cuya ID sea impar.\n");

//foreach (var producto in idImpar)
//{
//    ImprimirProducto(producto);
//}

#endregion

#region 32. Obtener los productos cuyo precio tenga un decimal mayor a .50.


#endregion

#region 33. Obtener los productos cuyo nombre tenga más de 10 caracteres.
var nombreMas10Caracteres = from producto in productos
                          where producto.Nombre.Length > 10
                          select producto;

//Console.WriteLine("\n33. Obtener los productos cuyo nombre tenga más de 10 caracteres.\n");

//foreach (var producto in nombreMas10Caracteres)
//{
//    ImprimirProducto(producto);
//}
#endregion

#region 34. Obtener los productos cuyo stock sea un número primo.


#endregion

#region 35. Obtener los productos cuyo nombre contenga la palabra "Pro".


#endregion

#region 36. Obtener los productos cuyo stock sea un múltiplo de 5.


#endregion

#region 37. Obtener los productos que tengan una descripción con más de 20 caracteres.

#endregion

#region 38. Obtener los productos cuyo precio sea un número redondo (sin decimales).

#endregion

#region 39. Obtener los productos que tengan exactamente dos palabras en su nombre.


#endregion

#region 40. Obtener la cantidad de productos que no pertenecen a la categoría "General".

#endregion

