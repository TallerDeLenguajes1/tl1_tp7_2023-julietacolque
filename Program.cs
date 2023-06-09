﻿using EspacioCalculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion, escape = 1;
        double numero;
        var c1 = new Calculadora();
        c1.Resultado = 10;


        while (escape == 1)
        {

            Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Limpiar\nIngrese la opcion: ");
            bool conversion = int.TryParse(Console.ReadLine(), out opcion);
            Console.WriteLine("Ingrese un valor");
            bool conversionNum = double.TryParse(Console.ReadLine(), out numero);
            if (conversion && conversionNum)
            {
                switch (opcion)
                {
                    case 1:
                        c1.Sumar(numero);
                        break;
                    case 2:
                        c1.Restar(numero);
                        break;
                    case 3:
                        c1.Multiplicar(numero);
                        break;
                    case 4:
                        c1.Dividir(numero);
                        break;
                    case 5:
                        c1.Limpiar();
                        break;

                }
            }
            Console.WriteLine(c1.Resultado);

            do
            {
                Console.WriteLine("Seguir?");
                conversion = int.TryParse(Console.ReadLine(), out escape);
            } while (!conversion);

        }
    }
}