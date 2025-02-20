using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
Passenger pass1 = new Passenger
{
    FirstName = "melek",
    LastName = "messaoudi",
    EmailAddress = "melek@gmail.com"
};
Console.WriteLine(pass1.checkprofile("messaoudi", "melek"));
Console.WriteLine(pass1.checkprofile("messaoudi", "melek", "melek@gmail.com"));
Staff s = new Staff { };
Traveller tr = new Traveller { };
pass1.PassengerType();
s.PassengerType();
tr.PassengerType();



FlightMethods fm = new FlightMethods();
fm.flights = TestData.listFlights;
for(int i = 0; i < fm.flights.Count; i++)
{
    Console.WriteLine(fm.flights[i]);
}

var flightsDate = fm.GetFlightDate("Paris");
foreach (var date in flightsDate)
{
    Console.WriteLine(date);
}

Console.WriteLine("************");

fm.showFlightsDetails(TestData.BoingPlane);
Console.WriteLine("************");
fm.showFlightsDetails(TestData.Airbusplane);

Console.WriteLine("************");

fm.ProgrammedFlightNumber(new DateTime(2022, 02, 01));

Console.WriteLine("************");

Console.WriteLine(fm.DurationAverage("Paris"));
Console.WriteLine("******************");

Console.WriteLine("********OrderedDurationFlights**********");
foreach (var item in fm.OrderedDurationFlights())
{ Console.WriteLine(item.EstimatedDuration); }
Console.WriteLine("********SeniorTravellers**********");
foreach (var item in fm.SeniorTravellers(TestData.flight1))
{ Console.WriteLine(item.FirstName+" "+ item.BirthDate); }
Console.WriteLine("********DestinationGroupFlights**********");
fm.DestinationGroupFlights();
Console.WriteLine("********Methode extention**********");

Console.WriteLine("*********BeforeUpperFullName*********");

Passenger p = TestData.p;
Console.WriteLine(p.LastName + " " + p.FirstName);
p.UpperFullName();
Console.WriteLine("*********UpperFullName*********");
Console.WriteLine(p.LastName+" "+p.FirstName);


//Console.WriteLine(fm.flights);


//fm.GetFlights("Destination", "Paris");