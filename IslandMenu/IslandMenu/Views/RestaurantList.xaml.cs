using IslandMenu.Models;
using IslandMenu.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IslandMenu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantList : ContentPage
    {
        RestaurantsViewModel vm;
        public RestaurantList()
        {
            InitializeComponent();

            vm = new RestaurantsViewModel {Navigation = Navigation};

            img.BindingContext = vm;
            LastUpdateLabel.BindingContext = vm;

            BindingContext = vm.Restaurants;
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Restaurant restaurant = e.Item as Restaurant;

            await this.Navigation.PushAsync(new MenuList(restaurant));

            ((ListView)sender).SelectedItem = null;
        }
    }
}
