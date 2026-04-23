//Camila González Mota
//Creación de clase animal
using System;

class Animal 
{
   //Atributos 
    public string Nombre;
    public int Edad; 

    //Constructor
    public Animal (string nombre, int edad)
    {
        //Parametros 
        Nombre = nombre;
        Edad = edad;
    }

    //Método
    public void HacerSonido()
    {
        Console.WriteLine (Nombre + " hace un sonido. ");
    }

    //Método para mostar info
    public void MostrarInfo()
    {
        Console.WriteLine ("Nombre: " + Nombre + ", Edad: " + Edad);
    }
}
