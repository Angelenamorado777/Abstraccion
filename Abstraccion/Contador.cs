public class Contador : Empleado
{
    public int HorasExtras { get; set; }
    public double PagoPorHoraExtra { get; set; }

    public override double CalcularSalarioAnual()
    {
        return (SalarioBase * 12) + (HorasExtras * PagoPorHoraExtra);
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("CONTADOR");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Salario Base: ${SalarioBase}");
        Console.WriteLine($"Horas Extras: {HorasExtras}");
        Console.WriteLine($"Pago por Hora Extra: ${PagoPorHoraExtra}");
        Console.WriteLine($"Salario Anual Total: ${CalcularSalarioAnual()}");
        Console.WriteLine();
    }
}