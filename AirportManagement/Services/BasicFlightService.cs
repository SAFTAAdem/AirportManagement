using System;
using System.Collections.Generic;
using System.Linq;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore;

namespace AM.ApplicationCore.Services
{
    public class BasicFlightService : IBasicFlightService
    {
        private IEnumerable<Flight> source;
        private ShowLine showLine;

        public BasicFlightService(IEnumerable<Flight> flights, ShowLine showLine)
        {
            this.source = flights;
            this.showLine = showLine;
        }

        public void ShowFlights(string filterType, string filterValue)
        {
            showLine($"Filter Type: {filterType}");
            showLine($"Filter Value: {filterValue}");

            switch (filterType)
            {
                case "Destination":
                    foreach (var f in source.Where(f => f.Destination == filterValue))
                        showLine(f.ToString());
                    break;

                case "FlightDate":
                    DateTime fd = DateTime.Parse(filterValue);
                    foreach (var f in source.Where(f => f.FlightDate == fd))
                        showLine(f.ToString());
                    break;

                case "FlightId":
                    int id = int.Parse(filterValue);
                    foreach (var f in source.Where(f => f.FlightId == id))
                        showLine(f.ToString());
                    break;

                default:
                    throw new ArgumentException("Unknown filter");
            }
        }



        public IEnumerable<(int FlightId, double Duration)> GetDurationsInMinutes()
        {
            foreach (var f in source)
                yield return (f.FlightId, (double)(f.EstimatedDuration * 60));
        }

        public IEnumerable<(int FlightId, double Duration)> GetDurationsInMinutesLINQ()
        {
            return source.Select(f => (f.FlightId, (double)(f.EstimatedDuration * 60)));
        }

        public IEnumerable<Flight> GetFlightsSortedByDuration()
        {
            return source.OrderByDescending(f => f.EstimatedDuration);
        }

        public double GetDurationsAverage()
        {
            return source.Average(f => f.EstimatedDuration);
        }

        public IEnumerable<string> GetPassengerTypes(int flightId)
        {
            var flight = source.FirstOrDefault(f => f.FlightId == flightId);
            if (flight == null) return new List<string>();
            return flight.Passengers.Select(p => p.PassengerType);
        }
    }
}