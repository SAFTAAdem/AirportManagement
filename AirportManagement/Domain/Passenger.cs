using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string TelNumber { get; set; }          
        public DateTime BirthDate { get; set; }
        public virtual string PassengerType => "Unknown passenger type";

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({PassportNumber}) - {EmailAddress ?? "pas d'email"} - Né le {BirthDate:dd/MM/yyyy}";
        }
    }
}
