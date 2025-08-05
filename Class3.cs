public class Vehiculo
{
    private bool encendido = false;  // Por defecto está apagado

    // Propiedad Encendido (solo lectura)
    public bool Encendido
    {
        get { return encendido; }
    }

    // Método para encender el vehículo
    public void Encender()
    {
        if (!encendido)
        {
            encendido = true;
            Console.WriteLine("Vehículo encendido.");
        }
        else
        {
            Console.WriteLine("El vehículo ya está encendido.");
        }
    }

    // Método para apagar el vehículo
    public void Apagar()
    {
        if (encendido)
        {
            encendido = false;
            Console.WriteLine("Vehículo apagado.");
        }
        else
        {
            Console.WriteLine("El vehículo ya está apagado.");
        }
    }
}
