//borramos la consola
Console.Clear();
//pedimos al usuario que ingrese un dato
Console.WriteLine("Hola, ingrese su nombre: ");
string nombre;
nombre = Console.ReadLine();
Console.WriteLine("Hola, " + nombre);
Console.WriteLine("ingrese su Apellido: ");
string apellido = Console.ReadLine();

Console.Clear();
Console.WriteLine("Este programa calcula la superficie de un recatangulo");
Console.WriteLine("Base del rectangulo:");
double baseRectangulo = double.Parse(Console.ReadLine());
Console.WriteLine("Altura del rectangulo:");
double altoRectangulo = double.Parse(Console.ReadLine());

double superficie = baseRectangulo * altoRectangulo;
Console.WriteLine("La superfce del rectangulo es: " + superficie);

bool esMayorADiez = superficie > 10;
if (esMayorADiez)
{
    Console.WriteLine("La superficie es mayor a diez");
}


