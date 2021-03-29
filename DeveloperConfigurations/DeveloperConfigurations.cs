using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace POS.DeveloperConfigurations
{
    public class DeveloperConfigurations
    {
       /// <summary>
       /// GET APPLICATION THEME
       /// </summary>
       /// <returns></returns>
        public string GetTheme()
        {
            string theme = LocalResources.ThemeSettings.Theme;
            return theme;

        }

        /// <summary>
        /// UPDATE APPLICATION THEME
        /// </summary>
        /// <param name="theme"></param>
        public void SetThemeValue(string theme)
        {
            ResXResourceWriter reswriter = new ResXResourceWriter("../../LocalResources/ThemeSettings.resx");
            reswriter.AddResource("Theme", theme);
            reswriter.Generate();
            reswriter.Close();

        }

        /// <summary>
        /// GET THE DEVELOPER TAG
        /// </summary>
        /// <returns></returns>
        public string GetDeveloper()
        {
            string Developer = LocalResources.ThemeSettings.Developer;
            return Developer;
        }

        /// <summary>
        /// APPLICATION VERSION GET
        /// </summary>
        /// <returns></returns>
        public string ApplicationVersion()
        {
            return LocalResources.ThemeSettings.Version;
        }

        /// <summary>
        /// GET THE CUSTOMER NAME
        /// </summary>
        /// <returns></returns>
        public string GetOwner()
        {
            return LocalResources.ThemeSettings.Customer;
        }
    }
}
