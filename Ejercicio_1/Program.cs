using System;
using espacioCalculadora;

internal class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        int opcion;
        double numero;
        calc.Sumar(5);
        

        do
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("Valor de dato actual: " + calc.Resultado);
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("6. Mostrar resultado");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese número a sumar: ");
                    numero = double.Parse(Console.ReadLine());
                    calc.Sumar(numero);
                    break;
                case 2:
                    Console.Write("Ingrese número a restar: ");
                    numero = double.Parse(Console.ReadLine());
                    calc.Restar(numero);
                    break;
                case 3:
                    Console.Write("Ingrese número a multiplicar: ");
                    numero = double.Parse(Console.ReadLine());
                    calc.Multiplicar(numero);
                    break;
                case 4:
                    Console.Write("Ingrese número a dividir: ");
                    numero = double.Parse(Console.ReadLine());
                    calc.dividir(numero);
                    break;
                case 5:
                    calc.limpiar();
                    Console.WriteLine("Resultado reiniciado.");
                    break;
                case 6:
                    Console.WriteLine($"Resultado actual: {calc.Resultado}");
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }
}
