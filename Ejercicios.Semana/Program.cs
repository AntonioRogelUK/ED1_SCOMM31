
Console.WriteLine("Introduce un numero del 1 al 7!");
string respuesta = Console.ReadLine();
int diaSemana = 0;
bool sePudoConvertir = int.TryParse(respuesta, out diaSemana);
string[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
if (sePudoConvertir == true && diaSemana > 0 && diaSemana < 8)
{
    Console.WriteLine($"El dia de la semana es: {semana[diaSemana - 1]}");
}
else
{
    MostrarMenu();
}


void MostrarMenu()
{
    int consecutivo = 0;
    foreach (string dia in semana)
    {
        consecutivo++;
        Console.WriteLine($"[{consecutivo}] {dia}");
    }
}
