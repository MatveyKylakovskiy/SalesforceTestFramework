
using SalesforceTestFramework.AppSettings.AppSettingsUI;
using System.Collections;

namespace SalesforceTestFramework.Helpers
{
    public class TestDataUI
    {

    }

    public class LoginData : IEnumerable
    {
        public SettingsUI settingsUI = new();
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { settingsUI.Login, settingsUI.Password, true };
        }
    }
}
