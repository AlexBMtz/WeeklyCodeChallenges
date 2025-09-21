using System;
using System.Collections.Generic;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            };
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var existingDictionary = GetEmptyDictionary();
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary == null)
                throw new ArgumentNullException(nameof(existingDictionary));

            if (existingDictionary.TryGetValue(countryCode, out string existingCountryName))
                return existingDictionary;

            existingDictionary[countryCode] = countryName;
            return existingDictionary;

        }

        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            {
                if (existingDictionary == null)
                    throw new ArgumentNullException(nameof(existingDictionary));

                if (existingDictionary.TryGetValue(countryCode, out string countryName))
                    return countryName;

                return string.Empty;
            }
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            if (existingDictionary == null)
                throw new ArgumentNullException(nameof(existingDictionary));

            return existingDictionary.ContainsKey(countryCode);
        }

        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary == null)
                throw new ArgumentNullException(nameof(existingDictionary));

            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            if (existingDictionary == null)
                throw new ArgumentNullException(nameof(existingDictionary));

            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            if (existingDictionary == null)
                throw new ArgumentNullException(nameof(existingDictionary));

            string longestName = string.Empty;
            int maxLength = 0;

            foreach (var country in existingDictionary.Values)
            {
                if (country != null && country.Length > maxLength)
                {
                    longestName = country;
                    maxLength = country.Length;
                }
            }

            return longestName;
        }
    }
}
