int numUsuario;

int numAzar = new
    Random(DateTime.Now.Millisecond).Next(1, 21);

string mensajeMenor = "Frio frio, piensa en grande.";
string mensajeMayor = "No, no es tan grande el número que pensé.";

Console.WriteLine("He pensado un número del 1 al 20 y quiero que lo adivines.");
Console.WriteLine("Qué número crees que he pensado ?");
numUsuario = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < 21; i++)
{
    if (numUsuario == numAzar)
    {
        Console.WriteLine("Felicitaciones !! adivinaste el número era : " + numAzar);
        Console.WriteLine("Lo adivinaste en sólo " + i + " intentos !!");
        break;
    }
    else if (numUsuario < numAzar)
    {
        Console.WriteLine(mensajeMenor + "Intentalo de nuevo.");
        Console.WriteLine("Intento número: " + i);
        numUsuario = Convert.ToInt32(Console.ReadLine());
    }
    else if (numUsuario > numAzar)
    {
        Console.WriteLine(mensajeMayor + "Intentalo de nuevo.");
        Console.WriteLine("Intento número: " + i);
        numUsuario = Convert.ToInt32(Console.ReadLine());
    }
}





