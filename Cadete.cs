public class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    private List<Pedido> pedidosCadete;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Pedido> PedidosCadete { get => pedidosCadete; set => pedidosCadete = value; }

    public double JornalACobrar()
    {
        int contador = 0;
        foreach (var item in PedidosCadete)
        {
            if (item.Estado == "Entregado")
            {
                contador++;
            }
        }

        return contador * 500;
    }

    public void AgregarPedido(Pedido pedido)
    {
        PedidosCadete.Add(pedido);
    }

    public void EliminarPedido(Pedido pedido)
    {
        PedidosCadete.Remove(pedido);
    }

    public int ObtenerPedidosTotales()
    {
        return PedidosCadete.Count();
    }

    public bool TienePedido(Pedido pedido)
    {
        return PedidosCadete.Contains(pedido);
    }
}

