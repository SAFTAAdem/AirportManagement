using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Domain
{
    public class Traveller : Passenger
    {
        public string Nationality { get; set; }
        public string HealthInformation { get; set; }
        public override string PassengerType => "Traveller passenger type";
        public override string ToString()
        {
            return base.ToString() +
                   $" | Nationalité : {Nationality} | Santé : {HealthInformation ?? "non renseigné"}";
        }
    }
}
