// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Producto camiseta = new Producto(100);
Producto campera = new Producto(200);
Producto pantalon = new Producto(150);
Producto medias = new Producto(50);

Console.WriteLine($"Precio de la camiseta con IVA: {camiseta.Precio}");
Console.WriteLine($"Precio de la campera con IVA: {campera.Precio}");
Console.WriteLine($"Precio del pantalón con IVA: {pantalon.Precio}");
Console.WriteLine($"Precio de las medias con IVA: {medias.Precio}");