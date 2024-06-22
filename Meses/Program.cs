using System.Xml;

namespace Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CargarMeses();   
        }

        static void CargarMeses()
        {
            List<Mes> meses = new List<Mes>();

            Mes enero = new Mes();
            enero.NombreDelMes = "Enero";
            enero.DiasDelMes = 31;
            meses.Add(enero);

            Mes febrero = new Mes();
            febrero.NombreDelMes = "Febrero";
            febrero.DiasDelMes = 28;
            meses.Add(febrero);

            Mes marzo = new Mes();
            marzo.NombreDelMes = "Marzo";
            marzo.DiasDelMes = 31;
            meses.Add(marzo);

            Mes abril = new Mes();
            abril.NombreDelMes = "Abril";
            abril.DiasDelMes = 30;
            meses.Add(abril);

            Mes mayo = new Mes();
            mayo.NombreDelMes = "Mayo";
            mayo.DiasDelMes = 31;
            meses.Add(mayo);

            Mes junio = new Mes();
            junio.NombreDelMes = "Junio";
            junio.DiasDelMes = 30;
            meses.Add(junio);

            Mes julio = new Mes();
            julio.NombreDelMes = "Julio";
            julio.DiasDelMes= 31;
            meses.Add(julio);

            Mes agosto = new Mes();
            agosto.NombreDelMes = "Agosto";
            agosto.DiasDelMes = 31;
            meses.Add(agosto);

            Mes septiembre = new Mes();
            septiembre.NombreDelMes = "Septiembre";
            septiembre.DiasDelMes = 30;
            meses.Add(septiembre);

            Mes octubre = new Mes();
            octubre.NombreDelMes = "Octubre";
            octubre.DiasDelMes = 31;
            meses.Add(octubre);

            Mes noviembre = new Mes();
            noviembre.NombreDelMes = "Noviembre";
            noviembre.DiasDelMes = 30;
            meses.Add(noviembre);

            Mes diciembre = new Mes();
            diciembre.NombreDelMes = "Diciembre";
            diciembre.DiasDelMes = 31;
            meses.Add(diciembre);


            Console.WriteLine("Introduce un numero del 1 al 12");
            string respuesta = Console.ReadLine();
            int numeroMes = 0;
            bool sePudoConvertir = int.TryParse(respuesta, out numeroMes);
            if (sePudoConvertir == true && numeroMes > 0 && numeroMes < 13)
            {
                Console.WriteLine($"{meses[numeroMes - 1]}");
            }
            else
            {
                MostrarMenu();
            }
            
            void MostrarMenu()
            {
                int consecutivo = 0;
                foreach (Mes mes in meses)
                {
                    consecutivo++;
                    Console.WriteLine($"[{consecutivo}] {mes}");
                }
            }

        }

    }
}
