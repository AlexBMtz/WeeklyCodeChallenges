using System;
using System.Collections.Generic;
using Xunit;

namespace TracksOnTracksOnTracks
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Test 1
                Assert.Empty(Languages.NewList());
                Console.WriteLine("Test 1 Passed");

                //Test 2
                var expected = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.Equal(expected, Languages.GetExistingLanguages());
                Console.WriteLine("Test 2 Passed");

                //Test 3
                //expected.Add("C#");
                //expected.Add("Clojure");
                //expected.Add("Elm");
                expected.Add("Bash");
                var languages = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };

                Assert.Equal(expected, Languages.AddLanguage(languages, "Bash"));
                Console.WriteLine("Test 3 Passed");

                //Test 4
                expected = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };

                Assert.Equal(3, Languages.CountLanguages(expected));
                Console.WriteLine("Test 4 Passed");

                //Test 5
                expected = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.True(Languages.HasLanguage(expected, "Elm"));
                Console.WriteLine("Test 5 Passed");

                //Test 6
                expected = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.False(Languages.HasLanguage(expected, "D"));
                Console.WriteLine("Test 6 Passed");

                //Test 7
                expected = new List<string>
                {
                    "Elm",
                    "Clojure",
                    "C#"
                };

                languages = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.Equal(expected, Languages.ReverseList(languages));
                Console.WriteLine("Test 7 Passed");

                //Test 8
                expected = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.True(Languages.IsExciting(expected));

                languages = new List<string>
                {
                    "VBA",
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.False(Languages.IsExciting(languages));

                languages = new List<string>();
                Assert.False(Languages.IsExciting(languages));

                languages = new List<string>
                {
                    "C#"
                };
                Assert.True(Languages.IsExciting(languages));

                languages = new List<string>
                {
                    "F#",
                    "C#"
                };
                Assert.True(Languages.IsExciting(languages));

                languages = new List<string>
                {
                    "F#",
                    "C#",
                    "Clojure"
                };
                Assert.True(Languages.IsExciting(languages));

                Console.WriteLine("Test 8 Passed");


                //Test 9
                expected = new List<string>
                {
                    "C#",
                    "Elm"
                };
                languages = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.Equal(expected, Languages.RemoveLanguage(languages, "Clojure"));

                expected = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };

                languages = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.Equal(expected, Languages.RemoveLanguage(languages, "English"));
                Console.WriteLine("Test 9 Passed");

                languages = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm"
                };
                Assert.True(Languages.IsUnique(languages));

                languages = new List<string>
                {
                    "C#",
                    "Clojure",
                    "Elm",
                    "C#"
                };
                Assert.False(Languages.IsUnique(languages));
                Console.WriteLine("Test 10 Passed");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Testing failed: {ex.Message}");
            }

        }
    }
}
