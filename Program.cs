﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Calentamiento en C#

int a;
int b;
a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

// Ejercicio 1

string num = "120";
int i = 0;
bool result = int.TryParse(num, out i);  // Convierte un numero string en numero int/float/double/etc
Console.Write(i);
Console.WriteLine("");
int aux = 0;
while (i > 0)   // Invierte el numero
{
    aux = i % 10;
    i = i / 10;
    Console.Write(aux);
}

