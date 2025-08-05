public class CuentaBancaria
{
    private decimal saldo;               // Dinero actual
    private decimal limiteRetiroDiario;  // Máximo que se puede retirar por día

    // Constructor
    public CuentaBancaria(decimal saldoInicial, decimal limite)
    {
        saldo = saldoInicial;
        limiteRetiroDiario = limite;
    }

    // Método para retirar dinero
    public void Retirar(decimal cantidad)
    {
        if (cantidad > limiteRetiroDiario)
        {
            Console.WriteLine("No puedes retirar más del límite diario.");
        }
        else if (cantidad > saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            saldo -= cantidad;
            Console.WriteLine($"Has retirado Q{cantidad} con éxito.");
        }
    }

    // Método para mostrar el saldo
    public void MostrarSaldo()
    {
        Console.WriteLine($"Tu saldo actual es: Q{saldo}");
    }
}
