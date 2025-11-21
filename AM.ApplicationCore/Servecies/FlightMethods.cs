using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Servecies
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; }
         = new List<Flight>();
        
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> result = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                    result.Add(Flights[i].FlightDate);
            }
            return result;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "EstimatedDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration == double.Parse(filterValue))
                            Console.WriteLine(flight);
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))

                            Console.WriteLine(flight);
                    }
                    break;
            }
        }
    }
}
