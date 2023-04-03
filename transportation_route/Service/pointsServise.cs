using transportationAPP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportationAPP.Service
{
    public class pointsServise
    {
        private List<points> pointes;

        public pointsServise()
        {
            pointes = new List<points>();
            init();
        }

        private void init()
        {
            

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "IAtransport",
                city_city = "Kyiv-Odesa",
                Price = 300.00,
               
            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "IAtransport",
                city_city = "Lviv-Dnipro",
                Price = 200.00,
                
            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "IAtransport",
                city_city = "Odesa-Lviv",
                Price = 250.00,
               
            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "LiteTransport",
                city_city = "Mykolaiv-Lviv",
                Price = 230.00,
                
            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "LiteTransport",
                city_city = "Chernihiv-Kherson",
                Price = 200,

            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "LiteTransport",
                city_city = "Uman - Kryvyi Rih",
                Price = 150.00,
                
            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "NewTransport",
                city_city = "Zaporizhzhia-Khmelnytskyi",
                Price = 280.00,
                
            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "NewTransport",
                city_city = "Rivne-Ivano-Frankivsk",
                Price = 250.00,
                
            });

            pointes.Add(new points
            {
                ID = Guid.NewGuid(),
                Title = "NewTransport",
                city_city = "Odesa-Vinnytsia",
                Price = 200.00,
                
            });
        }

        public List<points> GetList() => pointes;
    }
}
