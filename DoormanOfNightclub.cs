using System;

/// <summary>
/// Ejercicio 1: El Portero de Discoteca
/// </summary>
public class DoormanOfNightclub
{
    public static string CheckAccess(int age)
    {
        string mensaje = ""; 
        
        // --- INICIO DE LA SOLUCIÓN ---
        if (age < 18) 
        {
            mensaje = "Fuera de aquí";
        }
        else if (age >= 18 && age <= 60) 
        {
            mensaje = "Bienvenido a la fiesta";
        }
        else 
        {
            mensaje = "Señor, el bingo es al lado";
        }
        // --- FIN DE LA SOLUCIÓN ---
        
        return mensaje;
    }
}