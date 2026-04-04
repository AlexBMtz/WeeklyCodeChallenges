using System;
using System.Collections.Generic;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            // Devuelve un diccionario vacío de códigos de marcación
            return new Dictionary<int, string>();
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            // Diccionario prellenado con 3 códigos de países
            return new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            };
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            // Crear un diccionario vacío
            var dict = new Dictionary<int, string>();

            // Añadir el país
            dict[countryCode] = countryName;

            // Devolver el diccionario
            return dict;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            // Crear una copia del diccionario existente para no modificar el original
            var dict = new Dictionary<int, string>(existingDictionary);

            // Añadir el país solo si la clave no existe
            if (!dict.ContainsKey(countryCode))
            {
                dict[countryCode] = countryName;
            }

            // Devolver el diccionario actualizado
            return dict;
        }

        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            // Intentar obtener el país
            if (existingDictionary.TryGetValue(countryCode, out string countryName))
            {
                return countryName;
            }
            else
            {
                return string.Empty; // Si no existe el código, devolver string vacío
            }
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            // Devuelve true si la clave existe, false si no
            return existingDictionary.ContainsKey(countryCode);
        }

        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            // Crear una copia del diccionario para no modificar el original
            var dict = new Dictionary<int, string>(existingDictionary);

            // Actualizar el nombre solo si el código existe
            if (dict.ContainsKey(countryCode))
            {
                dict[countryCode] = countryName;
            }

            return dict;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            // Crear una copia del diccionario
            var dict = new Dictionary<int, string>(existingDictionary);

            // Intentar eliminar el país
            dict.Remove(countryCode);

            return dict;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            // Si el diccionario está vacío, devolver string vacío
            if (existingDictionary.Count == 0)
                return string.Empty;

            string longest = string.Empty;

            foreach (var country in existingDictionary.Values)
            {
                if (country.Length > longest.Length)
                {
                    longest = country;
                }
            }

            return longest;
        }
    }
}
