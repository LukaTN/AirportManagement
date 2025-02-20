using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }

        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public virtual List<Passenger> Passengers { get; set; }
        public virtual Plane Plane { get; set; }

        public override string ToString()
        {
            return $"FlightId: {FlightId}, Departure: {Departure}, Destination: {Destination}, " +
                   $"EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimatedDuration}, " +
                   $"FlightDate: {FlightDate}, Plane: {Plane?.PlaneType}, Passengers: {Passengers?.Count}";
        }

    }
}
