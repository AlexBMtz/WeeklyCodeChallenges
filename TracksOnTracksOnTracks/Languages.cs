using System;
using System.Collections.Generic;
using System.Linq;

//Ilan Ayala Morales
//03/10/2023
namespace TracksOnTracksOnTracks
{
    public static class Languages
    {
        public static List<string> NewList() //Crea una nueva lista de lenguajes
        {
            return new List<string>();
        }

        public static List<string> GetExistingLanguages() //Define una lista con lenguajes existentes
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        public static List<string> AddLanguage(List<string> languages, string language) //Agrega un lenguaje a la lista
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages) //Cuenta la cantidad de lenguajes en la lista
        {
            return languages.Count;
        }

        public static bool HasLanguage(List<string> languages, string language) //Verifica si un lenguaje está en la lista
        {
            return languages.Contains(language);
        }

        public static List<string> ReverseList(List<string> languages) //Invierte el orden de los lenguajes en la lista
        {
            languages.Reverse();
            return languages;
        }

        public static bool IsExciting(List<string> languages) //Verifica si la lista es "emocionante" según las reglas dadas
        {
            if (languages.Count == 0) return false;

            if (languages[0] == "C#") return true;

            if (languages.Count >= 2 && languages[1] == "C#" && (languages.Count == 2 || languages.Count == 3))
                return true;

            return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language) //Elimina un lenguaje de la lista
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages) //Verifica si todos los lenguajes en la lista son únicos
        {
            return languages.Distinct().Count() == languages.Count;
        }
    }
}
