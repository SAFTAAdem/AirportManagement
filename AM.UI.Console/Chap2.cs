using System;
using AM.ApplicationCore;          // pour ShowLine et CoreExtensions
using AM.ApplicationCore.Domain;   // pour Flight, Passenger, etc.
using AM.ApplicationCore.Services; // pour BasicFlightService

namespace AM.UI.Console
{
    public class Chap2
    {
        // Définition du délégué static qui pointe vers Console.WriteLine
        public static ShowLine show = s => System.Console.WriteLine(s);
        // alternative : public static ShowLine show = s => Console.WriteLine(s);

        // =========================
        // TEST 1
        // =========================
        public static void Test1()
        {
            // Création du service avec source de vols et délégué show
            var service = new BasicFlightService(
                InMemorySource.Flights,
                show);

            // Tester ShowFlights avec différents filtres
            service.ShowFlights("Destination", "Paris");
            service.ShowFlights("Destination", "Madrid");
            service.ShowFlights("FlightId", "3");
        }

        // =========================
        // TEST 2 (Section III)
        // =========================
        public static void Test2()
        {
            var service = new BasicFlightService(
                InMemorySource.Flights,
                show);

            // Utilisation des méthodes LINQ / extensions pour afficher les listes
            service.GetDurationsInMinutes()
                   .ShowList("GetDurationsInMinutes", show);

            service.GetDurationsInMinutesLINQ()
                   .ShowList("GetDurationsInMinutesLINQ", show);

            service.GetFlightsSortedByDuration()
                   .ShowList("GetFlightsSortedByDuration", show);

            show("========== GetDurationsAverage ==========");
            show(service.GetDurationsAverage().ToString());

            service.GetPassengerTypes(3)
                   .ShowList("GetPassengerTypes", show);
        }
    }
}