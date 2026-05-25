using System.ComponentModel;

Console.WriteLine("Hello, World!");
int a ; 
int b ;

a = 10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);

int numero = 10;
if (numero>0)
{
    numero = numero *(-1);
};
Console.WriteLine("Valor de numero:"+numero);

int sele=0,result=0;
int numero1=0,numero2 = 0,seguir = 0;
 double resultado=0,numeroD=0; 
do
{
    Console.WriteLine("Seleccione el tipo de operacion:");
    Console.WriteLine("1 : Suma");
    Console.WriteLine("2 : Resta");
    Console.WriteLine("3 : Multiplicacion");
    Console.WriteLine("4 : Division");

    Console.WriteLine("Opcion elegida:");
    while (!int.TryParse(Console.ReadLine(), out sele)) // 
        Console.WriteLine("Opcion invalida, ingrese un numero:");

    Console.WriteLine("Valor 1:");
    while (!int.TryParse(Console.ReadLine(), out numero1)) // 
        Console.WriteLine("Valor invalido, ingrese un numero entero:");

    Console.WriteLine("Valor 2:");
    while (!int.TryParse(Console.ReadLine(), out numero2)) // 
        Console.WriteLine("Valor invalido, ingrese un numero entero:");

    switch (sele)
    {
        case 1: result = numero1 + numero2; break;
        case 2: result = numero1 - numero2; break;
        case 3: result = numero1 * numero2; break;
        case 4:
            if (numero2 != 0) //  evitar division por cero
                result = numero1 / numero2;
            else
                Console.WriteLine("Error: no se puede dividir por cero");
            break;
        default:
            Console.WriteLine("Opcion invalida, elija entre 1 y 4");
            break;
    }

    Console.WriteLine("Resultado: " + result);

    Console.WriteLine("\n1 : Continuar  |  0 : Terminar");
    while (!int.TryParse(Console.ReadLine(), out seguir)) // 
        Console.WriteLine("Valor invalido, ingrese 1 o 0:");

} while (seguir == 1);