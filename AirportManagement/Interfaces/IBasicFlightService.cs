using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IBasicFlightService
    {
        void ShowFlights(string filterType, string filterValue);
        IEnumerable<(int FlightId, double Duration)> GetDurationsInMinutes();
        IEnumerable<(int FlightId, double Duration)> GetDurationsInMinutesLINQ();
        IEnumerable<Flight> GetFlightsSortedByDuration();
        double GetDurationsAverage();
        IEnumerable<string> GetPassengerTypes(int flightId);
    }
}
