
using Example.Contract;

namespace Plugin.FileSystem
{
    public class ConfigurationService : Prise.Proxy.ReverseProxy, IConfigurationService
    {
        public ConfigurationService(object hostService) : base(hostService) { }

        public string GetConfigurationValueForKey(string key)
        {
            return this.InvokeThisMethodOnHostService<string>(new[] { key });
        }
    }
}