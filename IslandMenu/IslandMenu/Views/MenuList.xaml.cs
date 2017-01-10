using System;
using IslandMenu.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslandMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuList : ContentPage
    {
        public MenuList(Restaurant restaurant)
        {
            BindingContext = restaurant;
            this.Title = restaurant.Name;
            InitializeComponent();
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            base.OnBindingContextChanged();

            var cell = (ViewCell) sender;
            RestaurantMenuItem item = (RestaurantMenuItem)cell.BindingContext;

            var l = item.Description.Length;
            var offset = (l / 50) * 20;

            cell.Height = 100 + offset;

        }
    }
}
