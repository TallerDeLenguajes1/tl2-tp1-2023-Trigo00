

Cadeteria miCadeteria = new Cadeteria();
miCadeteria = LecturaCsv.TraerDatosDeCsv(@"C:\Users\Nico\Desktop\Taller2\tl2-tp1-2023-Trigo00\Cadete.csv", @"C:\Users\Nico\Desktop\Taller2\tl2-tp1-2023-Trigo00\Cadeteria.csv", miCadeteria);

// Mostrar información de la Cadeteria
Console.WriteLine("Informacion de Cadeteria\n");
Console.WriteLine("Nombre Cadeteria: " + miCadeteria.Nombre);
Console.WriteLine("Direccion Cadeteria: " + miCadeteria.Direccion);
Console.WriteLine("Telefono Cadeteria: " + miCadeteria.Telefono);
Console.WriteLine("");

// Recorrer todos los cadetes y mostrar su información junto con la de sus pedidos
foreach (var cadete in miCadeteria.ListadoCadetes)
{
    Console.WriteLine("Informacion de Cadete\n");
    Console.WriteLine("ID: " + cadete.Id);
    Console.WriteLine("Nombre: " + cadete.Nombre);
    Console.WriteLine("Domicilio: " + cadete.Direccion);
    Console.WriteLine("Telefono: " + cadete.Telefono);
    Console.WriteLine("");

    foreach (var pedido in cadete.ListadoPedidos)
    {
        Console.WriteLine("Informacion del Pedido\n");
        Console.WriteLine("Pedido Nro: " + pedido.Nro);
        Console.WriteLine("Observacion del Pedido: " + pedido.Obs);
        Console.WriteLine("");

        Console.WriteLine("Informacion Cliente \n");
        Console.WriteLine("Nombre: " + pedido.Cliente.Nombre);
        Console.WriteLine("Direccion: " + pedido.Cliente.Direccion);
        Console.WriteLine("Telefono: " + pedido.Cliente.Telefono);
        Console.WriteLine("Alguna referencia para ubicar al cadete: " + pedido.Cliente.DatosReferenciaDireccion);
        Console.WriteLine("\nEstado del Pedido: " + pedido.EstadoPedido);
        Console.WriteLine("");
    }
}

// string opcion;
// do
// {
//     Console.WriteLine("/////Menú Principal/////");
//     Console.WriteLine("\n1) Dar de pedido de alta");
//     Console.WriteLine("\n2) Asignar pedido");
//     Console.WriteLine("\n3) Cambiar estado de pedido");
//     Console.WriteLine("\n4) Reasignar pedido");
//     Console.WriteLine("\n5) Salir");
//     Console.Write("Ingrese la opción deseada: ");
//     opcion = Console.ReadLine();
//     if(opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5"){
//         Console.WriteLine("Error, ingresa una opcion válida.");
//     }
// } while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5");

// switch (opcion)
// {
//     case "1":

//         break;
//     case "2":

//         break;
//     case "3":

//         break;
//     case "4":

//         break;
// }