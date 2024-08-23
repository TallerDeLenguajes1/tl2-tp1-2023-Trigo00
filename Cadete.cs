class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    private List<Pedidos> listadoPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public List<Pedidos> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }

    public double JornalACobrar(List<Pedidos> listadoPedidos)
    {
        int contador = 0;
        foreach (var item in listadoPedidos)
        {
            if (item.Estado == Pedidos.EstadoPedido.Entregado)
            {
                contador++;
            }
        }

        return contador * 500;
    }
}

