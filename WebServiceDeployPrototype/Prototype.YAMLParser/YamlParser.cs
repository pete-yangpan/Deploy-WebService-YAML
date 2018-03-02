using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace Prototype.YAMLParser
{
    public class YamlParser
    {
        public static WebServiceConfig ReadFromYaml(string yamlInfo)
        {
            StreamReader yamlStreamReader = new StreamReader(yamlInfo);


            YamlDotNet.Serialization.Deserializer deserializer = new Deserializer(namingConvention: new CamelCaseNamingConvention());
            var result = deserializer.Deserialize<WebServiceConfig>(yamlStreamReader);

            return result;
        }
    }
}
