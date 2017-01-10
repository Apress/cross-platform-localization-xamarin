using System.Globalization;
using Xamarin.Forms;

[assembly: Dependency(typeof(IslandMenu.UWP.PlatformCultureInfo))]
namespace IslandMenu.UWP
{
    class PlatformCultureInfo : ICultureInfo
    {
        public System.Globalization.CultureInfo CurrentCulture
        {
            get
            {
                return CultureInfo.CurrentCulture;
            }
            set
            {
                CultureInfo.CurrentCulture = value;
            }
        }

        public System.Globalization.CultureInfo CurrentUICulture
        {
            get
            {
                return CultureInfo.CurrentUICulture;
            }
            set
            {
                CultureInfo.CurrentUICulture = value;
            }
        }
    }
}