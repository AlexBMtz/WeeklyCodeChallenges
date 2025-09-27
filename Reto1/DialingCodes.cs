using System.Collections.Generic;
using System.Linq; 

public static class DialingCodes
{
    // Tarea 1 - Crea un nuevo diccionario
    /// <summary>
    /// Devuelve un diccionario vacío de códigos de marcación y nombres de países
    /// </summary>
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    // Tarea 2 - Crea un diccionario prellenado
    /// <summary>
    /// Devuelve un diccionario prellenado con códigos de marcación para EE. UU., Brasil e India
    /// </summary>
    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>
        {
            { 1, "United States of America" },
            { 55, "Brazil" },
            { 91, "India" }
        };
    }

    // Tarea 3 - Añade un país a un diccionario vacío
    /// <summary>
    /// Crea un diccionario, añade un código de marcación y un nombre de país, y lo devuelve
    /// </summary>
    /// <param name="code">El código de marcación (clave).</param>
    /// <param name="countryName">El nombre del país (valor).</param>
    /// <returns>El nuevo diccionario con el país añadido.</returns>
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int code, string countryName)
    {
        var dictionary = GetEmptyDictionary();
        dictionary.Add(code, countryName);
        return dictionary;
    }

    // Tarea 4 - Añade un país a un diccionario existente
    /// <summary>
    /// Añade un código de marcación y el nombre del país asociado a un diccionario.
    /// </summary>
    /// <param name="existingDictionary">El diccionario al que añadir el país.</param>
    /// <param name="code">El código de marcación (clave).</param>
    /// <param name="countryName">El nombre del país (valor).</param>
    /// <returns>El diccionario modificado.</returns>
    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int code, string countryName)
    {
        existingDictionary.Add(code, countryName);
        return existingDictionary;
    }

    // Tarea 5 - Obten el nombre del país de acuerdo a su código de marcación
    /// <summary>
    /// Obtiene el nombre del país de un diccionario dado su código de marcación
    /// </summary>
    /// <param name="dictionary">El diccionario de códigos de marcación.</param>
    /// <param name="code">El código de marcación a buscar.</param>
    /// <returns>El nombre del país o string.Empty si el código no se encuentra.</returns>
    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> dictionary, int code)
    {
        // El método TryGetValue es eficiente para obtener un valor sin lanzar una excepción
        // si la clave no existe.
        if (dictionary.TryGetValue(code, out string countryName))
        {
            return countryName;
        }
        return string.Empty;

    }

    // Tarea 6 - Checa que un país existe en el diccionario
    /// <summary>
    /// Comprueba si un código de marcación existe en el diccionario.
    /// </summary>
    /// <param name="dictionary">El diccionario a buscar.</param>
    /// <param name="code">El código de marcación a comprobar.</param>
    /// <returns>True si el código existe, false en caso contrario.</returns>
    public static bool CheckCodeExists(Dictionary<int, string> dictionary, int code)
    {
        return dictionary.ContainsKey(code);
    }

    // Tarea 7 - Actualiza un nombre de país
    /// <summary>
    /// Actualiza el nombre del país asociado a un código de marcación existente.
    /// </summary>
    /// <param name="dictionary">El diccionario a modificar.</param>
    /// <param name="code">El código de marcación cuya entrada se actualizará.</param>
    /// <param name="newCountryName">El nuevo nombre del país.</param>
    /// <returns>El diccionario modificado.</returns>
    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> dictionary, int code, string newCountryName)
    {
        
        if (dictionary.ContainsKey(code))
        {
            dictionary[code] = newCountryName;
        }
        return dictionary;
    }

    // Tarea 8 - Elimina un país del diccionario
    /// <summary>
    /// Elimina un código de marcación y el nombre del país asociado del diccionario
    /// </summary>
    /// <param name="dictionary">El diccionario a modificar.</param>
    /// <param name="code">El código de marcación a eliminar.</param>
    /// <returns>El diccionario modificado.</returns>
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> dictionary, int code)
    {
       
        dictionary.Remove(code);
        return dictionary;
    }

    // Tarea 9 - Busca el país con el nombre más largo
    /// <summary>
    /// Encuentra y devuelve el nombre del país con la longitud de string más larga
    /// </summary>
    /// <param name="dictionary">El diccionario de códigos de marcación.</param>
    /// <returns>El nombre del país con la longitud máxima. Devuelve string.Empty si el diccionario está vacío.</returns>
    public static string FindLongestCountryName(Dictionary<int, string> dictionary)
    {
        if (!dictionary.Any())
        {
            return string.Empty;
        }

        var longestEntry = dictionary.Aggregate(
            (max, current) => (current.Value.Length > max.Value.Length) ? current : max
        );

        return longestEntry.Value;

    }
}
