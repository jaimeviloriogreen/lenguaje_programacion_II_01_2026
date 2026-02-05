// See https://aka.ms/new-console-template for more information

/*
  1. Constantes
  2. Conversión de tipos
  2.1 Conversión implícita
  2.2 Conversión explícita
  5. Parseo de tipos
  6. Operadores
    - Operadores Aritméticos en C#
    - Operadores de asignación en C#
    - Operadores de comparación en C#
    - Operadores lógicos en C#
  6. Control de flujo
  6.1 If ... Else
*/

/*=== CONSTANTES === */
const double Pi = 3.14159;
const float Gravedad = 9.81F;

System.Console.WriteLine(Pi);
System.Console.WriteLine(Gravedad);

/*=== CONVERSIÓN DE TIPOS === */
// Conversión explícita (Casting)
int numero1 = 10;
float numero2 = (float)numero1;

int numero3 = 101;
short numero4 = (short)numero3;

int a = 10;
double b = 10.23;
double c = (double)a * b; // Esta conversión es redunddante a decir verdad, porque queda implícita
System.Console.WriteLine(c);

// Conversión implícita
int num1 = 10;
float num2 = num1;
Console.WriteLine(num2);


// Parsear -> Convertir un string a un entero
int anioActual = 2026;
string edad = "26";
Console.WriteLine(anioActual - int.Parse(edad));

/*=== OPERADORES === */
// Operadores matemáticos
Console.WriteLine(10 + 10);
Console.WriteLine(10 - 20);
Console.WriteLine(10 * 20);
Console.WriteLine(20 / 2);
Console.WriteLine(Math.Pow(10, 2)); // Potencia
Console.WriteLine(13 % 2);

// Operadores de asignación
int ahorro = 10;
ahorro += 10;
ahorro -= 5;
ahorro *= 5;
Console.WriteLine(ahorro);

// Operadores de comparación
Console.WriteLine(10 > 20);
Console.WriteLine(10 < 20);
Console.WriteLine(10 >= 10); // 10 > = 10
Console.WriteLine(5 <= 10);
Console.WriteLine(10 == 10);
Console.WriteLine(10 != 20); // ! =

// Operadores lógicos
Console.WriteLine(false && false); // And / && 
Console.WriteLine(false || true); // OR / || 
Console.WriteLine(!true); // Not / ! 


/*=== CONTROL DE FLUJO === */
// If .. else
bool esEstudiante = false;

if (esEstudiante) {
  Console.WriteLine("Eres estudiante");
}
else {
  Console.WriteLine("Eres profesor");
}

// If ... else anidado
int edadEstudiante = 30;

if (edadEstudiante < 18) {
  Console.WriteLine("Eres menor de edad");
}
else {
  if (edadEstudiante >= 30) {
    Console.WriteLine("Estás en la edad adulto maduro");
  }
  else {
    Console.WriteLine("Eres un muchacho aún");
  }

}




