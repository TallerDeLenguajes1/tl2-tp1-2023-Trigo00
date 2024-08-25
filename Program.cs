//Leer cadetes desde el archivo csv
string ubicacionArchivo = @"C:\Users\Nico\Desktop\Taller2\tl2-tp1-2023-Trigo00\Cadete.csv";
using (StreamReader archivo = new StreamReader(ubicacionArchivo))
{
    string separador = ",";
    string linea;
    while((linea = archivo.ReadLine()) != null)
    {
        string[] fila = linea.Split(separador);
        string idCadete = fila[0];
        string nombreCadete = fila[1];
        string direccionCadete = fila[2];
        string telefonoCadete = fila[3];
        string nroPedido = fila[4];
        string observacionPedido = fila[5];
        string nombreCliente = fila[6];
        string direccionCliente = fila[7];
        string telefonoCliente = fila[8];
        string referenciaDireccion = fila[9];
        string estPedido = fila[10];

        Console.WriteLine("Informacion de Cadete\n");
        Console.WriteLine("ID: " + idCadete);
        Console.WriteLine("Nombre: " + nombreCadete);
        Console.WriteLine("Domicilio: " + direccionCadete);
        Console.WriteLine("Telefono: " + telefonoCadete);
        Console.WriteLine("Informacion del Pedido\n");
        Console.WriteLine("Pedido Nro: " + nroPedido);
        Console.WriteLine("Observacion del Pedido: " + observacionPedido);
        Console.WriteLine("Informacion Cliente \n");
        Console.WriteLine("Nombre: " + nombreCliente);
        Console.WriteLine("Direccion: " + direccionCliente);
        Console.WriteLine("Telefono: " + telefonoCliente);
        Console.WriteLine("Alguna referencia para ubicar al cadete: " + referenciaDireccion);
        Console.WriteLine("\nEstado del Pedido: " + estPedido);
        Console.WriteLine("");
    }
}