using System;
using System.Collections.Generic;
using System.Linq;

namespace International_Calling_Connoisseur
{
    public static class DialingCodes
    {

        // 1) Método para obtener un diccionario vacío
        // Por ejemplo, si en otra parte del proyecto quiero pedir al usuario que agregue países,
        // puedo usar este método para inicializar el diccionario.
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        // 2) Método para obtener un diccionario prellenado con tres países
        // Esto sirve para pruebas rápidas o para tener un ejemplo de diccionario ya cargado
        // con datos válidos que puedo usar sin tener que escribir todo cada vez.
        public static Dictionary<int, string> GetExistingDictionary()
        {
            return new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            };
        }


        // 3) Agrega un país a un diccionario vacío
        // Este método es práctico cuando se empieza con un diccionario vacío pero quiero
        // agregar un país directamente sin tener que llamar primero a GetEmptyDictionary().
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>();
            dict[countryCode] = countryName;
            return dict;
        }

        // 4) Agrega un país a un diccionario existente
        // Aquí se crea una copia del diccionario original para no modificar el que se pasó.
        // Esto es útil porque en muchos escenarios quiero mantener intacto el diccionario original
        // y trabajar con una versión actualizada sin afectar otras partes del programa.
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>(existingDictionary);
            dict[countryCode] = countryName; // agrega o actualiza el país
            return dict;
        }

        // 5) Obtener el nombre de un país según su código
        // Se usa un TryGetValue porque así evito errores si el código no existe.
        // Si no está, devuelve string.Empty, así se puede manejar fácilmente en la interfaz o en pruebas.
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode)
               ? existingDictionary[countryCode]
               : string.Empty;
        }


        // 6) Verificar si un código existe
        // Es útil antes de actualizar o eliminar un país para no causar errores.
        // También sirve para condicionales, por ejemplo: "Si el país ya existe, no lo agrego de nuevo".
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }


        // 7) Actualizar el nombre de un país
        // Se copia el diccionario original para no modificarlo directamente.
        // Solo se actualiza si la clave existe, así evitamos agregar datos por accidente.
        // Es útil cuando quiero que los datos solo cambien si el país ya estaba registrado.
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            var dict = new Dictionary<int, string>(existingDictionary);
            if (dict.ContainsKey(countryCode))
            {
                dict[countryCode] = countryName;
            }
            return dict;
        }

        // 8) Eliminar un país del diccionario
        // Se copia el diccionario original y después Remove.
        // Remove no lanza error si el país no existe.
        // Permite limpiar diccionarios sin preocuparme por romper los datos originales.
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            var dict = new Dictionary<int, string>(existingDictionary);
            dict.Remove(countryCode);
            return dict;
        }

        // 9) Encontrar el país con el nombre más largo
        // Retorna vacío si el diccionario está vacío para evitar errores.
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            if (!existingDictionary.Any()) return string.Empty;
            return existingDictionary.Values.OrderByDescending(v => v.Length).First();
        
        }
    }
}
