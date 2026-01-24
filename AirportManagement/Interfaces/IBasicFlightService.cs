using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Interfaces
{
    public interface IBasicFlightService
    {
        void ShowFlights(string filterType, string filterValue);
    }
}
