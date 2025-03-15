using System;
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
