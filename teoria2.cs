using System;
using System.Text;
using System.Diagnostics;

namespace EjerciciosCSharp
{
    enum Meses
    {
        Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
    }

    class Program
    {
        static void Main()
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio10();
            Ejercicio11();
            Ejercicio12();
            Ejercicio20();
        }
    // Método que devuelve true si el número n es primo, false en caso contrario
    static bool EsPrimo(int n)
    {
        // Los números menores o iguales a 1 no son primos
        if (n <= 1)
            return false;

        // Comprobamos divisibilidad solo hasta la raíz cuadrada de n
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) // Si n es divisible por i, no es primo
                return false;
        }
        return true; // Si no es divisible por ningún número entre 2 y la raíz cuadrada de n, es primo
    }
     // Método Swap que intercambia los valores de dos enteros
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

        static void Ejercicio1()
        //El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas variables están
//apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la consola no sea “Z Z”?
// Rta: o1 apunta a "A", o2 apunta al mismo object de o1 (tambien es "A"), al asignarle Z a o2 se crea un nuevo object en memoria entonces o2 apunta a Z y o1 sigue apuntando a A
        {
            Console.WriteLine("\n--- Ejercicio 1 ---");
            object o1 = "A";
            object o2 = o1;
            o2 = "Z";
            Console.WriteLine(o1 + " " + o2);
        }

        static void Ejercicio2()
        {
            Console.WriteLine("\n--- Ejercicio 2 ---");
            char c1 = 'A';
            string st1 = "A";
            object o1 = c1; // Boxing
            object o2 = st1; // Conversión de referencia
            char c2 = (char)o1; // Unboxing
            string st2 = (string)o2; // Casting de object a string
        }

        static void Ejercicio3()
        {
            Console.WriteLine("\n--- Ejercicio 3 ---");
            //3) ¿Qué diferencias existen entre las conversiones de tipo implícitas y explícitas?
            // La conversion implicita se realiza cuando la operacion es segura y es automatica, en cambio la explicita requiere que el programador deje en claro que desea realizarla
        }

        static void Ejercicio4()
        // 4) Resolver los errores de compilación en el siguiente fragmento de código. Utilizar el operador as cuando sea posible.
    // object o = "Hola Mundo!";
    //string st = o;
    //int i = 12;
    //byte b = i;
    //double d = i;
    //float f = d;
    //o = i;
    //i = o + 1;

    // _________________________________ //
    //object o = "Hola Mundo!";
    //string st = (string)o;
    //int i = 12;
    //byte b = (byte)i;
    //double d = i;
    //float f = (float)d;
    //o = i;
    //i = (int)o + 1;
    // __________________________________//

    // IMPORTANTE "as" se utiliza para convertirr un tipo referencia a string
        {
            Console.WriteLine("\n--- Ejercicio 4 ---");
            object o = "Hola Mundo!";
            string st = o as string;
            int i = 12;
            byte b = (byte)i;
            double d = i;
            float f = (float)d;
            o = i;
            i = (int)o + 1;
        }

        static void Ejercicio6()
        //6) Supongamos que Program.cs sólo tiene las siguientes dos líneas:
        //int i;
        //Console.WriteLine(i);
        // ¿Por qué no compila?
        {
            Console.WriteLine("\n--- Ejercicio 6 ---");
            Console.WriteLine("El código no compila porque la variable 'i' no ha sido inicializada antes de ser utilizada.");
        }

        static void Ejercicio7()
        // 7) ¿Cuál es la salida por consola del siguiente fragmento de código? ¿Por qué la tercera y sexta línea producen resultados diferentes?
        // Rta: Se esta comparando los punteros que referencian a esas variables y no a su contenido primitivo que es "A", como en la primer comparacion
        {
            Console.WriteLine("\n--- Ejercicio 7 ---");
            char c1 = 'A';
            char c2 = 'A';
            Console.WriteLine(c1 == c2); // True, compara valores
            object o1 = c1;
            object o2 = c2;
            Console.WriteLine(o1 == o2); // False, compara referencias en memoria
        }

        static void Ejercicio8()
        //8) Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
//circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar un
//caso de ejemplo en el que el rendimiento sea claramente superior utilizando StringBuilder en lugar
//de string y otro en el que no.

// Rta: Es preferible usar StringBuilder con grandes volumenes de texto o cuando se realizan multiples concatenaciones dentro de un bucle
        {
            Console.WriteLine("\n--- Ejercicio 8 ---");
            int iteraciones = 100000;

            Stopwatch sw = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iteraciones; i++)
            {
                sb.Append("Texto ");
            }
            sw.Stop();
            Console.WriteLine($"Tiempo con StringBuilder: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            string texto = "Hola";
            texto += " mundo";  // Solo una concatenación
            sw.Stop();
            Console.WriteLine($"Tiempo con string: {sw.ElapsedMilliseconds} ms");
        }

        static void Ejercicio10()
        {
            Console.WriteLine("\n--- Ejercicio 10 ---");
            object[] v = new object[10];
            v[0] = new StringBuilder("Net");
            for (int i = 1; i < 10; i++)
            {
                v[i] = v[i - 1];
            }
            (v[5] as StringBuilder).Insert(0, "Framework .");
            foreach (StringBuilder s in v)
                Console.WriteLine(s);

            v[5] = new StringBuilder("CSharp");
            foreach (StringBuilder s in v)
                Console.WriteLine(s);
        }

        static void Ejercicio11()
        //11) ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas las
