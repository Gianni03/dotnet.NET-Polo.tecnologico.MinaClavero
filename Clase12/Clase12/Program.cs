using Clase12;

var alumno1 = new Alumno();
alumno1.Apellido = "Pasquinelli";
alumno1.Nombre = "Gianni";
alumno1.Legajo = 1234;
alumno1.Dni = "27.879.997";
alumno1.fechaNacimiento = new DateTime(1980,11,03);
alumno1.Calificaciones = new List<int>();

var alumno2 = new Alumno()
{
  Apellido = "Cortese",
  Nombre = "Belén",
  Legajo = 2431,
  Dni = "27.318.645",
  fechaNacimiento = new DateTime(1979, 07, 16)
};

alumno1.GetInfo();
alumno2.GetInfo();

alumno1.CargarNotas(3, new DateTime(2022,6,1));
alumno1.CargarNotas(8);
alumno1.CargarNotas(8, DateTime.Now);
alumno1.CargarNotas();

Console.WriteLine(alumno1.ObtenerPromedio());