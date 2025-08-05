using System;

public class Class1
{
	public Class1()
	{
	}
}
public class Empleado
{
    private string nombre;    // Atributo privado
    private decimal salario;  // Atributo privado

    // Propiedad para el nombre
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))  // No dejar vacío
            {
                nombre = value;
            }
            else
            {
                Console.WriteLine("Error: el nombre no puede estar en blanco.");
            }
        }
    }

    // Propiedad para el salario
    public decimal Salario
    {
        get { return salario; }
        set
        {
            if (value >= 0)  // No permitir valores negativos
            {
                salario = value;
            }
            else
            {
                Console.WriteLine("Error: el salario no puede ser negativo.");
            }
        }
    }

    // Constructor
    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
}
