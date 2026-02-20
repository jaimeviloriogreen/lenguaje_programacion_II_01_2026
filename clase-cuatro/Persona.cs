class Persona {
  // Campos o variables públicas
  public string nombre;
  public string apellido;
  public int edad;

  public Persona(string nombre, string apellido, int edad) {
    //  Constructor de la clase Persona
    this.nombre = nombre;
    this.apellido = apellido;
    this.edad = edad;
  }

  public void UnirNombre() {
    //  Método público
    Console.WriteLine($"Hola, mi nombre es {nombre} {apellido}");
  }
}