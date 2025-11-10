public class Gerente : Empleado
{
    public double BonoAnual { get; set; }

    public override double CalcularSalarioAnual()
    {
        return (SalarioBase * 12) + BonoAnual;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("GERENTE");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Salario Base: ${SalarioBase}");
        Console.WriteLine($"Bono Anual: ${BonoAnual}");
        Console.WriteLine($"Salario Anual Total: ${CalcularSalarioAnual()}");
        Console.WriteLine();
    }
}