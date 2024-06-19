namespace Meses
{
    internal class Mes
    {
        public string NombreDelMes { get; set; } = string.Empty;
        public int DiasDelMes { get; set; } = 0;

        public override string ToString()
        {
            return $"El mes es {NombreDelMes} y tiene {DiasDelMes} dias";
        }
    }
}
