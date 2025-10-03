using System;
using System.Collections.Generic;
using System.Linq;

namespace TracksOnTracksOnTracks
{
    public static class Languages
    {
        /// <summary>
        /// Metodo que regresa una lista vacia
        /// </summary>
        /// <returns>Lista vacia</returns>
        public static List<string> NewList()
        {
            return new List<string>();
        }
        /// <summary>
        /// Metodo que regresa la lista de lenguajes que se desea aprender
        /// </summary>
        /// <returns>Lista populada con los lenguajes</returns>
        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" }; //Instancia de nueva lista con valores predefinidos
        }
        /// <summary>
        /// Metodo qye agrega el lenguaje proporcionado por el usuario a la lista lenguajes
        /// </summary>
        /// <param name="languages">Lista de tipo string donde se almacenara el nuevo lenguaje</param>
        /// <param name="language">Lenguaje a aagregar</param>
        /// <returns>Lista actualizada</returns>
        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language); //Agregamos
            return languages; //Retornamos actualizado
        }

        /// <summary>
        /// Metodo que devuelve el numero de lenguajes dentro de la lista
        /// </summary>
        /// <param name="languages">Lista que se desea contar los elementos</param>
        /// <returns>Entero con el numero de elementos</returns>
        public static int CountLanguages(List<string> languages)
        {
            return languages.Count; //Obtenemos numero de elementos
        }

        /// <summary>
        /// Metodo que verifica si existe un lenguaje dentro de la lista proporcionada
        /// </summary>
        /// <param name="languages">Lista con los lenguajes a buscar</param>
        /// <param name="language">Lenguaje que se debe buscar</param>
        /// <returns>Verdadero o falso dependiendo si el lenguaje existe dentro de la lista o no</returns>
        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language); //Contains recibe el parametro a buscar
        }

        /// <summary>
        /// Metodo que invierta la lista 
        /// </summary>
        /// <param name="languages">Lista a invertir</param>
        /// <returns>Lista actualizada con los valores invertidos</returns>
        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse(); //Invierte el orden de los elementos
            return languages;
        }
        /// <summary>
        /// Metodo para determinar si una lista de lenguajes es interesante o no
        /// </summary>
        /// <param name="languages">Lista de lenguajes</param>
        /// <returns>Verdadero o falso</returns>
        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0)
            {

                return false; //Salimos si no contiene nada
            }
            if (languages[0] == "C#") //Si el lenguaje en el primer indice es C#:
            {
                return true; //Devolvemos true
            }
            if (languages[1] == "C#" && (languages.Count == 2 || languages.Count == 3))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Metodo que elimina una lista del lenguaje si existe
        /// </summary>
        /// <param name="languages">Lista donde se debe eliminar el valor</param>
        /// <param name="language">Lenguaje que se busca eliminar</param>
        /// <returns>Lista actualizada sin el valor</returns>
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language); // Elimina la primera coincidencia
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            return languages.Count == languages.Distinct().Count();
        }
    }
}
