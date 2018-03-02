using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.YAMLParser
{
    public class WebServiceConfig
    {
        public string SolutionName { get; set; }

        public string ConfigPath { get; set; }

        public List<ServiceSite> Sites { get; set; }
    }

    public class ServiceSite
    {
        public string Site { get; set; }
    }
}
