// See https://aka.ms/new-console-template for more information



/*
Plane pl = new Plane();
pl.Capacity = 500;
pl.ManufactureDate = DateTime.Now;
pl.PlaneType = PlaneType.Boeing;
Console.WriteLine(pl);

Plane pl1 = new Plane(PlaneType.Airbus, 300, DateTime.Now);
Console.WriteLine(pl1);
*/

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Servecies;
using System;
/*
Plane pl3 = new Plane
{
    PlaneType = PlaneType.Boeing,
    Capacity = 400,
    ManufactureDate = DateTime.Now
    
};
Console.WriteLine(pl3);

Passenger p1 = new Passenger
{
    FirstName = "Hamdi",
    LastName = "Jaza",
    EmailAddress ="hamdi.jaza@esprit.tn"
};
Console.WriteLine("---Afficher passanger profile---");
Console.WriteLine(p1.ToString());

Console.WriteLine("---Afficher passanger profile---");
Console.WriteLine(p1.CheckProfile("Hamdi","Jaza"));

Console.WriteLine("---Afficher passanger profile---");
Console.WriteLine(p1.CheckProfile("Hamdi", "Jaza", "Hamdi.Jaza@esprit.tn"));

Staff staff1 = new Staff{};
Traveller traveller1 = new Traveller{};

Console.WriteLine("---Afficher type passanger---");
p1.PassengerType();
staff1.PassengerType();
traveller1.PassengerType();
*/

FlightMethods flightmethodes = new FlightMethods
{
    Flights = TestData.listFlights
};
foreach (var item in flightmethodes.GetFlightDates("Madrid"))
{
    Console.WriteLine("Date : " + item);

}
Console.WriteLine("Methodes GetFlights: ");
flightmethodes.GetFlights("Destination", "Madrid");
