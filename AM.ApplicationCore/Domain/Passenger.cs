using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Flight> Flights { get; set; }

        public int Id { get; set; }



        public bool checkprofile(string nom, string prenom, string email = null)
        {
            if (email == null)
                return nom == LastName && prenom == FirstName;

            return nom == LastName && prenom == FirstName && email == EmailAddress;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger ");
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, EmailAddress: {EmailAddress}, " +
                   $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, TelNumber: {TelNumber}";
        }
    }
}
