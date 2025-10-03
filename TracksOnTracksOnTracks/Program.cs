using System;
using System.Collections.Generic;

namespace TracksOnTracksOnTracks
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Test 1
                if (Languages.NewList().Count != 0)
                    throw new Exception("Test 1 Failed");
                Console.WriteLine("Test 1 Passed");

                // Test 2
                var expected = new List<string> { "C#", "Clojure", "Elm" };
                if (!AreEqual(expected, Languages.GetExistingLanguages()))
                    throw new Exception("Test 2 Failed");
                Console.WriteLine("Test 2 Passed");

                // Test 3
                expected = new List<string> { "C#", "Clojure", "Elm", "Bash" };
                var languages = new List<string> { "C#", "Clojure", "Elm" };
                if (!AreEqual(expected, Languages.AddLanguage(languages, "Bash")))
                    throw new Exception("Test 3 Failed");
                Console.WriteLine("Test 3 Passed");

                // Test 4
                expected = new List<string> { "C#", "Clojure", "Elm" };
                if (Languages.CountLanguages(expected) != 3)
                    throw new Exception("Test 4 Failed");
                Console.WriteLine("Test 4 Passed");

                // Test 5
                if (!Languages.HasLanguage(expected, "Elm"))
                    throw new Exception("Test 5 Failed");
                Console.WriteLine("Test 5 Passed");

                // Test 6
                if (Languages.HasLanguage(expected, "D"))
                    throw new Exception("Test 6 Failed");
                Console.WriteLine("Test 6 Passed");

                // Test 7
                expected = new List<string> { "Elm", "Clojure", "C#" };
                languages = new List<string> { "C#", "Clojure", "Elm" };
                if (!AreEqual(expected, Languages.ReverseList(languages)))
                    throw new Exception("Test 7 Failed");
                Console.WriteLine("Test 7 Passed");

                // Test 8
                if (!Languages.IsExciting(new List<string> { "C#", "Clojure", "Elm" })) throw new Exception("Test 8.1 Failed");
                if (Languages.IsExciting(new List<string> { "VBA", "C#", "Clojure", "Elm" })) throw new Exception("Test 8.2 Failed");
                if (Languages.IsExciting(new List<string>())) throw new Exception("Test 8.3 Failed");
                if (!Languages.IsExciting(new List<string> { "C#" })) throw new Exception("Test 8.4 Failed");
                if (!Languages.IsExciting(new List<string> { "F#", "C#" })) throw new Exception("Test 8.5 Failed");
                if (!Languages.IsExciting(new List<string> { "F#", "C#", "Clojure" })) throw new Exception("Test 8.6 Failed");
                Console.WriteLine("Test 8 Passed");

                // Test 9
                expected = new List<string> { "C#", "Elm" };
                languages = new List<string> { "C#", "Clojure", "Elm" };
                if (!AreEqual(expected, Languages.RemoveLanguage(languages, "Clojure")))
                    throw new Exception("Test 9.1 Failed");

                expected = new List<string> { "C#", "Clojure", "Elm" };
                languages = new List<string> { "C#", "Clojure", "Elm" };
                if (!AreEqual(expected, Languages.RemoveLanguage(languages, "English")))
                    throw new Exception("Test 9.2 Failed");
                Console.WriteLine("Test 9 Passed");

                // Test 10
                languages = new List<string> { "C#", "Clojure", "Elm" };
                if (!Languages.IsUnique(languages)) throw new Exception("Test 10.1 Failed");

                languages = new List<string> { "C#", "Clojure", "Elm", "C#" };
                if (Languages.IsUnique(languages)) throw new Exception("Test 10.2 Failed");
                Console.WriteLine("Test 10 Passed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Testing failed: {ex.Message}");
            }
        }

        static bool AreEqual(List<string> a, List<string> b)
        {
            if (a.Count != b.Count) return false;
            for (int i = 0; i < a.Count; i++)
                if (a[i] != b[i]) return false;
            return true;
        }
    }
}