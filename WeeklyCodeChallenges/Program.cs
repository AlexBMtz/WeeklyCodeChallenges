using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Calling
{
    public class Program
    {
        public static void Main()
        {
            var empty = DialingCodes.GetEmptyDictionary();
            Console.WriteLine("Empty dict count: " + empty.Count);

            var existing = DialingCodes.GetExistingDictionary();
            Console.WriteLine("Existing dict: " + string.Join(", ", existing));

            var newDict = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
            Console.WriteLine("New dict: " + string.Join(", ", newDict));

            DialingCodes.AddCountryToExistingDictionary(existing, 44, "United Kingdom");
            Console.WriteLine("Updated dict: " + string.Join(", ", existing));

            Console.WriteLine("Code 55 => " + DialingCodes.GetCountryNameFromDictionary(existing, 55));
            Console.WriteLine("Code 999 => " + DialingCodes.GetCountryNameFromDictionary(existing, 999));

            Console.WriteLine("Exists 55? " + DialingCodes.CheckCodeExists(existing, 55));

            DialingCodes.UpdateDictionary(existing, 1, "Les États-Unis");
            Console.WriteLine("After update: " + string.Join(", ", existing));

            DialingCodes.RemoveCountryFromDictionary(existing, 91);
            Console.WriteLine("After remove: " + string.Join(", ", existing));

            Console.WriteLine("Longest name: " + DialingCodes.FindLongestCountryName(existing));
        }
    }

}

