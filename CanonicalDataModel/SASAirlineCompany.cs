using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CanonicalDataModel
{
    [XmlRoot("FlightInformation")]
    public class SASAirlineCompany
    {
        public string Airline {  get; set; }
        public string FlightNo { get; set; }
        public string Destination { get; set; }
        public string Origin { get; set; }
        public string ArrivalDeparture { get; set; }
        public DateTime Date {  get; set; }
        public DateTime Time { get; set; }

        // Empty Constructor to make it serializable
        public SASAirlineCompany()
        {

        }
        public SASAirlineCompany(string airline, string flightNo, string destination, string origin, string arrivalDeparture, DateTime date, DateTime time)
        {
            Airline = airline;
            FlightNo = flightNo;
            Destination = destination;
            Origin = origin;
            ArrivalDeparture = arrivalDeparture;
            Date = date;
            Time = time;
        }
    }
}
