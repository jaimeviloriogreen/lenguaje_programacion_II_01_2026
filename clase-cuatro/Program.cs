using System.Collections;


//=== ArrayList
ArrayList cosas = new ArrayList();

cosas.Add("Juan");
cosas.Add(3);
cosas.Add(true);

// Otra forma de inicializar un ArrayList
ArrayList objetos = new ArrayList() { "Perro", "Mesa", 19 };

// Forma moderna de inicializar un ArrayList
ArrayList personas = ["Julio", "José", "Ramón"];

foreach (var cosa in cosas) {
  System.Console.WriteLine(cosa);
}

//=== List
List<string> nombres = new List<string>();
nombres.Add("Carlos");
nombres.Add("Pedro");

// Otra forma de inicializar un List
List<string> animales = new List<string> { "Perro", "León", "Jiraga" };

// Forma moderna de inicializar un List
List<int> edades = [11, 13, 12, 18];

//=== Arreglos multidimensionales

// 1. Con dimensión fija
int[,] matriz = new int[2, 3];
matriz[0, 0] = 19;
matriz[0, 1] = 23;
matriz[0, 2] = 34;
matriz[1, 0] = 65;
matriz[1, 1] = 22;
matriz[1, 2] = 87;

// Forma más simple
int[,] nuevaMatriz = new int[2, 3]{
      {12, 13, 18},
      {11, 19, 23}
    };

// Forma mucho más simple
int[,] otraMatriz = {
      {12, 13, 18},
      {11, 19, 23}
    };

// 1. Con dimensión variable
int[][] otraNuevaMatriz = new int[2][];
otraNuevaMatriz[0] = new int[2];
otraNuevaMatriz[1] = new int[3];

otraNuevaMatriz[0][0] = 10;
otraNuevaMatriz[0][1] = 23;
otraNuevaMatriz[1][0] = 17;
otraNuevaMatriz[1][1] = 98;
otraNuevaMatriz[1][1] = 34;


// Una forma más simple

int[][] ultimaMatriz = [
  [92, 32, 32],
  [98, 22, 33, 22, 34]
];


for (int i = 0; i < otraNuevaMatriz.Length; i++) {
  for (int j = 0; j < otraNuevaMatriz[i].Length; j++) {
    Console.Write(otraNuevaMatriz[i][j] + " ");
  }
  Console.WriteLine("");
}


//=== Programación orientada a objetos
// Persona persona = new Persona("Juan", "Carlos", 17);
Persona persona = new("Juan", "Carlos", 17);
persona.UnirNombre();

