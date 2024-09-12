
namespace SalesforceTestFramework.AppSettings.AppSettingsAPI
{
    public class SettingsAPI : BaseSettings
    {   
        public string Key { get; }
        public string Secret { get; }
        public string MyDomain { get; }
        public SettingsAPI()
        {
            jsonSettings = "appSettingsAPI";

            Key = ReadSettings("Key");
            Secret = ReadSettings("Secret");
            MyDomain = ReadSettings("MyDomain");
        }
    }
}
