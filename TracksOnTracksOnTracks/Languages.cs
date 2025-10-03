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
        /// Crea e inicializa una nueva lista vacía de cadenas (string) para almacenar lenguajes.
        /// </summary>
        /// <returns></returns>
        public static List<string> NewList()
        {
            return new List<string>();
        }

        /// <summary>
        /// Retorna una lista de lenguajes de programación predefinidos.
        /// </summary>
        /// <returns>Una <see cref="List{T}"/> que contiene "C#", "Clojure", y "Elm"</returns>
        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        /// <summary>
        /// Agrega un nuevo lenguaje de programación a la lista proporcionada.
        /// </summary>
        /// <param name="languages">La lista de lenguajes a la que se agregará el nuevo elemento.</param>
        /// <param name="language">El nombre del lenguaje (string) a agregar.</param>
        /// <returns>La misma lista de lenguajes modificada (con el nuevo lenguaje añadido).</returns>
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);   
            return languages;
        }

        /// <summary>
        /// Cuenta el número total de lenguajes (elementos) presentes en la lista.
        /// </summary>
        /// <param name="languages">La lista de lenguajes cuya cantidad de elementos se desea contar.</param>
        /// <returns>El número entero de elementos en la lista.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        /// <summary>
        /// Verifica si un lenguaje de programación específico existe dentro de la lista.
        /// </summary>
        /// <param name="languages">La lista de lenguajes a buscar.</param>
        /// <param name="language">El lenguaje (string) que se desea verificar si está presente.</param>
        /// <returns><see langword="true"/> si la lista contiene el lenguaje; de lo contrario, <see langword="false"/>.</returns>
        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        /// <summary>
        /// Invierte el orden de los elementos en la lista de lenguajes.
        /// </summary>
        /// <param name="languages">La lista de lenguajes que se desea invertir.</param>
        /// <returns>Una nueva lista con los mismos elementos, pero en orden inverso al original.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static List<string> ReverseList(List<string> languages)
        {
            // Se usa AsEnumerable().Reverse().ToList() para obtener una copia invertida sin modificar la lista original.
            return languages.AsEnumerable().Reverse().ToList();
        }

        /// <summary>
        /// Determina si una lista de lenguajes es considerada "emocionante" bajo dos condiciones específicas:
        /// 1. El primer lenguaje es "C#".
        /// 2. Opcionalmente, el segundo lenguaje es "C#" Y el tamaño de la lista es 2 o 3.
        /// </summary>
        /// <param name="languages">La lista de lenguajes a evaluar.</param>
        /// <returns><see langword="true"/> si la lista cumple alguna de las condiciones de emoción; de lo contrario, <see langword="false"/>.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool IsExciting(List<string> languages)
        {
            // Condición 1: El primer elemento es "C#"
            bool isExiting = (languages.Count > 0 && languages[0] == "C#");

            // Si la condición 1 es falsa, se pasa a la siguiente condición
            if (!isExiting)
            {
                // Condición 2: El segundo es "C#" y el tamaño de la lista es 2 o 3
                if (languages.Count >= 2 && (languages.Count == 2 || languages.Count == 3))
                {
                    isExiting = languages[1] == "C#";
                }
            }
            return isExiting;
        }

        /// <summary>
        /// Elimina la primera ocurrencia de un lenguaje específico de la lista.
        /// </summary>
        /// <param name="languages">La lista de lenguajes de la que se desea eliminar un elemento.</param>
        /// <param name="language">El lenguaje (string) a eliminar.</param>
        /// <returns>La misma lista de lenguajes modificada (sin la primera ocurrencia del lenguaje si existía).</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        /// <summary>
        /// Verifica si todos los lenguajes en la lista son únicos (es decir, que no hay duplicados).
        /// </summary>
        /// <param name="languages">La lista de lenguajes a verificar.</param>
        /// <returns><see langword="true"/> si todos los elementos son únicos; <see langword="false"/> si hay al menos un lenguaje repetido.</returns>
        public static bool IsUnique(List<string> languages)
        {
            // Compara el conteo de elementos únicos (Distinct().Count()) con el conteo total (Count).
            return languages.Distinct().Count() == languages.Count;
        }
    }
}
