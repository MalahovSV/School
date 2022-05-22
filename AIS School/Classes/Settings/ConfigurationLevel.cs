using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_School.Classes.Settings
{
    static class ConfigurationLevel
    {
        

        /// <summary>
        /// Чтение записи из кофигуратора
        /// </summary>
        /// <param name="key">Ключ, имя настройки</param>
        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error reading app settings", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }


        /// <summary>
        /// Добавление записи в конфигуратор
        /// </summary>
        /// <param name="key">Ключ, имя настройки</param>
        /// <param name="value">Значение</param>
        public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                MessageBox.Show("Успешно", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error writing app settings", "System", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
