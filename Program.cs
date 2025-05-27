
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Ejercicio 1

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

string strnum = "120";
int i = 0;
bool result = int.TryParse(strnum, out i);
Console.Write(i);
Console.WriteLine("");
int aux = 0;
while (i > 0)
{
    aux = i % 10;
    i = i / 10;
    Console.Write(aux);
}

// Ejercicio 2

int resultado = 0;
string stringOpcion = "";
string stringRepetir = "";
int opcion = 0, repetir = 1;
float resultadoReales = 0;
do
{
    Console.WriteLine("\n1. Suma\n2. Resta \n3. Division\n4. Multiplicacion\n0. Salir");
    stringOpcion = Console.ReadLine();
    bool resultOption = int.TryParse(stringOpcion, out opcion);
    switch (opcion)
    {
        case 1:
            resultado = FuncionSuma();
            Mensaje(resultado);
            break;
        case 2:
            resultado = FuncionResta();
            Mensaje(resultado);
            break;
        case 3:
            resultadoReales = FuncionDivision();
            Mensaje2(resultadoReales);
            break;
        case 4:
            resultado = FuncionMultiplicacion();
            Mensaje(resultado);
            break;
    }
    Console.WriteLine("Desea Continuar?\n1. Si\0. No");
    stringRepetir = Console.ReadLine();
    bool resultRepetir = int.TryParse(stringRepetir, out repetir);
} while (repetir == 1);


// Funciones ejercicio 2

int FuncionSuma()
{
    string stringNum1 = "";
    string stringNum2 = "";
    int num1 = 0;
    int num2 = 0;
    Console.WriteLine("Ingrese un Numero: ");
    stringNum1 = Console.ReadLine();
    Console.WriteLine("Ingrese un 2do Numero: ");
    stringNum2 = Console.ReadLine();
    bool resultNum1 = int.TryParse(stringNum1, out num1);
    bool resultNum2 = int.TryParse(stringNum2, out num2);
    return num1 + num2;
}

int FuncionResta()
{
    string stringNum1 = "";
    string stringNum2 = "";
    int num1 = 0;
    int num2 = 0;
    Console.WriteLine("Ingrese un Numero: ");
    stringNum1 = Console.ReadLine();
    Console.WriteLine("Ingrese un 2do Numero: ");
    stringNum2 = Console.ReadLine();
    bool resultNum1 = int.TryParse(stringNum1, out num1);
    bool resultNum2 = int.TryParse(stringNum2, out num2);
    return num1 - num2;
}

float FuncionDivision()
{
    string stringNum1 = "";
    string stringNum2 = "";
    int num1 = 0;
    int num2 = 0;
    Console.WriteLine("Ingrese un Numero: ");
    stringNum1 = Console.ReadLine();
    Console.WriteLine("Ingrese un 2do Numero: ");
    stringNum2 = Console.ReadLine();
    bool resultNum1 = int.TryParse(stringNum1, out num1);
    bool resultNum2 = int.TryParse(stringNum2, out num2);
    return num1 / num2;
}

int FuncionMultiplicacion()
{
    string stringNum1 = "";
    string stringNum2 = "";
    int num1 = 0;
    int num2 = 0;
    Console.WriteLine("Ingrese un Numero: ");
    stringNum1 = Console.ReadLine();
    Console.WriteLine("Ingrese un 2do Numero: ");
    stringNum2 = Console.ReadLine();
    bool resultNum1 = int.TryParse(stringNum1, out num1);
    bool resultNum2 = int.TryParse(stringNum2, out num2);
    return num1 * num2;
}

void Mensaje(int resultado)
{
    Console.WriteLine("Su resultado es: " + resultado);
}

void Mensaje2(float resultado)
{
    Console.WriteLine("Su resultado es: " + resultado);
}

// Ejercicio 3

string stringNum = "";
float num = 0;

Console.WriteLine("Ingrese un numero: ");
stringNum = Console.ReadLine();
if (stringNum != null)
{
    bool resultNum = float.TryParse(stringNum, out num);

    ValorAbsoluto(num);
    Cuadrado(num);
    RaizCuadrada(num);
    SenoYCoseno(num);
    RedondearNumero(num);
}

string stringNumA = "";
string stringNumB = "";
int numA = 0;
int numB = 0;

Console.WriteLine("Ingrese un numero: ");
stringNumA = Console.ReadLine();
Console.WriteLine("Ingrese un 2do numero: ");
stringNumB = Console.ReadLine();

if (stringNumA != null && stringNumB != null)
{
    bool resultA = int.TryParse(stringNumA, out numA);
    bool resultB = int.TryParse(stringNumB, out numB);
    CompararNumeros(numA, numB);
}


// Funciones Ejercicio 3

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

void CompararNumeros(int numA, int numB)
{
    int max = Math.Max(numA, numB);
    int min = Math.Min(numA, numB);
    Console.WriteLine("\nNumero Maximo es: " + max);
    Console.WriteLine("\nNumero Minimo es: " + min);
}



