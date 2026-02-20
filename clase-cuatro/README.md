```c#
using System.Collections;

//? Matriz de dimensión fija

// int[,] matriz =  {
//   {18, 23, 89},
//   {87, 45, 23},
//   {87, 23, 98},
// };

// // matriz[0, 0] = 18;
// // matriz[0, 1] = 23;
// // matriz[1, 0] = 87;
// // matriz[1, 1] = 45;

// for (int i = 0; i < 3; i++) {
//   for (int j = 0; j < 3; j++) {
//     Console.Write(matriz[i, j] + " ");
//   }
//   Console.WriteLine("");
// }

//? Matriz de dimensión variable
// int[][] matriz = new int[2][];

// matriz[0] = new int[3];
// matriz[1] = new int[2];

// int[][] matriz = [
//   [23, 33, 87, 32],
//   [11, 23],
//   [98, 88, 77, 66, 24]
// ];

// System.Console.WriteLine(matriz[2][2]);
// for (int i = 0; i < matriz.Length; i++) {
//   for (int j = 0; j < matriz[i].Length; j++) {
//     Console.Write(matriz[i][j] + " ");
//   }
//   System.Console.WriteLine("");
// }

//? ArrayList

// ArrayList cosas = ["Hola", "Mundo", 18, true];

// cosas.Add("Estudiantes");
// cosas.Add(false);

// foreach (var cosa in cosas) {
//   Console.WriteLine(cosa);
// }

//? List
List<object> nombres = ["Carlos", "José", "Félix", true, 1];

nombres.Add("Juan");
nombres.Add("Pedro");

nombres.AddRange(3, "Rosario", "María", "Josefa");

bool existePersona = nombres.Contains("Mario José");

Console.WriteLine(existePersona);

// nombres.ForEach(static (nombre) => Console.WriteLine(nombre));

// foreach (var nombre in nombres) {
//   System.Console.WriteLine(nombre);
// }


```
