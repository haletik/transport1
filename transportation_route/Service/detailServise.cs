using transportationAPP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportationAPP.Service
{
    public class detailServise
    {
        private List<detail> detai;

        public detailServise()
        {
            detai = new List<detail>();
            init();
        }

        private void init()
        {
            var Transportation_routeServise = new transportation_routeServise();
            var Transportation_routes = Transportation_routeServise.GetList();

            var PointServise = new pointsServise();
            var pointes = PointServise.GetList();

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "мАмА мІя",
                Address = "м. Львів, вул. Небесної сотні, 17",
                Email = "mamaMia@gmail.com",
                Phone = "+380 11 111 1111",
                transportation_route = Transportation_routes.Where(p => p.Title == "IAtransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Odesa-Lviv").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Ірина Петренко",
                Address = "м. Одеса, вул. Буніна, 12",
                Email = "i.petrenko@yahoo.com",
                Phone = "+380 95 890 1234",
                transportation_route = Transportation_routes.Where(p => p.Title == "LiteTransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Mykolaiv-Lviv").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Михайло Ковальов",
                Address = "м. Львів, вул. Ринок, 2",
                Email = "m.kovalov@ukr.net",
                Phone = "+380 68 345 6789",
                transportation_route = Transportation_routes.Where(p => p.Title == "IAtransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Lviv-Dnipro").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Оксана Шевчук",
                Address = "м. Львів, вул. Личаківська, 19",
                Email = "o.shevchuk@hotmail.com",
                Phone = "+380 92 123 4567",
                transportation_route = Transportation_routes.Where(p => p.Title == "NewTransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Rivne-Ivano-Frankivsk").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Вікторія Мельник",
                Address = "м. Київ, вул. Лисенка, 7",
                Email = "v.melnyk@gmail.com",
                Phone = "+380 91 012 3456",
                transportation_route = Transportation_routes.Where(p => p.Title == "LiteTransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Chernihiv-Kherson").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Андрій Григоренко",
                Address = "м. Одеса, вул. Ришельєвська, 15",
                Email = "a.hryhorenko@yahoo.com",
                Phone = "+380 67 987 6543",
                transportation_route = Transportation_routes.Where(p => p.Title == "LiteTransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Uman - Kryvyi Rih").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Марія Ковальчук",
                Address = "м. Одеса, вул. Дерибасівська, 1",
                Email = "m.kovalchuk@ukr.net",
                Phone = "+380 63 567 8901",
                transportation_route = Transportation_routes.Where(p => p.Title == "NewTransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Zaporizhzhia-Khmelnytskyi").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Сергій Шевченко",
                Address = "м. Київ, вул. Володимирська, 23",
                Email = "s.shevchenko@hotmail.com",
                Phone = "+380 67 234 5678",
                transportation_route = Transportation_routes.Where(p => p.Title == "NewTransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Odesa-Vinnytsia").ToList()
            });

            detai.Add(new detail
            {
                ID = Guid.NewGuid(),
                Title = "Ольга Козак",
                Address = "м. Львів, вул. Галицька, 6",
                Email = "o.kozak@gmail.com",
                Phone = "+380 94 234 5678",
                transportation_route = Transportation_routes.Where(p => p.Title == "LiteTransport").ToList(),
                Point = pointes.Where(p => p.city_city == "Chernihiv-Kherson").ToList()
            });
        }


        public List<detail> GetList() => detai;
        public void Create(detail det)
        {
            detai.Add(det);
        }

        public void Update(detail refDet)
        {
            var det = detai.First(x => x.ID == refDet.ID);
            if (det.Title != refDet.Title)
                det.Title = refDet.Title;

            if (det.Address != refDet.Address)
                det.Address = refDet.Address;

            if (det.Email != refDet.Email)
                det.Email = refDet.Email;

            if (det.Phone != refDet.Phone)
                det.Phone = refDet.Phone;
        }

        public void Delete(Guid id)
        {
            detai.RemoveAll(x => x.ID == id);
        }
    }
}
