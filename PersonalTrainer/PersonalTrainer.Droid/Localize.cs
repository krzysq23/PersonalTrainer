using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;

[assembly: Dependency(typeof(PersonalTrainer.Droid.Localize))]

namespace PersonalTrainer.Droid
{
    public class Localize : PersonalTrainer.Resx.ILocalize
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default; // user's preferred locale
            var netLocale = androidLocale.ToString().Replace("_", "-");

            #region Debugging output
            Console.WriteLine("android:  " + androidLocale.ToString());
            Console.WriteLine("netlang:  " + netLocale);

            var ci = new CultureInfo(netLocale);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Console.WriteLine("thread:  " + Thread.CurrentThread.CurrentCulture);
            Console.WriteLine("threadui:" + Thread.CurrentThread.CurrentUICulture);
            #endregion

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