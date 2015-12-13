using System.Configuration;

namespace CSharp.Samples.Utilities
{

    public class AppSettingsHelper
    {
        #region Methdos.
        public static string GetAppSettingsValue(string keyName)
        {
            return ConfigurationManager.AppSettings[keyName] ?? string.Empty;
        }
        #endregion
    }

}