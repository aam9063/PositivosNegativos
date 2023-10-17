/*
en c# y usando el bucle 'while' crea un Programa que lee una secuencia de 15 números y nos dice cuántos hay positivos, cuántos negativos y cuantos ceros.
*/

using System;

public class Program
{
    public static void Main()
    {
        int contadorPositivos = 0;
        int contadorNegativos = 0;
        int contadorCeros = 0;
        int contadorTotal = 0;

        Console.WriteLine("Introduce una secuencia de 15 números.");

        while (contadorTotal < 15)
        {
            Console.Write($"Número {contadorTotal + 1}: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                contadorPositivos++;
            }
            else if (numero < 0)
            {
                contadorNegativos++;
            }
            else
            {
                contadorCeros++;
            }

            contadorTotal++;
        }

        Console.WriteLine($"Cantidad de números positivos: {contadorPositivos}");
        Console.WriteLine($"Cantidad de números negativos: {contadorNegativos}");
        Console.WriteLine($"Cantidad de ceros: {contadorCeros}");
    }
}
