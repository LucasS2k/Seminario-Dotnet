// Ejercicio 1
// 1) Ejecutar y analizar cuidadosamente el siguiente programa:
//Console.CursorVisible = false;
//ConsoleKeyInfo k = Console.ReadKey(true);
//while (k.Key != ConsoleKey.End)
//{
//Console.Clear();
//Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
// k Modifiers indica si hay modificadores como ctrl, alt o shift
// k Key muestra la tecla presionada
// k Keychar muestra el resultado

// Ejercicio 2
// 2) Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea en la consola.
using System.Dynamic;

///k = Console.ReadKey(true);
///}
int [,] matriz = new int[,] 
{ {1,2,3,4}, {5,6,7,8},{9,10,11,12}, {12,14,15,16} };
void ImprimirMatriz(int[,]matriz) {
    for (int f = 0; f < 3; f++){
        for (int c = 0; c< 4;c++){
            Console.Write(matriz[f,c]+" ");
        }
        Console.WriteLine("");
    }
}
ImprimirMatriz(matriz);
//Ejercicio 3

double [,] matrizDouble = new double[,]
{{1.111,2.222,3.333,4.4444},{5.555,6.666,7.777,8.888},{9.999,10.101,11.111,12.121}};
void ImprimirMatrizDouble(double[,]matrizDouble){
for (int f = 0; f < 3; f++){
        for (int c = 0; c< 4;c++){
            Console.Write($"{matrizDouble[f,c]:0.00}"+" ");
        }
        Console.WriteLine("");
    }
}
ImprimirMatrizDouble(matrizDouble);
// Ejercicio 4
double [] GetDiagonalPrincipal(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        
        if (filas != columnas)
            throw new ArgumentException("La matriz debe ser cuadrada");
        
        double[] diagonal = new double[filas];
        for (int i = 0; i < filas; i++)
        {
            diagonal[i] = matriz[i, i];
        }
        return diagonal;
    }
GetDiagonalPrincipal(matriz);

 double[] GetDiagonalSecundaria(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        
        if (filas != columnas)
            throw new ArgumentException("La matriz debe ser cuadrada");
        
        double[] diagonal = new double[filas];
        for (int i = 0; i < filas; i++)
        {
            diagonal[i] = matriz[i, columnas - 1 - i];
        }
        return diagonal;
    }
GetDiagonalSecundaria(matriz);
// Ejercicio 5
double[][] GetArregloDeArreglo(double [,] matrizDouble){
   int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double[][] resultado = new double[filas][];

        for (int i = 0; i < filas; i++)
        {
            resultado[i] = new double[columnas];
            for (int j = 0; j < columnas; j++)
            {
                resultado[i][j] = matriz[i, j];
            }
        }
        return resultado;
}
GetArregloDeArreglo(matrizDouble);

//Ejercicio 6


// Ejercicio 7
//int i = 10;
//var x = i * 1.0;
//var y = 1f;
//var z = i * y;
//x.GetType(); //Double
//y.GetType(); //single
//z.GetType(); //single

//Ejercicio 8
//object obj = new int[10];
//dynamic dyna = 13;
//Console.WriteLine(obj.Length); //object no tiene length
//Console.WriteLine(dyna.Length); // int no tiene length

//Ejercicio 9
//var a = 3L;
//dynamic b = 32;
//object obj = 3;
//a = a * 2.0; // no se puede convertir implicitamente un double a un char
//b = b * 2.0;
//b = "hola";
//obj = b;
//b = b + 11;
//obj = obj + 11; // nose puede sumar un int a un objeto
//var c = new { Nombre = "Juan" };
//var d = new { Nombre = "María" };
//var e = new { Nombre = "Maria", Edad = 20 };
//var f = new { Edad = 20, Nombre = "Maria" };
//f.Edad = 22; // solo se puede leer
//d = c;
//e = d; // son onjetos diferentes
//f = e; // son objetos diferentes

//Ejercicio 10
double primero = 10.20;
double segundo = 20.56;
Console.WriteLine(primero.ToString("0.0"));
Console.WriteLine(segundo.ToString("0.0"));
//Redondea

//Ejercicio 11
//List<int> a = [ 1, 2, 3, 4 ];
//a.Remove(5); // fuera de rango
//a.RemoveAt(4); // fuera de rango

//Ejercicio 12

// Ejercicio 13
static void Conversion(){
    Console.WriteLine("Ingrese un numero en base 10");
    int numero = int.Parse(Console.ReadLine());
    string resultado = Convertir(numero);
    Console.WriteLine(resultado);
}
static string Convertir(int numero)
{
    if (numero == 0) return "0";
    Stack<char> pila = new Stack<char>();
    while (numero > 0)
    {
        int resto = numero %2;
        pila.Push(resto ==0 ? '0' : '1');
        numero /=2;
    }
    return string.Join("",pila);
}

Conversion();

// Ejercicio 14


// Ejercicio 15
int x = 0;
try
{
Console.WriteLine(1.0 / x);
Console.WriteLine(1 / x);
Console.WriteLine("todo OK");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}
// Rta: attempted do divide by zero

//Ejercicio 16
 static void Dieciseis()
    {
        double suma = 0;
        string ingreso;
        
        Console.WriteLine("Ingrese numeros (deje una linea vacía para finalizar)");
        
        while (true)
        {
            ingreso = Console.ReadLine();
            
            if (ingreso == null) // Manejo de null
            break;
        
            if (ingreso == "") // Manejo de cadena vacía
            break;
            
            try
            {
                double numero = double.Parse(ingreso);
                suma += numero;
                Console.WriteLine($"Suma acumulada: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
            }
        }
        
        Console.WriteLine("Proceso finalizado. Suma total: " + suma);
    }
 Dieciseis();   
 // Ejercicio 17
 try
{
Metodo1();
}
catch
{
Console.WriteLine("Método 1 propagó una excepción no tratada");
}
try
{
Metodo2();
}
catch
{
Console.WriteLine("Método 2 propagó una excepción no tratada");
}
try
{
Metodo3();
}
catch
{
Console.WriteLine("Método 3 propagó una excepción");
}
void Metodo1()
{
object obj = "hola"
;

try
{
int

i = (int
)obj
;

}
finally
{
Console

.WriteLine

("Bloque finally en Metodo1");

}
}
void Metodo2()
{
object obj = "hola"
;

try
{
int

i = (int
)obj
;

}
catch (OverflowException
)

{
Console

.WriteLine

("Overflow");

}
}
void Metodo3()
{
object obj = "hola";
try
{
int i = (int)obj;
}
catch (InvalidCastException)
{
Console.WriteLine("Excepción InvalidCast en Metodo3");
throw;
}
}
//Bloque finally en Metodo1
//Método 1 propagó una excepción no tratada
//Método 2 propagó una excepción no tratada
//Excepción InvalidCast en Metodo3
//Método 3 propagó una excepción
