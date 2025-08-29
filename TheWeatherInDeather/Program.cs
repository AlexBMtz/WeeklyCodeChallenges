using System;
using Xunit;

namespace TheWeatherInDeather
{
    /*** Please do not modify this code ***/
    public class Program
    {
        static void Main()
        {
            var ws = new WeatherStation();

            //Test 1 - Get reading
            RunTest("Test 1", () =>
            {
                ws.AcceptReading(new Reading(20m, 25m, 0.01m, WindDirection.Unknown));
                decimal[] expected = { 20, 25, 0.01m };
                decimal[] actual = { ws.LatestTemperature, ws.LatestPressure, ws.LatestRainfall };
                Assert.Equal(expected, actual);
            });

            //Test 2 - Has History No
            RunTest("Test 2", () =>
            {
                ws.ClearAll();
                Assert.False(ws.HasHistory);
            });

            //Test 3 - Has History Yes
            RunTest("Test 3", () =>
            {
                ws.AcceptReading(new Reading(20m, 25m, 0.01m, WindDirection.Unknown));
                ws.AcceptReading(new Reading(21m, 25m, 0.00m, WindDirection.Unknown));
                Assert.True(ws.HasHistory);
            });

            //Test 4 - Clear All
            RunTest("Test 4", () =>
            {
                ws.AcceptReading(new Reading(20m, 25m, 0.01m, WindDirection.Unknown));
                ws.AcceptReading(new Reading(21m, 25m, 0.00m, WindDirection.Unknown));
                ws.ClearAll();
                object[] expectedValues = { false, 0m };
                object[] actualValues = { ws.HasHistory, ws.LatestTemperature };
                Assert.Equal(expectedValues, actualValues);
            });

            RunTest("Test 5", () =>
            {
                //Test 5 - ShortTermOutlook Exception
                //NOTE: An Exception is expected here
                Assert.Throws<ArgumentException>(() => ws.ShortTermOutlook);

                //Test 6 - ShortTermOutlook Cool
                ws.AcceptReading(new Reading(7m, 7m, 0m, WindDirection.Unknown));
                Assert.Equal(Outlook.Cool, ws.ShortTermOutlook);

                //Test 7 - ShortTermOutlook Good
                ws.AcceptReading(new Reading(55m, 7m, 0m, WindDirection.Unknown));
                Assert.Equal(Outlook.Good, ws.ShortTermOutlook);

                //Test 8 - ShortTermOutlook warm
                ws.AcceptReading(new Reading(40m, 7m, 0m, WindDirection.Unknown));
                Assert.Equal(Outlook.Warm, ws.ShortTermOutlook);

                //Test 9 - RunSelftTest good
                ws.AcceptReading(new Reading(40m, 7m, 0m, WindDirection.Unknown));
                Assert.Equal(State.Good, ws.RunSelfTest());

                //Test 10 - RunSelfTest bad
                ws.ClearAll();
                Assert.Equal(State.Bad, ws.RunSelfTest());

                //Test 11 - LongTermOutlook exception
                //NOTE: An Exception is expected here
                Assert.Throws<ArgumentException>(() => ws.LongTermOutlook);

                //Test 12 - LongTermOutlook cool
                ws.AcceptReading(new Reading(7m, 7m, 0m, WindDirection.Northerly));
                Assert.Equal(Outlook.Cool, ws.LongTermOutlook);

                //Test 13 - LongTermOutlook good
                ws.AcceptReading(new Reading(21m, 7m, 0m, WindDirection.Easterly));
                Assert.Equal(Outlook.Good, ws.LongTermOutlook);

                //Test 14 - LongTermOutlook good2
                ws.AcceptReading(new Reading(7m, 7m, 0m, WindDirection.Southerly));
                Assert.Equal(Outlook.Good, ws.LongTermOutlook);

                //Test 15 - LongTermOutlook warm
                ws.AcceptReading(new Reading(7m, 7m, 0m, WindDirection.Easterly));
                Assert.Equal(Outlook.Warm, ws.LongTermOutlook);

                //Test 16 - LongTermOutlook rainy
                ws.AcceptReading(new Reading(21m, 7m, 0m, WindDirection.Westerly));
                Assert.Equal(Outlook.Rainy, ws.LongTermOutlook);
            });

            Console.WriteLine("\nTodas las pruebas han terminado exitosamente.");
        }

        static void RunTest(string name, Action test)
        {
            try
            {
                test();
                Console.WriteLine($"{name} pasó correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{name} falló: {ex.Message}");
            }
        }
    }
}
