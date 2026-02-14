using System;
using System.Collections.Generic;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public float EstimatedDuration { get; set; }

        // Clé étrangère obligatoire pour EF Core
        public int PlaneId { get; set; }

        // Navigation vers l'avion (déjà présente)
        public Plane Plane { get; set; }

        // Navigation vers les passagers
        public IList<Passenger> Passengers { get; set; } = new List<Passenger>();

        public override string ToString()
        {
            return $"FlightId : {FlightId}, Destination : {Destination}, FlightDate : {FlightDate}";
        }
    }
}