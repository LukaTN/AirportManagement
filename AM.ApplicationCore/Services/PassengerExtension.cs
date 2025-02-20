using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        //upper to firt letter of first name and last name
        public static void UpperFullName(this Passenger p)
        {

            p.FirstName = p.FirstName[0].ToString().ToUpper()+p.FirstName.Substring(1);

            p.LastName = p.LastName[0].ToString().ToUpper() + p.LastName.Substring(1); 


        }
            
    }
}
