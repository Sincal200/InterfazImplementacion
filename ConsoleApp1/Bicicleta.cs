public class Bicicleta: IVehiculo{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }

    public Bicicleta(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public string ObtenerDetalles()
    {
        return $"Bicicleta - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}";
    }

    public void Arrancar()
    {
        Console.WriteLine($"{Marca} {Modelo} está lista para montar.");
    }

    public void Detener()
    {
        Console.WriteLine($"{Marca} {Modelo} se ha detenido.");
    }
}

