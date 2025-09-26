using System;
using System.Collections.Generic;
using System.Linq;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        /// <summary>
        /// Clase que retorna un diccionario vacio
        /// </summary>
        /// <returns>Diccionario Vacio</returns>
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }
        /// <summary>
        /// Clase que retorna un diccionario pre-llenado
        /// </summary>
        /// <returns>Diccionario Pre-llenado</returns>
        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                {1, "United States of America" },
                {55, "Brazil" },
                {91, "India" }
            };
        }
        /// <summary>
        /// Clase que crea un diccionario vacio y le agrega un pais
        /// </summary>
        /// <param name="countryCode">Codigo del pais</param>
        /// <param name="countryName">Nombre del pais</param>
        /// <returns>Diccionario Con 1 pais</returns>
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var diccionario = GetEmptyDictionary();
            diccionario[countryCode] = countryName;
            return diccionario;
        }


        /// <summary>
        /// Metodo que agrega un pais a un diccionario existente
        /// </summary>
        /// <param name="existingDictionary">Diccionario al que se agregará</param>
        /// <param name="countryCode">Codigo del pais</param>
        /// <param name="countryName">Nombre del pais</param>
        /// <returns>Diccionario con el pais agregado</returns>
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (!existingDictionary.ContainsKey(countryCode)) // Si el codigo no existe en el diccionario
            {
                existingDictionary.Add(countryCode, countryName); //Agregamos
            }
            return existingDictionary;
        }
        /// <summary>
        /// Metodo que retorna el nombre de un pais en base a su codigo
        /// </summary>
        /// <param name="existingDictionary">Diccionario existente</param>
        /// <param name="countryCode">Codigo del pais</param>
        /// <returns>Nombre del pais o cadena vacia</returns>
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.TryGetValue(countryCode, out var name) ? name : string.Empty; //Intenta obtener el valor de la clase, si da verdadero retorna el valor, falso retorna cadena vacia
        }

        /// <summary>
        /// Metodo que revisa si un pais existe dentro del diccionario
        /// </summary>
        /// <param name="existingDictionary">Diccionario existente</param>
        /// <param name="countryCode">Codigo del pais</param>
        /// <returns>True o False</returns>
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        /// <summary>
        /// Metodo que actualiza el nombre de un pais en base a la clave proporcionada
        /// </summary>
        /// <param name="existingDictionary">Diccionario Existente</param>
        /// <param name="countryCode">Codigo del pais</param>
        /// <param name="countryName">Nombre del pais</param>
        /// <returns>Diccionario Actualizado</returns>
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode)) //Si existe una clave con ese valor
            {
                existingDictionary[countryCode] = countryName; //Actualiza el valor asociado a esa clave
            }
            return existingDictionary;
        }

        /// <summary>
        /// Elimina un pais del diccionario
        /// </summary>
        /// <param name="existingDictionary">Diccionario existente</param>
        /// <param name="countryCode">Codigo del pais</param>
        /// <returns>Diccionario Actualizado</returns>
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode); //Elimina el valor de la clave especificada
            return existingDictionary;
        }
        /// <summary>
        /// Metodo que retorna el pais con nombre mas largo del diccionario
        /// </summary>
        /// <param name="existingDictionary">Diccionario existente</param>
        /// <returns>El nombre del país con m[as caracteres
        /// Si el diccionario esta vacio retorna cadena vacia</returns>
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            if(existingDictionary.Count == 0) return string.Empty; //Si no hay nada retorna vacio
            return existingDictionary.Values.OrderByDescending(c => c.Length).First();//Ordenamos el diccionario de mayor a menos segun la longitud y retornamos el primer valor (mas largo)

        }
    }
}
