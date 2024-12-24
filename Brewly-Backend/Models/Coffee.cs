using Microsoft.AspNetCore.Routing.Constraints;

namespace Brewly_Backend.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string RoastType { get; set; }
        public string Description { get; set; }
        public string CountryOfOrigin { get; set; }

    }
}
