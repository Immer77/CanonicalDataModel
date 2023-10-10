using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM
{
    [Serializable]
    public abstract class AirlineData
    {
        public string Airline { get; set; }
        public string FlightNo { get; set; }
        public string Destination { get; set; }
        public string Origin { get; set; }
        public DateTime date { get; set; }

        public AirlineData() { }

        public AirlineData(string airline, string flightNo, string destination, string origin, DateTime date) 
        {
            this.Airline = airline;
            this.FlightNo = flightNo;
            this.Destination = destination;
            this.Origin = origin;
            this.date = date;
        }
    }
}
