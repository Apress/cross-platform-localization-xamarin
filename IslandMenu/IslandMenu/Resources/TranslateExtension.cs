using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslandMenu.Resources
{
    // Define the default content property
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;

            // Return the localized resource if available, default resource if not
            return IslandMenu.ResourceManager.GetString(Text, IslandMenu.Culture);
        }
    }
}
