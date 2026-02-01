using System;
using System.Linq;
using AirportManagement;           
using AirportManagement.Domain;   

namespace AirportManagement.ConsoleTest  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TEST ToString() et PassengerType ===\n");

            // Un staff
            var captain = InMemorySource.Staffs.First();
            Console.WriteLine(captain);
            Console.WriteLine($"Type : {captain.PassengerType}\n");

            // Un traveller
            var traveller = InMemorySource.Travellers.First();
            Console.WriteLine(traveller);
            Console.WriteLine($"Type : {traveller.PassengerType}\n");

            // Un vol (pour voir l'affichage complet)
            var vol1 = InMemorySource.Flights.First();
            Console.WriteLine(vol1);
            Console.WriteLine($"Type du premier passager du vol 1 : {vol1.Passengers.First().PassengerType}");
        }
    }
}