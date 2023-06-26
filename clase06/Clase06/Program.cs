var num1 = 1;
// con var debo declarrar e inicializar  de a una variable
int num2 = 4;
int a, b, c;// con int puedo declarar varias variables e incializarlas luego
a = 3;
b = 15;
c = a + b;
Console.WriteLine($"var var{num1}, y var int{num2}");

/* Ejercicio
 * Escribir un programa ue haga:
 * 1- borrar la pantalla
 * 2- pedir nombre (ingreso de datos)
 * 3- saludarlo con un texto que diga ¡Hola [nombre]! (imprimir en pantalla)
 * 4- preguntar si quiere continuar (condicional)
 * 5- si continuarepetir desde el puento 1 (bucle)
 * 6- si no continua, finalizar el programa con un mensaje Programa terminado (imprimir en pantalla)
 * 7- si la respuesta no ni si ni no finalice el programa con mensaje de error Opcion no valida (imprimir en pantalla)
 */

var opcion = "S";
while (opcion.ToUpper() == "S")
{
Console.Clear();//borrar pantalla
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"¡Hola {nombre}!");
Console.Write("¿Desea continuar? (S/N) ");
opcion = Console.ReadLine();
}
if (opcion.ToUpper() == "N")
{
 Console.WriteLine("Programa terminado correctamente");
}
else
{
 Console.WriteLine("Programa terminado, Opción no válida");
}


//alternativa con do while
do
{
 Console.Clear(); //borrar pantalla
 Console.Write("alternativa con Do While");
 Console.Write("Ingrese su nombre: ");
 string nombre = Console.ReadLine();
 Console.WriteLine($"¡Hola {nombre}!");
 Console.Write("¿Desea continuar? (S/N) ");
 opcion = Console.ReadLine();
} while (opcion.ToUpper() == "S");

if (opcion.ToUpper() == "N")
{
 Console.WriteLine("Programa terminado correctamente");
}
else
{
 Console.WriteLine("Programa terminado, Opción no válida");
}