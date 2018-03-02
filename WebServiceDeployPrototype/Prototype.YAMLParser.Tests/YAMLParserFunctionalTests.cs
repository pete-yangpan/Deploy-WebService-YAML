using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prototype.YAMLParser.Tests
{
    [TestClass]
    public class YAMLParserFunctionalTests
    {
        [TestMethod]
        public void YAMLParserCanRead()
        {
            string configInfo = @"D:\Source\yanpan\Github\Deploy-WebService-YAML\WebServiceDeployPrototype\Prototype.PowerShell\YAMLConfig\EchoWebServiceConfig.yaml";
            var solutionName = YAMLParser.YamlParser.ReadFromYaml(configInfo);
            Assert.IsNotNull(solutionName);

        }
    }
}
