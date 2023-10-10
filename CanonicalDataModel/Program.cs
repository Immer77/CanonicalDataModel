using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanonicalDataModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SASAirlineCompany company = new SASAirlineCompany("Sas","SA113","JFK", "CPH", "D", DateTime.Now,DateTime.Now);
            Console.WriteLine(company.SerializeToXmlCDM());

            Console.ReadLine();
        }
    }
}
