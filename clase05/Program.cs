
Console.WriteLine("Continuar (S/N)");
var texto = Console.ReadLine();

if (texto.ToUpper() == "S")
{
    Console.WriteLine("Si, Continuar...");
}else if (texto.ToUpper() == "N")
{
    Console.WriteLine("No, Saliendo...");
}
else
{
    Console.WriteLine("Error, así no..");
}

// ciclo while y for
Console.WriteLine("Cuantas vueltas queres dar?");
var totalDeVueltas = int.Parse(Console.ReadLine());
var contador = 0;

while (contador < totalDeVueltas)
{
    contador++;
    Console.WriteLine("Dando ueltas, vuelta " + contador);
}

var respuesta = "S";
var count = 0;
while (respuesta.ToUpper() != "N")
{
    count++;
    Console.WriteLine("Dando ueltas, vuelta " + count);
    
    Console.WriteLine("Seguimos? (S/N)");
    respuesta = Console.ReadLine();
}


for (int i = 0; i < 8; i++)
{ 
    Console.WriteLine("Compre " + i + " Caramelos"); 
}
