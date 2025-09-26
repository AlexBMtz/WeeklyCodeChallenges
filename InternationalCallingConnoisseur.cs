using System;
using System.Collections.Generic;
using System.Linq;

//ILAN AYALA MORALES
// 2025-09-26
namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>(); //Devuelve un diccionario vacío de códigos de marcación y países.
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            }; //Devuelve un diccionario predefinido con códigos de marcación y países.
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
           return new Dictionary<int, string> { { countryCode, countryName } }; //Agrega un país a un diccionario vacío y lo devuelve.
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary[countryCode] = countryName; //Agrega o actualiza un país en un diccionario existente y lo devuelve.
            return existingDictionary;
        }

        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode) ? existingDictionary[countryCode] : string.Empty; //Devuelve el nombre del país correspondiente a un código de marcación dado, o una cadena vacía si no existe.
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode); //Verifica si un código de marcación existe en el diccionario.
        }

        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName; //Actualiza el nombre del país para un código de marcación dado si existe.
            }
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            if (existingDictionary.Count == 0) return string.Empty;
                return existingDictionary.Values.OrderByDescending(name => name.Length).First(); //Devuelve el nombre del país más largo en el diccionario, o una cadena vacía si el diccionario está vacío.
        }
    }
}
