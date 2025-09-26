using System;
using System.Collections.Generic;
using System.Linq;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        // Tarea 1
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        // Tarea 2
        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                {1, "United States of America"},
                {55, "Brazil"},
                {91, "India"}
            };
        }

        // Tarea 3
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>();
            dict[countryCode] = countryName;
            return dict;
        }

        // Tarea 4
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            // Clonamos para no modificar la referencia original
            var dict = new Dictionary<int, string>(existingDictionary);
            dict[countryCode] = countryName;
            return dict;
        }

        // Tarea 5
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode)
                ? existingDictionary[countryCode]
                : string.Empty;
        }

        // Tarea 6
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        // Tarea 7
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

        // Tarea 8
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            var dict = new Dictionary<int, string>(existingDictionary);
            dict.Remove(countryCode);
            return dict;
        }

        // Tarea 9
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            if (existingDictionary.Count == 0) return string.Empty;

            return existingDictionary.Values
                .OrderByDescending(name => name.Length)
                .First();
        }
    }
}
