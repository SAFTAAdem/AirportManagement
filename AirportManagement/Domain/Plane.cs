using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Domain
{
    
    public class Plane
    {
        public int PlaneId { get; set; }  
        public PlaneType PlaneType { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public Plane() { }

        public Plane(PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            PlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
        }
        public override string ToString()
        {
            return $"Avion {PlaneId} - {PlaneType} - Capacité : {Capacity} places - Fabriqué le {ManufactureDate:dd/MM/yyyy}";
        }
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();

    }
}
