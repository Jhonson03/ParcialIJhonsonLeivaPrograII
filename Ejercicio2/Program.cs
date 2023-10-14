Console.WriteLine("A continuacion se calculara el area superficial y volumen de una esfera");

Console.Write("\nIngrese el radio de la esfera: ");

double Radio = double.Parse(Console.ReadLine());

double Area = (4*(Math.PI) * Math.Pow(Radio, 2));

double Volumen = (4 * (Math.PI) * Math.Pow(Radio, 3) / 3);

Console.WriteLine($"\nEl area superficial real es: {Area}");
Console.WriteLine($"\nEl area superficial de la esfera es: {Math.Round(Area, 5)}");
Console.WriteLine($"\nEl area superficial de la esfera con valor redondeado hacia arriba es: {Math.Ceiling(Area)}");
Console.WriteLine($"\nEl area superficial de la esfera con valor redondeado hacia abajo es: {Math.Floor(Area)}");

Console.WriteLine("---------------------------------------------------------------------------------------");

Console.WriteLine($"\nEl volumen real es: {Volumen}");
Console.WriteLine($"\nEl volumen de la esfera es: {Math.Round(Volumen, 5)}");
Console.WriteLine($"\nEl volumen de la esfera con valor redondeado hacia arriba es: {Math.Ceiling(Volumen)}");
Console.WriteLine($"\nEl volumen de la esfera con valor redondeado hacia abajo es: {Math.Floor(Volumen)}");