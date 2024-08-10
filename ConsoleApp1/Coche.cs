public class Coche : IVehiculo{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }

    public Coche(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public string ObtenerDetalles()
    {
        return $"Coche - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}";
    }

    public void Arrancar()
    {
        Console.WriteLine($"{Marca} {Modelo} está arrancando.");
    }

    public void Detener()
    {
        Console.WriteLine($"{Marca} {Modelo} se ha detenido.");
    }
}

