using System;
using System.Collections.Generic;

namespace International_Calling_Connoisseur
{
    /// Clase estática DialingCodes
    /// Fecha: 24/09/2025
    /// Autor: Mauricio Murgo
    /// Versión: 1.0
    /// Descripción: Métodos para crear y manipular un diccionario de códigos de marcación
    ///              donde la clave es el código (int) y el valor es el nombre del país (string).
    public static class DialingCodes
    {
        /// Tarea 1 - GetEmptyDictionary
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Devuelve un diccionario vacío para empezar a insertar códigos.
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            // Creo y devuelvo un diccionario vacío (clave: int, valor: string).
            return new Dictionary<int, string>();
        }

        /// Tarea 2 - GetExistingDictionary
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Devuelve un diccionario prellenado con 3 países requeridos.
        public static Dictionary<int, string> GetExistingDictionary()
        {
            // Inicializo el diccionario con los tres pares indicados en el enunciado.
            var codes = new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            };

            return codes;
        }

        /// Tarea 3 - AddCountryToEmptyDictionary
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Crea un diccionario vacío, añade un país con su código y lo devuelve.
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            // Creo un diccionario nuevo vacío.
            var dict = new Dictionary<int, string>();

            // Añadimos (o asignamos) el código con el nombre del país.
            // Uso la indexación porque es simple y maneja tanto insert como update.
            dict[countryCode] = countryName;

            // Devuelvo el diccionario ya con la entrada agregada.
            return dict;
        }

        /// Tarea 4 - AddCountryToExistingDictionary
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Añade (o actualiza) un país en un diccionario que ya existe y lo devuelve.
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            // Validación ligera: si por alguna razón el dict es nulo, creo uno nuevo para evitar excepciones.
            if (existingDictionary == null)
            {
                existingDictionary = new Dictionary<int, string>();
            }

            // Inserto o actualizo la entrada. Si la clave existe, se reemplaza; si no, se agrega.
            existingDictionary[countryCode] = countryName;

            // Devuelvo el diccionario modificado.
            return existingDictionary;
        }

        /// Tarea 5 - GetCountryNameFromDictionary
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Devuelve el nombre del país para un código dado; si no existe, devuelve string.Empty.
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            // Si el diccionario es nulo, no hay nada que buscar -> retorno string.Empty.
            if (existingDictionary == null)
                return string.Empty;

            // Uso ContainsKey para comprobar existencia y luego devuelvo el valor si existe.
            return existingDictionary.ContainsKey(countryCode) ? existingDictionary[countryCode] : string.Empty;
        }

        /// Tarea 6 - CheckCodeExists
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Comprueba si un código de marcación existe en el diccionario.
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            // Si el diccionario es nulo, consideramos que no existe el código.
            if (existingDictionary == null)
                return false;

            // Devuelve true si la clave está presente, false en caso contrario.
            return existingDictionary.ContainsKey(countryCode);
        }

        /// Tarea 7 - UpdateDictionary
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Actualiza el nombre del país para la clave dada si existe; si no, deja el diccionario igual.
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            // Si el diccionario es nulo, no hay nada que actualizar -> devuelvo un diccionario vacío por seguridad.
            if (existingDictionary == null)
                return new Dictionary<int, string>();

            // Solo actualizo si la clave ya existe.
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }

            // Devuelvo el diccionario (modificado o no).
            return existingDictionary;
        }

        /// Tarea 8 - RemoveCountryFromDictionary
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Elimina la entrada asociada a countryCode del diccionario (si existe).
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            // Si el diccionario es nulo, devuelvo uno vacío para evitar NullReferenceException.
            if (existingDictionary == null)
                return new Dictionary<int, string>();

            // Remove devuelve true si eliminó, false si la clave no existía. No hace falta manejar el bool aquí.
            existingDictionary.Remove(countryCode);

            // Devuelvo el diccionario resultante.
            return existingDictionary;
        }

        /// Tarea 9 - FindLongestCountryName
        /// Fecha: 24/09/2025
        /// Autor: Mauricio Murgo
        /// Versión: 1.0
        /// Descripción: Busca y devuelve el nombre de país más largo almacenado en el diccionario.
        ///              Si el diccionario está vacío o es nulo, devuelve string.Empty.
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            // Si no hay diccionario o está vacío, retorno cadena vacía.
            if (existingDictionary == null || existingDictionary.Count == 0)
                return string.Empty;

            // Mantengo una variable para el nombre más largo encontrado hasta ahora.
            string longest = string.Empty;

            // Recorro cada valor (nombre de país) del diccionario.
            foreach (var kvp in existingDictionary)
            {
                string country = kvp.Value;

                // Compruebo si el actual es más largo que el guardado.
                if (country != null && country.Length > longest.Length)
                {
                    longest = country; // si es más largo, lo guardo
                }
            }

            // Devuelvo el nombre más largo encontrado.
            return longest;
        }
    }
}
