using System;
using System.Collections.Generic;

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
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            var newList = new List<string>(languages);
            newList.AddRange(languages); 
            newList.Add(language);       
            return newList;
        }

        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        public static List<string> ReverseList(List<string> languages)
        {
            var reversedList = new List<string>(languages);
            reversedList.Reverse();
            return reversedList;
        }

        public static bool IsExciting(List<string> languages)
        {
            if (languages == null || languages.Count == 0)
                return false;

            if (languages[0] == "C#")
                return true;

            if (languages.Count >= 2 && (languages.Count == 2 || languages.Count == 3) && languages[1] == "C#")
                return true;

            return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            var newList = new List<string>(languages);
            newList.Remove(language);
            return newList;
        }

        public static bool IsUnique(List<string> languages)
        {
            var set = new HashSet<string>();
            foreach (var language in languages)
            {
                if (!set.Add(language))
                    return false;
            }
            return true;
        }
    }
}
