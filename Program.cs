using System;
using Xunit;

namespace International_Calling_Connoisseur
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var emptyDict = DialingCodes.GetEmptyDictionary();
                Assert.Empty(emptyDict);
                Console.WriteLine("Test 1 Passed");

                var prePopulated = DialingCodes.GetExistingDictionary();
                Assert.Equal(3, prePopulated.Count);
                Console.WriteLine("Test 2 Passed");

                prePopulated = DialingCodes.GetExistingDictionary();
                Assert.Equal("United States of America", prePopulated[1]);
                Console.WriteLine("Test 3 Passed");

                prePopulated = DialingCodes.GetExistingDictionary();
                Assert.Equal("Brazil", prePopulated[55]);
                Console.WriteLine("Test 4 Passed");

                prePopulated = DialingCodes.GetExistingDictionary();
                Assert.Equal("India", prePopulated[91]);
                Console.WriteLine("Test 5 Passed");
                var countryCodes = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
                Assert.Single(countryCodes);
                Console.WriteLine("Test 6 Passed");

                countryCodes = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
                Assert.Equal("United Kingdom", countryCodes[44]);
                Console.WriteLine("Test 7 Passed");

                countryCodes = DialingCodes.AddCountryToExistingDictionary(
            DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
                Assert.Equal(4, countryCodes.Count);
                Console.WriteLine("Test 8 Passed");

                countryCodes = DialingCodes.AddCountryToExistingDictionary(
            DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
                Assert.Equal("United States of America", countryCodes[1]);
                Console.WriteLine("Test 9 Passed");

                countryCodes = DialingCodes.AddCountryToExistingDictionary(
            DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
                Assert.Equal("United Kingdom", countryCodes[44]);
                Console.WriteLine("Test 10 Passed");

                countryCodes = DialingCodes.AddCountryToExistingDictionary(
            DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
                Assert.Equal("Brazil", countryCodes[55]);
                Console.WriteLine("Test 11 Passed");

                countryCodes = DialingCodes.AddCountryToExistingDictionary(
            DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
                Assert.Equal("India", countryCodes[91]);
                Console.WriteLine("Test 12 Passed");

                var countryName = DialingCodes.GetCountryNameFromDictionary(
            DialingCodes.GetExistingDictionary(), 55);
                Assert.Equal("Brazil", countryName);
                Console.WriteLine("Test 13 Passed");

                countryName = DialingCodes.GetCountryNameFromDictionary(
           DialingCodes.GetExistingDictionary(), 999);
                Assert.Equal(string.Empty, countryName);
                Console.WriteLine("Test 14 Passed");

                var exists = DialingCodes.CheckCodeExists(
            DialingCodes.GetExistingDictionary(), 55);
                Assert.True(exists);
                Console.WriteLine("Test 15 Passed");

                exists = DialingCodes.CheckCodeExists(
            DialingCodes.GetExistingDictionary(), 999);
                Assert.False(exists);
                Console.WriteLine("Test 16 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
           DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
                Assert.Equal(3, countryCodes.Count);
                Console.WriteLine("Test 17 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
            DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
                Assert.Equal("les États-Unis", countryCodes[1]);
                Console.WriteLine("Test 18 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
            DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
                Assert.Equal("Brazil", countryCodes[55]);
                Console.WriteLine("Test 19 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
            DialingCodes.GetExistingDictionary(), 1, "les États-Unis");
                Assert.Equal("India", countryCodes[91]);
                Console.WriteLine("Test 20 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
            DialingCodes.GetExistingDictionary(), 999, "Newlands");
                Assert.Equal(3, countryCodes.Count);
                Console.WriteLine("Test 21 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
            DialingCodes.GetExistingDictionary(), 999, "Newlands");
                Assert.Equal("United States of America", countryCodes[1]);
                Console.WriteLine("Test 22 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
           DialingCodes.GetExistingDictionary(), 999, "Newlands");
                Assert.Equal("Brazil", countryCodes[55]);
                Console.WriteLine("Test 23 Passed");

                countryCodes = DialingCodes.UpdateDictionary(
            DialingCodes.GetExistingDictionary(), 999, "Newlands");
                Assert.Equal("India", countryCodes[91]);
                Console.WriteLine("Test 24 Passed");

                countryCodes = DialingCodes.RemoveCountryFromDictionary(
           DialingCodes.GetExistingDictionary(), 91);
                Assert.Equal(2, countryCodes.Count);
                Console.WriteLine("Test 25 Passed");

                countryCodes = DialingCodes.RemoveCountryFromDictionary(
            DialingCodes.GetExistingDictionary(), 91);
                Assert.Equal("United States of America", countryCodes[1]);
                Console.WriteLine("Test 26 Passed");

                countryCodes = DialingCodes.RemoveCountryFromDictionary(
            DialingCodes.GetExistingDictionary(), 91);
                Assert.Equal("Brazil", countryCodes[55]);
                Console.WriteLine("Test 27 Passed");

                countryCodes = DialingCodes.RemoveCountryFromDictionary(
            DialingCodes.GetExistingDictionary(), 999);
                Assert.Equal(3, countryCodes.Count);
                Console.WriteLine("Test 28 Passed");

                countryCodes = DialingCodes.RemoveCountryFromDictionary(
           DialingCodes.GetExistingDictionary(), 999);
                Assert.Equal("United States of America", countryCodes[1]);
                Console.WriteLine("Test 29 Passed");

                countryCodes = DialingCodes.RemoveCountryFromDictionary(
            DialingCodes.GetExistingDictionary(), 999);
                Assert.Equal("Brazil", countryCodes[55]);
                Console.WriteLine("Test 30 Passed");

                countryCodes = DialingCodes.RemoveCountryFromDictionary(
            DialingCodes.GetExistingDictionary(), 999);
                Assert.Equal("India", countryCodes[91]);
                Console.WriteLine("Test 31 Passed");

                countryCodes = DialingCodes.AddCountryToExistingDictionary(
            DialingCodes.GetExistingDictionary(), 263, "Zimbabwe");
                var longestCountryName = DialingCodes.FindLongestCountryName(countryCodes);
                Assert.Equal("United States of America", longestCountryName);
                Console.WriteLine("Test 32 Passed");

                longestCountryName = DialingCodes.FindLongestCountryName(
            DialingCodes.GetEmptyDictionary());
                Assert.Equal(string.Empty, longestCountryName);
                Console.WriteLine("Test 33 Passed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Testing failed: {ex.Message}");
            }

        }
    }
}
