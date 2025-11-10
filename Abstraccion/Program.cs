class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new Gerente
        {
            Nombre = "Fernando Perez",
            ID = 1602,
            SalarioBase = 5000,
            BonoAnual = 12000
        };

        Desarrollador dev = new Desarrollador
        {
            Nombre = "Angel Enamorado",
            ID = 1603,
            SalarioBase = 4000,
            LenguajePrincipal = "C#"
        };

        Contador contador = new Contador
        {
            Nombre = "Oscar Perdomo",
            ID = 1604,
            SalarioBase = 3500,
            HorasExtras = 20,
            PagoPorHoraExtra = 50
        };
    
        gerente.MostrarInformacion();
        dev.MostrarInformacion();
        contador.MostrarInformacion();

    }
}
