using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using IslandMenu.Models;
using Newtonsoft.Json;

namespace IslandMenu.Services
{
    public class DataServices
    {
        public async Task<IEnumerable<Restaurant>> GetRestaurants(string locale)
        {
            var language = GetClosestLanguage(locale);
            var assembly = typeof(DataServices).GetTypeInfo().Assembly;
            var json = "";

            var stream = assembly.GetManifestResourceStream($"IslandMenu.Services.data{language}.json") ??
                         assembly.GetManifestResourceStream("IslandMenu.Services.data.json");

            using (var reader = new StreamReader(stream))
            {
                json = await reader.ReadToEndAsync();
            }

            var restaurants = JsonConvert.DeserializeObject<List<Restaurant>>(json);

            return restaurants;
        }

        private static string GetClosestLanguage(string locale)
        {
            var langs = new[]{ "es", "de", "zh" };
            var result = "";

            foreach(var lang in langs)
            {
                if (locale.StartsWith(lang))
                {
                    result = $"-{lang}";
                    break;
                }
            }

            return result;
        }
    }
}
