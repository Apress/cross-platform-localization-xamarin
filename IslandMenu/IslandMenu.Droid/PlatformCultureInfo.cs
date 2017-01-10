using Xamarin.Forms;
using System.Threading;

[assembly: Dependency(typeof(IslandMenu.Droid.PlatformCultureInfo))]
namespace IslandMenu.Droid
{
    class PlatformCultureInfo : ICultureInfo
    {
        public System.Globalization.CultureInfo CurrentCulture
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture;
            }
            set
            {
                Thread.CurrentThread.CurrentCulture = value;
            }
        }

        public System.Globalization.CultureInfo CurrentUICulture
        {
            get
            {
                return Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                Thread.CurrentThread.CurrentUICulture = value;
            }
        }
    }
}