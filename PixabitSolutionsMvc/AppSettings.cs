using System;
using System.Configuration;


namespace PixabitSolutionsMvc
{
    public class AppSettings
    {

        public static string DefaultCulture = "en-GB";

        public static string FromEmailAddress
        {
            get { return GetSettingOrDefault("FromEmailAddress", "web@pixabit-solutions.de"); }
        }

        public static string ToEmailAddress
        {
            get { return GetSettingOrDefault("ToEmailAddress", "stefan.nesselhauf@pixabit-solutions.de"); }
        }

        private static T GetSettingOrDefault<T>(string key, T defaultValue)
        {
            var setting = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrWhiteSpace(setting))
                return defaultValue;

            try
            {
                return (T)Convert.ChangeType(setting, typeof(T));
            }
            catch (Exception ex)
            {
                var message = string.Format("Error converting of application setting '{0}' from web.config file.\n {1}", key, ex);

                throw new ConfigurationErrorsException(message);
            }
        }

        public static string Language
        {
            get { return GetSettingOrDefault("Language", "en-GB"); }
        }

    }

}