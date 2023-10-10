using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Airlines
{
    internal class SasAirlineCompany : AirlineData
    {
        public string arrivalDeparture;

   
        public SasAirlineCompany(string airline, string flightNo, string destination, string origin, string arrivalDeparture, DateTime date) : base(airline, flightNo, destination, origin,date) 
        {
            this.arrivalDeparture = arrivalDeparture;
        }
    }
}
