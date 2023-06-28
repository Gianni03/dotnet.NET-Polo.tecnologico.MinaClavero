// matrices
//almacenan múltiĺes valores en una sola variable []
//lo arrays son matrices de dimension única

string[] cars = {"Volvo", "BMW", "Audi", "Mazda"};
int[] myNum = { 10, 20, 30, 40 };
Console.WriteLine(cars[0]);
Console.WriteLine(myNum[2]);

string[] Frutas = new string[4] ;//definimos 4 posiciones
Frutas[0] = "Pera";
Frutas[1] = "Manzana";
Frutas[2] = "Uva";
Frutas[3] = "Limón";
Console.WriteLine(Frutas[2]);
Frutas[2] = "Kiwi";
Console.WriteLine(Frutas[2]);

int[] enteros = new int[5];
  Console.WriteLine($"El array tiene estas posiciones {enteros.Length}");
for (int i = 0; i < enteros.Length; i++)
{
  Console.WriteLine($"'Ingrese un número entero, número {i+1}");
  enteros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Los valores ingresados son:");
for (int i = 0; i < enteros.Length; i++)
{
Console.WriteLine(enteros[i]);
}

int suma = 0;
for (int i = 0; i < enteros.Length; i++)
{
  suma += enteros[i];
}
Console.WriteLine($"La suma de todos los númerso es: {suma}");


// vector: se una dimension int[] notas = new int[7];
//matriz: dos dimensiones
//multidimencional: n dimensiones

// VECTOR
Console.WriteLine("ingrese la cantidad de alumnos");
int cantidadAlumnos = int.Parse(Console.ReadLine());
  
Console.WriteLine("ingrese las notas de cada alumno");
int[] notas = new int[cantidadAlumnos];
for (int i = 0; i < notas.Length; i++)
{
  Console.WriteLine($"Notas del alumno N° {i+1}: ");
  notas[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("==============================");
Console.WriteLine();
for (int i = 0; i < notas.Length; i++)
{
  Console.WriteLine($"La nota del alumno N° {i+1}: {notas[i]}");
}


//matriz - int[,] notas = new int[filas,columnas]

Console.WriteLine("Notas de los exámenes: ");
Console.WriteLine("========================================== ");
Console.WriteLine("Ingrese la cantidad de alumnos: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());//columnas
Console.WriteLine("Ingrese la cantidad de notas de los alumnos: ");
int cantidadNotas = int.Parse(Console.ReadLine());//filas

int[,] notas = new int[cantidadNotas, cantidadAlumnos];

int lengthFilas = notas.GetUpperBound(0) + 1;
int lengthColumnas = notas.GetUpperBound(1) + 1;

//recorremos las columnas
for (int col = 0; col < lengthColumnas; col++)
{
  Console.WriteLine($"Notas de alumno N°{col + 1}");
  //Recorremos las filas
  for (int fil = 0; fil < lengthFilas; fil++)
  {
    Console.WriteLine($"Cargar la nota N°{fil + 1}");
    notas[fil, col] = int.Parse(Console.ReadLine());
  }
}

//mostrar las notas
for (int col = 0; col < lengthColumnas; col++)
{
  Console.WriteLine($"Notas de alumno N°{col + 1}");
  //Recorremos las filas
  for (int fil = 0; fil < lengthFilas; fil++)
  {
    Console.WriteLine($"La nota N°{fil +1 }:");
    Console.WriteLine(notas[fil,col]);
  }
}






