using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Domain
{
    public class Staff : Passenger
    {
        public string Function { get; set; }
        public double Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
        public override string PassengerType => "Staff passenger type";

        public override string ToString()
        {
            return base.ToString() +
                   $" | Fonction : {Function} | Salaire : {Salary:C} | Embauché le {EmploymentDate:dd/MM/yyyy}";
        }

    }
}
