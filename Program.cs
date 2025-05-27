// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Ejercicio 1

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

string num = "120";
int i = 0;
bool result = int.TryParse(num, out i);
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