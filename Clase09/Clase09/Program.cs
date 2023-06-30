
Console.Write("Tamaño del listado: ");
int n = int.Parse(Console.ReadLine());
int[] vector = new int[n];
Random aleatorio = new Random();//variable de tipo random
for (int i = 0; i < vector.Length; i++)
{//llenamos la matriz con valores random hasta el num 100
  vector[i] = aleatorio.Next(100);
}

var contador = 0;
foreach (int i in vector)
{//mostramos los valores
  contador++;
  Console.Write(contador + ": " + i + " ");
}
Console.WriteLine();
Console.Write("Posicion a modificar: ");
var k = int.Parse(Console.ReadLine());
if (k > vector.Length || k < 0)
{
  Console.WriteLine("Indice incorrecto");
}
else
{
  Console.Write("Ingrese un nuevo valor: ");
  while (true)
  {
    var nuevoValor = int.Parse(Console.ReadLine());
    if (nuevoValor > 0 && nuevoValor < 100)
    {
      vector[k - 1] = nuevoValor;
      break;//para salir del bucle infinito
    }
    else
    {
      Console.WriteLine("El valor debe ser positivo y menor de 100");
    }
  }
  
}
contador = 0;
foreach (int i in vector)
{//mostramos los valores
  contador++;
  Console.Write(contador + ": " + i + " ");
}


