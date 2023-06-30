//acer un array de 100 elementos que muestre lo números primos
Console.Write("Cuantos numeros primos quieres: ");
var n = int.Parse(Console.ReadLine());

int[] primos = new int[n];
int posicion = 0;
int aux = 0;
int numero = 1;
while (posicion < n)
{
  aux = 0;
  for (int i = 1; i <= numero; i++)
  {
    if (numero % i == 0 )
    {
      aux++;
    }
  }
  if (aux == 2)
  {
    primos[posicion] = numero;
    posicion++;
  }
  numero++;
}

foreach (var i in primos)
{
  Console.WriteLine(i);
}
