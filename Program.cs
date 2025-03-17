using System;
using System.ComponentModel;
using System.Runtime.Serialization;
Console.WriteLine("Hello, World!");
// Ejercicio 1 //
Console.WriteLine("ingrese su numero");
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i=1; i < n; i++)
{
    suma+=i;
}
Console.WriteLine(suma);
// Ejercicio 2 //
string texto = "\t ejemplo \n de \\ prueba";
Console.Write(texto);
// Ejercicio 3 //
string st = @"c:\windows\system";
Console.WriteLine(st);
//Ejercicio 4 //
Console.WriteLine("ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("hola", nombre);
//Ejercicio 5 //
Console.WriteLine("ingrese otro nombre");
string otroNombre = Console.ReadLine();
if (otroNombre == "juan") {
    Console.WriteLine("Hola amigo!");
} else if (otroNombre == "maria") {
    Console.WriteLine("Buen dia señora");
} else if (otroNombre == "alberto"){
    Console.WriteLine("Hola Alberto");
} else if (otroNombre == ""){
    Console.WriteLine("Buen dia mundo");
} else {
    Console.WriteLine("Buen dia," + otroNombre);
}
// Ejercicio 6 //
Console.WriteLine("Ingrese una secuencia de caracteres");
string secuencia = Console.ReadLine();
while (secuencia.Length != 0 ) {
    Console.WriteLine(secuencia.Length);
    Console.WriteLine("Ingrese otra secuencia de caracteres");
    secuencia = Console.ReadLine();
}
// Ejercicio 7 //
Console.WriteLine("100".Length);
// Imprime 3, el largo de la cadena//

// Ejericio 8 //
Console.WriteLine(st=Console.ReadLine());
// Es valido, lee e imprime en consola la variable //

// Ejercicio 9 //

// Ejercicio 10 //
bool puedo = true;
bool puedo2 = true;
int multi = 1;
while (puedo | puedo2)
{
    if (multi * 17 < 1000) {
        Console.WriteLine(multi + " por 17 es "+ multi*17);
        
    } else {
        puedo=false;
    }
    if (multi * 29 < 1000){
        Console.WriteLine(multi + " por 29 es " + multi*29);
    } else {
        puedo2 = false;
    } multi++;
}
// Ejercicio 11//
///Console.WriteLine("10/3 = " + 10 / 3);
//Console.WriteLine("10.0/3 = " + 10.0 / 3);
//Console.WriteLine("10/3.0 = " + 10 / 3.0);
//int a = 10, b = 3;
//Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
//Console.WriteLine("entonces a/b = " + a / b);
//double c = 3;
///Console.WriteLine("Si c es una variable double, c=3");
//Console.WriteLine("entonces a/c = " + a / c);//
// Ejercicio 12 //
Console.WriteLine("Ingrese un entero positivo:");
string numero = Console.ReadLine();
int num = int.Parse(numero);

Console.WriteLine($"Divisores de {num}:");
for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine(i);
    }
}
// Ejercicio 13 //
int a = 10;
int b = 1;
if ((b != 0) && (a/b > 5)) Console.WriteLine(a/b);
// Se cambia el & por  &&, que evalua la segunda condicion solo si la primera es verdera //

// Ejercicio 14 //
Console.WriteLine("ejercicio 14");
int var1 = 10;
int var2 = 1;
int mayor = (var1 < var2) ? var2 : var1;
Console.WriteLine(mayor);
// Ejercicio 15 //
Console.WriteLine("ejercicio 15");
// int i = 0; el problema era esta linea //
for (int i = 1; i <= 10;)
{
Console.WriteLine(i++);
}
// Ejercicio 16 //
int x = 1;
if (--x == 0)
{
Console.WriteLine("cero");
}
if (x++ == 0)
{
Console.WriteLine("cero");
}
Console.WriteLine(x);
// Imprime  "cero", "cero" y 1//