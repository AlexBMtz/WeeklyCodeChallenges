using System;
using System.Collections.Generic;
using System.Linq;

namespace TracksOnTracksOnTracks
{
    public static class Languages
    {
        public static List<string> NewList()
        {
            return new List<string>();
        }

        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm"};
        }

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages)
        {
            return languages.Count();
        }

        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();
            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            // Si no hay nada pos no
            if (languages == null || languages.Count == 0 )
            {
                return false;
            }

            // El primero es C#
            if ( languages[ 0 ] == "C#" )
                return true;

            // El segundo es C# y hay 2 o 3
            if ( languages.Count <= 3 && languages.Count >= 2 && languages[ 1 ] == "C#" )
                return true;

            else return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            return languages.Distinct().Count() == languages.Count();
        }
    }
}
