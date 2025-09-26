using System;
using System.Linq;
using System.Collections.Generic;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        // Tarea 1: Diccionario vacío
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        // Tarea 2: Diccionario prellenado
        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            };
        }

        // Tarea 3: Añadir a diccionario vacío
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>
            {
                { countryCode, countryName }
            };
            return dict;
        }

        // Tarea 4: Añadir a diccionario existente
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>(existingDictionary);
            dict[countryCode] = countryName; // añade o reemplaza
            return dict;
        }

        // Tarea 5: Obtener nombre de país por código
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.TryGetValue(countryCode, out var name) ? name : string.Empty;
        }

        // Tarea 6: Verificar si existe código
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        // Tarea 7: Actualizar nombre si existe
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>(existingDictionary);
            if (dict.ContainsKey(countryCode))
            {
                dict[countryCode] = countryName;
            }
            return dict;
        }

        // Tarea 8: Eliminar país por código
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            var dict = new Dictionary<int, string>(existingDictionary);
            dict.Remove(countryCode);
            return dict;
        }

        // Tarea 9: País con nombre más largo
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            if (existingDictionary.Count == 0)
                return string.Empty;

            return existingDictionary.Values
                .OrderByDescending(name => name.Length)
                .First();
        }
    }
}