//palabras (una por línea) de una frase ingresada por consola por el usuario.

//Rta: se usa para dividir una cadena delimitada en subcadenas (si no se especifica ningun caracter, la cadena se divide por los espacios es blanco)
        {
            Console.WriteLine("\n--- Ejercicio 11 ---");
            Console.WriteLine("Ingrese varias palabras separadas:");
            string cadena1 = Console.ReadLine();
            string[] palabras = cadena1.Split(' ');

            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }
        }

        static void Ejercicio12()
        {
            Console.WriteLine("\n--- Ejercicio 12 ---");
            Console.WriteLine("Meses en orden inverso:");
            for (Meses mes = Meses.Diciembre; mes >= Meses.Enero; mes--)
            {
                Console.WriteLine(mes);
            }

            Console.Write("\nIngrese un mes: ");
            string entrada = Console.ReadLine();
            bool esMesValido = Enum.TryParse(entrada, true, out Meses mesIngresado);

            if (esMesValido)
            {
                Console.WriteLine($"'{entrada}' es un mes válido.");
            }
            else
            {
                Console.WriteLine($"'{entrada}' no es un mes válido.");
            }
        }
        // Ejercicio 13
        //13) ¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?
        //Console.WriteLine(args == null);
        //Console.WriteLine(args.Length);

        // Ejercicio 14
        //14) ¿Qué hace la instrucción? ¿Asigna a la variable vector el valor null?
        //int[]? vector = new int[0];
        // Rta: crea un array vacio, no null

        //Ejercicio 15
        //15) Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros cuando se invoca desde la línea de comandos.
        //Console.WriteLine("¡Hola {0}!", args[0]);
        //Rta: sin parametros tira error porque el indice 0 no esta definido

        // Ejercicio 16
       //16) Escribir un programa que reciba una lista de nombres como parámetro por la línea de comandos e imprima por consola un saludo personalizado para cada uno de ellos. a) Utilizando la sentencia for b) Utilizando la sentencia foreach
        static void Ejercicio16(string[] args)
    {
        // Verificar que se han recibido argumentos en la línea de comandos
        if (args.Length == 0)
        {
            Console.WriteLine("No se han proporcionado nombres.");
            return;
        }

        // Usando la sentencia for para recorrer los argumentos
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Hola, {args[i]}!");
        }
    }

    static void Ejercicio16b(string[] args)
    {
        // Verificar que se han recibido argumentos en la línea de comandos
        if (args.Length == 0)
        {
            Console.WriteLine("No se han proporcionado nombres.");
            return;
        }

        // Usando la sentencia foreach para recorrer los argumentos
        foreach (string nombre in args)
        {
            Console.WriteLine($"Hola, {nombre}!");
        }
    }

     static void Ejercicio17(string[] args)
    {
        // Verificamos que se haya pasado un argumento en la línea de comandos
        if (args.Length < 1)
        {
            Console.WriteLine("Por favor, ingrese un número natural como argumento.");
            return;
        }

        // Convertimos el argumento a un número entero
        int limite;
        if (int.TryParse(args[0], out limite) && limite > 0)
        {
            Console.WriteLine("Números primos entre 1 y " + limite + ":");
            // Iteramos sobre los números desde 1 hasta el límite dado
            for (int i = 1; i <= limite; i++)
            {
                if (EsPrimo(i)) // Si el número es primo, lo mostramos
                    Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
    static void Ejercicio20()
    {
        int x = 5;
        int y = 10;

        Console.WriteLine($"Antes de Swap: x = {x}, y = {y}");

        // Llamada al método Swap pasando las variables por referencia
        Swap(ref x, ref y);

        Console.WriteLine($"Después de Swap: x = {x}, y = {y}");
    }

    //21) Codificar el método Imprimir para que el siguiente código produzca la salida por consola que seobserva. Considerar que el usuario del método Imprimir podría querer más adelante imprimir otros datos, posiblemente de otros tipos pasando una cantidad distinta de parámetros cada vez que invoque el método. Tip: usar params
    static void Imprimir(params object[] datos)
    {
        foreach (var dato in datos)
        {
            // Usando el operador ternario o 'if' para diferenciar el tipo
            Console.WriteLine(dato is int ? $"Entero: {dato}" :
                              dato is string ? $"Cadena: {dato}" :
                              dato is double ? $"Decimal: {dato}" :
                              dato is bool ? $"Booleano: {dato}" :
                              $"Tipo no reconocido: {dato}");
        }
    }

    static void Main(string[] args)
    {
        // Ejemplo de llamada con diferentes tipos de datos
        Imprimir(1, "Hola", 3.14, true, 'A');  // Imprime diferentes tipos
        Imprimir(42, "Texto");               // Imprime sólo int y string
        Imprimir();                          // No se imprime nada
    }
    }
}

