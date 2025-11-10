public class Desarrollador : Empleado
{
    public string? LenguajePrincipal { get; set; }

    public override double CalcularSalarioAnual()
    {
        return SalarioBase * 12;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("DESARROLLADOR");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Salario Base: ${SalarioBase}");
        Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
        Console.WriteLine($"Salario Anual Total: ${CalcularSalarioAnual()}");
        Console.WriteLine();
    }
}
