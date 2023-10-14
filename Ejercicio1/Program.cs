Console.WriteLine("Ingrese la clave para realizar configuracion de respaldo");

Console.Write("Ingresa la clave: ");
string Clave = Console.ReadLine().ToLower();

Clave = Clave.Replace(" ", "").Replace("\t", "");

if (Clave == "administrador")
{
    Console.WriteLine("¡Acceso concedido!");
}
else
{
    Console.WriteLine("Clave incorrecta. Acceso denegado.");
}