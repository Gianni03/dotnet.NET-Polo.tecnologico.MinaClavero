namespace Clase12;

internal class Alumno
{
  public int Legajo { get; set; }
  public string Nombre { get; set; }
  public string Apellido { get; set; }
  public DateTime fechaNacimiento { get; set; }
  public string Dni { get; set; }
  public List<int> Calificaciones { get; set; }

  public void CargarNotas(int Nota, DateTime Fecha)
  {
    Calificaciones.Add(Nota);
    Console.WriteLine(Fecha.ToString("dddd dd-MM-yy") + $" se asignó la calificacion {Nota} al legajo {Legajo}");
  }
  public void CargarNotas(int Nota)
  {
    Calificaciones.Add(Nota);
    var Fecha = DateTime.Now;
    Console.WriteLine(Fecha.ToString("dddd dd-MM-yy") + $" se asignó la calificacion {Nota} al legajo {Legajo}");
    
  }
  // sobrecarga, dos funciones con el mismo nobre 


  public decimal ObtenerPromedio()
  {
    decimal acumulador = 0;
    foreach (var nota in Calificaciones)
    {
      acumulador += nota;
    }
    var promedio = acumulador / Calificaciones.Count;
    return promedio;
  }
  public void GetInfo() // función que devuelve algo
  {
    Console.WriteLine($"Legajo {Legajo} Apellido: {Apellido}");

  }
  
  
}