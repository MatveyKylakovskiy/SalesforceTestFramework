using Microsoft.Extensions.Configuration;

namespace SalesforceTestFramework.AppSettings
{
    public abstract class BaseSettings
    {
        public string jsonSettings { get; init; }
        private IConfiguration InitConfiguration() => new ConfigurationBuilder().AddJsonFile(jsonSettings + ".json").Build();
        private protected string ReadSettings(string settingName) => InitConfiguration()[settingName];
    }
}
