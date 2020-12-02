using System;
using System.Collections.Generic;
using System.Linq;


//Ejemplo en red social
public class Program
{
  public static void Main()
  {
    Publicacion post1 = new Publicacion("Gracias por el saludo de cumpleaños", true, "Oscar Osambela");//del constructor parametrizado
    Console.WriteLine(post1.ToString());

		Publicacion post2 = new Publicacion("Gracias por el saludo de cumpleaños", true, "Francisco Osambela");//del constructor parametrizado
    Console.WriteLine(post2.ToString());

    PublicacioImagen imagen1 = new PublicacioImagen("Mira la siguiente imagen","Oscar Osambela", "http://www.imagen.com", true);
    Console.WriteLine(imagen1.ToString());
  }
}


  

