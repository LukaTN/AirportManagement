using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightsMethods
    {
        public delegate void FlightDetailsDel(Plane plane);
        public delegate double DurationAverageDel(string destination);

        public FlightMethods() {
            FlightDetailsDel flightDetailsDel = showFlightsDetails;
            DurationAverageDel durationAverageDel = DurationAverage;
        }

        public List<Flight> flights = new List<Flight>();





        public List<DateTime> GetFlightDate(string destination)
        {
            List<DateTime> date = new List<DateTime>();
            //for (int i = 0; i < flights.Count; i++)
            //{
            //    if (flights[i].Destination == destination)
            //    date.Add(flights[i].FlightDate);
            //}
            /*foreach (var flight in flights)
            {
                if (flight.Destination == destination)

                    date.Add(flight.FlightDate);
            }
            return date;*/
            //lambda expression
            return flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();

        }

        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            throw new NotImplementedException();
        }

        public void ProgrammedFlightNumber(DateTime startDate)
        {
            int i = 0;
            var req = from flight in flights
                      where flight.FlightDate >= startDate && flight.FlightDate <= startDate.AddDays(7)
                      select (flight);
            foreach (var item in req)
            {
                i++;
            }
            Console.WriteLine("Number of flights programmed for " + startDate + " is: " + i);



        }

        public int programmedFlightNumber(DateTime startDate)
        {
            /*var req = from flight in flights
                      where DateTime.Compare(startDate, flight.FlightDate) <= 0 && (flight.FlightDate - startDate).TotalDays <= 7 
                      select flight;
            return req.Count();  */
            return flights.Count(f => f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7));
        }

        public void showFlightsDetails(Plane plane)
        {
            /*var req = from flight in flights
                      where flight.Plane == plane
                      select new { flight.Destination, flight.FlightDate };*/

            var req = flights.Where(f => f.Plane == plane).Select(f => new { f.Destination, f.FlightDate });
            foreach (var item in req)
            {
                Console.WriteLine("Destination: " + item.Destination + ",Flight Date: " + item.FlightDate);
            }
        }
        public double DurationAverage(string destination)
        {
            /*var req = from flight in flights
                      where flight.Destination == destination
                      select flight.EstimatedDuration;
            return req.Average();*/

            return flights.Where(f => f.Destination == destination).Average(f => f.EstimatedDuration);

        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            /*var query = from f in flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query;*/
            return flights.OrderByDescending(f => f.EstimatedDuration);
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            /* var query = from item in flight.Passengers.OfType<Traveller>()
                         orderby item.BirthDate
                         select item;
             return query.Take(3);*/
            return flight.Passengers.OfType<Traveller>().OrderBy(t => t.BirthDate).Take(3);

        }

        public void DestinationGroupFlights()
        {
            /*var req = from flight in flights
                      group flight by flight.Destination;*/
            var req = flights.GroupBy(f => f.Destination);

            foreach (var items in req)
            {
                Console.WriteLine("Destination: " + items.Key);
                foreach (var f in items)
                {
                    Console.WriteLine("Flight Date: " + f.FlightDate);
                }

            }
        }


        

    }
}