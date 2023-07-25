namespace Clase_14_Herencia;

public class Persona
{
  public string NombreCompleto { get; set; }
  public int Dni { get; set; }

  public Persona()
  {
    NombreCompleto = "Juan Perex";
    Dni = 23423423;
  }

  protected string Clave()
  {
    return "09r38g8gt2308sd93de";
  }

  public static void saludar()
  {
    Console.WriteLine("Hola");
  } 
}