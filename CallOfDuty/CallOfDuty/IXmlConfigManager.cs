using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallOfDuty
{
    public class IXmlConfigManager
    {
        
        T[] LoadConfigFromStream<T>(Stream stream);
        T[] LoadObjectFromPath<T>(string path);
        void SaveObjectToPath<T>(T ConfigurationSettings, string path);
        Stream SaveObjectToStream<T>(T ConfigurationSettings);
    }
}