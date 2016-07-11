using Foundation;
using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xamarin.Forms;

[assembly: Dependency(typeof(PersonalTrainer.iOS.Localize))]

namespace PersonalTrainer.iOS
{
    public class Localize : PersonalTrainer.Resx.ILocalize
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var netLanguage = "en";
            var prefLanguageOnly = "en";
            if (NSLocale.PreferredLanguages.Length > 0)
            {
                var pref = NSLocale.PreferredLanguages[0];
                prefLanguageOnly = pref.Substring(0, 2);
                if (prefLanguageOnly == "pl")
                {
                    if (pref == "pl")
                        pref = "pl-PL"; 
                }
                netLanguage = pref.Replace("_", "-");
                Console.WriteLine("preferred language:" + netLanguage);
            }
            System.Globalization.CultureInfo ci = null;
            try
            {
                ci = new System.Globalization.CultureInfo(netLanguage);
            }
            catch
            {
                // iOS locale not valid .NET culture (eg. "en-ES" : English in Spain)
                // fallback to first characters, in this case "en"
                ci = new System.Globalization.CultureInfo(prefLanguageOnly);
            }
            return ci;
        }
        public void SetLocale()
        {
            var ci = GetCurrentCultureInfo();
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

    }
}
