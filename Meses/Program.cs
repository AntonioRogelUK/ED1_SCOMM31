namespace Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CargarMeses();
        }

        static void CargarMeses()
        {
            Mes enero = new Mes();
            enero.NombreDelMes = "Enero";
            enero.DiasDelMes = 31;

            Mes febrero = new Mes();
            febrero.NombreDelMes = "Febrero";
            febrero.DiasDelMes = 28;

            Console.WriteLine(febrero.ToString());
        }
    }
}
