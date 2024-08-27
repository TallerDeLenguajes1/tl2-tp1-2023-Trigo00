
public class Cadeteria
{
    private string nombre;
    private string telefono;
    private string direccion;
    private List<Cadete> listadoCadetes;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

    public Cadeteria()
    {
        ListadoCadetes = new List<Cadete>();
    }

    //public List<Pedido> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }

    // public void AsignarPedido(Cadete cadete, Pedido pedido)
    // {
    //     cadete.AgregarPedido(pedido);
    //     ListadoPedidos.Add(pedido);
    // }

    // public void ReasignarPedido(Pedido pedido, Cadete nuevoCadete)
    // {
    //     var cadeteAnterior = ListadoCadetes.FirstOrDefault(c => c.TienePedido(pedido));
    //     if (cadeteAnterior != null)
    //     {
    //         cadeteAnterior.EliminarPedido(pedido);
    //     }
    //     nuevoCadete.AgregarPedido(pedido);
    // }

    // public void EliminarPedido2(Pedido pedido)
    // {
    //     var cadete = ListadoCadetes.FirstOrDefault(c => c.TienePedido(pedido));
    //     if (cadete != null)
    //     {
    //         cadete.EliminarPedido(pedido);
    //     }
    //     ListadoPedidos.Remove(pedido);
    // }

    public void GenerarInforme()
    {
        double totalGeneral = 0;

        Console.WriteLine("Informe de Cadetería:");
        foreach (var cadete in ListadoCadetes)
        {
            double montoGanado = cadete.JornalACobrar();
            totalGeneral += montoGanado;
            Console.WriteLine($"Cadete: {cadete.Nombre}, Total de Envíos: {cadete.ObtenerPedidosTotales()}, Monto Ganado: {montoGanado:C}");
        }
        Console.WriteLine($"Monto Total Ganado por la Cadetería: {totalGeneral:C}");
    }

}


