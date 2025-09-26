using System;
using System.Collections.Generic;
using System.Linq;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        /// <summary>
        /// Crea y devuelve un diccionario vacío de códigos de marcación.
        /// </summary>
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        /// <summary>
        /// Devuelve un diccionario prellenado con 3 códigos:
        /// 1 -> United States of America
        /// 55 -> Brazil
        /// 91 -> India
        /// </summary>
        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                {1, "United States of America"},
                {55, "Brazil"},
                {91, "India"}
            };
        }

        /// <summary>
        /// Crea un diccionario vacío y agrega el país indicado.
        /// </summary>
        /// <param name="countryCode">Código de marcación del país</param>
        /// <param name="countryName">Nombre del país</param>
        /// <returns>Diccionario con el nuevo país agregado</returns>
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>();
            dict[countryCode] = countryName;
            return dict;
        }

        /// <summary>
        /// Agrega un país a un diccionario existente.
        /// </summary>
        /// <param name="existingDictionary">Diccionario existente</param>
        /// <param name="countryCode">Código de marcación del país</param>
        /// <param name="countryName">Nombre del país</param>
        /// <returns>Diccionario con el nuevo país agregado</returns>
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        /// <summary>
        /// Obtiene el nombre de un país dado su código de marcación.
        /// Si el código no existe, devuelve string.Empty.
        /// </summary>
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode)
                ? existingDictionary[countryCode]
                : string.Empty;
        }

        /// <summary>
        /// Verifica si un código de marcación existe en el diccionario.
        /// </summary>
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        /// <summary>
        /// Actualiza el nombre de un país según su código de marcación.
        /// Si el código no existe, no modifica el diccionario.
        /// </summary>
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        /// <summary>
        /// Elimina un país del diccionario según su código de marcación.
        /// Si el código no existe, no modifica el diccionario.
        /// </summary>
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        /// <summary>
        /// Encuentra el país con el nombre más largo en el diccionario.
        /// Si el diccionario está vacío, devuelve string.Empty.
        /// </summary>
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
