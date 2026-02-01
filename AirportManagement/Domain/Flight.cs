using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }          
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public float EstimatedDuration { get; set; } 

        
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }

        public IList<Passenger> Passengers { get; set; } = new List<Passenger>();

        public override string ToString()
        {
            string avion = Plane != null ? Plane.ToString() : "Aucun avion assigné";
            return $"Vol {FlightId} | {FlightDate:dd/MM/yyyy HH:mm} → {Destination} | Durée estimée : {EstimatedDuration}h | " +
                   $"Arrivée : {EffectiveArrival:HH:mm} | Avion : {avion} | {Passengers.Count} passagers";
        }

    }
}
