using AirportManagement.Domain;
using System;
using System.Collections.Generic;

namespace AirportManagement
{
    public static class InMemorySource
    {
        // Avions
        public static Plane Boeing1 { get; private set; }

        public static Plane Boeing2 { get; } = CreateBoeing2();

        public static readonly Plane Airbus = new Plane
        {
            PlaneId = 3,
            PlaneType = PlaneType.Airbus,
            Capacity = 250,
            ManufactureDate = new DateTime(2020, 11, 11)
        };

        // Liste de tous les Staffs (déclarée avant Flights)
        public static readonly IList<Staff> Staffs = new List<Staff>
        {
            new Staff
            {
                PassportNumber = "CAP001",
                FirstName = "captain",
                LastName = "Captain",
                EmailAddress = "captain@gmail.com",
                TelNumber = null,
                BirthDate = new DateTime(1965, 1, 1),
                Function = "Pilot",
                Salary = 10000,
                EmploymentDate = new DateTime(1999, 1, 1)
            },
            new Staff
            {
                PassportNumber = "HOS001",
                FirstName = "hostess1",
                LastName = "Hostess1",
                EmailAddress = "hostess1@gmail.com",
                TelNumber = null,
                BirthDate = new DateTime(1995, 1, 1),
                Function = "Hostess",
                Salary = 5000,
                EmploymentDate = new DateTime(2019, 1, 1)
            },
            new Staff
            {
                PassportNumber = "HOS002",
                FirstName = "hostess2",
                LastName = "Hostess2",
                EmailAddress = "hostess2@gmail.com",
                TelNumber = null,
                BirthDate = new DateTime(1996, 1, 1),
                Function = "Hostess",
                Salary = 6100,
                EmploymentDate = new DateTime(2018, 1, 1)
            }
        };

        // Liste de tous les Travellers (déclarée avant Flights)
        public static readonly IList<Traveller> Travellers = new List<Traveller>
        {
            new Traveller
            {
                PassportNumber = "TRV001",
                FirstName = "traveller1",
                LastName = "Traveller1",
                BirthDate = new DateTime(1980, 1, 1),
                HealthInformation = "No troubles",
                Nationality = "American"
            },
            new Traveller
            {
                PassportNumber = "TRV002",
                FirstName = "traveller2",
                LastName = "Traveller2",
                BirthDate = new DateTime(1981, 1, 1),
                HealthInformation = "Some troubles",
                Nationality = "French"
            },
            new Traveller
            {
                PassportNumber = "TRV003",
                FirstName = "traveller3",
                LastName = "Traveller3",
                BirthDate = new DateTime(1982, 1, 1),
                HealthInformation = "No troubles",
                Nationality = "Tunisian"
            },
            new Traveller
            {
                PassportNumber = "TRV004",
                FirstName = "traveller4",
                LastName = "Traveller4",
                BirthDate = new DateTime(1983, 1, 1),
                HealthInformation = "Some troubles",
                Nationality = "American"
            },
            new Traveller
            {
                PassportNumber = "TRV005",
                FirstName = "traveller5",
                LastName = "Traveller5",
                BirthDate = new DateTime(1984, 1, 1),
                HealthInformation = "Some troubles",
                Nationality = "Spanish"
            }
        };

        // Liste de tous les Flights avec relations Plane et Passengers remplies
        public static readonly IList<Flight> Flights = new List<Flight>
        {
            // Vol 1 → Boeing1 + tous les Staffs
            new Flight
            {
                FlightId = 1,
                FlightDate = new DateTime(2022, 1, 1, 15, 10, 0),
                Destination = "Paris",
                EffectiveArrival = new DateTime(2022, 1, 1, 17, 10, 0),
                EstimatedDuration = 2f,
                Plane = Boeing1,
                Passengers = new List<Passenger>(Staffs)
            },

            // Vol 2 → Boeing2 + tous les Travellers
            new Flight
            {
                FlightId = 2,
                FlightDate = new DateTime(2022, 2, 1, 21, 10, 0),
                Destination = "Paris",
                EffectiveArrival = new DateTime(2022, 2, 1, 23, 10, 0),
                EstimatedDuration = 2f,
                Plane = Boeing2,
                Passengers = new List<Passenger>(Travellers)
            },

            // Vol 3 → Airbus + tous les passagers (Staffs + Travellers)
            new Flight
            {
                FlightId = 3,
                FlightDate = new DateTime(2022, 3, 1, 5, 10, 0),
                Destination = "Paris",
                EffectiveArrival = new DateTime(2022, 3, 1, 7, 10, 0),
                EstimatedDuration = 2f,
                Plane = Airbus,
                Passengers = new List<Passenger>(GetAllPassengers())
            },

            // Vol 4 → Airbus (sans passagers)
            new Flight
            {
                FlightId = 4,
                FlightDate = new DateTime(2022, 4, 1, 6, 10, 0),
                Destination = "Madrid",
                EffectiveArrival = new DateTime(2022, 4, 1, 8, 40, 0),
                EstimatedDuration = 2.5f,
                Plane = Airbus,
                Passengers = new List<Passenger>()
            },

            // Vol 5 → Airbus (sans passagers)
            new Flight
            {
                FlightId = 5,
                FlightDate = new DateTime(2022, 5, 1, 17, 10, 0),
                Destination = "Madrid",
                EffectiveArrival = new DateTime(2022, 5, 1, 19, 40, 0),
                EstimatedDuration = 2.5f,
                Plane = Airbus,
                Passengers = new List<Passenger>()
            },

            // Vol 6 → Airbus (sans passagers)
            new Flight
            {
                FlightId = 6,
                FlightDate = new DateTime(2022, 6, 1, 20, 10, 0),
                Destination = "Lisbonne",
                EffectiveArrival = new DateTime(2022, 6, 1, 23, 10, 0),
                EstimatedDuration = 3f,
                Plane = Airbus,
                Passengers = new List<Passenger>()
            }
        };

        // Constructeur statique
        static InMemorySource()
        {
            Boeing1 = CreateBoeing1();
        }

        // Méthode helper pour Boeing1
        private static Plane CreateBoeing1()
        {
            Plane plane = new Plane();
            plane.PlaneId = 1;
            plane.PlaneType = PlaneType.Boeing;
            plane.Capacity = 200;
            plane.ManufactureDate = new DateTime(2019, 12, 31);
            return plane;
        }

        // Méthode helper pour Boeing2
        private static Plane CreateBoeing2()
        {
            return new Plane(PlaneType.Boeing, 150, new DateTime(2015, 2, 3));
        }

        // Méthode helper pour obtenir tous les passagers (utilisée pour le vol 3)
        private static IList<Passenger> GetAllPassengers()
        {
            var all = new List<Passenger>();
            all.AddRange(Staffs);
            all.AddRange(Travellers);
            return all;
        }
    }
}