using Clase13.Modelo;

var persona1 = new Persona
{
  EstaCasado = true,
  Edad = 42,
  NombreCompleto = "Gianni Pasquinelli",
  NumeroDocumento = "27879997"
};

Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Belén"));


var persona2 = new Persona("Belen Cortese", "27318645", 43, true);
Console.WriteLine(persona2.ObtenerSaludo());

var miOcupacion = new Ocupacion();





