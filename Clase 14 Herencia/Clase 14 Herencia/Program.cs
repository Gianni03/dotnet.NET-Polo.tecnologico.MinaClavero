
using System.Threading.Channels;
using Clase_14_Herencia;

Alumno alumno = new Alumno();

Console.WriteLine(alumno.NombreCompleto);
Console.WriteLine(alumno.recuperarClave());

Persona.saludar(); // static, puedo utilizar sin instanciar
