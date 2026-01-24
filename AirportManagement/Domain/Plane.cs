using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane
    {
        public Plane(){}
        public Plane(PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            PlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
        }
        public int PlaneId { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

    }
}
