using transportationAPP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportationAPP.Service
{
    public class transportation_routeServise
    {
        private List<transportation_route> Transportation_routes;

        public transportation_routeServise()
        {
            Transportation_routes = new List<transportation_route>();
            init();
        }

        private void init()
        {
            var PointServise = new pointsServise();
            var pointes = PointServise.GetList();

            Transportation_routes.Add(new transportation_route
            {
                ID = Guid.NewGuid(),
                Title = "SkyNet",
                Rating = 7.5,
                Address = "м. Київ, вул. Хрещатик, 1",
                Phone = "+380 66 123 4567",
                Points = pointes.Where(p => p.Title == "SkyBasic" || p.Title == "SkyPlus" || p.Title == "SkyElite").ToList()
            });

            Transportation_routes.Add(new transportation_route
            {
                ID = Guid.NewGuid(),
                Title = "NovaLink",
                Rating = 9.5,
                Address = "м. Львів, вул. Садова, 5",
                Phone = "+380 99 678 9012",
                Points = pointes.Where(p => p.Title == "NovaLite" || p.Title == "NovaPro" || p.Title == "NovaUltra").ToList()
            });

            Transportation_routes.Add(new transportation_route
            {
                ID = Guid.NewGuid(),
                Title = "ConnectUs",
                Rating = 8.9,
                Address = "м. Одеса, вул. Шевченка, 23",
                Phone = "+380 50 456 7890",
                Points = pointes.Where(p => p.Title == "ConnectHome" || p.Title == "ConnectPlus" || p.Title == "ConnectMax").ToList()
            });
        }

        public List<transportation_route> GetList() => Transportation_routes;
    }
}
