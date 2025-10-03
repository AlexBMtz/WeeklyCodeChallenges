using System;
using System.Collections.Generic;
using System.Linq;

namespace TracksOnTracksOnTracks
{
    /// <summary>
    /// Clase estática que maneja operaciones de las listas de lenguajes de programación
    /// </summary>
    public static class Languages
    {
        /// <summary>
        /// Crea y devuelve una lista vacía de lenguajes
        /// </summary>
        /// <returns>Una lista vacía de cadenas.</returns>
        public static List<string> NewList()
        {
            return new List<string>();
        }

    /// <summary>
    /// Devuelve una lista predefinida de lenguajes
    /// </summary>
    /// <returns>Una lista con los lenguajes iniciales.</returns>
    public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        /// <summary>
        /// Añade un nuevo lenguaje al final de la lista
        /// </summary>
        /// <param name="languages">La lista de lenguajes existente</param>
        /// <param name="language">El nuevo lenguaje a añadir</param>
        /// <returns>Una nueva lista con el lenguaje añadido</returns>
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            var newList = new List<string>(languages);
            newList.Add(language);
            return newList;
        }

        /// <summary>
        /// Cuenta la cantidad de lenguajes que hay en la lista
        /// </summary>
        /// <param name="languages">La lista de lenguajes</param>
        /// <returns>El número de lenguajes en la lista</returns>
        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        /// <summary>
        /// Comprueba si un lenguaje específico está presente en la lista
        /// </summary>
        /// <param name="languages">La lista de lenguajes</param>
        /// <param name="language">El lenguaje que se va a verificar</param>
        /// <returns>True si existe, False si no</returns>
        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        /// <summary>
        /// Invierte el orden de los lenguajes en la lista
        /// </summary>
        /// <param name="languages">La lista de lenguajes</param>
        /// <returns>Una nueva lista con los lenguajes en orden inverso</returns>
        public static List<string> ReverseList(List<string> languages)
        {
            var reversed = new List<string>(languages);
            reversed.Reverse();
            return reversed;
        }

        /// <summary>
        /// Comprobamos si la lista de lenguajes es emocionante
        /// Una lista es emocionante si:
        /// - El primer lenguaje es "C#"
        /// - El segundo es "C#" y la lista tiene 2 o 3 elementos
        /// </summary>
        /// <param name="languages">La lista de lenguajes</param>
        /// <returns>True si es emocionante, False en caso contrario</returns>
        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0) return false;

            if (languages[0] == "C#") return true;

            if ((languages.Count == 2 || languages.Count == 3) && languages[1] == "C#") return true;

            return false;
        }

        /// <summary>
        /// Elimina un lenguaje de la lista
        /// Si el lenguaje no existe, la lista no cambia
        /// </summary>
        /// <param name="languages">La lista de lenguajes</param>
        /// <param name="language">El lenguaje a eliminar</param>
        /// <returns>Una nueva lista sin el lenguaje especificado</returns>
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            var newList = new List<string>(languages);
            newList.Remove(language);
            return newList;
        }

        /// <summary>
        /// Verifica si todos los lenguajes en la lista son únicos
        /// </summary>
        /// <param name="languages">La lista de lenguajes</param>
        /// <returns>True si todos son únicos, False si hay duplicados</returns>
        public static bool IsUnique(List<string> languages)
        {
            return languages.Distinct().Count() == languages.Count;
        }
    }

}
