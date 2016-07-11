using Java.Lang;
using PersonalTrainer.Resx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(PersonalTrainer.WinPhone.Localize))]

namespace PersonalTrainer.WinPhone
{
    public class Localize //: ILocalize
    {
        //public System.Globalization.CultureInfo GetCurrentCultureInfo()
        //{
        //    return Thread.CurrentThread.CurrentUICulture;
        //}

        //public void SetLocale()
        //{
        //    var ci = GetCurrentCultureInfo();
        //    Thread.CurrentThread.CurrentCulture = ci;
        //    Thread.CurrentThread.CurrentUICulture = ci;
        //}
    }
}
