namespace Clase11 //namespace, forma de agrupar clases
{
  internal class Program // clase program 
  {
    static void Main(string[] args) //metodo main, void es q no devuelve nada
    {

      //instancia 1
      Perro firulais = new Perro();
      firulais.Color = "Negro";
      firulais.Edad = 4;
      firulais.Tamanio = "Grande";
      firulais.Raza = "Mastín Napolitano";

      //instancia 2
      var cartucho = new Perro();
      cartucho.Edad = 2;
      cartucho.Color = "Blanco";
      cartucho.Tamanio = "Chico";
      cartucho.Raza = "Maltés";
      
      //instancia 3
      var fatiga = new Perro();
      fatiga.Edad = 3;
      fatiga.Color = "Marrón";
      fatiga.Tamanio = "Medio";
      fatiga.Raza = "Chow Chow";

      //list
      var perritos = new List<Perro>();
      perritos.Add(firulais);
      perritos.Add(cartucho);
      perritos.Add(fatiga);

      foreach (var item in perritos)
      {
        Console.WriteLine(item.Raza);
        item.Ladrar();
      }
      Console.WriteLine(perritos.Count);
      
      //Console.WriteLine(firulais.Raza);
      //Console.WriteLine(cartucho.Raza);
      //Console.WriteLine(fatiga.Raza);



    }
  }
}

