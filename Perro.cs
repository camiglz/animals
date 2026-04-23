//Perro es clase hija de Animal 
//los dos puntos son de herencia

class Perro : Animal
{
//Atributo propio de Perro
public string Raza;

//constructor (llama al constrcutor del padre con "base")
public Perro(string nombre, int edad, string raza)
  //datos del constructor animal, por eso es base
  :base(nombre, edad)
  {
    //parametro
    Raza = raza;
  }
  //se pone el metodo del padre
  public new void HacerSonido()
  {
    Console.WriteLine(Nombre + " dice; ¡Guau!");
  }

  //Método propio de perro
  public void Buscar()
  {
    Console.WriteLine(Nombre+ " está buscando algo...");
  }
}

//clase principal
class Program
{
    static void Main()
    {
    //crear objeto animal
    Console.WriteLine();

    Perro miPerro = new Perro("Chaneke", 7, "Salchicha");
    miPerro.MostrarInfo();
    miPerro.HacerSonido();
    miPerro.Buscar();

    Console.WriteLine("Raza: " + miPerro.Raza);
    }
}
