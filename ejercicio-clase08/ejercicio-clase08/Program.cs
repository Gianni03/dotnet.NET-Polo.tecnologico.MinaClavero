/* ejercicio
- crear una matriz de dos dimensiones llamada numero
- determinar el tamaño de cada dimension (fila columna) mediante calores ingresados en pantalla
- declarar el vector de tipo double con elementos tipo int
- recorrer la matriz para cargar con elem tipo int
- recorrer la matriz para mostrar cada valor de la matriz
- calcular el promedio de cada columna y asignarlo a la posision correspondiente dentro del vector de promedios
- mostrar los promedios recorriendo el vector promedios
*/
Console.WriteLine("Ejercicio clase 8");
// Pedimos dimensiones de la matriz
Console.WriteLine("Ingrese la cantidad de filas de la matriz");
int filas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
int columnas = int.Parse(Console.ReadLine());

// declaramos la matriz
int[,] matriz = new int[filas, columnas];

// cargamos las matriz
for (int f = 0; f < filas; f++)
{
  Console.WriteLine();
  Console.WriteLine($"Vamos a ingresar los valores de las fila  {f + 1}");
  for (int c = 0;c < columnas; c++)
  {
    Console.WriteLine($"Ingrese el valor de la columna {c + 1}");
    matriz[f,c] = int.Parse(Console.ReadLine()); 
  }
}
Console.Clear();

//declaramos el vector promedio
var promedios = new double[columnas]; 
// calculo de promedios
double suma = 0d;
for (int c = 0; c < columnas; c++)
{
  for (int f = 0; f < filas; f++)
  {
    suma += matriz[f, c];
  }
  promedios[c] = suma / filas;
  suma = 0;
}

// mostramos la matriz
Console.WriteLine("Los valores de las matriz son:");
for (int f = 0; f < filas; f++)
{
  for (int c = 0; c < columnas; c++)
  {
    Console.Write($"{matriz[f,c]:000} ");
  }
  Console.WriteLine();
}

//mostras los promedios
Console.WriteLine();
Console.WriteLine("Los promedios son:");

for (int c = 0; c < columnas; c++)
{
  Console.Write($"{promedios[c]:00.00} ");
}




