using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandMenu.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Photo { get; set; }
        public List<RestaurantMenuItem> Menu { get; set; }
    }
}
