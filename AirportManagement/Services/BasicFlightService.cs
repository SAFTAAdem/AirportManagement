using AirportManagement.Domain;
using AirportManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Services
{
    public class BasicFlightService : IBasicFlightService
    {
        private readonly ICollection<Flight> _flights;

        public BasicFlightService(ICollection<Flight> flights)
        {
            _flights = flights;
        }
        public void ShowFlights(string filterType, string filterValue)
        {
            // Liste pour stocker les vols filtrés
            IEnumerable<Flight> filteredFlights = _flights;

            // Filtrage selon le type
            switch (filterType.ToLower())
            {
                case "destination":
                    filteredFlights = _flights.Where(f => f.Destination.Equals(filterValue));
                    break;

                case "departure":
                    filteredFlights = _flights.Where(f => f.Departure.Equals(filterValue));
                    break;

                case "flightdate":
                    // Conversion de la chaîne en DateTime
                    if (DateTime.TryParse(filterValue, out DateTime date))
                    {
                        filteredFlights = _flights.Where(f => f.FlightDate.Date == date.Date);
                    }
                    else
                    {
                        throw new ArgumentException("Format de date invalide.");
                    }
                    break;

                case "flightid":
                    // Conversion en int
                    if (int.TryParse(filterValue, out int id))
                    {
                        filteredFlights = _flights.Where(f => f.FlightId == id);
                    }
                    else
                    {
                        throw new ArgumentException("L'ID du vol doit être un nombre.");
                    }
                    break;

                default:
                    throw new ArgumentException("Unknown filter");
            }

            // Affichage du résultat
            if (!filteredFlights.Any())
            {
                Console.WriteLine("Aucun vol trouvé avec ce filtre.");
                return;
            }

            foreach (var flight in filteredFlights)
            {
                Console.WriteLine(flight);
            }
        }
    }
}
