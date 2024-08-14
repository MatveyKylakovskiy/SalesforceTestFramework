﻿
namespace SalesforceTestFramework.AppSettings.AppSettingsUI
{
    public class SettingsUI : BaseSettings
    {
        public string Driver { get; }
        public string URL { get; }
        public string Login { get; }
        public string Password { get; }

        public SettingsUI()
        {
            jsonSettings = "appSettingsUI";

            Driver = ReadSettings("Driver");
            URL = ReadSettings("URL");
            Login = ReadSettings("Login");
            Password = ReadSettings("Password");
        }
    }
}
