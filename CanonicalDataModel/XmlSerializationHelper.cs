using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CanonicalDataModel
{
    public static class XmlSerializationHelper
    {
        public static string SerializeToXmlCDM(this SASAirlineCompany airlineCompany)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SASAirlineCompany));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, airlineCompany);
                return writer.ToString();
            }
        }
    }
}
