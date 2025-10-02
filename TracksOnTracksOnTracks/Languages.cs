// Clase estática Languages
// Fecha: 24/09/2025
// Autor: Mauricio Sevilla
// Versión: 1.0
// Descripción: Métodos para crear y manipular listas de lenguajes de programación.

using System;
using System.Collections.Generic;

namespace TracksOnTracksOnTracks
{
    public static class Languages
    {
        // Crea y devuelve una nueva lista vacía
        public static List<string> NewList()
        {
            return new List<string>();
        }

        // Devuelve la lista existente de lenguajes predeterminados
        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        // Añade un lenguaje al final de la lista y devuelve la lista actualizada
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        // Devuelve el número de elementos en la lista
        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        // Comprueba si un lenguaje específico está presente en la lista
        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        // Invierte el orden de los elementos en la lista
        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();
            return languages;
        }

        // Comprueba si la lista es “emocionante” según las reglas dadas
        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0)
                return false;

            if (languages[0] == "C#")
                return true;

            if ((languages.Count == 2 || languages.Count == 3) && languages[1] == "C#")
                return true;

            return false;
        }

        // Elimina un lenguaje de la lista si existe
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        // Comprueba si todos los elementos de la lista son únicos
        public static bool IsUnique(List<string> languages)
        {
            var seen = new HashSet<string>();
            foreach (var lang in languages)
            {
                if (!seen.Add(lang))
                    return false;
            }
            return true;
        }
    }
}
