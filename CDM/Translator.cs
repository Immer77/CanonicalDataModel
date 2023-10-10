using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace CDM
{
    public static class Translator<T> where T : AirlineData
    {
        public static T TranslateXMLToCanonical(string xml)
        {
            try
            {
                // Deserialize the XML into the specified type (T)
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
                {
                    T airlineData = (T)serializer.Deserialize(reader);
                    return airlineData;
                }
            }
            catch (Exception ex)
            {
                // Handle deserialization or translation errors
                Console.WriteLine("Error translating XML to Canonical: " + ex.Message);
                return null;
            }
        }
    }
}
