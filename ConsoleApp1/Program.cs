
public class Programn
{
    public static void Main(string[] args)
    {
        IVehiculo miAutomovil = new Coche("Toyota", "Corolla", 2020);
        IVehiculo miBicicleta = new Bicicleta("Giant", "Escape 3", 2021);

        MostrarDetallesVehiculo(miAutomovil);
        MostrarDetallesVehiculo(miBicicleta);
    }

    public static void MostrarDetallesVehiculo(IVehiculo vehiculo)
    {
        Console.WriteLine(vehiculo.ObtenerDetalles());
        vehiculo.Arrancar();
        vehiculo.Detener();
        Console.WriteLine();
    }
}
