class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new Gerente
        {
            Nombre = "Fernando Perez",
            ID = 1602,
            SalarioBase = 12000,
            BonoAnual = 20000
        };

        Desarrollador dev = new Desarrollador
        {
            Nombre = "Angel Enamorado",
            ID = 1603,
            SalarioBase = 10000,
            LenguajePrincipal = "Python"
        };

        Contador contador = new Contador
        {
            Nombre = "Oscar Perdomo",
            ID = 1604,
            SalarioBase = 9000,
            HorasExtras = 30,
            PagoPorHoraExtra = 60
        };
    
        gerente.MostrarInformacion();
        dev.MostrarInformacion();
        contador.MostrarInformacion();

    }
}
