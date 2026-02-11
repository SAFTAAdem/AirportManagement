using AirportManagement;           
using AirportManagement.Domain;   
using AirportManagement.Services;
using AM.ApplicationCore;
using System;
using System.Linq;

namespace AirportManagement.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== TESTS COMPLETS AIRPORT MANAGEMENT ===\n");

            // ----------------------------------------------------------------
            // Test ToString() et PassengerType (comme dans ton deuxième code)
            // ----------------------------------------------------------------
            Console.WriteLine("=== Test ToString() et PassengerType ===\n");

            // Un staff
            var captain = InMemorySource.Staffs.FirstOrDefault();
            if (captain != null)
            {
                Console.WriteLine(captain);
                Console.WriteLine($"Type : {captain.PassengerType}\n");
            }

            // Un traveller
            var traveller = InMemorySource.Travellers.FirstOrDefault();
            if (traveller != null)
            {
                Console.WriteLine(traveller);
                Console.WriteLine($"Type : {traveller.PassengerType}\n");
            }

            // Un vol (avec ToString() complet)
            var vol1 = InMemorySource.Flights.FirstOrDefault(f => f.FlightId == 1);
            if (vol1 != null)
            {
                Console.WriteLine(vol1);
                if (vol1.Passengers.Any())
                {
                    Console.WriteLine($"Type du premier passager du vol 1 : {vol1.Passengers.First().PassengerType}");
                }
            }

            // ----------------------------------------------------------------
            // Test ShowFlights + ShowList (avec délégué)
            // ----------------------------------------------------------------
            Console.WriteLine("\n=== Test ShowFlights et ShowList ===\n");

            // Création du délégué (pointe vers Console.WriteLine)
            ShowLine afficher = Console.WriteLine;

            // Création du service
            var service = new BasicFlightService(InMemorySource.Flights, afficher);

            // Test ShowFlights
            Console.WriteLine("Test ShowFlights - Vols vers Paris :");
            service.ShowFlights("destination", "Paris");

            Console.WriteLine("\nTest ShowFlights - Vol ID 3 :");
            service.ShowFlights("flightid", "3");

            // Test de la méthode d'extension ShowList
            Console.WriteLine("\nTest ShowList (extension) :");
            InMemorySource.Staffs.ShowList("Tous les staffs", afficher);
            InMemorySource.Travellers.ShowList("Tous les voyageurs", afficher);
            InMemorySource.Flights.ShowList("Tous les vols", afficher);

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}