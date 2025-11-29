using System.ComponentModel.DataAnnotations;

namespace EFCoreLoading_Data.Models
{
    internal class Route
    {

        public int RouteId { get; set; }
        public int Distance { get; set; }
        public int Destination { get; set; }
        public string? Origin { get; set; }
        public string? Classification { get; set; }


        public ICollection<RouteAircraft> RrouteAircraft { get; set; } = new HashSet<RouteAircraft>();
       


    }
}