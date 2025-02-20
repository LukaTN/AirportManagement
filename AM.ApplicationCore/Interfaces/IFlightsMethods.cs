using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightsMethods
    {
        List<DateTime> GetFlightDate(string destination);
        List<Flight> GetFlights(string filterType, string filterValue);
        void showFlightsDetails(Plane plane);

        void ProgrammedFlightNumber(DateTime startDate);

        double DurationAverage(string destination);
        IEnumerable<Traveller> SeniorTravellers(Flight flight);
       
        IEnumerable<Flight> OrderedDurationFlights();

        void DestinationGroupFlights();

        //int ProgrammedFlightNumber(DateTime startDate);

        /*void programmedFlightNumber(DateTime startDate);*/
    }
}
