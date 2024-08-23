
class Pedidos
{
    private int nro;
    private string obs;
    private Cliente cliente;
    private EstadoPedido estado;

    public enum EstadoPedido
    {
        Aceptado,
        Preparando,
        Enviando,
        Entregado
    }

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public EstadoPedido Estado { get => estado; set => estado = value; }

    public string VerDireccionCliente(Cliente miCliente){
        return miCliente.Direccion;
    }

    public string VerDatosCliente(Cliente miCliente){
        return "Nombre: " + miCliente.Nombre + "\nDireccion: " + cliente.Direccion + "\nTelefono: " + miCliente.Telefono + "\nReferencia: " + miCliente.DatosReferenciaDireccion;
    }
}



