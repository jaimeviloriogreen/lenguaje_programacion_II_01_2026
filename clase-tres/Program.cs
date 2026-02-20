// See https://aka.ms/new-console-template for more information
using Spectre.Console;
//? Operadores ternarios
// bool esEstudiante = true;
// int edad = 18;

// string resultado = edad > 17 ? "Es un adulto" : "Es un menor";
// Console.WriteLine(resultado);

// if (esEstudiante) {
//   Console.WriteLine("Es un estudiante");
// }
// else {
//   Console.WriteLine("Es un profesor");
// }

//? Switch
// string diaSemana = "Miércoles";

// string mensaje = diaSemana switch {
//   "Lunes" => "Es Lunes", // = >
//   "Martes" => "Es Martes",
//   "Miércoles" => "Es Miércoles",
//   "Jueves" => "Es Jueves",
//   "Viernes" => "Es Viernes",
//   "Sábado" => "Es Sábado",
//   "Domingo" => "Es Domingo",
//   _ => "No se especifica el día"
// };

// Console.WriteLine(mensaje);


// switch (diaSemana) {
//   case "Lunes":
//     Console.WriteLine("Es Lunes");
//     break;
//   case "Martes":
//     Console.WriteLine("Es Martes");
//     break;
//   case "Miércoles":
//     Console.WriteLine("Es Miércoles");
//     break;
//   case "Jueves":
//     Console.WriteLine("Es Jueves");
//     break;
//   case "Sábado":
//   case "Domingo":
//     Console.WriteLine("Es fin de semana");
//     break;
//   default:
//     Console.WriteLine("No se especifica el día");
//     break;
// }

//? While
// int i = 1;

// while (i <= 12) {

//   if (i > 9) {
//     break;
//   }
//   Console.WriteLine(i);

//   ++i; // Incrementado la variable i en 1
// }

// while (true) {
//   Console.WriteLine("¿Desea continuar? ");
//   string? continuar = Console.ReadLine();

//   if (continuar != "s") {
//     break;
//   }
// }

// int i = 1;
// do {
//   Console.WriteLine("Aunque sea una sola vez: " + i);

//   ++i;
// } while (i <= 12);


//  Arrays -> Arreglos
// int[] numeros;
// numeros = new int[5];

// int[] numeros = new int[5];
// numeros[0] = 1;
// numeros[1] = 89;
// numeros[2] = 23;
// numeros[3] = 16;
// numeros[4] = 102;

// int[] numeros = { 28, 3, 89, 32, 7 };
// int[] numeros = new int[] { 28, 3, 89, 32, 7 };

int[] numeros = [28, 3, 89, 32, 7];


// int i = 0;

// while (i < numeros.Length) {
//   Console.WriteLine("Valor: " + numeros[i]);
//   i++;
// }

// ? Foreach

foreach (int numero in numeros) {
  Console.WriteLine("Número en mi arreglo: " + numero);
}

//? For
