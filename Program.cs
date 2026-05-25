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
    Console.WriteLine("1 : Valor Absoluto");
    Console.WriteLine("2 : Cuadrado");
    Console.WriteLine("3 : Raiz cuadrada");
    Console.WriteLine("4 : Seno");
    Console.WriteLine("5 : Coseno");
    Console.WriteLine("6 : Parte entera");

    Console.WriteLine("Opcion elegida:");
    while (!int.TryParse(Console.ReadLine(), out sele)) // 
        Console.WriteLine("Opcion invalida, ingrese un numero:");

    if (sele >= 1 && sele <= 5) // casos que usan numero entero
    {
        Console.WriteLine("Valor:");
        while (!int.TryParse(Console.ReadLine(), out numero1)) // 
            Console.WriteLine("Valor invalido, ingrese un numero entero:");
    }

    switch (sele)
    {
        case 1:
            if (numero1 < 0) numero1 = numero1 * (-1);
            resultado = numero1;
            break;
        case 2:
            resultado = numero1 * numero1;
            break;
        case 3:
            resultado = Math.Sqrt(numero1);
            break;
        case 4:
            resultado = Math.Sin(numero1 * Math.PI / 180);
            break;
        case 5:
            resultado = Math.Cos(numero1 * Math.PI / 180);
            break;
        case 6:
            Console.WriteLine("Valor decimal:");
            while (!double.TryParse(Console.ReadLine(), out numeroD)) // 
                Console.WriteLine("Valor invalido, ingrese un numero decimal:");
            resultado = Math.Floor(numeroD);
            break;
        default:
            Console.WriteLine("Opcion invalida, elija entre 1 y 6");
            break;
    }

    Console.WriteLine("Resultado: " + resultado);

    Console.WriteLine("\n1 : Continuar  |  0 : Terminar");
    while (!int.TryParse(Console.ReadLine(), out seguir)) // 
        Console.WriteLine("Valor invalido, ingrese 1 o 0:");

} while (seguir == 1);

// --- MAYOR Y MENOR ---
float valores1 = 0, valores2 = 0, mayor = 0, menor = 0;

Console.WriteLine("Coloque valor 1:");
while (!float.TryParse(Console.ReadLine(), out valores1)) // 
    Console.WriteLine("Valor invalido, ingrese un numero:");

Console.WriteLine("Coloque valor 2:");
while (!float.TryParse(Console.ReadLine(), out valores2)) // 
    Console.WriteLine("Valor invalido, ingrese un numero:");

if (valores1 > valores2) { mayor = valores1; menor = valores2; }
else                     { mayor = valores2; menor = valores1; }

Console.WriteLine("El valor mayor es: " + mayor);
Console.WriteLine("El valor menor es: " + menor);