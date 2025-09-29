using System;
using System.Collections.Generic;
using System.Linq;

namespace TracksOnTracksOnTracks
{
    /// <summary>
    /// Proporciona métodos estáticos para manipular listas de lenguajes de programación.
    /// </summary>
    public static class Languages
    {
        /// <summary>
        /// Crea una nueva lista de strings vacía.
        /// </summary>
        /// <returns>Una nueva instancia de <c>List&lt;string&gt;</c> vacía.</returns>
        public static List<string> NewList()
        {
            return new List<string>();
        }

        /// <summary>
        /// Obtiene una lista predefinida de lenguajes de programación.
        /// </summary>
        /// <returns>Una lista que contiene "C#", "Clojure" y "Elm".</returns>
        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        /// <summary>
        /// Añade un nuevo lenguaje al final de una lista existente.
        /// </summary>
        /// <param name="languages">La lista a la que se añadirá el lenguaje.</param>
        /// <param name="language">El lenguaje que se va a añadir.</param>
        /// <returns>La misma lista modificada con el nuevo lenguaje al final.</returns>
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        /// <summary>
        /// Cuenta el número de elementos en una lista de lenguajes.
        /// </summary>
        /// <param name="languages">La lista de lenguajes a contar.</param>
        /// <returns>El número total de lenguajes en la lista.</returns>
        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        /// <summary>
        /// Verifica si un lenguaje específico existe en la lista.
        /// </summary>
        /// <param name="languages">La lista en la que se buscará.</param>
        /// <param name="language">El lenguaje a buscar.</param>
        /// <returns><c>true</c> si el lenguaje se encuentra en la lista; de lo contrario, <c>false</c>.</returns>
        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        /// <summary>
        /// Invierte el orden de los elementos en una lista, devolviendo una nueva lista.
        /// </summary>
        /// <param name="languages">La lista a invertir.</param>
        /// <returns>Una nueva lista con los elementos en orden inverso.</returns>
        public static List<string> ReverseList(List<string> languages)
        {
            return languages.AsEnumerable().Reverse().ToList();
        }

        /// <summary>
        /// Determina si una lista de lenguajes es "emocionante" según ciertas reglas.
        /// </summary>
        /// <remarks>
        /// Una lista se considera emocionante si cumple una de estas condiciones:
        /// 1. El primer elemento es "C#".
        /// 2. El segundo elemento es "C#" y la lista contiene exactamente 2 o 3 elementos.
        /// </remarks>
        /// <param name="languages">La lista a verificar.</param>
        /// <returns><c>true</c> si la lista es emocionante; de lo contrario, <c>false</c>.</returns>
        public static bool IsExciting(List<string> languages)
        {
            // Condición 1: El primer elemento es "C#"
            bool esEmocionante = (languages.Count > 0 && languages[0] == "C#");

            // Si la condición 1 no se cumplió, evaluamos la condición 2
            if (!esEmocionante)
            {
                // Condición 2: El segundo es "C#" y el tamaño es 2 o 3
                if (languages.Count >= 2 && (languages.Count == 2 || languages.Count == 3))
                {
                    esEmocionante = languages[1] == "C#";
                }
            }

            return esEmocionante;
        }

        /// <summary>
        /// Elimina la primera ocurrencia de un lenguaje específico de la lista.
        /// </summary>
        /// <param name="languages">La lista de la que se eliminará el lenguaje.</param>
        /// <param name="language">El lenguaje a eliminar.</param>
        /// <returns>La misma lista modificada.</returns>
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        /// <summary>
        /// Verifica si todos los elementos en la lista son únicos (sin duplicados).
        /// </summary>
        /// <param name="languages">La lista a verificar.</param>
        /// <returns><c>true</c> si todos los lenguajes son únicos; de lo contrario, <c>false</c>.</returns>
        public static bool IsUnique(List<string> languages)
        {
            // Compara el conteo de elementos únicos con el conteo total.
            return languages.Distinct().Count() == languages.Count;
        }
    }
}