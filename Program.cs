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

int num1 = 0;
int num2 = 0;
int resultado = 0;
int opcion = 0, repetir = 1;
float resultadoReales = 0;
do
{
    Console.WriteLine("\n1. Suma\n2. Resta \n3.Division\n4. Multiplicacion\n0. Salir");
    opcion = Console.Read();
    switch (opcion)
    {
        case 1:
            resultado = FuncionSuma(num1, num2);
            Mensaje(resultado);
            break;
        case 2:
            resultado = FuncionResta(num1, num2);
            Mensaje(resultado);
            break;
        case 3:
            resultadoReales = FuncionDivision(num1, num2);
            Mensaje2(resultadoReales);
            break;
        case 4:
            resultado = FuncionMultiplicacion(num1, num2);
            Mensaje(resultado);
            break;
    }
    Console.WriteLine("Desea Continuar?\n1. Si\0. No");
    repetir = Console.Read();
} while (repetir == 1);

int FuncionSuma(int num1, int num2)
{
    Console.WriteLine("Ingrese un Numero: ");
    num1 = Console.Read();
    Console.WriteLine("Ingrese un 2do Numero: ");
    num2 = Console.Read();
    return num1 + num2;
}

int FuncionResta(int num1, int num2)
{
    Console.WriteLine("Ingrese un Numero: ");
    num1 = Console.Read();
    Console.WriteLine("Ingrese un 2do Numero: ");
    num2 = Console.Read();
    return num1 - num2;
}

float FuncionDivision(int num1, int num2)
{
    Console.WriteLine("Ingrese un Numero: ");
    num1 = Console.Read();
    Console.WriteLine("Ingrese un 2do Numero: ");
    num2 = Console.Read();
    return num1 / num2;
}

int FuncionMultiplicacion(int num1, int num2)
{
    Console.WriteLine("Ingrese un Numero: ");
    num1 = Console.Read();
    Console.WriteLine("Ingrese un 2do Numero: ");
    num2 = Console.Read();
    return num1 * num2;
}

void Mensaje(int resultado) {
    Console.WriteLine("Su resultado es: " + resultado);
}

void Mensaje2(float resultado) {
    Console.WriteLine("Su resultado es: " + resultado);
}