

// tipos por valor y por referencia
/*int primerNumero = 1986; // tipo valor
int segundoNumero = primerNumero; // le asigna el valor al momento

Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);

primerNumero = 1978;
Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);*/

// using Clase15.Modelos;

// ******* Segunda parte *******

/*
var miPrimerClase = new MiClase //var de tipo referencia (las clases)
{
  Id = 1,
  Nombre = "Astor Pasquinelli"
};

Console.WriteLine(miPrimerClase.Nombre);

var miSegundaClase = miPrimerClase;
Console.WriteLine(miSegundaClase.Nombre);

miPrimerClase.Nombre = "Milan Pasquinelli";
Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);
*/
// ****** tercera parte ********

/*var primeraClase = new MiClase
{
Id = 1,
Nombre = "Juan"
};
var segundaClase = new MiClase
{
Id = 2,
Nombre = "Luna"
};

var miLista = new List<MiClase>();
miLista.Add(primeraClase);
miLista.Add(segundaClase);
Console.WriteLine(primeraClase.Nombre);
Console.WriteLine(segundaClase.Nombre);

foreach(var item in miLista)
{
  Console.WriteLine(item.Nombre);
  if (item.Id == 1)
    item.Nombre = "Juana";
}
Console.WriteLine(primeraClase.Nombre);
Console.WriteLine(segundaClase.Nombre);*/

// *********** Cuarta Parte **************

using Clase15.Modelos;

var primerPersona = new Persona()
{
  Apellido = "Pasquinelli",
  Nombre = "Milan"
};

var primerDocente = new Docente()
{
  Salario = 70000,
  Nombre = "Gianni",
  Apellido = "Pasquinelli"
};

var primerAlumno = new Alumno()
{
Legajo = 10042,
Nombre = "Astor",
Apellido = "Pasquinelli"
};

var personas = new List<Persona>();
personas.Add(primerPersona);
personas.Add(primerDocente);
personas.Add(primerAlumno);

foreach (var persona in personas)
{
  Console.WriteLine(persona.Nombre);
  if (persona.GetType() == typeof(Docente))
  {
    var p = (Docente)persona;
    Console.WriteLine(p.Salario);
  }
}
