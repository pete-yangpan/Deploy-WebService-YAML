#
# Script.ps1
#
[Reflection.Assembly]::LoadFile("D:\Source\yanpan\Github\Deploy-WebService-YAML\WebServiceDeployPrototype\Prototype.YAMLParser\bin\Debug\YamlDotNet.dll")
[Reflection.Assembly]::LoadFile("D:\Source\yanpan\Github\Deploy-WebService-YAML\WebServiceDeployPrototype\Prototype.YAMLParser\bin\Debug\Prototype.YAMLParser.dll")

$yamlConfig = [Prototype.YAMLParser.YamlParser]::ReadFromYaml("D:\Source\yanpan\Github\Deploy-WebService-YAML\WebServiceDeployPrototype\Prototype.PowerShell\YAMLConfig\EchoWebServiceConfig.yaml")
$webConfig = $yamlConfig.ConfigPath
$site = $yamlConfig.Sites[0].Site

& "C:\Program Files\IIS Express\iisexpress.exe" /config:$webConfig /site:$site
