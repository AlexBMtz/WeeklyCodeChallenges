using System;

namespace BirdCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Don't touch this section since it's part of the testing scenarios.
            //To test your code execute the app and verify the outputs.
            Console.WriteLine("=== Pruebas BirdCount ===");

            // Datos de prueba
            int[] counts = { 0, 2, 5, 3, 7, 8, 4 };
            BirdCount birdCount = new BirdCount(counts);

            // 1. Probar LastWeek()
            Console.WriteLine("\n1) LastWeek():");
            Console.WriteLine("Esperado: 0 2 5 3 7 8 4");
            Console.WriteLine("Obtenido: " + string.Join(" ", BirdCount.LastWeek()));

            // 2. Probar Today()
            Console.WriteLine("\n2) Today():");
            Console.WriteLine($"Esperado: 3, Obtenido: {birdCount.Today()}");

            // 3. Probar IncrementTodaysCount()
            Console.WriteLine("\n3) IncrementTodaysCount():");
            birdCount.IncrementTodaysCount();
            Console.WriteLine($"Esperado: 4, Obtenido: {birdCount.Today()}");

            // 4. Probar HasDayWithoutBirds()
            Console.WriteLine("\n4) HasDayWithoutBirds():");
            Console.WriteLine($"Esperado: True, Obtenido: {birdCount.HasDayWithoutBirds()}");

            // 5. Probar CountForFirstDays()
            Console.WriteLine("\n5) CountForFirstDays(4):");
            Console.WriteLine($"Esperado: 14, Obtenido: {birdCount.CountForFirstDays(4)}");

            // 6. Probar BusyDays()
            Console.WriteLine("\n6) BusyDays():");
            Console.WriteLine($"Esperado: 2, Obtenido: {birdCount.BusyDays()}");

            Console.WriteLine("\n=== Fin de pruebas ===");
        }
    }
}
