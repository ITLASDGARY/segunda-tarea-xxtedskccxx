using System;

/// <summary>
/// Ejercicio 3: Detector de Pares
/// </summary>
public class EvenOddDetector
{
    public static string DetectEvenOdd(int number)
    {
        string resultado = ""; 
        
        // TODO: Usa el operador % y if/else para determinar si es PAR o IMPAR
        
        // Si el residuo de dividir el número entre 2 es 0, es PAR
        if (number % 2 == 0)
        {
            resultado = "PAR";
        }
        // Si el residuo es 1 (o cualquier otro valor), es IMPAR
        else
        {
            resultado = "IMPAR";
        }
        
        return resultado;
    }
}