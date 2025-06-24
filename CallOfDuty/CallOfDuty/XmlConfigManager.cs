using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallOfDuty
{
    public class XmlConfigManager: IXmlConfigManager
    {
        public T[] LoadConfigFromStream<T>(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));
            T[] result = (T[])serializer.Deserialize(stream);
            return result;
        }

        public T[] LoadObjectFromPath<T>(string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            string xmlString = xmlDocument.OuterXml;

            using (StringReader stringReader = new StringReader(xmlString))
            using (XmlReader xmlReader = XmlReader.Create(stringReader))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T[])serializer.Deserialize(xmlReader);
            }
        }

        public void SaveObjectToPath<T>(T ConfigurationSettings, string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, ConfigurationSettings);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(path);
            }
        }

        public Stream SaveObjectToStream<T>(T ConfigurationSettings)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T[]));

            MemoryStream stream = new MemoryStream();
            serializer.Serialize(stream, ConfigurationSettings);
            stream.Position = 0;

            return stream;
        }
    }
}