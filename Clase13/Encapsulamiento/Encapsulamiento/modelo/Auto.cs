namespace Encapsulamiento.modelo;

internal class Auto
{
  //Campos, variables para la clase privados
  private string _tipoMotor
  {
    get { return TipoMotor; }
    set
    {
      if (value == null || value == "")
      {
        _tipoMotor = "Nafta";
      }
      else
      {
        _tipoMotor = value;
      }
    }
  }
  private string _anioConstruccion;
  
  
  public string TipoMotor { get; set; }
  public bool EstaEncendido { get; set; }
  public int AnioConstruccion { get; set; }
  public string Marca { get; set; }
  
}