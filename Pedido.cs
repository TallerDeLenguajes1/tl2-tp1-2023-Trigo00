
public class Pedido
{
    public int Nro { get; set; }
    public string Obs { get; set; }
    public Cliente Cliente { get; set; }
    public string Estado { get; set; }

    public string VerDireccionCliente(Cliente miCliente)
    {
        return miCliente.Direccion;
    }

    public string VerDatosCliente(Cliente miCliente)
    {
        return "Nombre: " + miCliente.Nombre + "\nDireccion: " + miCliente.Direccion + "\nTelefono: " + miCliente.Telefono + "\nReferencia: " + miCliente.DatosReferenciaDireccion;
    }
}



