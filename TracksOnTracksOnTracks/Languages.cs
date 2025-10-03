using System;
using System.Collections.Generic;
using System.Linq;

namespace TracksOnTracksOnTracks
{
    public static class Languages
    {
        public static List<string> NewList()
        {
            var listOfStrings = new List<string>();
            return listOfStrings;
        }

        public static List<string> GetExistingLanguages()
        {
            List<string> listExistingLang = new List<string> 
                    {"C#",
                    "Clojure",
                    "Elm"};
            return listExistingLang;
        }

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        public static bool HasLanguage(List<string> languages, string language)
        {
            bool exists = languages.Contains(language);
            return exists;
        }

        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();
            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            //if there are no elements
            if (languages.Count == 0) return false;

            if (languages[0] == "C#") return true;
            if (languages[1] == "C#" && (languages.Count == 2 || languages.Count == 3)) return true;
            return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            var seen = new HashSet<string>();
            foreach (var lang in languages) 
            {
                if (seen.Contains(lang))
                {
                    return false;//repeated
                }
                seen.Add(lang);
            }
            return true; //unnique

            //opt 2:
            //distinct removes duplicates
            //if count stays the same, then theyre unique

            //return languages.Distinct().Count() == languages.Count();
        }
    }
}
