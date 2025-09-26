using System;
using System.Collections.Generic;
using System.Linq;

namespace International_Calling
{
    public static class DialingCodes
    {
        // Tarea 1 - Diccionario vacío
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        // Tarea 2 - Diccionario prellenado
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
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int code, string country)
        {
            var dict = new Dictionary<int, string>();
            dict.Add(code, country);
            return dict;
        }

        // Tarea 4 - Añade un país a un diccionario existente
        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> dict, int code, string country)
        {
            dict[code] = country; // Add o Update
            return dict;
        }

        // Tarea 5 - Obtener nombre de país según código
        public static string GetCountryNameFromDictionary(Dictionary<int, string> dict, int code)
        {
            return dict.ContainsKey(code) ? dict[code] : string.Empty;
        }

        // Tarea 6 - Checa si existe un código
        public static bool CheckCodeExists(Dictionary<int, string> dict, int code)
        {
            return dict.ContainsKey(code);
        }

        // Tarea 7 - Actualizar nombre de país
        public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> dict, int code, string newCountry)
        {
            if (dict.ContainsKey(code))
            {
                dict[code] = newCountry;
            }
            return dict;
        }

        // Tarea 8 - Eliminar un país
        public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> dict, int code)
        {
            dict.Remove(code);
            return dict;
        }

        // Tarea 9 - País con el nombre más largo
        public static string FindLongestCountryName(Dictionary<int, string> dict)
        {
            if (dict.Count == 0)
                return string.Empty;

            return dict.Values.OrderByDescending(v => v.Length).First();
        }
    }
}

