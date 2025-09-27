using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Pruebas de diccionarios ---\n");

        // Tarea 1: Obtener un diccionario vacío
        Console.WriteLine("Tarea 1: Obtener diccionario vacío.");
        var emptyDict = DialingCodes.GetEmptyDictionary();
        Console.WriteLine($"Diccionario vacío creado. Count: {emptyDict.Count}");
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 2: Obtener un diccionario prellenado
        Console.WriteLine("Tarea 2: Obtener diccionario existente.");
        var existingDict = DialingCodes.GetExistingDictionary();
        PrintDictionary(existingDict);
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 3: Añadir a un diccionario vacío
        Console.WriteLine("Tarea 3: Añadir país a diccionario vacío (UK: 44).");
        var singleEntryDict = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
        PrintDictionary(singleEntryDict);
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 4: Añadir a un diccionario existente
        Console.WriteLine("Tarea 4: Añadir país a diccionario existente (UK: 44).");
        // Usamos una nueva copia del diccionario original para no modificar la fuente
        var dictForTask4 = DialingCodes.GetExistingDictionary();
        var addedDict = DialingCodes.AddCountryToExistingDictionary(dictForTask4, 44, "United Kingdom");
        PrintDictionary(addedDict);
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 5: Obtener el nombre del país
        Console.WriteLine("Tarea 5: Obtener nombre del país.");
        var country55 = DialingCodes.GetCountryNameFromDictionary(existingDict, 55);
        var country999 = DialingCodes.GetCountryNameFromDictionary(existingDict, 999);
        Console.WriteLine($"Código 55: '{country55}'"); // Debería ser "Brazil"
        Console.WriteLine($"Código 999: '{country999}'"); // Debería ser "" (string vacío)
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 6: Checar si un código existe
        Console.WriteLine("Tarea 6: Checar si un código existe.");
        var exists55 = DialingCodes.CheckCodeExists(existingDict, 55);
        var exists7 = DialingCodes.CheckCodeExists(existingDict, 7);
        Console.WriteLine($"¿Existe el código 55? {exists55}");
        Console.WriteLine($"¿Existe el código 7? {exists7}");
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 7: Actualizar un nombre de país
        Console.WriteLine("Tarea 7: Actualizar nombre de país (1 -> Les États-Unis).");
        var dictForTask7 = DialingCodes.GetExistingDictionary();
        var updatedDict = DialingCodes.UpdateDictionary(dictForTask7, 1, "Les États-Unis");
        PrintDictionary(updatedDict);

        Console.WriteLine("Intento de actualización de código inexistente (999).");
        var noChangeDict = DialingCodes.UpdateDictionary(updatedDict, 999, "Newlands");
        PrintDictionary(noChangeDict);
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 8: Eliminar un país
        Console.WriteLine("Tarea 8: Eliminar un país (91 - India).");
        var dictForTask8 = DialingCodes.GetExistingDictionary();
        var removedDict = DialingCodes.RemoveCountryFromDictionary(dictForTask8, 91);
        PrintDictionary(removedDict);
        Console.WriteLine("--------------------------------------------------\n");

        // Tarea 9: Buscar el país con el nombre más largo
        Console.WriteLine("Tarea 9: Buscar el país con el nombre más largo.");
        var longestName = DialingCodes.FindLongestCountryName(existingDict);
        Console.WriteLine($"El país con el nombre más largo es: '{longestName}'");

        var dictForLongest = new Dictionary<int, string> { { 1, "A" }, { 2, "BBBB" }, { 3, "CCC" } };
        Console.WriteLine($"Test con ['A', 'BBBB', 'CCC']: '{DialingCodes.FindLongestCountryName(dictForLongest)}'");

        Console.WriteLine("\n--- Fin de Pruebas ---");
    }

    /// <summary>
    /// Método auxiliar para imprimir el contenido de un diccionario
    /// </summary>
    private static void PrintDictionary(Dictionary<int, string> dict)
    {
        if (dict.Count == 0)
        {
            Console.WriteLine("-> El diccionario está vacío.");
            return;
        }

        Console.Write("-> Contenido del Diccionario: { ");
        foreach (var entry in dict)
        {
            Console.Write($"[{entry.Key}: \"{entry.Value}\"], ");
        }
        // Limpia el ", " final y cierra la llave.
        Console.WriteLine("\b\b }");
    }
}

