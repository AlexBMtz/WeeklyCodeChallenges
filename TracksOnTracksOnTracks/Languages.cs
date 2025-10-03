using System;
using System.Collections.Generic;
using System.Linq;

namespace TracksOnTracksOnTracks
{
    public static class Languages
    {
        // 1. Crear nueva lista vacía
        public static List<string> NewList()
        {
            return new List<string>();
        }

        // 2. Definir lista existente
        public static List<string> GetExistingLanguages()
        {
            return new List<string>
            {
                "C#",
                "Clojure",
                "Elm"
            };
        }

        // 3. Añadir un nuevo lenguaje
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            var newList = new List<string>(languages); // copia para no modificar referencia original
            newList.Add(language);
            return newList;
        }

        // 4. Contar lenguajes
        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        // 5. Verificar si contiene un lenguaje
        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        // 6. Invertir lista
        public static List<string> ReverseList(List<string> languages)
        {
            var reversed = new List<string>(languages);
            reversed.Reverse();
            return reversed;
        }

        // 7. Lista emocionante
        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0)
                return false;
            if (languages[0] == "C#")
                return true;
            if (languages.Count >= 2 && languages[1] == "C#" && (languages.Count == 2 || languages.Count == 3))
                return true;
            return false;
        }

        // 8. Eliminar lenguaje
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            var newList = new List<string>(languages);
            newList.Remove(language); // si no existe, no hace nada
            return newList;
        }

        // 9. Verificar unicidad
        public static bool IsUnique(List<string> languages)
        {
            return languages.Distinct().Count() == languages.Count;
        }
    }
}
