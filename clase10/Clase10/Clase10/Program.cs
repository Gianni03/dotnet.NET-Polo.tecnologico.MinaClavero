/* Listas:
 1- arrays
 2- listas
 3- colas
 4- pilas
 5- diccionarios
 */
//inicializacion de un array

using Microsoft.VisualBasic;

var miArray = new int[10];
 //recorrer el array, conociendo la cantidad de iteraciones
 for (int i = 0; i < miArray.Length; i++)
 {
  Console.Write(miArray[i] + " ");
 }
 
 //si saber cuatas vueltas va a dar
 foreach (var item in miArray)
 {
  Console.WriteLine(item);
 }
 
 var personas = new List<string>();
 personas.Add("Gianni");
personas.Add("Astor");
personas.Add("Milan");
 foreach (var persona in personas)
 {
  Console.WriteLine(persona);
 }

var listaNombres = new List<string>();
string entradaUsuario;
do
{

 Console.WriteLine("Lista de nombres ");
 Console.WriteLine("elija una opcion ");
 Console.WriteLine("1 agregar elemnto ");
 Console.WriteLine("2 quitar elemnto ");
 Console.WriteLine("3 ubicar elemnto ");
 Console.WriteLine("4 invertir lista ");
 Console.WriteLine("5 contenido lista ");
 Console.WriteLine("6 Salir ");
 entradaUsuario = Console.ReadLine();
 switch (entradaUsuario)
 {
  case "1":
   Console.WriteLine("Ingrese un nombre");
   var nuevoNombre = Console.ReadLine();
   Console.WriteLine("Donde se agrega el elemento");
   Console.WriteLine("1. al final");
   Console.WriteLine("2. en pos determinada");
   var opcionUbicacion = Console.ReadLine();
   switch (opcionUbicacion)
   {
    case "1":
     listaNombres.Add(nuevoNombre);
     break;
    case "2":
     Console.WriteLine("Ingrese la pos");
     var posicion = int.Parse(Console.ReadLine());
     listaNombres.Insert(posicion, nuevoNombre);
     break;
   }

   break;
  case "2":
   Console.WriteLine("Ingrese un nombre a borrar");
   var borrar = Console.ReadLine();
   listaNombres.Remove(borrar);
   break;
  case "3":
   Console.WriteLine("encontrar un nombre");
   var encuentra = Console.ReadLine();
   var ubicacion = listaNombres.IndexOf(encuentra);
   if (ubicacion > -1)
   {
    Console.WriteLine("El nombre esta en la posicion " + ubicacion);
   }
   else
   {
    Console.WriteLine("El elemento no existe");
   }

   break;
  case "4":
   Console.WriteLine("invertir lista");
   listaNombres.Reverse();
   foreach (var nombre in listaNombres)
   {
    Console.WriteLine(nombre);
   }
   break;
  case "5":
   Console.WriteLine("Mostrar lista");
   foreach (var nombre in listaNombres)
   {
    Console.WriteLine(nombre);
   }

   break;
 }
} while (entradaUsuario != "6");

//pila
var miPila = new Stack<int>();
miPila.Push(1);
miPila.Push(2);
miPila.Push(3);
miPila.Push(4);
Console.WriteLine(miPila.Pop());

//colas
var miCola = new Queue<int>();
miCola.Enqueue(1);
miCola.Enqueue(2);
miCola.Enqueue(3);
miCola.Enqueue(4);
Console.WriteLine(miCola.Dequeue());
Console.WriteLine(miCola.Dequeue());


 
 