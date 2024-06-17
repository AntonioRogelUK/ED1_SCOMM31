Console.WriteLine("Favor de ingresar un numero del 1 al 7");
string respuesta = Console.ReadLine();

int diaEnNumero = 0;
bool sePudoConvertir = int.TryParse(respuesta, out diaEnNumero);
if (sePudoConvertir == true && diaEnNumero > 0 && diaEnNumero < 8)
{

}