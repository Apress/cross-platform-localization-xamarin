using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IslandMenu.Models;
using IslandMenu.Services;
using Xamarin.Forms;

namespace IslandMenu.ViewModels
{
    public class RestaurantsViewModel
    {
        public string ImageUrl { get; private set; }
        public string LastUpdate { get; private set; }
        public IEnumerable<Restaurant> Restaurants { get; private set; }

        public INavigation Navigation { get; set; }

        public RestaurantsViewModel()
        {
            ImageUrl = "islandmenubanner.jpg";
            Restaurants = GetRestaurants().Result;
        }

        private async Task<IEnumerable<Restaurant>> GetRestaurants()
        {
            var ds = new DataServices();
            LastUpdate = String.Format(Resources.IslandMenu.LastUpdate, DateTime.Now.ToString("D"));

            var cultureInfo = Xamarin.Forms.DependencyService.Get<ICultureInfo>();

            return await ds.GetRestaurants(cultureInfo.CurrentCulture.Name);
        }
    }
}
