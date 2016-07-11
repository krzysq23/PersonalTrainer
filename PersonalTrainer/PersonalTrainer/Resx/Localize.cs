﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalTrainer.Resx
{
    public class Localize
    {
        static readonly CultureInfo ci;

        static Localize()
        {
            ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
        }

        public static string GetString(string key, string comment)
        {
            ResourceManager temp = new ResourceManager("PersonalTrainer.Resx.AppResources", typeof(Localize).GetTypeInfo().Assembly);

            string result = temp.GetString(key, ci);

            return result;
        }
    }
}
