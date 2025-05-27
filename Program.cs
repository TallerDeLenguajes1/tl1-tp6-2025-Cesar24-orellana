
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

// Ejercicio 3

string stringNum = "";
float num = 0;

Console.WriteLine("Ingrese un numero: ");
stringNum = Console.ReadLine();
bool result = float.TryParse(stringNum, out num);

ValorAbsoluto(num);
Cuadrado(num);
RaizCuadrada(num);
SenoYCoseno(num);
RedondearNumero(num);

string stringNumA = "";
string stringNumB = "";
int numA = 0;
int numB = 0;

Console.WriteLine("Ingrese un numero: ");
stringNumA = Console.ReadLine();
Console.WriteLine("Ingrese un 2do numero: ");
stringNumB = Console.ReadLine();

bool resultA = int.TryParse(stringNumA, out numA);
bool resultB = int.TryParse(stringNumB, out numB);

CompararNumeros(numA, numB);

// Funciones

void ValorAbsoluto(float num)
{
    double resultado;
    resultado = Math.Abs(num);
    Console.WriteLine("\nEl Valor Absoluto de su numero es: " + resultado);
}

void Cuadrado(float num)
{
    double resultado;
    resultado = Math.Pow(num, 2);
    Console.WriteLine("\nEl Cuadrado de su numero es: " + resultado);
}

void RaizCuadrada(float num)
{
    double resultado = Math.Sqrt(num);
    Console.WriteLine("\nLa raiz de su numero es: " + resultado);
}

void SenoYCoseno(float num)
{
    double resultado1 = Math.Sin(num);
    double resultado2 = Math.Cos(num);
    Console.WriteLine("\nEl Seno de su numero es: " + resultado1);
    Console.WriteLine("\nEl Coseno de su numero es: " + resultado2);
}

void RedondearNumero(float num)
{
    double resultado = Math.Round(num);
}

void CompararNumeros(int numA,int numB)
{
    int max = Math.Max(numA, numB);
    int min = Math.Min(numA, numB);
    Console.WriteLine("\nNumero Maximo es: " + max);
    Console.WriteLine("\nNumero Minimo es: " + min);
}