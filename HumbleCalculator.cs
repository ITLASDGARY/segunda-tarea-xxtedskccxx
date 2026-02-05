using System;

/// <summary>
/// Ejercicio 2: Calculadora Humilde (Switch)
/// </summary>
public class HumbleCalculator
{
    public static double Calculate(double num1, double num2, int operation)
    {
        double resultado = 0; 
        
        // Implementación del switch según las reglas del ejercicio
        switch (operation) 
        {
            case 1: 
                // Operación: Suma
                resultado = num1 + num2; 
                break;
            case 2: 
                // Operación: Resta
                resultado = num1 - num2; 
                break;
            case 3: 
                // Operación: Multiplicación
                resultado = num1 * num2; 
                break;
            default:
                // Opcional: Manejo de operación no válida
                Console.WriteLine("Operación no reconocida.");
                break;
        }
        
        return resultado;
    }
}