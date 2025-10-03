using System;
using System.Collections.Generic;
using System.Linq;

namespace TracksOnTracksOnTracks
{
    public static class Languages
    {
        // 1. Crear una nueva lista
        public static List<string> NewList()
        {
            return new List<string>();
        }

        // 2. Definir una lista existente
        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        //3. Añade un nuevo idioma a la lista
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            var result = new List<string>(languages); 
            result.Add(language);
            return result;
        }

        //4. Contar los lenguajes de la lista
        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        //5. Comprueba si un idioma está en la lista
        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        //6. Invertir la lista
        public static List<string> ReverseList(List<string> languages)
        {
            var result = new List<string>(languages);
            result.Reverse();
            return result;
        }


        //7. Comprueba si la lista es emocionante.
        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0) return false;
            if (languages[0] == "C#") return true;
            if (languages.Count >= 2 && languages[1] == "C#")
                return languages.Count == 2 || languages.Count == 3;
            return false;
        }

        //8. Eliminar lenguaje
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        //9. Comprobar si todos los lenguajes de la lista son únicos
        public static bool IsUnique(List<string> languages)
        {
            return languages.Distinct().Count() == languages.Count;
        }
    }
}
