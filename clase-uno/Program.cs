// Variables y principales tipos de datos
string nombre = "Carlos";
string apellido = "Santana";
char inicialNombre = 'J';
/*
  En C#, los números enteros son un tipo de valor que representa números sin decimales. Los números enteros en C# incluyen los siguientes tipos: byte, short, int, long.
*/
int edad = 23;
bool esProfesor = true;

/*
  Los números flotantes en C# incluyen los siguientes tipos: float y double.
*/
float altura = 5.9f;

Console.WriteLine($"Hola, mi nombre es {nombre} {apellido}");
Console.WriteLine("Tengo " + edad + " años de edad.\n");


// Entrada de datos
Console.Write("Nombre: ");
string? nombreUsuario = Console.ReadLine(); // El símbolo ? indica que puede ser string o null

Console.Write("Apellido: ");
string? apellidoUsuario = Console.ReadLine();

Console.WriteLine($"¡Bienvenido {nombreUsuario} {apellidoUsuario}!");


