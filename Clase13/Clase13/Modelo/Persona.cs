namespace Clase13.Modelo;

internal class Persona
{
  //propiedades
  public string NombreCompleto { get; set; }
  public string NumeroDocumento { get; set; }
  public int Edad { get; set; }
  public bool EstaCasado { get; set; }
  
  //constructor de la clase
  public Persona()
  {
    Console.WriteLine("Se instancio una nueva persona");
    
  }public Persona(string nombreCompleto, string numeroDocumento, int edad, bool estaCasado)
  {
    NombreCompleto = nombreCompleto;
    NumeroDocumento = numeroDocumento;
    Edad = edad;
    EstaCasado = estaCasado;
  }

  //metodos
  public string ObtenerSaludo()
  {
    return $"Hola soy {NombreCompleto}";
  }

  public string ObtenerSaludo(string nombrePersonaAQuienSaludar)
  {
    return $"Hola {nombrePersonaAQuienSaludar}, soy {NombreCompleto}";
  }
  
}