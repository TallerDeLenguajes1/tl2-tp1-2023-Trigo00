public class Cadete
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public List<Pedido> PedidosCadete { get; set; }

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

