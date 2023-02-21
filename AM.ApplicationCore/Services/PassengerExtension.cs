using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger p)
        {
            p.FirstName = p.FirstName.ToUpper();
            p.LastName = p.LastName.ToUpper();
        }
    }
}
