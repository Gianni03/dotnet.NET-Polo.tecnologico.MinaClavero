namespace Clase_14_Herencia;

public class Alumno : Persona
{
  public string Curso { get; set; }
  public string Division { get; set; }

  public string recuperarClave()
  {
    return Clave();
  }
}