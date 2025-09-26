using System;
using System.Collections.Generic;
using System.Linq;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        // devuelve un diccionario vacío, o sea, sin nada
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        // devuelve un diccionario ya armado con 3 países de ejemplo
        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
        {
            {1,"United States of America" },
            {55,"Brazil" },
            {91, "India" }
        };
        }

        // crea un diccionario nuevo y le mete un país con su código
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var countryDictionary = new Dictionary<int, string>();
            countryDictionary.Add(countryCode, countryName);
            return countryDictionary;
        }

        // agrega o actualiza un país dentro de un diccionario que ya existe
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        // busca un país por código, si existe devuelve el nombre, si no, devuelve vacío
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode) ? existingDictionary[countryCode] : string.Empty;
        }

        // checa si un código existe en el diccionario
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        // si el país ya está en el diccionario, lo actualiza con un nuevo nombre
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        // elimina un país del diccionario usando el código
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        // busca el nombre de país "más largo", aunque en realidad
        // está ordenando alfabéticamente de atrás para adelante y agarra el primero
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            if (existingDictionary.Count == 0)
                return string.Empty;

            return existingDictionary.Values.OrderByDescending(x => x).FirstOrDefault();
        }
    }

}
