using System.Text.Json;


var jsonStringCadeteria = File.ReadAllText("Cadeterias.json");
var cadeteriasObtenidas = JsonSerializer.Deserialize<List<Cadeteria>>(jsonStringCadeteria);

foreach (var cadeteria in cadeteriasObtenidas)
{
    Console.WriteLine($"Cadetería: {cadeteria.Nombre}, Teléfono: {cadeteria.Telefono}");
    foreach (var cadete in cadeteria.ListadoCadetes)
    {
        Console.WriteLine($"Cadete: {cadete.Nombre}, Teléfono: {cadete.Telefono}");
    }
}

