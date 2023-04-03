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
        private List<transportationRoute> Transportation_routes;

        public transportation_routeServise()
        {
            Transportation_routes = new List<transportationRoute>();
            init();
        }

        private void init()
        {
            var PointServise = new pointsServise();
            var pointes = PointServise.GetList();

            Transportation_routes.Add(new transportationRoute
            {
                id = Guid.NewGuid(),
                Title = "IAtransport",
                Rating = 7.5,
                country_country = "Ukraine-Ukraine",
                Phone = "+380 66 123 4567",
                Points = pointes.Where(p => p.Title == "IAtransport").ToList()
            });

            Transportation_routes.Add(new transportationRoute
            {
                id = Guid.NewGuid(),
                Title = "LiteTransport",
                Rating = 9.5,
                country_country = "Ukraine-Ukraine",
                Phone = "+380 99 678 9012",
                Points = pointes.Where(p => p.Title == "LiteTransport").ToList()
            });

            Transportation_routes.Add(new transportationRoute
            {
                id = Guid.NewGuid(),
                Title = "NewTransport",
                Rating = 8.9,
                country_country = "Ukraine-Ukraine",
                Phone = "+380 50 456 7890",
                Points = pointes.Where(p => p.Title == "NewTransport").ToList()
            });
        }

        public List<transportationRoute> GetList() => Transportation_routes;
    }
}
