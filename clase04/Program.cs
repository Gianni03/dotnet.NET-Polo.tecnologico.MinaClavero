// Sentencias condicionales
Console.WriteLine("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su equipo: ");
string equipo = Console.ReadLine();
Console.WriteLine("La edad ingresada es " + edad);
Console.WriteLine("Su equipo es " + equipo);

if (edad < 18)
{
    Console.WriteLine("Eres menor de edad");
} 
else
{
  Console.WriteLine("eres mayor de edad");  
}

if (edad >= 18 && equipo == "NOB")
{
    Console.WriteLine("Eres mayor y juega tu equipo");
}
else
{
    Console.WriteLine("eres menor de edad, o no juega tu equipo");
}

/*
 * AND &&
 * OR !!
 * DISTINTO !=
 */

// elseif
if (edad < 18)
{
    Console.WriteLine("Eres menor de edad");
}
else if (edad >= 18 && edad <= 65)
{
    Console.WriteLine("Eres Mayor de edad");
}
else
{
    Console.WriteLine("Eres Mayor de edad, jubilado");
}

//switch
Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicación");
Console.WriteLine("4 - División");

Console.WriteLine("Elija la operación a realizar");
string operacion = Console.ReadLine();
Console.WriteLine("ingrese dos numeros: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());


switch (operacion)
{
    case "1":
        Console.WriteLine("Sumando...");
        Console.WriteLine(num1 + num2);
        break;
    case "2":
        Console.WriteLine("Restando...");
        Console.WriteLine(num1 - num2);
        break;
    case "3":
        Console.WriteLine("Multiplicando...");
        Console.WriteLine(num1 * num2);
        break;
    case "4" when num2 != 0:
        Console.WriteLine("Dividiendo...");
        Console.WriteLine(num1 / num2);
        break;
    default:
        Console.WriteLine("ERROR");
        break;
}

